namespace CarRacingDemo
{
    partial class InGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.startPress = new System.Windows.Forms.Label();
            this.notiLevel = new System.Windows.Forms.Label();
            this.conPan = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.notiOverGame = new System.Windows.Forms.Label();
            this.notibestScore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMissile = new System.Windows.Forms.PictureBox();
            this.missileLbl = new System.Windows.Forms.Label();
            this.picBonus = new System.Windows.Forms.PictureBox();
            this.lblBonusCoin = new System.Windows.Forms.Label();
            this.currentTime1 = new System.Windows.Forms.Label();
            this.maxTime1 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxTime = new System.Windows.Forms.Label();
            this.picSkill = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoin = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.mainCar = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.overGame = new System.Windows.Forms.Panel();
            this.levelValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.Label();
            this.lblCurrExp = new System.Windows.Forms.Label();
            this.lblExpNeed = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.conPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.overGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.startPress);
            this.panel1.Controls.Add(this.notiLevel);
            this.panel1.Controls.Add(this.conPan);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.car3);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.mainCar);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Controls.Add(this.overGame);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 904);
            this.panel1.TabIndex = 0;
            // 
            // startPress
            // 
            this.startPress.BackColor = System.Drawing.Color.Transparent;
            this.startPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPress.ForeColor = System.Drawing.Color.White;
            this.startPress.Location = new System.Drawing.Point(114, 276);
            this.startPress.Name = "startPress";
            this.startPress.Size = new System.Drawing.Size(477, 32);
            this.startPress.TabIndex = 14;
            this.startPress.Text = "Press < or > to start";
            this.startPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notiLevel
            // 
            this.notiLevel.BackColor = System.Drawing.Color.Transparent;
            this.notiLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notiLevel.ForeColor = System.Drawing.Color.White;
            this.notiLevel.Location = new System.Drawing.Point(117, 276);
            this.notiLevel.Name = "notiLevel";
            this.notiLevel.Size = new System.Drawing.Size(477, 32);
            this.notiLevel.TabIndex = 3;
            this.notiLevel.Text = "Level Up!!!";
            this.notiLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conPan
            // 
            this.conPan.BackgroundImage = global::CarRacingDemo.Properties.Resources.blurBackground;
            this.conPan.Controls.Add(this.closeForm);
            this.conPan.Controls.Add(this.notiOverGame);
            this.conPan.Controls.Add(this.notibestScore);
            this.conPan.Location = new System.Drawing.Point(120, 358);
            this.conPan.Name = "conPan";
            this.conPan.Size = new System.Drawing.Size(420, 132);
            this.conPan.TabIndex = 12;
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.Transparent;
            this.closeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeForm.Image = global::CarRacingDemo.Properties.Resources.BTN_CONTINUE;
            this.closeForm.Location = new System.Drawing.Point(170, 72);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(100, 50);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeForm.TabIndex = 13;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.pictureBox1_Click);
            this.closeForm.MouseLeave += new System.EventHandler(this.closeForm_MouseLeave);
            this.closeForm.MouseHover += new System.EventHandler(this.closeForm_MouseHover);
            // 
            // notiOverGame
            // 
            this.notiOverGame.BackColor = System.Drawing.Color.Transparent;
            this.notiOverGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notiOverGame.ForeColor = System.Drawing.Color.White;
            this.notiOverGame.Location = new System.Drawing.Point(11, 0);
            this.notiOverGame.Name = "notiOverGame";
            this.notiOverGame.Size = new System.Drawing.Size(421, 32);
            this.notiOverGame.TabIndex = 12;
            this.notiOverGame.Text = "Game Over";
            this.notiOverGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notibestScore
            // 
            this.notibestScore.BackColor = System.Drawing.Color.Transparent;
            this.notibestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notibestScore.ForeColor = System.Drawing.Color.White;
            this.notibestScore.Location = new System.Drawing.Point(-69, 24);
            this.notibestScore.Name = "notibestScore";
            this.notibestScore.Size = new System.Drawing.Size(593, 45);
            this.notibestScore.TabIndex = 14;
            this.notibestScore.Text = "You earn new best score!!!";
            this.notibestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.picMissile);
            this.panel2.Controls.Add(this.missileLbl);
            this.panel2.Controls.Add(this.picBonus);
            this.panel2.Controls.Add(this.lblBonusCoin);
            this.panel2.Controls.Add(this.currentTime1);
            this.panel2.Controls.Add(this.maxTime1);
            this.panel2.Controls.Add(this.currentTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.maxTime);
            this.panel2.Controls.Add(this.picSkill);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCoin);
            this.panel2.Controls.Add(this.txtScore);
            this.panel2.Location = new System.Drawing.Point(0, 796);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 107);
            this.panel2.TabIndex = 3;
            // 
            // picMissile
            // 
            this.picMissile.Image = global::CarRacingDemo.Properties.Resources._321;
            this.picMissile.Location = new System.Drawing.Point(444, 10);
            this.picMissile.Name = "picMissile";
            this.picMissile.Size = new System.Drawing.Size(45, 45);
            this.picMissile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMissile.TabIndex = 31;
            this.picMissile.TabStop = false;
            this.picMissile.Visible = false;
            // 
            // missileLbl
            // 
            this.missileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missileLbl.ForeColor = System.Drawing.Color.White;
            this.missileLbl.Location = new System.Drawing.Point(408, 47);
            this.missileLbl.Name = "missileLbl";
            this.missileLbl.Size = new System.Drawing.Size(121, 49);
            this.missileLbl.TabIndex = 32;
            this.missileLbl.Text = "0";
            this.missileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.missileLbl.Visible = false;
            // 
            // picBonus
            // 
            this.picBonus.Image = global::CarRacingDemo.Properties.Resources.coin;
            this.picBonus.Location = new System.Drawing.Point(443, 58);
            this.picBonus.Name = "picBonus";
            this.picBonus.Size = new System.Drawing.Size(45, 45);
            this.picBonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBonus.TabIndex = 29;
            this.picBonus.TabStop = false;
            this.picBonus.Visible = false;
            // 
            // lblBonusCoin
            // 
            this.lblBonusCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusCoin.ForeColor = System.Drawing.Color.Gold;
            this.lblBonusCoin.Location = new System.Drawing.Point(451, 58);
            this.lblBonusCoin.Name = "lblBonusCoin";
            this.lblBonusCoin.Size = new System.Drawing.Size(121, 49);
            this.lblBonusCoin.TabIndex = 30;
            this.lblBonusCoin.Text = "+10";
            this.lblBonusCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBonusCoin.Visible = false;
            // 
            // currentTime1
            // 
            this.currentTime1.BackColor = System.Drawing.Color.Crimson;
            this.currentTime1.ForeColor = System.Drawing.Color.White;
            this.currentTime1.Location = new System.Drawing.Point(56, 45);
            this.currentTime1.Name = "currentTime1";
            this.currentTime1.Size = new System.Drawing.Size(0, 10);
            this.currentTime1.TabIndex = 28;
            // 
            // maxTime1
            // 
            this.maxTime1.BackColor = System.Drawing.Color.White;
            this.maxTime1.ForeColor = System.Drawing.Color.White;
            this.maxTime1.Location = new System.Drawing.Point(56, 45);
            this.maxTime1.Name = "maxTime1";
            this.maxTime1.Size = new System.Drawing.Size(200, 10);
            this.maxTime1.TabIndex = 27;
            this.maxTime1.Text = "maxTIme";
            // 
            // currentTime
            // 
            this.currentTime.BackColor = System.Drawing.Color.DodgerBlue;
            this.currentTime.ForeColor = System.Drawing.Color.White;
            this.currentTime.Location = new System.Drawing.Point(56, 20);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(0, 10);
            this.currentTime.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-8, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // maxTime
            // 
            this.maxTime.BackColor = System.Drawing.Color.White;
            this.maxTime.ForeColor = System.Drawing.Color.White;
            this.maxTime.Location = new System.Drawing.Point(56, 20);
            this.maxTime.Name = "maxTime";
            this.maxTime.Size = new System.Drawing.Size(200, 10);
            this.maxTime.TabIndex = 25;
            this.maxTime.Text = "maxTIme";
            // 
            // picSkill
            // 
            this.picSkill.Location = new System.Drawing.Point(3, 15);
            this.picSkill.Name = "picSkill";
            this.picSkill.Size = new System.Drawing.Size(45, 45);
            this.picSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSkill.TabIndex = 23;
            this.picSkill.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Press \'P\' to pause";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRacingDemo.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(584, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score";
            // 
            // txtCoin
            // 
            this.txtCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoin.ForeColor = System.Drawing.Color.White;
            this.txtCoin.Location = new System.Drawing.Point(548, 47);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(121, 49);
            this.txtCoin.TabIndex = 15;
            this.txtCoin.Text = "0";
            this.txtCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(3, 56);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(685, 31);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // car3
            // 
            this.car3.Location = new System.Drawing.Point(599, 25);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(50, 100);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car3.TabIndex = 6;
            this.car3.TabStop = false;
            this.car3.Tag = "car3";
            // 
            // car2
            // 
            this.car2.Location = new System.Drawing.Point(428, 25);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(50, 100);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car2.TabIndex = 5;
            this.car2.TabStop = false;
            this.car2.Tag = "car2";
            // 
            // car1
            // 
            this.car1.Location = new System.Drawing.Point(137, 25);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(50, 100);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car1.TabIndex = 4;
            this.car1.TabStop = false;
            this.car1.Tag = "car1";
            // 
            // mainCar
            // 
            this.mainCar.Image = global::CarRacingDemo.Properties.Resources.xe;
            this.mainCar.Location = new System.Drawing.Point(307, 654);
            this.mainCar.Name = "mainCar";
            this.mainCar.Size = new System.Drawing.Size(65, 120);
            this.mainCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainCar.TabIndex = 1;
            this.mainCar.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roadTrack2.Image = global::CarRacingDemo.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, -790);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(688, 790);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 7;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roadTrack1.Image = global::CarRacingDemo.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(-2, 10);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(688, 790);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // overGame
            // 
            this.overGame.BackColor = System.Drawing.Color.Transparent;
            this.overGame.BackgroundImage = global::CarRacingDemo.Properties.Resources.blurBackground;
            this.overGame.Controls.Add(this.levelValue);
            this.overGame.Controls.Add(this.label4);
            this.overGame.Controls.Add(this.txtExp);
            this.overGame.Controls.Add(this.lblCurrExp);
            this.overGame.Controls.Add(this.lblExpNeed);
            this.overGame.Location = new System.Drawing.Point(123, 311);
            this.overGame.Name = "overGame";
            this.overGame.Size = new System.Drawing.Size(420, 255);
            this.overGame.TabIndex = 11;
            // 
            // levelValue
            // 
            this.levelValue.BackColor = System.Drawing.Color.Transparent;
            this.levelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelValue.ForeColor = System.Drawing.Color.White;
            this.levelValue.Location = new System.Drawing.Point(25, 44);
            this.levelValue.Name = "levelValue";
            this.levelValue.Size = new System.Drawing.Size(396, 41);
            this.levelValue.TabIndex = 15;
            this.levelValue.Text = "1";
            this.levelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExp
            // 
            this.txtExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.ForeColor = System.Drawing.Color.White;
            this.txtExp.Location = new System.Drawing.Point(19, 137);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(387, 32);
            this.txtExp.TabIndex = 10;
            this.txtExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrExp
            // 
            this.lblCurrExp.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblCurrExp.ForeColor = System.Drawing.Color.White;
            this.lblCurrExp.Location = new System.Drawing.Point(16, 104);
            this.lblCurrExp.Name = "lblCurrExp";
            this.lblCurrExp.Size = new System.Drawing.Size(1, 20);
            this.lblCurrExp.TabIndex = 9;
            // 
            // lblExpNeed
            // 
            this.lblExpNeed.BackColor = System.Drawing.Color.White;
            this.lblExpNeed.ForeColor = System.Drawing.Color.White;
            this.lblExpNeed.Location = new System.Drawing.Point(16, 104);
            this.lblExpNeed.Name = "lblExpNeed";
            this.lblExpNeed.Size = new System.Drawing.Size(390, 20);
            this.lblExpNeed.TabIndex = 8;
            this.lblExpNeed.Text = "label4";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CarRacingDemo.Properties.Resources.roadTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 903);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "InGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.is_pressStartDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.is_keyup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.conPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.overGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox mainCar;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblExpNeed;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.Label lblCurrExp;
        private System.Windows.Forms.Label txtExp;
        private System.Windows.Forms.Panel overGame;
        private System.Windows.Forms.Label notiLevel;
        private System.Windows.Forms.Panel conPan;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.Label notiOverGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCoin;
        private System.Windows.Forms.Label levelValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label startPress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label notibestScore;
        private System.Windows.Forms.PictureBox picSkill;
        private System.Windows.Forms.Label currentTime1;
        private System.Windows.Forms.Label maxTime1;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label maxTime;
        private System.Windows.Forms.PictureBox picBonus;
        private System.Windows.Forms.Label lblBonusCoin;
        private System.Windows.Forms.PictureBox picMissile;
        private System.Windows.Forms.Label missileLbl;
    }
}