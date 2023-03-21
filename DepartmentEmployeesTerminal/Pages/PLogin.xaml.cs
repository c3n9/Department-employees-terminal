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
    /// Логика взаимодействия для PLogin.xaml
    /// </summary>
    public partial class PLogin : Page
    {
        public PLogin()
        {
            InitializeComponent();
            Refresh();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DB.Employee.FirstOrDefault(u => u.Code == TBCodeEmployee.Text);
            if (employee == null || employee.Id == 6 || employee.Id == 7)
            {
                MessageBox.Show("Неверный код сотрудника подразделения");
                return;
            }
            NavigationService.Navigate(new PGuests(employee));
        }

        private void Refresh()
        {
            App.MainWindowInstance.BBack.Visibility = Visibility.Collapsed;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
