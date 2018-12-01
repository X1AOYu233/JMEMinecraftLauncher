using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMEMinecraftLauncher
{
    static class ProgramStart
    {
        public static MainWindow form1;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            form1 = new MainWindow();
            Application.Run(form1);
            
        }
    }
}
