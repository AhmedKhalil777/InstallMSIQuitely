using System;

namespace InstallRedisMSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================== Installing a Service in a quiet mode ==================================");
            Console.WriteLine("===================== Trying To Install Redis MSI          ==================================");
            var strCmdText = "/C msiexec /quiet /i Redis-x64-3.0.504.msi";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Console.WriteLine("===================== Installation Completed Successfully  ===============================");
            Console.ReadKey();
        }
    }
}
