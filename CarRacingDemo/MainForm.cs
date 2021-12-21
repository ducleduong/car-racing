using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //BUTTON CLICKED
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm sf = new SignInForm();
            sf.ShowDialog();
            this.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:8000/regi");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:8000");
        }

        //PROCCESS CONTROLS
        private void mainForm_Load(object sender, EventArgs e)
        {
            btnExit.MouseMove += btn_move;
            btnSignIn.MouseMove += btn_move;
            btnSignUp.MouseMove += btn_move;
            btnVisit.MouseMove += btn_move;

            btnExit.MouseLeave += btn_leave;
            btnSignIn.MouseLeave += btn_leave;
            btnSignUp.MouseLeave += btn_leave;
            btnVisit.MouseLeave += btn_leave;
        }

        private void btn_move(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;

            switch (btn.Name)
            {
                case "btnExit":
                    btn.Image = Properties.Resources.BTN_Exit_hover;
                    break;
                case "btnSignIn":
                    btn.Image = Properties.Resources.BTN_SignIn_hover;
                    break;
                case "btnSignUp":
                    btn.Image = Properties.Resources.BTN_SignUp_hover;
                    break;
                case "btnVisit":
                    btn.Image = Properties.Resources.BTN_VISIT_hover;
                    break;
            }
        }

        private void btn_leave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            switch (btn.Name)
            {
                case "btnExit":
                    btn.Image = Properties.Resources.BTN_Exit;
                    break;
                case "btnSignIn":
                    btn.Image = Properties.Resources.BTN_SignIn;
                    break;
                case "btnSignUp":
                    btn.Image = Properties.Resources.BTN_SignUp;
                    break;
                case "btnVisit":
                    btn.Image = Properties.Resources.BTN_VISIT;
                    break;
            }
        }

    }
}
