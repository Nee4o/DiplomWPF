using DiplomWPF.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DiplomWPF.Pages.AddEditPages
{
    /// <summary>
    /// Логика взаимодействия для AddEditRequest.xaml
    /// </summary>
    public partial class AddEditRequest : Page
    {
        private Models.Request _currentRequest = new Models.Request();
        public AddEditRequest(Models.Request request)
        {
            if (request != null)
            {
                _currentRequest = request;
            }
            InitializeComponent();
            DataContext = _currentRequest;
            comboBoxTypes.ItemsSource = RZDDatabaseContext.db.Types.ToList();
            comboBoxWorkers.ItemsSource = RZDDatabaseContext.db.Workers.ToList();
            comboBoxStatuses.ItemsSource = RZDDatabaseContext.db.Statuses.ToList();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentRequest.Id == 0)
                RZDDatabaseContext.db.Requests.Add(_currentRequest);
            try
            {
                RZDDatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
