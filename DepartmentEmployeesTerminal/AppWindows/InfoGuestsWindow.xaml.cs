using DepartmentEmployeesTerminal.Model;
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
using System.Windows.Shapes;

namespace DepartmentEmployeesTerminal.AppWindows
{
    /// <summary>
    /// Логика взаимодействия для InfoGuestsWindow.xaml
    /// </summary>
    public partial class InfoGuestsWindow : Window
    {
        Pass contextGuest;
        public InfoGuestsWindow(Pass pass)
        {
            InitializeComponent();
            contextGuest = pass;
            DataContext = contextGuest;
            DGEnterOrExit.ItemsSource = App.DB.PassLog.Where(e => e.PassId == contextGuest.Id).ToList();
        }

        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
