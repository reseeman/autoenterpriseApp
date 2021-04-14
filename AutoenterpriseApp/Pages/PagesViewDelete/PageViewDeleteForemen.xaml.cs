using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteForemen.xaml
    /// </summary>
    public partial class PageViewDeleteForemen : Page
    {
        public PageViewDeleteForemen()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
