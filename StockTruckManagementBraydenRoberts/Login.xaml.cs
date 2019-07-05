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
using StockTruckManagementBraydenRoberts.Models.DB;

namespace StockTruckManagementBraydenRoberts
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            string un = userNametb.Text;
            string pwd = userPasswordtb.Text;

            if(un.Length == 0 || pwd.Length == 0)
            {
                MessageBox.Show("Please enter missing values");
            }
            else
            {
                using (GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
                {
                    TruckEmployee te = ctx.TruckEmployee.Where(c => c.Username == un &&
                    c.Password == pwd).FirstOrDefault();

                    if(te == null)
                    {
                        MessageBox.Show("Please enter correct login details");
                    }
                    else
                    {
                        MessageBox.Show("Welcome");
                        MainWindow mw = new MainWindow();
                        mw.Show();

                    }
                }
            }
        }
    }
}
