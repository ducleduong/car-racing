using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            refresh();
            btnStart.Click += btn_Click;
            btnInventory.Click += btn_Click;
            btnShop.Click += btn_Click;
            btnRanking.Click += btn_Click;
            btnLogout.Click += btn_Click;

            btnStart.MouseMove += btn_Move;
            btnInventory.MouseMove += btn_Move;
            btnShop.MouseMove += btn_Move;
            btnRanking.MouseMove += btn_Move;
            btnLogout.MouseMove += btn_Move;

            btnStart.MouseLeave += btn_Leave;
            btnInventory.MouseLeave += btn_Leave;
            btnShop.MouseLeave += btn_Leave;
            btnRanking.MouseLeave += btn_Leave;
            btnLogout.MouseLeave += btn_Leave;

            Character.receiveCarStorage();
        }

        //LOAD DATA
        private void refresh()
        {
            Character.receiveData();


            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.lblExpNeed, Character.currentExp + "/" + Character.expLevelUp);
            toolTip1.SetToolTip(this.txtCurrentExp, Character.currentExp + "/" + Character.expLevelUp);

            double rate = Character.currentExp * 1.0 / Character.expLevelUp * 1.0;
            txtCurrentExp.Width = Convert.ToInt32(lblExpNeed.Width * rate);

            lblUserName.Text = Character.name;
            coinValue.Text = Character.currentCoin.ToString();
            lblLevel.Text = Character.level.ToString();

            lblbestScore.Text = "Best score: " + Character.bestScore;
        }

        //PROCESS CONTROL

        private void btn_Click(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            switch (button.Tag)
            {
                case "Start":
                    this.Hide();
                    InGame ig = new InGame();
                    ig.ShowDialog();
                    refresh();
                    this.Show();
                    break;
                case "Inventory":
                    this.Hide();
                    ChooseCar cc = new ChooseCar();
                    cc.ShowDialog();
                    refresh();
                    this.Show();
                    break;
                case "Shop":
                    this.Hide();
                    Store s = new Store();
                    s.ShowDialog();
                    refresh();
                    this.Show();
                    break;
                case "Ranking":
                    this.Hide();
                    Ranking r = new Ranking();
                    r.ShowDialog();
                    refresh();
                    this.Show();
                    break;
                case "Logout":
                    this.Close();
                    break;
            }
        }

        private void btn_Move(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;

            switch (btn.Tag)
            {
                case "Start":
                    btnStart.Image = Properties.Resources.BTN_START_HOVER;
                    break;
                case "Inventory":
                    btnInventory.Image = Properties.Resources.BTN_GARAGE_hover;
                    break;
                case "Shop":
                    btnShop.Image = Properties.Resources.BTN_SHOP_hover;
                    break;
                case "Ranking":
                    btnRanking.Image = Properties.Resources.BTN_RANKING_hover;
                    break;
                case "Logout":
                    btnLogout.Image = Properties.Resources.BTN_LOGOUT_hover;
                    break;
            }
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;

            switch (btn.Tag)
            {
                case "Start":
                    btnStart.Image = Properties.Resources.BTN_START;
                    break;
                case "Inventory":
                    btnInventory.Image = Properties.Resources.BTN_GARAGE;
                    break;
                case "Shop":
                    btnShop.Image = Properties.Resources.BTN_SHOP;
                    break;
                case "Ranking":
                    btnRanking.Image = Properties.Resources.BTN_RANKING21;
                    break;
                case "Logout":
                    btnLogout.Image = Properties.Resources.BTN_LOGOUT;
                    break;
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Character.updateData();
                PublicClass.ID_USER = "";
                Character.cars.Clear();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
