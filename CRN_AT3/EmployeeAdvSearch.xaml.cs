using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace CRN_AT3
{
    /// <summary>
    /// Interaction logic for EmployeeAdvSearch.xaml
    /// </summary>
    public partial class EmployeeAdvSearch : Window
    {
        public EmployeeAdvSearch()
        {
            InitializeComponent();
            
        }

        string dbconnectionString = "datasource=localhost; port=3306; username=root; password='';";

        
        
    

        private void EmployeeDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

            int MinSalary;
            int MaxSalary;

            if (!int.TryParse(SalaryMinTextbox.Text, out MinSalary)) 
            {
                MinSalary = 0;
            };
            if (!int.TryParse(SalaryMaxTextbox.Text, out MaxSalary)) 
            {
                MaxSalary = 99999999;
            };

            MySqlConnection conn = new MySqlConnection(dbconnectionString);

            string sqlQuery = "Select * from crn_ictprg431.employees where given_name like '%" + GivenNameTextbox.Text + "%' AND family_name like '%" + FamilyNameTextbox.Text + "%' AND date_of_birth like '%" + DoBTextbox.Text + "%' AND gender_identity like '%" + GenderIdentityTextbox.Text + "%' AND supervisor_id like '%" + SupervisorIDTextbox .Text + "%' AND branch_id like '%" + BranchIDTextbox.Text + "%' AND gross_salary >= " + MinSalary + " AND gross_salary <= " + MaxSalary + ";";
            try
            {
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<Employee> listEmployees = new List<Employee>();


                while (rdr.Read())
                {
                    listEmployees.Add(new Employee()
                    {
                        ID = Convert.ToInt32(rdr["id"].ToString()),
                        GivenName = rdr["given_name"].ToString(),
                        FamilyName = rdr["family_name"].ToString(),
                        DateOfBirth = rdr["date_of_birth"].ToString(),
                        GenderIdentity = rdr["gender_identity"].ToString(),
                        GrossSalary = int.Parse(rdr[5].ToString()),
                        SupervisorID = int.Parse(rdr[6].ToString()),
                        BranchID = int.Parse(rdr[7].ToString())
                    });

                }

                EmployeeDataGrid.ItemsSource = listEmployees;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void SearchByGivenName_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
