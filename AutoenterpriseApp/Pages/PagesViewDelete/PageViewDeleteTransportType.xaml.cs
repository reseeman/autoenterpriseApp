using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteTransportType.xaml
    /// </summary>
    public partial class PageViewDeleteTransportType : Page
    {
        public PageViewDeleteTransportType()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
