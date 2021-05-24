using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteMaster.xaml
    /// </summary>
    public partial class PageViewDeleteMaster : Page
    {
        MasterContext db;
        public PageViewDeleteMaster()
        {
            InitializeComponent();

            db = new MasterContext();
            db.masters.Load(); // загружаем данные
            mastersGrid.ItemsSource = db.masters.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteMaster_Unloaded;
        }

        private void PageViewDeleteMaster_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (mastersGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < mastersGrid.SelectedItems.Count; i++)
                {
                    Master master = mastersGrid.SelectedItems[i] as Master;
                    if (master != null)
                    {
                        db.masters.Remove(master);

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
