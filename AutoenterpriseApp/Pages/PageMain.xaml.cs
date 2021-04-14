using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void buttonOpenAddPage(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAdd());
        }

        private void buttonOpenViewDeletePage(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageViewDelete());
        }
    }
}
