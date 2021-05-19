using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddMaster.xaml
    /// </summary>
    public partial class PageAddMaster : Page
    {
        public PageAddMaster()
        {
            InitializeComponent();

            CmbBrigadierChoise.SelectedValuePath = "idBrigadier";
            CmbBrigadierChoise.DisplayMemberPath = "nameBrigadier";
            CmbBrigadierChoise.ItemsSource = OdbConnectHelper.entObj.brigadiers.ToList();
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
        private void buttonAddMaster(object sender, RoutedEventArgs e)
        {
            if (this.TbxFIO.Text != null && CmbBrigadierChoise.SelectedValue != null)
            {
                try
                {
                    //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                    masters mstObj = new masters()
                    {
                        nameMaster = TbxFIO.Text,
                        idBrigadier = Convert.ToInt32(CmbBrigadierChoise.SelectedValue)
                    };

                    OdbConnectHelper.entObj.masters.Add(mstObj);
                    OdbConnectHelper.entObj.SaveChanges();

                    MessageBox.Show("Мастер " + mstObj.nameMaster + " успешно добавлен!",
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
