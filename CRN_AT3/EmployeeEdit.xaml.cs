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

namespace CRN_AT3
{
    /// <summary>
    /// Interaction logic for EmployeeEdit.xaml
    /// </summary>
    public partial class EmployeeEdit : Window
    {
        Employee employee;

        public EmployeeEdit(String searchdata)
        {
            InitializeComponent();

            employee = new Employee();
            employee.Searchrec(searchdata);
            this.DataContext = employee;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            employee.Updaterec();
            MessageBox.Show("Saved");

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            GivenNameTextbox.Clear();
            FamilyNameTextbox.Clear();
            DateOfBirthTextbox.Clear();
            GenderIdentityTextbox.Clear();
            GrossSalaryTextbox.Clear();
            SupervisorIDTextbox.Clear();
            BranchIDTextbox.Clear();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
