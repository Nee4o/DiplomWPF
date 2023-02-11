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
    /// Логика взаимодействия для Cost.xaml
    /// </summary>
    public partial class Cost : Page
    {
        public Cost()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            RZDDatabaseContext.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DataGridCost.ItemsSource = RZDDatabaseContext.db.Costs.ToList();
        }

        private void DeleteCostButton_Click(object sender, RoutedEventArgs e)
        {
            var costs = DataGridCost.SelectedItems.Cast<Models.Cost>().ToList();
            if (MessageBox.Show($"Вы действительно хотите удалить {costs.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            try
            {
                RZDDatabaseContext.db.Costs.RemoveRange(costs);
                RZDDatabaseContext.db.SaveChanges();
                MessageBox.Show("Данные успешно удалены!");
                DataGridCost.ItemsSource = RZDDatabaseContext.db.Costs.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CreateCostButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddEditCost(null));
        }

        private void DataGridCost_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddEditCost(DataGridCost.CurrentItem as Models.Cost));
        }
    }
}
