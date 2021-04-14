using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Pages.PagesAdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoenterpriseApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        public PageAdd()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void buttonConfirm(object sender, RoutedEventArgs e)
        {
            if (AddingChoise.SelectedIndex == 0) //Маршрут
            {
                FrameApp.frmObj.Navigate(new PageAddDestination());
            }
            else if (AddingChoise.SelectedIndex == 1) //Рейс
            {
                FrameApp.frmObj.Navigate(new PageAddRoute());
            }
            else if (AddingChoise.SelectedIndex == 2) //Водитель
            {
                FrameApp.frmObj.Navigate(new PageAddDriver());
            }
            else if (AddingChoise.SelectedIndex == 3) //Мастер
            {
                FrameApp.frmObj.Navigate(new PageAddMaster());
            }
            else if (AddingChoise.SelectedIndex == 4) //Начальник цеха
            {
                FrameApp.frmObj.Navigate(new PageAddForemen());
            }
            else if (AddingChoise.SelectedIndex == 5) //Бригадир
            {
                FrameApp.frmObj.Navigate(new PageAddBrigadier());
            }
            else if (AddingChoise.SelectedIndex == 6) //Начальник участка
            {
                FrameApp.frmObj.Navigate(new PageAddLandchief());
            }
            else if (AddingChoise.SelectedIndex == 7) //Работник сервиса
            {
                FrameApp.frmObj.Navigate(new PageAddService());
            }
            else if (AddingChoise.SelectedIndex == 8) //Тип транспорта
            {
                FrameApp.frmObj.Navigate(new PageAddTransportType());
            }
        }
    }
}
