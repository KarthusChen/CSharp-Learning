using System.Linq;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseTest02
{
    public partial class MainWindow : Window
    {

        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["WpfApp1"]
            
        }
    }
}
