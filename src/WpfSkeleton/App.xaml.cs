using Serilog;
using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfSkeleton
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Helpers.initDefaultLanguage();
            Helpers.InitLogger();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            Helpers.CloseLogger();
        }


    }
}
