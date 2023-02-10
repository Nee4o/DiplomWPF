using DiplomWPF.Models;
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
            if (RZDDatabaseContext.db.SystemAdministrators.Where(sys => sys.Login == loginTextBox.Text && sys.Password == passwordPasswordBox.Password).FirstOrDefault () != null)
                NavigationPages.OpenPage(NavigationPages.Pages.Main);
            else MessageBox.Show("Ошибка логина или пароля");
        }
    }
}
