using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    public partial class PageViewDeleteBrigadier : Page
    {
        BrigadierContext db;
        public PageViewDeleteBrigadier()
        {
            InitializeComponent();

            db = new BrigadierContext();
            db.brigadiers.Load(); // загружаем данные
            brigadiersGrid.ItemsSource = db.brigadiers.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteBrigadier_Unloaded;
        }

        private void PageViewDeleteBrigadier_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (brigadiersGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < brigadiersGrid.SelectedItems.Count; i++)
                {
                    Brigadier brigadier = brigadiersGrid.SelectedItems[i] as Brigadier;
                    if (brigadier != null)
                    {
                        db.brigadiers.Remove(brigadier);

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
