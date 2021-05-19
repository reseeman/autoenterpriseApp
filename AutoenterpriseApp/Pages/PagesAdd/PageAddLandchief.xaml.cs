using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddLandchief.xaml
    /// </summary>
    public partial class PageAddLandchief : Page
    {
        public PageAddLandchief()
        {
            InitializeComponent();

            CmbForemenChoise.SelectedValuePath = "idForemen";
            CmbForemenChoise.DisplayMemberPath = "nameForemen";
            CmbForemenChoise.ItemsSource = OdbConnectHelper.entObj.foremens.ToList();
            this.TbxFIO.PreviewTextInput += new TextCompositionEventHandler(TbxString_PreviewTextInput);
        }

        void TbxString_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0)) e.Handled = true;
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddLandchief(object sender, RoutedEventArgs e)
        {
            if (this.TbxFIO.Text != null && CmbForemenChoise.SelectedValue != null)
            {
                try
                {
                    //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                    landchiefs lndObj = new landchiefs()
                    {
                        nameLandchief = TbxFIO.Text,
                        idForemen = Convert.ToInt32(CmbForemenChoise.SelectedValue)
                    };

                    OdbConnectHelper.entObj.landchiefs.Add(lndObj);
                    OdbConnectHelper.entObj.SaveChanges();

                    MessageBox.Show("Начальник участка " + lndObj.nameLandchief + " успешно добавлен!",
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
            else
            {
                MessageBox.Show("Недостаточно данных!");
            }
        }
    }
}