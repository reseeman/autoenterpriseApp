using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddBrigadier.xaml
    /// </summary>
    public partial class PageAddBrigadier : Page
    {
        public PageAddBrigadier()
        {
            InitializeComponent();

            CmbBrigadeChoise.SelectedValuePath = "Id";
            CmbBrigadeChoise.DisplayMemberPath = "Name";
            CmbBrigadeChoise.ItemsSource = OdbConnectHelper.entObj.brigadiers.ToList();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBrigadier(object sender, RoutedEventArgs e)
        {
            try
            {
                brigadiers brgObj = new brigadiers()
                {
                    nameBrigadier = TbxFIO.Text,
                    idBrigade = CmbBrigadeChoise.SelectedItem as brigades
                };

                OdbConnectHelper.entObj.brigadiers.Add(brgObj);
                OdbConnectHelper.entObj.SaveChanges();

                MessageBox.Show("Бригадир " + brgObj.nameBrigadier + " успешно добавлен!",
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information
                                );
                FrameApp.frmObj.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Критическая работа с приложением: " + ex.Message.ToString(),
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                    );
            }
        }
    }
}
