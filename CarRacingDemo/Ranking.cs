using System;
using System.Collections;
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
    public partial class Ranking : Form
    {
        ArrayList name = new ArrayList();
        ArrayList score = new ArrayList();
        public Ranking()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            DataTable data = Rank.dataReceive();

            foreach (DataRow dt in data.Rows)
            {
                name.Add(dt["UserName"].ToString());
                score.Add(Convert.ToInt32(dt["BestScore"]));
            }

            lblName1.Text = name[0].ToString();
            lblName2.Text = name[1].ToString();
            lblName3.Text = name[2].ToString();
            lblName4.Text = name[3].ToString();
            lblName5.Text = name[4].ToString();
            lblName6.Text = name[5].ToString();
            lblName7.Text = name[6].ToString();
            lblName8.Text = name[7].ToString();

            lblScore1.Text = score[0].ToString();
            lblScore2.Text = score[1].ToString();
            lblScore3.Text = score[2].ToString();
            lblScore4.Text = score[3].ToString();
            lblScore5.Text = score[4].ToString();
            lblScore6.Text = score[5].ToString();
            lblScore7.Text = score[6].ToString();
            lblScore8.Text = score[7].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
