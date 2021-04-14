using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Pages;
using AutoenterpriseApp.Windows;
using System.Windows;

namespace AutoenterpriseApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameApp.frmObj = FrmMain;
            FrmMain.Navigate(new PageMain());

            OdbConnectHelper.entObj = new autoenterpriseEntities();
        }

        private void menuOpenAboutWindow(object sender, RoutedEventArgs e)
        {
            WindowAbout windowAbout = new WindowAbout();
            windowAbout.Show();
        }
    }
}
