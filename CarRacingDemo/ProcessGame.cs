using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class ProccessGame
    {
        public static void destroyCar(PictureBox car, ref Panel panel1)
        {
            PictureBox explosion = new PictureBox();
            explosion.Tag = "explosion";
            explosion.Size = new Size(64, 64);
            explosion.Image = Properties.Resources.explosion;
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.Controls.Add(explosion);
            explosion.Location = new Point(car.Left, car.Top);
            explosion.BackColor = Color.Transparent;
            explosion.BringToFront();
            car.Visible = false;
        }

        public static void changeCarPosition(PictureBox temp, int distance)
        {
            Random carPosition = new Random();

            switch (temp.Tag.ToString())
            {
                case "car1":
                    temp.Location = new Point(carPosition.Next(11, 90), carPosition.Next(100, 150) * -1 - distance);
                    break;
                case "car2":
                    temp.Location = new Point(carPosition.Next(150, 320), carPosition.Next(50, 125) * -1 - distance);
                    break;
                case "car3":
                    temp.Location = new Point(carPosition.Next(375, 460), carPosition.Next(70, 100) * -1 - distance);
                    break;
            }
        }

        public static void changeCarImage(ref PictureBox temp)
        {
            Random random = new Random();
            int carImage = random.Next(1, 9);

            switch (carImage)
            {
                case 1:
                    temp.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    temp.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    temp.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    temp.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    temp.Image = Properties.Resources.TruckBlue;
                    break;
                case 6:
                    temp.Image = Properties.Resources.TruckWhite;
                    break;
                case 7:
                    temp.Image = Properties.Resources.carPink;
                    break;
                case 8:
                    temp.Image = Properties.Resources.CarRed;
                    break;
                case 9:
                    temp.Image = Properties.Resources.carYellow;
                    break;
            }
        }

        public static void changeIconSkill(PictureBox temp)
        {
            switch (Character.currentCar)
            {
                case 2:
                    temp.Image = Properties.Resources.des;
                    break;
                case 3:
                    temp.Image = Properties.Resources.MotoIcon;
                    break;
                case 4:
                    temp.Image = Properties.Resources.flameICON;
                    break;
                case 5:
                    temp.Image = Properties.Resources.bonuscoin;
                    break;
                case 6:
                    temp.Image = Properties.Resources.missileSkillIcon;
                    break;
                case 7:
                    temp.Image = Properties.Resources.F1SkillIcon;
                    break;
                case 8:
                    temp.Image = Properties.Resources.SentinalIcon;
                    break;
                case 9:
                    temp.Image = Properties.Resources.freezeIcon;
                    break;
                default:
                    temp.Image = null;
                    break;
            }
        }

        public static void removeExplosion(ref int count, ref Panel panel1)
        {
            count++;
            if (count % 20 == 0)
            {
                count = 0;
                foreach (Control x in panel1.Controls)
                {
                    if (x is PictureBox && x.Tag == "explosion")
                    {
                        panel1.Controls.Remove(x);
                        x.Dispose();
                    }
                }
            }
        }

    }
}
