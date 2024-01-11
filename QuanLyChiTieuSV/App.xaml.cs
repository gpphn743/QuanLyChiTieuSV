using System.Configuration;
using System.Data;
using System.Windows;

namespace QuanLyChiTieuSV
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Show the login window first
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            // Check if the login was successful before proceeding
            //if (loginWindow.DialogResult.HasValue && loginWindow.DialogResult.Value)
            //{
            //    // If login was successful, show the main window
            //    MainWindow mainWindow = new MainWindow();
            //    mainWindow.Show();
            //}
            //else
            //{
            //    // If login was not successful, close the application
            //    Shutdown();
            //}
        }
    }

}
