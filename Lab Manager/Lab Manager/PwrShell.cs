using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace Lab_Manager
{
    class PwrShell
    {
        static void main()
        {
            ProcessStartInfo cmd = new ProcessStartInfo("cmd");
            Process teste1 = new Process();
            cmd.WorkingDirectory = @"C:\windows\";
            cmd.UseShellExecute = false;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardOutput = true;
            cmd.RedirectStandardOutput = true;
            teste1.StartInfo=cmd;
            teste1.Start();
            teste1.StandardInput.WriteLine("net use",@"\\172.30.17.53\ipc$"," /user:educacao ailiram46825");
            //teste1.StandardInput.WriteLine("break");
            //teste1.StandardInput.WriteLine("ailiram46825");
            teste1.StandardInput.WriteLine("shutdown -r -t 5 -m \\172.30.17.53");


            //teste1.WaitForExit();// Waits here for the process to exit.
            //Process.Start("cmd.exe");
            
        }
        public void teste()
        {
            main();
        }
        
    }
}
