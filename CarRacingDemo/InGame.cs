using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRacingDemo

{
    public partial class InGame : Form
    {
        int playerSpeed, roadSpeed, score, lastExp, tempLv, tempExp, count = 0, currentSpeed,countBonus;
        bool goLeft, goRight, goUp, goDown, shot = false, pause;
        bool bonus, enableSkill, countDown;
        int curTime, maxTimeSkill, countDownTime,temp;
        int missileCount,lifeLevel;
        Size currentSize = new Size();

        //---------------------------LOAD FORM------------------------
        public InGame()
        {
            InitializeComponent();
            init(); 
        }

        //------------------------------SETTING----------------------
        private void init()
        {
            score = 0;
            roadSpeed = 0;
            currentSpeed = 15;
            playerSpeed = 12;
            ProccessGame.changeCarPosition(car1, 0);
            ProccessGame.changeCarPosition(car2, 0);
            ProccessGame.changeCarPosition(car3, 0);
            ProccessGame.changeCarImage(ref car1);
            ProccessGame.changeCarImage(ref car2);
            ProccessGame.changeCarImage(ref car3);
            overGame.Visible = false;
            notiLevel.Visible = false;
            conPan.Visible = false;
            conPan.Enabled = false;
            txtCoin.Text = Character.currentCoin.ToString();
            pause = true;
            mainCar.Image = Character.setImageCurrentCarInGame();
            currentSize = mainCar.Size;

            switch (Character.currentCar)
            {
                case 2:
                    maxTimeSkill = 300;
                    break;
                case 3:
                    mainCar.Size = new Size(40, 80);
                    maxTimeSkill = 200;
                    break;
                case 4:
                    maxTimeSkill = 450;
                    break;
                case 5:
                    countBonus = 0;
                    maxTimeSkill = 200;
                    break;
                case 6:
                    maxTimeSkill = 100;
                    missileLbl.Visible = true;
                    picMissile.Visible = true;
                    missileCount = 0;
                    break;
                case 7:
                    maxTimeSkill = 300;
                    break;
                case 8:
                    maxTimeSkill = 0;
                    lifeLevel = 3;
                    missileLbl.Visible = true;
                    missileLbl.Text = lifeLevel.ToString();
                    picMissile.Visible = true;
                    picMissile.Image = Properties.Resources.LifeIcon;
                    break;
                case 9:
                    maxTimeSkill = 300;
                    break;
                default:
                    maxTimeSkill = 0;
                    break;
            }
            enableSkill = false;
            curTime = 0;
            countDown = false;
            temp = 0;
            count = 0;
            ProccessGame.changeIconSkill(picSkill);
            timer3.Start();
        }

        private void is_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (enableSkill)
                {
                    switch (Character.currentCar)
                    {
                        case 2:
                            Skill.Destroyer(car1, car2, car3, ref panel1);
                            enableSkill = false;
                            curTime = 0;
                            SoundPlayer sound = new SoundPlayer(Properties.Resources.Explosion_3);
                            sound.Play();
                            break;
                        case 3:
                            mainCar.Size = new Size(30, 70);
                            playerSpeed += 5;
                            countDown = true;
                            enableSkill = false;
                            countDownTime = 200;
                            temp = 200;
                            break;
                        case 4:
                            mainCar.Size = new Size(180, 180);
                            mainCar.Image = Properties.Resources.carflame;
                            enableSkill = false;
                            countDown = true;
                            countDownTime = 200;
                            temp = 200;
                            break;
                        case 5:
                            break;
                        case 6:
                            if(missileCount == 3)
                            {
                                curTime = 0;
                            }
                            Missile.createItem(mainCar, ref panel1);
                            missileCount--;
                            missileLbl.Text = missileCount.ToString();
                            break;
                        case 7:
                            currentSpeed = roadSpeed;
                            roadSpeed = 5;
                            countDown = true;
                            enableSkill = false;
                            countDownTime = 200;
                            temp = 200;
                            break;
                        case 9:
                            currentSpeed = roadSpeed;
                            roadSpeed = 0;
                            Skill.Freeze(car1);
                            Skill.Freeze(car2);
                            Skill.Freeze(car3);
                            countDownTime = 250;
                            temp = 250;
                            countDown = true;
                            enableSkill = false;
                            break;
                    }
                }
            }

            if (e.KeyCode == Keys.P)
            {
                pause = true;
                this.KeyDown += is_pressStartDown;
                this.KeyDown -= is_keydown;
            }
        }

        private void is_keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (shot == true)
            {
                shot = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        //-------------------------IN GAME---------------------------
        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.BringToFront();

            //----------------------------------------------COIN-----------------------------------
            if (score % 75 == 0 && score != 0)
            {
                if (countDown && Character.currentCar == 9)
                {
                    score++;
                }
                else
                {
                    Coin coinItem = new Coin(new PictureBox());
                    coinItem.createItem(ref panel1);
                }
            }
            Coin.moveItem(ref panel1, roadSpeed, txtCoin);

            //----------------------------------------------SKILL-----------------------------------
            countSkill();
            countDownSkill();

            switch (Character.currentCar)
            {
                //============================MOTO============================
                case 3:
                    if (!countDown && !enableSkill)
                    {
                        mainCar.Size = new Size(40, 80);
                        playerSpeed = 12;
                    }
                    break;
                
                    //===========================FLAME MASTER===================
                case 4:
                    if (!countDown)
                    {
                        mainCar.Size = currentSize;
                        mainCar.Image = Properties.Resources.tdrc01_car09_f;
                    }
                    break;
               
                    //=============================LAMBORGINI=========================
                case 5:
                    bonusRun();
                    break;
                
                    //==============================ROCKET============================
                case 6:
                    if (missileCount > 0)
                    {
                        enableSkill = true;
                    }
                    else
                    {
                        enableSkill = false;
                    }
                    Missile.missileFire(ref panel1);
                    break;

                    //========================F1===========================
                case 7:
                    if (!countDown)
                    {
                        roadSpeed = currentSpeed;
                    }
                    break;

                    //=====================FREEZE===========================
                case 9:
                    if (!countDown)
                    {
                        foreach (Control cl in panel1.Controls)
                        {
                            if (cl.Name == "car1" || cl.Name == "car2" || cl.Name == "car3")
                            {
                                foreach (Control pic in cl.Controls)
                                {
                                    if (pic.Tag == "freeze")
                                    {
                                        cl.Controls.Remove(pic);
                                        pic.Dispose();
                                    }
                                }
                            }
                        }

                        roadSpeed = currentSpeed;
                        car1.BringToFront();
                        car2.BringToFront();
                        car3.BringToFront();
                        panel2.BringToFront();
                    }
                    break;
            }

            //-----------------------------------SCORE-------------------------
            if (startPress.Visible == false)
            {
                score++;
                txtScore.Text = score.ToString();
            }

            //------------------------------------PAUSE-------------------------
            if (pause)
            {
                roadSpeed = 0;
                startPress.Visible = true;
                startPress.Enabled = true;
            }

            //----------------------------------PLAYER CONTROL-------------------
            if (goLeft == true && mainCar.Left > 10)
            {
                mainCar.Left -= playerSpeed;
            }

            if (goRight == true && mainCar.Left < panel1.Width - mainCar.Width)
            {
                mainCar.Left += playerSpeed;
            }

            if (goUp == true && mainCar.Top > 0)
            {
                mainCar.Top -= playerSpeed;
            }

            if (goDown == true && mainCar.Top < panel1.Height - mainCar.Height - panel2.Height - 20)
            {
                mainCar.Top += playerSpeed;
            }

            //--------------------------------------ROAD------------------------------
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > roadTrack2.Size.Height - 107)
            {
                roadTrack2.Top = -790;
            }
            if (roadTrack1.Top > roadTrack1.Size.Height - 107)
            {
                roadTrack1.Top = -790;
            }

            //------------------------------------CAR TRAFFIC-------------------------
            car1.Top += roadSpeed;
            car2.Top += roadSpeed;
            car3.Top += roadSpeed;

            if (car1.Top > roadTrack2.Size.Height + 50)
            {
                ProccessGame.changeCarImage(ref car1);
                ProccessGame.changeCarPosition( car1, 0);
            }
            if (car2.Top > roadTrack2.Size.Height + 50)
            {
                ProccessGame.changeCarImage(ref car2);
                ProccessGame.changeCarPosition(car2, 0);
            }
            if (car3.Top > roadTrack2.Size.Height + 50)
            {
                ProccessGame.changeCarImage(ref car3);
                ProccessGame.changeCarPosition(car3, 0);
            }

            //----------------------------------------------RESURRECTION-------------------------------------
            if (mainCar.Bounds.IntersectsWith(car1.Bounds) || mainCar.Bounds.IntersectsWith(car2.Bounds) || mainCar.Bounds.IntersectsWith(car3.Bounds))
            {
                if (countDown && Character.currentCar == 4)
                {
                    Skill.flameMaster(ref panel1);
                }
                else if(lifeLevel > 0 && Character.currentCar == 8)
                {
                    lifeLevel--;
                    missileLbl.Text = lifeLevel.ToString();
                    ProccessGame.destroyCar(mainCar, ref panel1);
                    ProccessGame.changeCarPosition(car1, 350);
                    ProccessGame.changeCarPosition(car2, 350);
                    ProccessGame.changeCarPosition(car3, 350);
                    resurrection();
                }
                else
                {
                    gameOver();
                }
            }

            //--------------------------------------INCREASE GAME SPEED----------------------
            if (score % 500 == 0 && score != 0 && countDown == false)
            {
                roadSpeed += 2;
                currentSpeed = roadSpeed;
            }

            //------------------------------PROCESS-----------------------------------------
            ProccessGame.removeExplosion(ref count, ref panel1);
        }
        private void is_pressStartDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                }
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                }
                roadSpeed = currentSpeed;
                startPress.Visible = false;
                startPress.Enabled = false;
                SoundPlayer start = new SoundPlayer(Properties.Resources.carstartgarage);
                start.Play();
                pause = false;
                this.KeyDown -= is_pressStartDown;
                this.KeyDown += is_keydown;
            }
        }

        private void countSkill()
        {
            if (!enableSkill && score != 0 && !countDown && Character.currentCar != 6 && Character.currentCar != 5 && Character.currentCar != 8 && Character.currentCar != 1)
            {
                curTime++;
                if (curTime >= maxTimeSkill)
                {
                    curTime = maxTimeSkill;
                    enableSkill = true;
                }
                double rate = curTime * 1.0 / maxTimeSkill * 1.0;
                currentTime.Width = Convert.ToInt32(maxTime.Width * rate);
            }

            if(Character.currentCar == 6 && score != 0)
            {
               
                curTime++;
                if (curTime >= maxTimeSkill && missileCount < 3)
                {
                    missileCount++;
                    curTime = 0;
                    missileLbl.Text = missileCount.ToString();
                } else if(missileCount >= 3)
                {
                    curTime = maxTimeSkill;
                }
                double rate = curTime * 1.0 / maxTimeSkill * 1.0;
                currentTime.Width = Convert.ToInt32(maxTime.Width * rate);
            }

            if(Character.currentCar == 5 && score != 0)
            {
                curTime++;
                if(curTime >= maxTimeSkill)
                {
                    curTime = 0;
                    Character.currentCoin += (10 + countBonus);
                    txtCoin.Text = Character.currentCoin.ToString();
                    countBonus++;
                    bonus = true;
                }
                double rate = curTime * 1.0 / maxTimeSkill * 1.0;
                currentTime.Width = Convert.ToInt32(maxTime.Width * rate);
            }
        }

        private void countDownSkill()
        {
            if (!enableSkill && countDown && score != 0)
            {
                countDownTime--;
                curTime = 0;
                if (countDownTime <= 0)
                {
                    countDown = false;
                    enableSkill = false;
                }
                double rate = countDownTime * 1.0 / temp * 1.0;
                currentTime1.Width = Convert.ToInt32(maxTime1.Width * rate);
            }
        }

        private void bonusRun()
        {
            if (bonus)
            {
                lblBonusCoin.Visible = true;
                lblBonusCoin.BringToFront();
                picBonus.Visible = true;
                picBonus.BringToFront();
                lblBonusCoin.Text = "+" + (10 + countBonus - 1);
                lblBonusCoin.Top -= 2;
                picBonus.Top -= 2;

                if(lblBonusCoin.Top <= picBonus.Height - 15)
                {
                    lblBonusCoin.Visible = false;
                    picBonus.Visible = false;
                    lblBonusCoin.Top = 58;
                    picBonus.Top = 58;
                    bonus = false;
                }
            }
        }

        //-----------------------RESURRECTION---------------------------
        public void resurrection()
        {
            timer3.Stop();

            Panel resu = new Panel();
            resu.Tag = "temp";
            resu.Size = new Size(420, 110);
            resu.BackgroundImage = Properties.Resources.blurBackground;
            panel1.Controls.Add(resu);
            resu.Location = new Point(panel1.Width / 2 - resu.Width / 2, panel1.Height / 2 - resu.Height / 2 - panel2.Height);
            resu.BringToFront();

            PictureBox picture = new PictureBox();
            picture.Size = new Size(100, 50);
            picture.Tag = "revieve";
            picture.Image = Properties.Resources.BTN_REVIEVE;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.BackColor = Color.Transparent;
            resu.Controls.Add(picture);
            picture.Location = new Point(resu.Width / 2 - picture.Width / 2, resu.Height / 2 - picture.Height / 2);
            picture.BringToFront();
            picture.MouseMove += btnRevieve_hover;
            picture.MouseLeave += btnRevieve_leave;
            picture.Click += resu_Click;
        }

        //---------------------------GAME OVER--------------------------
        private int calcLastExp()
        {
            int countLv = 0;
            while (lastExp > Character.expLevelUp)
            {
                lastExp -= Character.expLevelUp;
                Character.expLevelUp += 500;
                countLv++;
            }
            return countLv;
        }
        private void gameOver()
        {
            conPan.Controls.Remove(notibestScore);
            if (score > Character.bestScore)
            {
                Character.bestScore = score;
                conPan.Controls.Add(notibestScore);
                notibestScore.Visible = true;
            }
            lastExp = Character.currentExp + score;
            tempExp = Character.expLevelUp;
            tempLv = Character.level;
            timer3.Stop();
            ProccessGame.destroyCar(mainCar, ref panel1);
            conPan.Visible = true;
            conPan.Enabled = true;
            conPan.BringToFront();
            Character.level += calcLastExp();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Character.currentExp += 15;
            score -= 15;
            double rate = (double)Character.currentExp / tempExp;
            lblCurrExp.Width = Convert.ToInt32(lblExpNeed.Width * rate);
            txtExp.Text = String.Format("{0}/{1}", Character.currentExp, tempExp);
            levelValue.Text = tempLv.ToString();

            if (Character.currentExp >= tempExp)
            {
                notiLevel.Visible = true;
                lblCurrExp.Width = 1;
                tempExp += 500;
                Character.currentExp = 0;
                tempLv++;
                Character.currentCoin += 500;
            }

            if (score <= 0)
            {
                PictureBox exitBtn = new PictureBox();
                exitBtn.Size = new System.Drawing.Size(125, 50);
                exitBtn.Image = Properties.Resources.ExitToMainMenu;
                exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                overGame.Controls.Add(exitBtn);
                exitBtn.Location = new Point(95, 150);
                exitBtn.MouseMove += btnExitMenu_hover;
                exitBtn.MouseLeave += btnExitMenu_leave;
                exitBtn.Click += pictureBox2_Click;
                txtExp.Text = String.Format("{0}/{1}", lastExp, tempExp);
                Character.currentExp = lastExp;
                timer2.Stop();
            }

        }

        //--------------------------PROCESS CONTROL---------------------
        private void btnExitMenu_hover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.Image = Properties.Resources.ExitToMainMenu_hover;
        }
        private void btnExitMenu_leave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.Image = Properties.Resources.ExitToMainMenu;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conPan.Visible = false;
            closeForm.Enabled = false;
            overGame.Visible = true;
            overGame.BringToFront();
            double rate = (double)Character.currentExp / Character.expLevelUp;
            lblCurrExp.Width = Convert.ToInt32(lblExpNeed.Width * rate);
            txtExp.Text = String.Format("{0}/{1}", Character.currentExp, Character.expLevelUp);
            timer2.Start();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Character.updateData();
            this.Close();
        }
        private void closeForm_MouseHover(object sender, EventArgs e)
        {
            closeForm.Image = Properties.Resources.BTN_CONTINUE_hover;
        }
        private void closeForm_MouseLeave(object sender, EventArgs e)
        {
            closeForm.Image = Properties.Resources.BTN_CONTINUE;
        }
        public void resu_Click(object sender, EventArgs e)
        {
            foreach (Control ct in panel1.Controls)
            {
                if ((ct is PictureBox && ct.Tag == "explosion") || (ct is Panel && ct.Tag == "temp"))
                {
                    panel1.Controls.Remove(ct);
                    ct.Dispose();
                }
            }
            mainCar.Visible = true;
            roadSpeed = 0;
            startPress.Visible = true;
            this.KeyDown += is_pressStartDown;
            this.KeyDown -= is_keydown;
            timer3.Start();
        }
        public void btnRevieve_hover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (btn.Tag == "revieve")
            {
                btn.Image = Properties.Resources.BTN_REVIEVE_hover;
            }
        }
        public void btnRevieve_leave(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (btn.Tag == "revieve")
            {
                btn.Image = Properties.Resources.BTN_REVIEVE;
            }
        }
    }
}
