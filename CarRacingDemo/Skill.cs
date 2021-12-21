using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class Skill
    {
        public static void Destroyer(PictureBox car1, PictureBox car2, PictureBox car3, ref Panel panel1)
        {
            ProccessGame.destroyCar(car1, ref panel1);
            ProccessGame.changeCarPosition(car1, 350);
            car1.Visible = true;
            ProccessGame.destroyCar(car2, ref panel1);
            ProccessGame.changeCarPosition(car2, 350);
            car2.Visible = true;
            ProccessGame.destroyCar(car3, ref panel1);
            ProccessGame.changeCarPosition(car3, 350);
            car3.Visible = true;
        }

        public static void flameMaster(ref Panel panel1)
        {
            foreach (Control control in panel1.Controls)
            {
                if(control is PictureBox && control.Name == "mainCar")
                {
                    foreach(Control ctr in panel1.Controls)
                    {
                        if(control.Bounds.IntersectsWith(ctr.Bounds) && (ctr.Name == "car1" || ctr.Name == "car2" || ctr.Name == "car3"))
                        {
                            ProccessGame.destroyCar((PictureBox)ctr, ref panel1);
                            ProccessGame.changeCarPosition((PictureBox)ctr, 350);
                            ctr.Visible = true;
                        }
                    }
                }
            }
        }

       public static void Freeze(PictureBox car)
        {
            PictureBox freeze = new PictureBox();
            freeze.Tag = "freeze";
            freeze.Size = new Size(64, 64);
            freeze.Image = Properties.Resources.freeze;
            freeze.SizeMode = PictureBoxSizeMode.StretchImage;
            car.Controls.Add(freeze);
            freeze.Location = new Point(-8,8);
            freeze.BackColor = Color.Transparent;
            freeze.BringToFront();
        }
    }
}
