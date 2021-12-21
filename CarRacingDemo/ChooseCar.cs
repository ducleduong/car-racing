using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    public partial class ChooseCar : Form
    {
        public ChooseCar()
        {
            InitializeComponent();
            init();
        }

        private void setLabel()
        {
            if (Character.cars.Count > 1)
            {
                Button[] pics = new Button[Character.cars.Count];
                for (int i = 0; i < pics.Length - 1; i++)
                {
                    pics[i] = new Button();
                    pics[i].BackgroundImageLayout = ImageLayout.Stretch;
                    pics[i].ForeColor = pic0.ForeColor;
                    pics[i].Size = pic0.Size;
                    pics[i].BackColor = Color.Transparent;
                    pics[i].Font = pic0.Font;
                    pics[i].Name = String.Format("pic{0}", (int)Character.cars[i + 1]);
                    pics[i].Tag = Character.cars[i + 1];
                    this.Controls.Add(pics[i]);
                    Character.setLogoCar(pics[i], (int)Character.cars[i + 1]);
                    if (i == 0)
                    {
                        pics[i].Location = new Point(pic0.Left, pic0.Top + pic0.Height + 4);
                    }
                    else
                    {
                        pics[i].Location = new Point(pics[i - 1].Left, pics[i - 1].Top + pics[i - 1].Height + 4);
                    }
                    pics[i].Click += btn_Click;

                    if (Character.currentCar == Convert.ToInt32(pics[i].Name.Substring(3, 1)))
                    {
                        Character.setLogoCar(pics[i], Convert.ToInt32(pics[i].Name.Substring(3, 1)));
                        showInfo(pics[i]);
                        pics[i].Enabled = false;
                        pictureBox3.Tag = pics[i].Tag;
                    }
                }
            }

                if (Character.currentCar == 1)
                {
                    Character.setLogoCar(pic0, Convert.ToInt32(pic0.Name.Substring(3, 1)));
                    showInfo(pic0);
                    pic0.Enabled = false;
                    pictureBox3.Tag = pic0.Tag;
                }
                pic0.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            foreach (Control control in this.Controls)
            {
                if(control is Button && !control.Enabled)
                {
                    control.Enabled = true;
                    Character.setLogoCar((Button)control, Convert.ToInt32(control.Name.Substring(3, 1)));
                }
            }

            showInfo(btn);

            btn.Enabled = false;
            pictureBox3.Tag = btn.Tag;

            if (Character.currentCar == Convert.ToInt32(btn.Tag))
            {
                selectBtn.Enabled = false;
            }
            else
            {
                selectBtn.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Character.updateData();
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            Character.currentCar = Convert.ToInt32(pictureBox3.Tag);
            selectBtn.Enabled = false;
        }

        private void init()
        {
            setLabel();
            u.Controls.Add(label1);
            label1.Location = new Point(u.Width / 2 - (label1.Width + label2.Width + 4) / 2, u.Height - label1.Height - u.Height / 20);
            u.Controls.Add(label2);
            label2.Location = new Point(label1.Left + label1.Width + 4, label1.Top);
            u.Controls.Add(selectBtn);
            selectBtn.Location = new Point(label2.Left, label2.Top + label2.Height + 4);
            u.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(u.Width / 2 - pictureBox1.Width / 2, label1.Top - pictureBox1.Height - 4);
            u.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(u.Width / 2 - pictureBox2.Width / 2, 10);
            label1.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(0, 0);
            u.Controls.Add(button2);
            button2.Location = new Point(label2.Left, selectBtn.Top + selectBtn.Height + 6);
        }

        private void showInfo(Button btn)
        {
            switch (btn.Name)
            {
                case "pic0":
                    btn.BackgroundImage = Properties.Resources.DefaultSelected;
                    pictureBox1.Image = Properties.Resources.defaultCar;
                    label2.Image = Properties.Resources.carYellow;
                    label1.Text = "The default car, have nothing special";
                    label1.ForeColor = Color.LightGoldenrodYellow;
                    pictureBox3.Image = null;
                    break;
                case "pic2":
                    btn.BackgroundImage = Properties.Resources.logoDestroyerSelected;
                    pictureBox1.Image = Properties.Resources.lackcar;
                    label2.Image = Properties.Resources.tdrc01_car08_d;
                    label1.Text = "The car can destroy anything on sight";
                    label1.ForeColor = Color.DarkGray;
                    pictureBox3.Image = Properties.Resources.destroyerLabel;
                    break;
                case "pic3":
                    btn.BackgroundImage = Properties.Resources.logoR15Selected;
                    pictureBox1.Image = Properties.Resources.moto;
                    label2.Image = Properties.Resources.clipart101458;
                    label1.Text = "The unique moto in game, it can minimize its size and increase speed";
                    label1.ForeColor = Color.Red;
                    pictureBox3.Image = Properties.Resources.R15Label;
                    break;
                case "pic4":
                    btn.BackgroundImage = Properties.Resources.logoPhoenixSelected;
                    pictureBox1.Image = Properties.Resources.orangeCar;
                    label2.Image = Properties.Resources.tdrc01_car09_f;
                    label1.Text = "The car with power of flame phoenix, destroy anything touch it";
                    label1.ForeColor = Color.Orange;
                    pictureBox3.Image = Properties.Resources.PhoenixLabel;
                    break;
                case "pic5":
                    btn.BackgroundImage = Properties.Resources.logoLamSelected;
                    pictureBox1.Image = Properties.Resources.lamborCarg;
                    label2.Image = Properties.Resources.tdrc01_car03_a;
                    label1.Text = "Your can use this car to get more coin easier";
                    label1.ForeColor = Color.Yellow;
                    pictureBox3.Image = Properties.Resources.lamborginiLabel;
                    break;
                case "pic6":
                    btn.BackgroundImage = Properties.Resources.logoRocketSelected;
                    pictureBox1.Image = Properties.Resources.white;
                    label2.Image = Properties.Resources.tdrc01_car01_b;
                    label1.Text = "Can launch missile to destroy front car";
                    label1.ForeColor = Color.WhiteSmoke;
                    pictureBox3.Image = Properties.Resources.RocketLabel;
                    break;
                case "pic7":
                    btn.BackgroundImage = Properties.Resources.logoF1Selected;
                    pictureBox1.Image = Properties.Resources.f1;
                    label2.Image = Properties.Resources.clipart3005101;
                    label1.Text = "This car can make everything slower than it";
                    label1.ForeColor = Color.DarkGreen;
                    pictureBox3.Image = Properties.Resources.F1Label;
                    break;
                case "pic8":
                    btn.BackgroundImage = Properties.Resources.logoSentielSelected;
                    pictureBox1.Image = Properties.Resources.greencar;
                    label2.Image = Properties.Resources.ger_png;
                    label1.Text = "The car resurect when being crash";
                    label1.ForeColor = Color.LightGreen;
                    pictureBox3.Image = Properties.Resources.sentinelLabel;
                    break;
                case "pic9":
                    btn.BackgroundImage = Properties.Resources.logoFreezeSelected;
                    pictureBox1.Image = Properties.Resources.freezeCar;
                    label2.Image = Properties.Resources.blueCarIg_jpg;
                    label1.Text = "Freeze everything on its sight include time";
                    label1.ForeColor = Color.DeepSkyBlue;
                    pictureBox3.Image = Properties.Resources.freezeLabel;
                    break;
            }
        }
    }
        
}
