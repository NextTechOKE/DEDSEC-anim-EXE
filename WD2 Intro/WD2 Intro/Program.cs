using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Globalization;
using System.IO;
using System.Media;
using System.Security.AccessControl;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        // Specify the command to run and any arguments
        string command = "cmd.exe";
        string arguments = "/c echo Hello, World! && timeout /nobreak /t 2";

        // Start the process
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            RedirectStandardInput = true,
            UseShellExecute = false,
            CreateNoWindow = false // Set this to true if you want to hide the terminal window
        };

        Process process = new Process { StartInfo = psi };

        process.Start();
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("dsuofhwsedufisoh");
        //Console.ResetColor();
        //Thread.Sleep(1000);
        //Console.WriteLine("dfueabgifea");





        // You can read the output if needed
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();
        Console.ReadKey();
    }
}