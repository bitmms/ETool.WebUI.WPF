using System.Windows;

namespace ETool.WPF.App
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
