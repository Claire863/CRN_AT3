using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace CRN_AT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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




        public MainWindow()
        {
            InitializeComponent();
            dbconnectionString = $"server={dbServer}; user={dbUser}; database={dbName}; port={dbPort}; password={dbPassword}";
            conn = new MySqlConnection(dbconnectionString);

        }

        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMain op1 = new EmployeeMain();
            op1.ShowDialog();
        }

        private void ComingSoonButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Feature Coming Soon!");
        }
    }
}
