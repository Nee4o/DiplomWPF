using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

        private void saveButton_Click(object sender, RoutedEventArgs e)
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
