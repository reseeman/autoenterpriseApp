using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteForemen.xaml
    /// </summary>
    public partial class PageViewDeleteLandwork : Page
    {
        LandworkContext db;
        public PageViewDeleteLandwork()
        {
            InitializeComponent();

            db = new LandworkContext();
            db.landworks.Load(); // загружаем данные
            landworksGrid.ItemsSource = db.landworks.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteLandwork_Unloaded;
        }

        private void PageViewDeleteLandwork_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (landworksGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < landworksGrid.SelectedItems.Count; i++)
                {
                    Landwork landwork = landworksGrid.SelectedItems[i] as Landwork;
                    if (landwork != null)
                    {
                        db.landworks.Remove(landwork);
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
