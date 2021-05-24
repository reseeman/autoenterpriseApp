using AutoenterpriseApp.DataBaseFiles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoenterpriseApp.Pages.PagesAdd
{
    /// <summary>
    /// Логика взаимодействия для PageAddRoute.xaml
    /// </summary>
    public partial class PageAddRoute : Page
    {
        public PageAddRoute()
        {
            InitializeComponent();

            this.TbxBrand.PreviewTextInput += new TextCompositionEventHandler(TbxString_PreviewTextInput);
            this.TbxMileage.PreviewTextInput += new TextCompositionEventHandler(TbxInt_PreviewTextInput);
            this.TbxDestination.PreviewTextInput += new TextCompositionEventHandler(TbxInt_PreviewTextInput);

            CmbDriverChoise.SelectedValuePath = "idDriver";
            CmbDriverChoise.DisplayMemberPath = "nameDriver";
            CmbTransportTypeChoise.ToolTip = "Фамилия, Имя, Отчество водителя";
            CmbDriverChoise.ItemsSource = OdbConnectHelper.entObj.drivers.ToList();

            CmbTransportTypeChoise.SelectedValuePath = "idTransportType";
            CmbTransportTypeChoise.DisplayMemberPath = "nameTransportType";
            CmbTransportTypeChoise.ToolTip = "Тип транспорта\n" +
                                             "  Вместимость:\n" +
                                             "      - Автобус: 52\n" +
                                             "      - Такси: 4\n" +
                                             "      - Маршрутное такси: 4\n" +
                                             "      - Грузовой: 2";
            CmbTransportTypeChoise.ItemsSource = OdbConnectHelper.entObj.transport_type.ToList();
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

        private void buttonAddRoute(object sender, RoutedEventArgs e)
        {
            if (this.TbxBrand.Text != null && this.TbxMileage.Text != null && this.CmbDriverChoise.SelectedValue != null && this.CmbTransportTypeChoise.SelectedValue != null)
            {
                try
                {
                    //MessageBox.Show(CmbBrigadeChoise.SelectedValue.ToString());
                    routes rtsObj = new routes()
                    {
                        mileageTransport = Convert.ToInt32(TbxMileage.Text),
                        dateOfReceiptTransport = DateTime.Parse(TbxReceipt.Text),
                        dateOfDeductionTransport = DateTime.Parse(TbxDeduction.Text),
                        brandTransport = TbxBrand.Text,
                        idDestination = Convert.ToInt32(TbxDestination.Text),

                        idDriver = Convert.ToInt32(CmbDriverChoise.SelectedValue),
                        idTransportType = Convert.ToInt32(CmbTransportTypeChoise.SelectedValue)
                    };

                    if (this.TbxBrand.Text == "" || this.TbxMileage.Text == "" || this.CmbDriverChoise.SelectedValue == null || this.CmbTransportTypeChoise.SelectedValue == null || this.TbxDeduction.Text == "" || this.TbxReceipt.Text == "" || this.TbxDestination.Text == "")
                    {
                        MessageBox.Show("Не все данные введены!");
                    }
                    else
                    {
                        OdbConnectHelper.entObj.routes.Add(rtsObj);
                        OdbConnectHelper.entObj.SaveChanges();

                        MessageBox.Show("Рейс № " + rtsObj.idRoute + " успешно добавлен!",
                                    "Уведомление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information
                                    );
                        FrameApp.frmObj.GoBack();
                    }
                    
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
