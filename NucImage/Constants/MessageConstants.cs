using System;

namespace NucImage.Constants
{
    public class MessageConstants
    {
        public const String APPLICATION_NAME = "NucImage";
        public const String MESSAGEBOX_TITLE_INFORMATION = APPLICATION_NAME + " » Information";
        public const String MESSAGEBOX_TITLE_WARNING = APPLICATION_NAME + " » Warning";
        public const String MESSAGEBOX_TITLE_ERROR = APPLICATION_NAME + " » Error";
        public const String MESSAGEBOX_TARGET_IS_NO_WEBSITE = "The url you entered cant be reached!";
        public const String MESSAGEBOX_ATTRIBUTE_HELP = "You can specify the custom image attribute. For wordpress I would recommend data-url or srcset, for any normal case I would use the normal src attribute.";
        public const String MESSAGEBOX_NO_TARGET_SPECIFIED = "You didnt specified a target url.";
        public const String MESSAGEBOX_NO_OUTPUT_SPECIFIED = "You didnt specified a output folder.";
        public const String MESSAGEBOX_NO_ATTRIBUTE_SPECIFIED = "You didnt specified a target attribute";
        public const String LOGBOX_SEARCHING_FOR_IMAGES = "» Searching for images. This can take a while...";
        public const String LOGBOX_FOUND_IMAGES = "» Found %IMAGECOUNT% Images.";
        public const String LOGBOX_DOWNLOAD_STARTED = "» Starting now the download...";
        public const String LOGBOX_DOWNLOAD_SUCCESFULLY = "» Download succesfully.";
        public const String LOGBOX_ERROR_WHILE_SCRAPING = "» ERROR [%LINK%]";
        public const String LOGBOX_DOWNLOADED_FILE = "» OK %LINK%";
        public const String LOGBOX_NO_IMAGES_FOUND = "» No images found!";
    }
}
