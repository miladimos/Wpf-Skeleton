using Serilog;
using System.Globalization;

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
    }
}
