using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace JMEMinecraftLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void TabPage1_Click_2(object sender, EventArgs e)
        {
        }

        private void 游戏档案_Click(object sender, EventArgs e)
        {
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void Log(string inf)
        {
            richTextBox1.AppendText("[" + DateTime.UtcNow.ToLocalTime().ToString(CultureInfo.CurrentCulture) +
                                    " INFO]: " + inf + "\n");
        }

        public void Warn(string inf)
        {
            richTextBox1.AppendText("[" + DateTime.UtcNow.ToLocalTime().ToString(CultureInfo.CurrentCulture) +
                                    " WARN]: " + inf + "\n");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            var logWindow = new GameLogWindow();
            Process gameProcess;
            gameProcess =
                ProcessTool.StartJar(
                    "F:\\BaiduNetdiskDownload\\proxyee-down-2.54-windows\\proxyee-down-2.54\\main\\proxyee-down-core.jar");
            gameProcess.StartInfo.RedirectStandardInput = true; // 重定向输入
            gameProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出
            gameProcess.StartInfo.RedirectStandardError = true; // 重定向错误输出
            Thread.Sleep(1000);
            reader = gameProcess.StandardOutput;
            Console.WriteLine(reader);
            Console.WriteLine(@"Start task2");
            button3.Enabled = false;
            ProgramStart.Form1.Visible = false;

            new Thread(() => logWindow.ShowDialog()).Start();
            new Thread(async () =>
            {
                while (!gameProcess.HasExited)
                {
                    var result = await reader.ReadLineAsync();
                    logWindow.richTextBox1.AppendText(result + "\n");
                }
            }).Start();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
        }
    }
}