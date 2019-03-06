using System;
using System.IO;
using System.Threading;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Xml;
using System.Collections.Generic;
using System.Net;

namespace build
{
    class structures
    {
        private static void Main()
        {
            Console.Write("Debuging API : ");
            Directory.CreateDirectory("Code");
            Directory.CreateDirectory("Config");
            Directory.CreateDirectory("Gradle");
            Directory.CreateDirectory("Plugins");
            Directory.CreateDirectory("License");
            CreateBuild();
        }
        private static void CreateBuild()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[");
            for(int x = 0; x <= 20;x++)
            {
                
               string Fileprotcol = "Config/Config_" + Convert.ToString(x) + ".ntyconfig" ; 
               File.Create(Fileprotcol); 
               Thread.Sleep(100);

               Console.Write("#");
               if(x==20)
               {
                   Console.Write("#]");
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.Write("\nDone\n");
                   Console.ForegroundColor = ConsoleColor.Gray;
                   Thread.Sleep(100);
                   try
                   {
                       Console.Write("\nInstall Gradle : ");
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.Write("[###########");
                       System.Diagnostics.Process.Start("cmd.exe","/c" + "SET PATH=%PATH%;C:/Windows/Microsoft.NET/Framework/v4.0.30319/csc.exe");
                       Thread.Sleep(500);
                       Console.Write("###########]");
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.Write("\nDone\n");
                       Console.ForegroundColor = ConsoleColor.Gray; 
                       StreamWriter lic = new StreamWriter("License/License.ntyc");
                       lic.Write("Licensed by Asier");
                       lic.Write("\n[EnableCode] = 00010000101111010001");
                       lic.Close();

                       StreamWriter plug = new StreamWriter("Plugins/metapack.json");
                       plug.Write("{\"EnableCount\":\"true\",\"AutoCopy\":\"false\"}");
                       plug.Close();

                       StreamWriter payl = new StreamWriter("Start.bat");
                       payl.Write("echo off && cls && Code/main.exe");
                       payl.Close();

                       File.Create("error.log");
                       System.Diagnostics.Process.Start("cmd.exe","/c" + "csc error.cs");
                       System.Diagnostics.Process.Start("cmd.exe","/c" + "csc reset.cs");
                   }
                   catch(Exception) 
                   {
                       Console.Write("Error de cscui.dll//csc.exe");
                   }


               }
            }
        }

            
    }

}