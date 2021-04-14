using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    public partial class PageViewDeleteBrigadier : Page
    {
        public PageViewDeleteBrigadier()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
