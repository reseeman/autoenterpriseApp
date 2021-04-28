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

            CmbBrigadeChoise.SelectedValuePath = "idBrigade";
            CmbBrigadeChoise.DisplayMemberPath = "nameBrigade";
            CmbBrigadeChoise.ItemsSource = OdbConnectHelper.entObj.brigades.ToList();
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
                //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                brigadiers brgObj = new brigadiers()
                {
                    nameBrigadier = TbxFIO.Text,
                    idBrigade = Convert.ToInt32(CmbBrigadeChoise.SelectedValue)
                };

                OdbConnectHelper.entObj.brigadiers.Add(brgObj);
                OdbConnectHelper.entObj.SaveChanges();

                MessageBox.Show("Бригадир " + brgObj.nameBrigadier + " успешно добавлен!",
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information
                                );
                FrameApp.frmObj.GoBack();

                //SET IDENTITY_INSERT MyTable ON - при ошибке IDENTIY_OFF
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
