using AutoenterpriseApp.DataBaseFiles;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageViewDelete.xaml
    /// </summary>
    public partial class PageViewDelete : Page
    {
        public PageViewDelete()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
