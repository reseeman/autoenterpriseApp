using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddDriver.xaml
    /// </summary>
    public partial class PageAddDriver : Page
    {
        public PageAddDriver()
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
        private void buttonAddDriver(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                drivers drvObj = new drivers()
                {
                    nameDriver = TbxFIO.Text,
                    idBrigade = Convert.ToInt32(CmbBrigadeChoise.SelectedValue)
                };

                OdbConnectHelper.entObj.drivers.Add(drvObj);
                OdbConnectHelper.entObj.SaveChanges();

                MessageBox.Show("Водитель " + drvObj.nameDriver + " успешно добавлен!",
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
