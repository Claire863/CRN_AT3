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
using MySql.Data.MySqlClient;

namespace CRN_AT3
{
    /// <summary>
    /// Interaction logic for EmployeeMain.xaml
    /// </summary>
    public partial class EmployeeMain : Window
    {

        // Define Connection Details
        private string dbName = "crn_ictprg431";
        private string dbUser = "root";
        private string dbPassword = "";
        private int dbPort = 3306;
        private string dbServer = "localhost";

        // Connection String and MySQL Connection
        private string dbconnectionString = "";
        private MySqlConnection conn;


        public EmployeeMain()
        {
            InitializeComponent();
            dbconnectionString = $"server={dbServer}; user={dbUser}; database={dbName}; port={dbPort}; password={dbPassword}";
            conn = new MySqlConnection(dbconnectionString);
        }

        


        private void FillButton_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbconnectionString);
            string sqlQuery = "SELECT * FROM employees;";
            

            /* OLD Version using ListBox
            try
            {
                EmployeeListbox.Items.Clear();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EmployeeListbox.Items.Add($"{rdr[1]}, {rdr[2]}, DOB : {rdr[3]}, Gender Identity : {rdr[4]}, Gross Salary : {rdr[5]}, Supervisor ID : {rdr[6]}, Branch ID : {rdr[7]}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();

            */

            try
            {
                // EmployeeDataGrid.Items.Clear();

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



        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string sqlQuery = "Select * from employees where family_name like '%" + SearchEmployeeTextbox.Text + "%';";
            try
            {
                /* 
                EmployeeListbox.Items.Clear();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeeListbox.Items.Add($"{rdr[1]}, {rdr[2]}, DOB : {rdr[3]}, Gender Identity : {rdr[4]}, Gross Salary : {rdr[5]}, Supervisor ID : {rdr[6]}, Branch ID : {rdr[7]}");
                }
                */
                
                
                // EmployeeDataGrid.Items.Clear();

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

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeInsert op1 = new EmployeeInsert();
            op1.ShowDialog();

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string sqlQuery = "Delete from employees where family_name like '%" + SearchEmployeeTextbox.Text + "%';";
            try
            {

                /*
                EmployeeListbox.Items.Clear();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeeListbox.Items.Add($"{rdr[1]}, {rdr[2],5}");
                }

                */

                // EmployeeDataGrid.Items.Clear();

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


                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchEmployeeTextbox.Text))
            {
                MessageBox.Show("Enter Employee Family Name in Search box ");
            }
            else
            {

                EmployeeEdit ob = new EmployeeEdit(SearchEmployeeTextbox.Text);
                ob.ShowDialog();
            }
        }

        private void JoinOperationButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeJoinOperation ob = new EmployeeJoinOperation();
            ob.ShowDialog();
        }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void EmployeeDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AdvancedSearchButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAdvSearch ob = new EmployeeAdvSearch();
            ob.ShowDialog();
        }
    }
}
