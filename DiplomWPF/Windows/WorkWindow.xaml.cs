using DiplomWPF.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DiplomWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
            Manager.mainFrame = mainFrame;
            Manager.mainFrame.Navigate(new Main());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch ((sender as Label).Content)
            {
                case "Заявки":
                    Manager.mainFrame.Navigate(new Request());
                    break;
                case "Затраты":
                    Manager.mainFrame.Navigate(new Cost());
                    break;
                case "Отчеты":
                    Manager.mainFrame.Navigate(new Report());
                    break;
                default:
                    break;
            }
        }
    }
}
