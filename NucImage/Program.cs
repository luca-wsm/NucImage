using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NucImage
{
    static class Program
    {

        private static Panel _panel;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _panel = new Panel();
            Application.Run(_panel);
        }

        public static Panel getInstance()
        {
            return _panel;
        }
    }
}
