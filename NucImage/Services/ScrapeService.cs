using HtmlAgilityPack;
using NucImage.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace NucImage.Services
{
    public class ScrapeService
    {
        public String url { get; set; }
        public String savePath { get; set; }
        public String targetAttribute { get; set; }
        public String targetTag { get; set; }
        public bool enableVideo { get; set; }
        public List<String> imageUrls { get; private set; }

        /// <summary>
        /// Sets the imageUrls list and adds to the given url https
        /// </summary>
        public void InitImageList()
        {
            if(!url.Contains("http") || !url.Contains("https"))
            {
                url = "https://" + url;
            }

            imageUrls = GetImageUrls();
        }

        /// <summary>
        /// Gets and filter all images tags on the given website.
        /// </summary>
        /// <returns></returns>
        private List<String> GetImageUrls()
        {
            var document = new HtmlWeb().Load(url);

            var imageListRaw = document.DocumentNode.Descendants(targetTag)
                                            .Select(e => e.GetAttributeValue(targetAttribute, null))
                                            .Where(s => !String.IsNullOrEmpty(s)).ToList();

            if(enableVideo)
            {
                var videoListRaw = document.DocumentNode.Descendants("video")
                    .Select(e => e.GetAttributeValue("src", null))
                    .Where(s => !String.IsNullOrEmpty(s)).ToList();

                foreach (var video in videoListRaw)
                {
                    imageListRaw.Add(video);
                }
            }

            var imageList = new List<string>();

            foreach(var tempUrl in imageListRaw)
            {
                if(!tempUrl.Contains("data:image") && IsValidImage(tempUrl) && !imageList.Contains(tempUrl))
                {
                        imageList.Add(tempUrl);
                }
            }

            return imageList;
        }

        public int GetImageCount()
        {
            return imageUrls.Count;
        }

        /// <summary>
        /// Starts the thread
        /// </summary>
        public void SaveImages()
        {
            var worker = new Thread(SaveImagesThread);
            worker.Start();
         
        }

        /// <summary>
        /// Starts the downloading process
        /// </summary>
        private void SaveImagesThread(object obj)
        {
            Parallel.ForEach(imageUrls, new ParallelOptions
            {
                MaxDegreeOfParallelism = 2,
            }, entry =>
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        DownloadImage(entry);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            var uri = new Uri(url);
                            var baseUri = uri.GetLeftPart(System.UriPartial.Authority);
                            if (!baseUri.EndsWith("/") && !entry.StartsWith("/"))
                            {
                                baseUri = baseUri + "/";
                            }

                            DownloadImage(baseUri + entry);
                        }
                        catch
                        {
                            try
                            {
                                var uri = new Uri(url);
                                var baseUri = uri.GetLeftPart(System.UriPartial.Authority);
                               
                                DownloadImage(baseUri + entry);
                            }
                            catch 
                            {
                                Program.getInstance().AddLogItem(MessageConstants.LOGBOX_ERROR_WHILE_SCRAPING.Replace("%LINK%", entry));
                            }
                        }
                    }
                }
            });

            Program.getInstance().AddLogItem(MessageConstants.LOGBOX_DOWNLOAD_SUCCESFULLY);
            Program.getInstance().SetStartButtonState(true);
        }

        /// <summary>
        /// Downloads a image
        /// </summary>
        private void DownloadImage(String entry)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] dataArr = webClient.DownloadData(entry);
                File.WriteAllBytes(savePath + $"/{entry.Substring(entry.LastIndexOf('/') + 1)}", dataArr);
                Program.getInstance().AddLogItem(MessageConstants.LOGBOX_DOWNLOADED_FILE.Replace("%LINK%", entry));
                webClient.Dispose();
            }
        }

        /// <summary>
        /// Checks if the given entry is a valid image
        /// </summary>
        private bool IsValidImage(String entry)
        {
            if(enableVideo)
            {
                return entry.Contains(".jpg") || entry.Contains(".png") || entry.Contains(".tiff") || entry.Contains(".jpeg") || entry.Contains(".svg") || entry.Contains(".gif") || entry.Contains(".bmp") || entry.Contains(".mp4") || entry.Contains(".mov");
            } else
            {
                return entry.Contains(".jpg") || entry.Contains(".png") || entry.Contains(".tiff") || entry.Contains(".jpeg") || entry.Contains(".svg") || entry.Contains(".gif") || entry.Contains(".bmp");
            }
        }
    }
}
