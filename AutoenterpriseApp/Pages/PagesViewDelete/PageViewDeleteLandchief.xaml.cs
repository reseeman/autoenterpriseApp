using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteLandchief.xaml
    /// </summary>
    public partial class PageViewDeleteLandchief : Page
    {
        LandchiefContext db;
        public PageViewDeleteLandchief()
        {
            InitializeComponent();

            db = new LandchiefContext();
            db.landchiefs.Load(); // загружаем данные
            landchiefsGrid.ItemsSource = db.landchiefs.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteLandchief_Unloaded;
        }

        private void PageViewDeleteLandchief_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (landchiefsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < landchiefsGrid.SelectedItems.Count; i++)
                {
                    Landchief landchief = landchiefsGrid.SelectedItems[i] as Landchief;
                    if (landchief != null)
                    {
                        db.landchiefs.Remove(landchief);
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
