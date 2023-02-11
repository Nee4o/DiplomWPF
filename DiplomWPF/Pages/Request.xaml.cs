using DiplomWPF.Models;
using DiplomWPF.Pages.AddEditPages;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DiplomWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class Request : Page
    {
        public Request()
        {
            InitializeComponent();
        }

        private void CreateRequestButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddEditRequest(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            RZDDatabaseContext.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DataGridRequest.ItemsSource = RZDDatabaseContext.db.Requests.ToList();
        }

        private void DataGridRequest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddEditRequest((DataGridRequest.CurrentItem as Models.Request)));
        }

        private void DeleteRequestButton_Click(object sender, RoutedEventArgs e)
        {
            var requests = DataGridRequest.SelectedItems.Cast<Models.Request>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {requests.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            try
            {
                RZDDatabaseContext.db.Requests.RemoveRange(requests);
                RZDDatabaseContext.db.SaveChanges();
                MessageBox.Show("Данные успешно удалены!");
                DataGridRequest.ItemsSource = RZDDatabaseContext.db.Requests.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
