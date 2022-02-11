using NucImage.Constants;
using System;
using System.Windows.Forms;

namespace NucCheck.Services
{
    public enum MessageBoxType
    {
        INFORMATION,
        WARNING,
        ERROR,
    }

    public class MessageBoxService
    {
        public void Send(MessageBoxType type, String message)
        {
            switch (type)
            {
                case MessageBoxType.INFORMATION:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MessageBoxType.WARNING:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageBoxType.ERROR:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}