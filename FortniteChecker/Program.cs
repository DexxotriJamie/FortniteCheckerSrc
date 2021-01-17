using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace FortniteChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(120000);
            int number = 0;

            while (number < 200)
            {
                Console.Clear();
                Console.WriteLine("Checking if <*Fortnite*> is running...");
                Process[] pname = Process.GetProcessesByName("fortnite");
                if (pname.Length > 0)
                {
                    Console.WriteLine("Fortnite is running");
                }
                else
                {
                    Console.WriteLine("Fortnite is not running, closing Epic Games...");
                    try
                    {
                        Process.GetProcessesByName("UnrealCEFSubProcess")[0].Kill();
                        Process.GetProcessesByName("UnrealCEFSubProcess")[0].Kill();
                        Process.GetProcessesByName("UnrealCEFSubProcess")[0].Kill();
                        Process.GetProcessesByName("UnrealCEFSubProcess")[0].Kill();
                    }
                    catch
                    {
                    }

                    try
                    {
                        Process.GetProcessesByName("FortniteClient-Win64-Shipping")[0].Kill();
                        Process.GetProcessesByName("FortniteClient-Win64-Shipping")[0].Kill();
                        Process.GetProcessesByName("FortniteClient-Win64-Shipping")[0].Kill();
                        Process.GetProcessesByName("FortniteClient-Win64-Shipping")[0].Kill();
                    }
                    catch
                    {
                    }

                    try
                    {
                        Process.GetProcessesByName("EpicGamesLauncher")[0].Kill();
                        Process.GetProcessesByName("EpicGamesLauncher")[0].Kill();
                        Process.GetProcessesByName("EpicGamesLauncher")[0].Kill();
                        Process.GetProcessesByName("EpicGamesLauncher")[0].Kill();
                        Process.GetProcessesByName("EpicGamesLauncher")[0].Kill();
                    }
                    catch
                    {
                    }


                    void StopService(string EasyAntiCheat, int timeoutMilliseconds)
                    {
                        ServiceController service = new ServiceController(EasyAntiCheat);
                        try
                        {
                            TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                            service.Stop();
                            service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                        }
                        catch
                        {
                            // ...
                        }
                    }
                    Environment.Exit(0);
                }
                Console.WriteLine(number);
                //number = number + 1;
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadLine();
            
        }
    }
}
