using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class Item
    {
        protected PictureBox item;

        public Item(PictureBox item)
        {
            this.item = item;
        }

        public virtual void createItem(ref Panel panel1)
        {
            Random random = new Random();
            item.Size = new Size(40, 40);
            item.SizeMode = PictureBoxSizeMode.StretchImage;
            item.Location = new Point(random.Next(11, 460), random.Next(50, 150) * -1);
            panel1.Controls.Add(item);
        }
    }
}
