using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRN_AT3
{
    internal class Employee
    {
        private string dbname = "crn_ictprg431";
        private string dbuser = "root";
        private string dbpassword = "";
        private int dbport = 3306;
        private string dbserver = "localhost";
        private string dbsslm = "none";
        private string dbconnectionString = "";
        private MySqlConnection conn;


        public string SearchFN { get; set; }
        public int ID { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string DateOfBirth { get; set; }
        public string GenderIdentity { get; set; }
        public int GrossSalary { get; set; }
        public int SupervisorID { get; set; }
        public int BranchID { get; set; }

        public Employee()
        {
            dbconnectionString = String.Format("server={0};port={1};user={2};password={3};database={4};sslMode={5}", dbserver, dbport, dbuser, dbpassword, dbname, dbsslm);
            conn = new MySqlConnection(dbconnectionString);
            try
            {
                conn.Open();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("No DB Connection");
            }
            finally
            {
                conn.Close();
            }

        }

        public void Searchrec(string searchdata)
        {
            try
            {

                string sqlToRun = "Select id,given_name,family_name,date_of_birth,gender_identity,gross_salary,supervisor_id,branch_id from employees where family_name = '" + searchdata + "'; ";
                SearchFN = searchdata;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlToRun, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ID = Convert.ToInt32(rdr["id"].ToString());
                    GivenName = rdr["given_name"].ToString();
                    FamilyName = rdr["family_name"].ToString();
                    DateOfBirth = rdr["date_of_birth"].ToString();
                    GenderIdentity = rdr["gender_identity"].ToString();
                    GrossSalary = int.Parse(rdr[5].ToString());
                    SupervisorID = int.Parse(rdr[6].ToString());
                    BranchID = int.Parse(rdr[7].ToString());

                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("No record found");
            }
        }

        

        public void Updaterec()
        {
            try
            {
                string sqlToRun = "Update employees set given_name = '" + GivenName + "', gender_identity = '" + GenderIdentity + "', gross_salary = '" + GrossSalary + "', supervisor_id = " + SupervisorID + ", branch_id = " + BranchID + " where family_name = '" + SearchFN + "';";
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlToRun, conn);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No record found");
            }
            finally
            {
                conn.Close();
            }
        }



    }
}
