using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteLandchief.xaml
    /// </summary>
    public partial class PageViewDeleteLandchief : Page
    {
        public PageViewDeleteLandchief()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
