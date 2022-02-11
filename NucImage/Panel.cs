using HtmlAgilityPack;
using NucCheck.Services;
using NucImage.Constants;
using NucImage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NucImage
{
    public partial class Panel : Form
    {

        private CURLService _curlService;
        private MessageBoxService _messageBoxService;
        private ScrapeService _scrapeService;

        public Panel()
        {
            InitializeComponent();
            _messageBoxService = new MessageBoxService();
            _curlService = new CURLService();
        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && _curlService.CallUrl(targetUrlBox.Text))
            {
                StartScraping();
            }
        }

        private void outputBttn_Click(object sender, EventArgs e)
        {
            saveDialog.ShowDialog();
        }

        public bool ValidateInputs()
        {
            if(targetUrlBox.Text == string.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_NO_TARGET_SPECIFIED);
                return false;
            }

            if(saveDialog.SelectedPath == string.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_NO_OUTPUT_SPECIFIED);
                return false;
            }

            if(targetAttribute.Text == string.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_NO_ATTRIBUTE_SPECIFIED);
            }

            return true;
        }

        /// <summary>
        /// Starts the scraping process
        /// </summary>
        public void StartScraping()
        {
            ClearLog();
            if(_scrapeService != null)
            {
                _scrapeService = null;
            }

            _scrapeService = new ScrapeService();
            AddLogItem(MessageConstants.LOGBOX_SEARCHING_FOR_IMAGES);
            _scrapeService.url = targetUrlBox.Text;
            _scrapeService.targetTag = targetTag.Text;
            _scrapeService.enableVideo = saveVideo.Checked;
            _scrapeService.targetAttribute = targetAttribute.Text;
            _scrapeService.InitImageList();

            if(_scrapeService.GetImageCount() == 0)
            {
                NoImagesFound();
                return;
            }

            AddLogItem(MessageConstants.LOGBOX_FOUND_IMAGES.Replace("%IMAGECOUNT%", _scrapeService.GetImageCount().ToString()));
            AddLogItem(MessageConstants.LOGBOX_DOWNLOAD_STARTED);
            _scrapeService.savePath = saveDialog.SelectedPath;
            _scrapeService.SaveImages();
            SetStartButtonState(false);
        }

        /// <summary>
        /// This method wil be called when no images where found
        /// </summary>
        public void NoImagesFound()
        {
            ClearLog();
            AddLogItem(MessageConstants.LOGBOX_NO_IMAGES_FOUND);
        }

        /// <summary>
        /// Adds a item to the logBox.
        /// We need to invoke this method because it will be called from the ScrapeThread.
        /// </summary>
        public void AddLogItem(string item)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.AddLogItem(item); });
                return;
            }
            logBox.Items.Add(item);
            logBox.SelectedIndex = logBox.Items.Count - 1;

        }

        /// <summary>
        /// Sets the startBttn enabled or disabled
        /// </summary>
        /// <param name="enabled"></param>
        public void SetStartButtonState(bool enabled)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.SetStartButtonState(enabled); });
                return;
            }
            startBttn.Enabled = enabled;
        }

        public void ClearLog()
        {
            logBox.Items.Clear();
        }

        private void logBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(logBox.SelectedItem.ToString());
        }

        private void targetAttributeHelpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_ATTRIBUTE_HELP);
        }
    }
}
