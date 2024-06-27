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

namespace LoginApp
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Click_Button(object sender, RoutedEventArgs e)
        {
            var PasswordEntered = PasswordBox1.Password;

            var password = Environment.GetEnvironmentVariable("InvoiceManagement");
            if (password != null) 
            {
                if (PasswordEntered == password)
                {
                    MessageBox.Show("Entered Correct Password");
                }
                else
                {
                    MessageBox.Show("Entered Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Enviornment Variable is NULL");
            }
        }

        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox1.Password);
        }

    }
}
