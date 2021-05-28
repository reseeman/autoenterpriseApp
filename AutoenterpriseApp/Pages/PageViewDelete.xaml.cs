using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Pages.PagesViewDelete;
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

        private void buttonConfirm(object sender, RoutedEventArgs e)
        {
            if (ViewDeleteChoise.SelectedIndex == 0) //Маршрут
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteDestination());
            }
            else if (ViewDeleteChoise.SelectedIndex == 1) //Рейс
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteRoute());
            }
            else if (ViewDeleteChoise.SelectedIndex == 2) //Водитель
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteDriver());
            }
            else if (ViewDeleteChoise.SelectedIndex == 3) //Мастер
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteMaster());
            }
            else if (ViewDeleteChoise.SelectedIndex == 4) //Начальник цеха
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteLandwork());
            }
            else if (ViewDeleteChoise.SelectedIndex == 5) //Бригадир
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteBrigadier());
            }
            else if (ViewDeleteChoise.SelectedIndex == 6) //Начальник участка
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteLandchief());
            }
            else if (ViewDeleteChoise.SelectedIndex == 7) //Работник сервиса
            {
                FrameApp.frmObj.Navigate(new PageViewDeleteStaff());
            }
        }
    }
}
