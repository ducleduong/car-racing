using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class Car
    {
        private Random random;
        public PictureBox item;

        public Car()
        {
            random = new Random();
            item = new PictureBox();
        }
        public virtual void createItem(ref Panel panel1)
        {
            Random random = new Random();
            item.SizeMode = PictureBoxSizeMode.StretchImage;
            //item.Location = new Point(random.Next(11, 460), random.Next(50, 150) * -1);
            panel1.Controls.Add(item);
            item.Size = new Size(50, 100);
            ProccessGame.changeCarImage(ref item);
            item.Tag = "car";
            item.BringToFront();

            foreach(Control control in panel1.Controls)
            {
                if(control is PictureBox && control.Tag == "car" && control.Bounds.IntersectsWith(item.Bounds))
                {
                    item.Location = new Point(random.Next(11, 460), random.Next(50, 150) * -1);
                }
            }
        }

        public static void moveCar(ref Panel panel1, ref Panel panel2, int roadSpeed,PictureBox roadTrack2)
        {
            panel2.BringToFront();
            foreach (Control co in panel1.Controls)
            {
                if (co is PictureBox && co.Tag == "car")
                {
                    co.Top += roadSpeed;

                    if (co.Top >= panel1.Height - panel2.Height)
                    {
                        panel1.Controls.Remove(co);
                        co.Dispose();   
                    }
                }
            }
        }

    }

    class CarA: Car
    {
        public CarA()
        {
        }
        public override void createItem(ref Panel panel1)
        {
            Random random = new Random();
            item.Location = new Point(random.Next(11, panel1.Width/3), random.Next(100, 150) * -1);
            base.createItem(ref panel1);
        }
    }

    class CarB : Car
    {
        public CarB()
        {
        }
        public override void createItem(ref Panel panel1)
        {
            Random random = new Random();
            item.Location = new Point(random.Next(panel1.Width/3+10 , panel1.Width / 3*2), random.Next(50, 125) * -1);
            base.createItem(ref panel1);
        }
    }

        class CarC : Car
        {
           
            public CarC()
            {
        }
            public override void createItem(ref Panel panel1)
            {
            Random random = new Random();
            item.Location = new Point(random.Next(panel1.Width / 3 * 2 + 10, panel1.Width), random.Next(70, 100) * -1);
            base.createItem(ref panel1);
            }
        }
}
