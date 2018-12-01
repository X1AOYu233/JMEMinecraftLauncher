using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace JMEMinecraftLauncher
{
    class ProcessTool
    {
        public static Process StartJar(String jarfile)
        {
            var p = new Process();
            var processTask = new Task(() =>
            {
                p.StartInfo.FileName = "java"; //命令
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false; //不启用shell启动进程
                p.StartInfo.RedirectStandardInput = true; // 重定向输入
                p.StartInfo.RedirectStandardOutput = true; // 重定向标准输出
                p.StartInfo.RedirectStandardError = true; // 重定向错误输出 
                p.StartInfo.Arguments = "-jar " + jarfile;
                p.Start();
            });
            processTask.Start();
            return p;
        }
    }
}