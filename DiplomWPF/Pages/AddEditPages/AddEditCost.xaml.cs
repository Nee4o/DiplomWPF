using System;
using System.Windows;
using System.Windows.Controls;
using DiplomWPF.Models;

namespace DiplomWPF.Pages.AddEditPages
{
    /// <summary>
    /// Логика взаимодействия для AddEditCost.xaml
    /// </summary>
    public partial class AddEditCost : Page
    {
        private Models.Cost _currentCost = new Models.Cost();
        public AddEditCost(Models.Cost cost)
        {
            if (cost != null)
            {
                _currentCost = cost;
            }
            InitializeComponent();
            DataContext = _currentCost;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCost.Id == 0)
                RZDDatabaseContext.db.Costs.Add(_currentCost);
            try
            {
                RZDDatabaseContext.db.SaveChanges();
                MessageBox.Show("Затрата успшено добавлена!");
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
