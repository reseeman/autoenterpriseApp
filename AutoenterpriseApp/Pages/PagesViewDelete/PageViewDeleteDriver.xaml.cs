using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.Windows;
using System;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteDriver.xaml
    /// </summary>
    public partial class PageViewDeleteDriver : Page
    {
        DriverContext db;
        public PageViewDeleteDriver()
        {
            InitializeComponent();

            db = new DriverContext();
            db.drivers.Load(); // загружаем данные
            driversGrid.ItemsSource = db.drivers.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteDriver_Unloaded;
        }

        private void PageViewDeleteDriver_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (driversGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < driversGrid.SelectedItems.Count; i++)
                {
                    Driver driver = driversGrid.SelectedItems[i] as Driver;
                    if (driver != null)
                    {
                        db.drivers.Remove(driver);
                    }
                }
            }
            db.SaveChanges();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
