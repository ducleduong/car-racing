using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class Coin : Item
    {
        public Coin(PictureBox item) : base(item)
        {

        }
        public override void createItem(ref Panel panel1)
        {
            base.createItem(ref panel1);
            item.Image = Properties.Resources.coin;
            item.Name = "coin";
            item.BringToFront();
            foreach (Control control in panel1.Controls)
            {
                if (control is PictureBox && (control.Name == "car1" || control.Name == "car2" || control.Name == "car3"))
                {
                    if (control.Bounds.IntersectsWith(item.Bounds))
                    {
                        createItem(ref panel1);
                    }
                }
            }
        }

        public static void moveItem(ref Panel panel, int roadSpeed, Label lblCoin)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is PictureBox && control.Name == "coin")
                {
                    control.Top += roadSpeed;

                    foreach (Control co in panel.Controls)
                    {
                        if (co is PictureBox && co.Name == "mainCar")
                        {
                            if (co.Bounds.IntersectsWith(control.Bounds))
                            {
                                Character.currentCoin += 10;
                                lblCoin.Text = Character.currentCoin.ToString();
                                panel.Controls.Remove(control);
                                control.Dispose();
                            }
                        }
                    }

                    if (control.Top > panel.Height)
                    {
                        panel.Controls.Remove(control);
                        control.Dispose();
                    }
                }

            }
        }
    }
}
