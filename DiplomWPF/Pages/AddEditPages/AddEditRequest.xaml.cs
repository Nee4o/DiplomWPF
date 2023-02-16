using DiplomWPF.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Type = DiplomWPF.Models.Type;

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
                _currentRequest = request;

            InitializeComponent();
            DataContext = _currentRequest;

            ComboBoxTypes.ItemsSource = RZDDatabaseContext.db.Types.ToList();
            ComboBoxWorkers.ItemsSource = RZDDatabaseContext.db.Workers.ToList();
            ComboBoxStatuses.ItemsSource = RZDDatabaseContext.db.Statuses.ToList();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var errors = ErrorHandler.Handler(_currentRequest);
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            if (ComboBoxTypes.SelectedItem != null || ComboBoxStatuses.SelectedItem != null || ComboBoxWorkers.SelectionBoxItem != null)
            {
                _currentRequest.TypeId = ((Type)ComboBoxTypes.SelectedItem).Id;
                _currentRequest.StatusId = ((Status)ComboBoxStatuses.SelectedItem).Id;
                _currentRequest.WorkerId = ((Worker)ComboBoxWorkers.SelectedItem).Id;
            }
            else
            {
                return;
            }

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
