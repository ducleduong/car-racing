namespace CarRacingDemo
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblbestScore = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnRanking = new System.Windows.Forms.PictureBox();
            this.btnShop = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coinValue = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtCurrentExp = new System.Windows.Forms.Label();
            this.lblExpNeed = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CarRacingDemo.Properties.Resources.blurBackground2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblbestScore);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 692);
            this.panel2.TabIndex = 3;
            // 
            // lblbestScore
            // 
            this.lblbestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbestScore.ForeColor = System.Drawing.Color.White;
            this.lblbestScore.Location = new System.Drawing.Point(45, 17);
            this.lblbestScore.Name = "lblbestScore";
            this.lblbestScore.Size = new System.Drawing.Size(559, 81);
            this.lblbestScore.TabIndex = 8;
            this.lblbestScore.Text = "Best Score: 2000";
            this.lblbestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Controls.Add(this.btnRanking);
            this.panel4.Controls.Add(this.btnShop);
            this.panel4.Controls.Add(this.btnInventory);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Location = new System.Drawing.Point(235, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 443);
            this.panel4.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::CarRacingDemo.Properties.Resources.BTN_LOGOUT;
            this.btnLogout.Location = new System.Drawing.Point(10, 350);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 80);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogout.TabIndex = 13;
            this.btnLogout.TabStop = false;
            this.btnLogout.Tag = "Logout";
            // 
            // btnRanking
            // 
            this.btnRanking.Image = global::CarRacingDemo.Properties.Resources.BTN_RANKING21;
            this.btnRanking.Location = new System.Drawing.Point(10, 264);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(200, 80);
            this.btnRanking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRanking.TabIndex = 12;
            this.btnRanking.TabStop = false;
            this.btnRanking.Tag = "Ranking";
            // 
            // btnShop
            // 
            this.btnShop.Image = global::CarRacingDemo.Properties.Resources.BTN_SHOP;
            this.btnShop.Location = new System.Drawing.Point(10, 178);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(200, 80);
            this.btnShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShop.TabIndex = 11;
            this.btnShop.TabStop = false;
            this.btnShop.Tag = "Shop";
            // 
            // btnInventory
            // 
            this.btnInventory.Image = global::CarRacingDemo.Properties.Resources.BTN_GARAGE;
            this.btnInventory.Location = new System.Drawing.Point(10, 92);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(200, 80);
            this.btnInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInventory.TabIndex = 10;
            this.btnInventory.TabStop = false;
            this.btnInventory.Tag = "Inventory";
            // 
            // btnStart
            // 
            this.btnStart.Image = global::CarRacingDemo.Properties.Resources.BTN_START;
            this.btnStart.Location = new System.Drawing.Point(10, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 80);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 9;
            this.btnStart.TabStop = false;
            this.btnStart.Tag = "Start";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 853);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.coinValue);
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Controls.Add(this.txtCurrentExp);
            this.panel3.Controls.Add(this.lblExpNeed);
            this.panel3.Controls.Add(this.lblLevel);
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 123);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRacingDemo.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(149, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // coinValue
            // 
            this.coinValue.BackColor = System.Drawing.Color.Gold;
            this.coinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinValue.ForeColor = System.Drawing.Color.White;
            this.coinValue.Location = new System.Drawing.Point(200, 70);
            this.coinValue.Name = "coinValue";
            this.coinValue.Size = new System.Drawing.Size(105, 34);
            this.coinValue.TabIndex = 16;
            this.coinValue.Text = "10000";
            this.coinValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(142, 2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(390, 34);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "label2";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentExp
            // 
            this.txtCurrentExp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCurrentExp.ForeColor = System.Drawing.Color.White;
            this.txtCurrentExp.Location = new System.Drawing.Point(149, 36);
            this.txtCurrentExp.Name = "txtCurrentExp";
            this.txtCurrentExp.Size = new System.Drawing.Size(1, 20);
            this.txtCurrentExp.TabIndex = 10;
            // 
            // lblExpNeed
            // 
            this.lblExpNeed.BackColor = System.Drawing.Color.White;
            this.lblExpNeed.ForeColor = System.Drawing.Color.White;
            this.lblExpNeed.Location = new System.Drawing.Point(149, 36);
            this.lblExpNeed.Name = "lblExpNeed";
            this.lblExpNeed.Size = new System.Drawing.Size(390, 20);
            this.lblExpNeed.TabIndex = 9;
            this.lblExpNeed.Text = "label4";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(2, 16);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(141, 61);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "11";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CarRacingDemo.Properties.Resources.BackgroundMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 903);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExpNeed;
        private System.Windows.Forms.Label txtCurrentExp;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label coinValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbestScore;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.PictureBox btnRanking;
        private System.Windows.Forms.PictureBox btnShop;
        private System.Windows.Forms.PictureBox btnInventory;
    }
}