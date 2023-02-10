using DiplomWPF.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DiplomWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Entry.xaml
    /// </summary>
    public partial class Entry : Page
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void entryButton_Click(object sender, RoutedEventArgs e)
        {
            if (RZDDatabaseContext.db.SystemAdministrators.Where(sys => sys.Login == loginTextBox.Text && sys.Password == passwordPasswordBox.Password).FirstOrDefault() != null)
                Manager.mainFrame.Navigate(new Main());
            else MessageBox.Show("Ошибка логина или пароля");
        }
    }
}
