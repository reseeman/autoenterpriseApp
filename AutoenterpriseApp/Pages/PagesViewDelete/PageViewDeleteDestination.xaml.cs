using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageAddDestination.xaml
    /// </summary>
    public partial class PageViewDeleteDestination : Page
    {
        DestinationContext db;
        public PageViewDeleteDestination()
        {
            InitializeComponent();

            db = new DestinationContext();
            db.destinations.Load(); // загружаем данные
            destinationsGrid.ItemsSource = db.destinations.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteDestination_Unloaded;
        }

        private void PageViewDeleteDestination_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (destinationsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < destinationsGrid.SelectedItems.Count; i++)
                {
                    Destination destination = destinationsGrid.SelectedItems[i] as Destination;
                    if (destination != null)
                    {
                        db.destinations.Remove(destination);

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
