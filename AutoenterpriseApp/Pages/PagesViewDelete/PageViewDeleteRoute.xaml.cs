using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageAddRoute.xaml
    /// </summary>
    public partial class PageViewDeleteRoute : Page
    {
        public PageViewDeleteRoute()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
