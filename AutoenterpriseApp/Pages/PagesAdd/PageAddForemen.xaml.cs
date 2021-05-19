using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddForemen.xaml
    /// </summary>
    public partial class PageAddForemen : Page
    {
        public PageAddForemen()
        {
            InitializeComponent();

            CmbMasterChoise.SelectedValuePath = "idMaster";
            CmbMasterChoise.DisplayMemberPath = "nameMaster";
            CmbMasterChoise.ItemsSource = OdbConnectHelper.entObj.masters.ToList();
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
        private void buttonAddForemen(object sender, RoutedEventArgs e)
        {
            if (this.TbxFIO.Text != null && CmbMasterChoise.SelectedValue != null)
            {
                try
                {
                    //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                    foremens frmnsObj = new foremens()
                    {
                        nameForemen = TbxFIO.Text,
                        idMaster = Convert.ToInt32(CmbMasterChoise.SelectedValue)
                    };

                    OdbConnectHelper.entObj.foremens.Add(frmnsObj);
                    OdbConnectHelper.entObj.SaveChanges();

                    MessageBox.Show("Начальник цеха " + frmnsObj.nameForemen + " успешно добавлен!",
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