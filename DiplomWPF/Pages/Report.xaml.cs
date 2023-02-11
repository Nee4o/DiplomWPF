using DiplomWPF.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DiplomWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            RZDDatabaseContext.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DataGridReport.ItemsSource = RZDDatabaseContext.db.Reports.ToList();
        }
    }
}
