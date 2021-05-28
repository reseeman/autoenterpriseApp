using AutoenterpriseApp.DataBaseFiles;
using AutoenterpriseApp.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace AutoenterpriseApp.Pages.PagesViewDelete
{
    /// <summary>
    /// Логика взаимодействия для PageViewDeleteService.xaml
    /// </summary>
    public partial class PageViewDeleteStaff : Page
    {
        StaffContext db;
        public PageViewDeleteStaff()
        {
            InitializeComponent();

            db = new StaffContext();
            db.staffs.Load(); // загружаем данные
            staffsGrid.ItemsSource = db.staffs.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Unloaded += PageViewDeleteStaff_Unloaded;
        }

        private void PageViewDeleteStaff_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (staffsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < staffsGrid.SelectedItems.Count; i++)
                {
                    Staff staff = staffsGrid.SelectedItems[i] as Staff;
                    if (staff != null)
                    {
                        db.staffs.Remove(staff);

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
