using Microsoft.Win32;
using Serilog;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace WpfSkeleton
{
    public class Helpers
    {
        public static bool GetMethodTest()
        {
            return true;
        }

        public static void InitLogger()
        {
            Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Information()
           .WriteTo.File("log.txt",
               rollingInterval: RollingInterval.Day,
               rollOnFileSizeLimit: true)
           .CreateLogger();
        }
        public static void CloseLogger()
        {
            Log.CloseAndFlush();
        }

        public static void initDefaultLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }

        public static void changeLanguage(string langCode)
        {
            switch (langCode)
            {
                case "en":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

                    break;
                case "fa":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa");
                    break;
                default:
                    break;
            }
        }

        public static void createWindowsContextMenuItem()
        {
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Classes\*\shell\WpfSkeleton\command"); // for files
                                                                                                                          // RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Classes\Directory\shell\WpfSkeleton\command"); // for directories

            registryKey.SetValue("", $"\"{Assembly.GetExecutingAssembly().Location}\" " + "\"%1\"");
            registryKey.Close();
        }

        public static void getWindowsContextMenuItemArgs(StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                //
            }
            else
            {
                return;
            }
        }


    }
}
