using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddDestination.xaml
    /// </summary>
    public partial class PageAddDestination : Page
    {
        public PageAddDestination()
        {
            InitializeComponent();
            this.TbxDestinationCode.PreviewTextInput += new TextCompositionEventHandler(TbxInt_PreviewTextInput);
            this.TbxDeparture.PreviewTextInput += new TextCompositionEventHandler(TbxString_PreviewTextInput);
            this.TbxTerminate.PreviewTextInput += new TextCompositionEventHandler(TbxString_PreviewTextInput);
        }

        void TbxString_PreviewTextInput(object sender, TextCompositionEventArgs e) 
        {
            if (!Char.IsLetter(e.Text, 0)) e.Handled = true;
        }

        void TbxInt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDestination(object sender, RoutedEventArgs e)
        {
            if (this.TbxTerminate.Text != "" && this.TbxDeparture.Text != "")
            {
                try
                {
                    destinations dstObj = new destinations()
                    {
                        departureDestination = TbxDeparture.Text,
                        terminalDestination = TbxTerminate.Text,
                        codeDestination = TbxDestinationCode.Text
                    };

                    OdbConnectHelper.entObj.destinations.Add(dstObj);
                    OdbConnectHelper.entObj.SaveChanges();

                    MessageBox.Show("Маршрут " + dstObj.idDestination + " успешно добавлен!",
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
            else
            {
                MessageBox.Show("Недостаточно данных!");
            }
        }
    }
}
