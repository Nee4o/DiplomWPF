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

        private void createRequestButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddEditRequest(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                RZDDatabaseContext.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dataGridRequest.ItemsSource = RZDDatabaseContext.db.Requests.ToList();
            }
        }

        private void dataGridRequest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddEditRequest((dataGridRequest.CurrentItem as Models.Request)));
        }

        private void deleteRequestButton_Click(object sender, RoutedEventArgs e)
        {
            var requests = dataGridRequest.SelectedItems.Cast<Models.Request>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {requests.Count} элементов?", "Внимание", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RZDDatabaseContext.db.Requests.RemoveRange(requests);
                    RZDDatabaseContext.db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");
                    dataGridRequest.ItemsSource = RZDDatabaseContext.db.Requests.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
