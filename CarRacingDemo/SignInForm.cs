using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace CarRacingDemo
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }


        //BUTTON CLICK
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn2_Click(object sender, EventArgs e)
        {
            CommandSQL sqlCommand = new CommandSQL();
            string command = String.Format("SELECT UserName, id_user, Password FROM CARUSER WHERE UserName = '{0}' AND Password = '{1}'", txbUsername.Text, txbPassword.Text);
            if (sqlCommand.login(command)) 
            {
                MainMenu mn = new MainMenu();
                this.Hide();
                this.Close();
                mn.ShowDialog();

            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Sign in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_MouseMove(object sender, MouseEventArgs e)
        {
            btnSignIn.Image = Properties.Resources.BTN_SignIn_hover1;
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.Image = Properties.Resources.BTN_SignIn1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BTN_BACK_hover1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BTN_BACK21;
        }
    }
}
