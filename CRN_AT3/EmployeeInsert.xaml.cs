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

namespace CRN_AT3
{
    /// <summary>
    /// Interaction logic for EmployeeInsert.xaml
    /// </summary>
    public partial class EmployeeInsert : Window
    {
        public EmployeeInsert()
        {
            InitializeComponent();
        }

        string dbconnectionString = "datasource=localhost; port=3306; username=root; password='';";

        public void cleardata()
        {
            GivenNameTextbox.Clear();
            FamilyNameTextbox.Clear();
            DateOfBirthTextbox.Clear();
            GenderIdentityTextbox.Clear();
            GrossSalaryTextbox.Clear();
            SupervisorIDTextbox.Clear();
            BranchIDTextbox.Clear();
        }

        public void insertrec()
        {
            MySqlConnection conn = new MySqlConnection(dbconnectionString);
            
            string sqlQuery = "Insert into crn_ictprg431.employees values (0,'" + this.GivenNameTextbox.Text + "','" + this.FamilyNameTextbox.Text + "',date '" + this.DateOfBirthTextbox.Text + "','" + this.GenderIdentityTextbox.Text + "'," + this.GrossSalaryTextbox.Text + "," + this.SupervisorIDTextbox.Text + "," + this.BranchIDTextbox.Text + ",CURRENT_TIMESTAMP(),CURRENT_TIMESTAMP())";
           

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            try
            {

                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sqlQuery, conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Added");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            insertrec();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            cleardata();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
