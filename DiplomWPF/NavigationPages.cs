using DiplomWPF.Models;
using DiplomWPF.Pages;
using DiplomWPF.Pages.AddEditPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Request = DiplomWPF.Pages.Request;

namespace DiplomWPF
{
    /// <summary>
    /// 
    /// </summary>
    public class NavigationPages
    {
        public static Frame mainFrame { get; set; }
        public enum Pages
        {
            Main,
            Request,
            Entry,
            AddEditRequest
        }

        public static void OpenPage(Pages pages)
        {
            switch (pages)
            {
                case Pages.Main:
                    mainFrame.Navigate(new Main());
                    break;
                case Pages.Request:
                    mainFrame.Navigate(new Request());
                    break; 
                case Pages.Entry:
                    mainFrame.Navigate(new Entry());
                    break;
                case Pages.AddEditRequest:
                    mainFrame.Navigate(new AddEditRequest());
                    break;
                default:
                    break;
            }
        }
    }
}
