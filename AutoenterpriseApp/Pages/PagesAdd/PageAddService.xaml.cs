﻿using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddService.xaml
    /// </summary>
    public partial class PageAddService : Page
    {
        public PageAddService()
        {
            InitializeComponent();

            CmbBrigadeChoise.SelectedValuePath = "idBrigade";
            CmbBrigadeChoise.DisplayMemberPath = "nameBrigade";
            CmbBrigadeChoise.ItemsSource = OdbConnectHelper.entObj.brigades.ToList();
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
        private void buttonAddService(object sender, RoutedEventArgs e)
        {
            if (this.TbxFIO.Text != null && this.CmbBrigadeChoise.SelectedValue != null)
            {
                try
                {
                    //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                    service srvcObj = new service()
                    {
                        nameService = TbxFIO.Text,
                        idBrigade = Convert.ToInt32(CmbBrigadeChoise.SelectedValue)
                    };

                    OdbConnectHelper.entObj.service.Add(srvcObj);
                    OdbConnectHelper.entObj.SaveChanges();

                    MessageBox.Show("Персонал " + srvcObj.nameService + " успешно добавлен!",
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
