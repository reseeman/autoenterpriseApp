using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageAddRoute.xaml
    /// </summary>
    public partial class PageViewDeleteRoute : Page
    {
        RouteContext db;
        public PageViewDeleteRoute()
        {
            InitializeComponent();

            db = new RouteContext();
            db.routes.Load(); // загружаем данные
            routesGrid.ItemsSource = db.routes.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteRoute_Unloaded;
        }

        private void PageViewDeleteRoute_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (routesGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < routesGrid.SelectedItems.Count; i++)
                {
                    Route route = routesGrid.SelectedItems[i] as Route;
                    if (route != null)
                    {
                        db.routes.Remove(route);

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
