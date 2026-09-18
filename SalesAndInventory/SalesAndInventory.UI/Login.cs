using System;
using System.Windows.Forms;

namespace SalesAndInventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel matchingUser = UserController.ValidateUser(txtUsername.Text, txtPassword.Text);

                if (matchingUser != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide(); // Hide login form

                    // Example role-based navigation
                    if (matchingUser.Role == "Admin")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                    }
                    else if (matchingUser.Role == "Cashier")
                    {
                        CashierDashboard cashierDashboard = new CashierDashboard();
                        cashierDashboard.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role. Cannot navigate.");
                    }

                    this.Close(); // Close login after dashboard exits
                }
                else
                {
                    throw new Exception("Invalid Credentials");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
