using DiplomWPF.Models;
using DiplomWPF.Pages;
using System.Linq;
using System.Windows;

namespace DiplomWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            if (RZDDatabaseContext.db.SystemAdministrators.FirstOrDefault(sys => sys.Login == loginTextBox.Text && sys.Password == passwordPasswordBox.Password) != null)
            {
                WorkWindow workWindow = new WorkWindow();
                workWindow.Show();
                this.Close();
            }
            else MessageBox.Show("Ошибка логина или пароля");
        }
    }
}
