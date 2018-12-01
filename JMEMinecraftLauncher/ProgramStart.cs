using System;using System.Windows.Forms;

namespace JMEMinecraftLauncher
{
    static class ProgramStart
    {
        public static MainWindow Form1;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Form1 = new MainWindow();
            Application.Run(Form1);
            
        }
    }
}
