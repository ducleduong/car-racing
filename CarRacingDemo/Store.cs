using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    public partial class Store : Form
    {
        int[,] carPrices =
        {
            {2,3,4,5,6,7,8,9},
            {6300,3150,7800,6300,4800,6300,4800,4800}
        };
        
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            btncar2.Click += btn_Click;
            btncar3.Click += btn_Click;
            btncar7.Click += btn_Click;
            btncar5.Click += btn_Click;
            btncar6.Click += btn_Click;
            btncar4.Click += btn_Click;
            btncar8.Click += btn_Click;
            btncar9.Click += btn_Click;

            btncar2.MouseLeave += btn_leave;
            btncar3.MouseLeave += btn_leave;
            btncar7.MouseLeave += btn_leave;
            btncar5.MouseLeave += btn_leave;
            btncar6.MouseLeave += btn_leave;
            btncar4.MouseLeave += btn_leave;
            btncar8.MouseLeave += btn_leave;
            btncar9.MouseLeave += btn_leave;

            btncar2.MouseMove += btn_move;
            btncar3.MouseMove += btn_move;
            btncar4.MouseMove += btn_move;
            btncar5.MouseMove += btn_move;
            btncar6.MouseMove += btn_move;
            btncar7.MouseMove += btn_move;
            btncar8.MouseMove += btn_move;
            btncar9.MouseMove += btn_move;

            lblCurrentCoin.Text = Character.currentCoin.ToString();
            checkCars();
            btnBuy.Enabled = false;
            btnBuy.BackgroundImage = Properties.Resources.BTN_BUY_disabled5;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int index;

            switch (btn.Tag)
            {
                case "car2":
                    ptrbSeeCar.Image = Properties.Resources.tdrc01_car08_d;
                    label1.Text = "The car can destroy anything on sight";
                    label1.ForeColor = Color.DarkGray;
                    break;
                case "car3":
                    ptrbSeeCar.Image = Properties.Resources.clipart101458;
                    label1.Text = "The unique moto in game, it can minimize its size and increase speed";
                    label1.ForeColor = Color.Red;
                    break;
                case "car4":
                    ptrbSeeCar.Image = Properties.Resources.tdrc01_car09_f;
                    label1.Text = "The car with power of flame phoenix, destroy anything touch it";
                    label1.ForeColor = Color.Orange;
                    break;
                case "car5":
                    ptrbSeeCar.Image = Properties.Resources.tdrc01_car03_a;
                    label1.Text = "Your can use this car to get more coin easier";
                    label1.ForeColor = Color.Yellow;
                    break;
                case "car6":
                    ptrbSeeCar.Image = Properties.Resources.tdrc01_car01_b;
                    label1.Text = "Can launch missile to destroy front car";
                    label1.ForeColor = Color.WhiteSmoke;
                    break;
                case "car7":
                    ptrbSeeCar.Image = Properties.Resources.clipart3005101;
                    label1.Text = "This car can make everything slower than it";
                    label1.ForeColor = Color.DarkGreen;
                    break;
                case "car8":
                    ptrbSeeCar.Image = Properties.Resources.ger_png;
                    label1.Text = "The car resurect when being crash";
                    label1.ForeColor = Color.LightGreen;
                    break;
                case "car9":
                    ptrbSeeCar.Image = Properties.Resources.blueCarIg_jpg;
                    label1.Text = "Freeze everything on its sight include time";
                    label1.ForeColor = Color.DeepSkyBlue;
                    break;
            }

            ptrbSeeCar.Tag = btn.Tag;
            index = Convert.ToInt32(ptrbSeeCar.Tag.ToString().Substring(3,1)) - 2;
            if(carPrices[1, index] == 0)
            {
                lblPrice.Text = "HAVE OWNED";
                btnBuy.Enabled = false;
                btnBuy.BackgroundImage = Properties.Resources.BTN_BUY_disabled5;
            }
            else
            {
                lblPrice.Text = carPrices[1, index].ToString();
                btnBuy.Enabled = true;
                btnBuy.BackgroundImage = Properties.Resources.BTN_BUY;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;

            btn.BackgroundImage = Properties.Resources.bovien;
        }

        private void btn_leave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;

            btn.BackgroundImage = Properties.Resources.bo;
        }

         private void checkCars()
        {
            foreach(int car in Character.cars)
            {
                for(int i = 0; i < 8; i++)
                {
                    if(carPrices[0,i] == car)
                    {
                        carPrices[1, i] = 0;
                    }
                }
            }
        }

        private void buyCar(int price)
        {
            if(Character.currentCoin >= price)
            {
                Character.currentCoin -= price;
                lblCurrentCoin.Text = Character.currentCoin.ToString();
                lblPrice.Text = "HAVE OWNED";
                btnBuy.Enabled = false;
                btnBuy.BackgroundImage = Properties.Resources.BTN_BUY_disabled5;
                Character.addCar(Convert.ToInt32(ptrbSeeCar.Tag.ToString().Substring(3, 1)));
                Character.updateData();
            } else
            {
                MessageBox.Show("You have not enough coin! Let's collect some more", "Not enough coin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            checkCars();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            buyCar(Convert.ToInt32(lblPrice.Text));
        }

       private void btn_move(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;

            btn.BackgroundImage = Properties.Resources.bovien;
        }
    }
}
