using DepartmentEmployeesTerminal.AppWindows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DepartmentEmployeesTerminal.Pages
{
    /// <summary>
    /// Логика взаимодействия для PGuests.xaml
    /// </summary>
    public partial class PGuests : Page
    {
        Employee contextEmployee;
        public PGuests(Employee employee)
        {
            InitializeComponent();
            contextEmployee = employee;
            Refresh();
        }
        private void Refresh()
        {
            var filtred = App.DB.Pass.Where(g => g.PassStatus.Id == 2 && g.Employee.DepartmentId == contextEmployee.DepartmentId).ToList();
            if(DPDateForFilter.SelectedDate != null)
            {
                filtred = filtred.Where(f => f.DateStart == DPDateForFilter.SelectedDate.Value).ToList();
            }
            DGGuests.ItemsSource = filtred;
            App.MainWindowInstance.BBack.Visibility= Visibility.Visible;
        }

        private void DPDateForFilter_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void BView_Click(object sender, RoutedEventArgs e)
        {
            var selectedGuest = DGGuests.SelectedItem as Pass;
            if(selectedGuest == null)
            {
                MessageBox.Show("Выберите гостя");
                return;
            }
            new InfoGuestsWindow(selectedGuest).ShowDialog();
        }

        private void DGGuests_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var selectedGuest = DGGuests.SelectedItem as Pass;
            if (selectedGuest != null)
            {
                new AddToBlackListWindow(selectedGuest).ShowDialog();
            }
        }
    }
}
