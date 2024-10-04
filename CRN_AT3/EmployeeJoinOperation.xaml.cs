using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for EmployeeJoinOperation.xaml
    /// </summary>
    public partial class EmployeeJoinOperation : Window
    {
        public EmployeeJoinOperation()
        {
            InitializeComponent();
        }

        string dbconnectionString = "datasource=localhost; port=3306; username=root; password='';";

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(dbconnectionString);

            string sqlQuery1 = "select client_name as 'client name', sum(total_sales) as 'sales per client' FROM crn_ictprg431.`working_with` inner join crn_ictprg431.`employees` on employee_id =  employees.id inner join crn_ictprg431.`clients` on client_id =  clients.id WHERE family_name like '%" + EmployeeJoinOperationTextbox.Text + "%' group by client_id";
            string sqlQuery2 = "select sum(total_sales) as 'total sales' FROM crn_ictprg431.`working_with` inner join crn_ictprg431.`employees` on employee_id =  employees.id WHERE family_name like '%" + EmployeeJoinOperationTextbox.Text + "%'";



            try
            {

                conn.Open();

                // Fill the datagrid
                MySqlCommand cmd1 = new MySqlCommand(sqlQuery1, conn);
                cmd1.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                JoinOperationDataGrid.ItemsSource = dt.DefaultView;
                cmd1.Dispose();

                //Fill the total textbox
                MySqlCommand cmd2 = new MySqlCommand(sqlQuery2, conn);
                cmd2.ExecuteNonQuery();

                MySqlDataReader rdr = cmd2.ExecuteReader();

                while (rdr.Read())
                {
                    TotalSalesTextbox.Text = rdr[0].ToString();
                }


                conn.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();


            
                    


































        }

        private void EmployeeDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
        