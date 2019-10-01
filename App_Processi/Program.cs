using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Processi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione di processi");

            Process.Start("Notepad.exe", @"C:\Users\studenti\Desktop\App_Processi\App_Processi\HelloWorld.txt");

            Process.Start("Chrome.exe", "https://docs.microsoft.com/it-it/dotnet/api/system.diagnostics.process?view=netframework-4.8");

            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\studenti\Desktop\App_Processi\App_Processi\HelloWorld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
            Console.WriteLine("Programma terminato");

            var processes = Process.GetProcesses();
            foreach(var p in processes)
            {
                if (p.ProcessName == "notepad")
                {
                    p.Kill();
                }
            }
            Console.ReadLine();
        }
    }
}
