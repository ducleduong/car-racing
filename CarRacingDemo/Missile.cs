using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class Missile
    {
        public static int missileSpeed = 15;

        public static void createItem(PictureBox mainCar, ref Panel panel1)
        {
            PictureBox item = new PictureBox();
            item.Size = new Size(50, 80);
            item.SizeMode = PictureBoxSizeMode.StretchImage;
            item.Image = Properties.Resources.Missile;
            item.Location = new Point(mainCar.Left, mainCar.Top - mainCar.Height + 20);
            item.Tag = "missile";
            panel1.Controls.Add(item);
            item.BringToFront();
        }

        public static void missileFire(ref Panel panel1)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is PictureBox && control.Tag == "missile")
                {
                    control.Top -= missileSpeed;

                    foreach(Control ctr in panel1.Controls)
                    {
                        if (ctr is PictureBox && ctr.Bounds.IntersectsWith(control.Bounds))
                        {
                            if(ctr.Name == "car1" || ctr.Name == "car2" || ctr.Name == "car3")
                            {
                                ProccessGame.destroyCar((PictureBox)ctr, ref panel1);
                                ProccessGame.changeCarPosition((PictureBox)ctr, 350);
                                ctr.Visible = true;
                                control.Visible = false;
                                control.Enabled = false;
                                panel1.Controls.Remove(control);
                                control.Dispose();
                            }
                        }
                    }

                    if(control.Top <= 0 - control.Height)
                    {
                        control.Visible = false;
                        control.Enabled = false;
                        panel1.Controls.Remove(control);
                        control.Dispose();
                    }
                    
                }
            }
        }



    }
}
