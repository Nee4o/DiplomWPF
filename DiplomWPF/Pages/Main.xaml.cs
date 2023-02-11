using System.Windows;
using System.Windows.Controls;

namespace DiplomWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToRequest_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new Request());
        }
    }
}
