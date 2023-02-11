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

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            if (RZDDatabaseContext.db.SystemAdministrators.FirstOrDefault(sys => sys.Login == LoginTextBox.Text && sys.Password == PasswordPasswordBox.Password) != null)
                Manager.mainFrame.Navigate(new Main());
            else MessageBox.Show("Ошибка логина или пароля");
        }
    }
}
