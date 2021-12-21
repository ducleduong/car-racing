using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CarRacingDemo
{
    class Character
    {
        public static string name;
        public static int level;
        public static int currentCoin;
        public static int currentExp;
        public static int expLevelUp;
        public static int lifeLevel;
        public static ArrayList cars = new ArrayList();
        public static int currentCar;
        public static int bestScore;

        public static void createCharacter(string name)
        {
            Character.name = name;
            level = 1;
            currentCoin = 0;
            currentExp = 0;
            expLevelUp = 500 * level;
            lifeLevel = 0;
            cars.Add(1);
            currentCar = 1;
            bestScore = 0;
        }

        public static void receiveData()
        {
            string command = String.Format("SELECT UserName,CharacterLevel,CurrentCoin,CurrentExp,ExpLevelUp,BestScore,CurrentCar FROM CARUSER WHERE id_user = '{0}'", PublicClass.ID_USER);
            CommandSQL commandSQL = new CommandSQL();
            DataTable table = commandSQL.readData(command);

            if (table != null)
            {
                foreach (DataRow dr in table.Rows)
                {
                    currentExp = Convert.ToInt32(dr["CurrentExp"]);
                    name = dr["UserName"].ToString();
                    level = Convert.ToInt32(dr["CharacterLevel"]);
                    currentCoin = Convert.ToInt32(dr["CurrentCoin"]);
                    expLevelUp = level * 500;
                    bestScore = Convert.ToInt32(dr["BestScore"]);
                    currentCar = Convert.ToInt32(dr["CurrentCar"]);
                }
            }
            else
            {
                name = "Undefined";
                level = 1;
                currentCoin = 0;
                currentExp = 0;
                expLevelUp = 500 * level;
            }
        }

        public static void updateData()
        {
            string command = String.Format("UPDATE CARUSER SET CharacterLevel = {0}, CurrentCoin = {1}, CurrentExp = {2}, ExpLevelUp = {3}, BestScore = {4}, CurrentCar = '{5}' WHERE id_user = '{6}';", level, currentCoin, currentExp, expLevelUp, bestScore, currentCar, PublicClass.ID_USER);
            CommandSQL commandSQL = new CommandSQL();
            commandSQL.addData(command);
        }

        public static void receiveCarStorage()
        {
            string command = String.Format("SELECT id_car FROM USER_CAR WHERE id_user = '{0}' ", PublicClass.ID_USER);
            CommandSQL commandSQL = new CommandSQL();
            DataTable table = commandSQL.readData(command);

            if(table != null)
            {
                foreach(DataRow dr in table.Rows)
                {
                    cars.Add(Convert.ToInt32(dr["id_car"]));
                }
            }
        }

        public static Image setImageCurrentCarInGame()
        {
            Image image = Properties.Resources.carYellow; ;

            switch (currentCar)
            {
                case 2:
                    image = Properties.Resources.tdrc01_car08_d;
                    break;
                case 3:
                    image = Properties.Resources.clipart101458;
                    break;
                case 4:
                    image = Properties.Resources.tdrc01_car09_f;
                    break;
                case 5:
                    image = Properties.Resources.tdrc01_car03_a;
                    break;
                case 6:
                    image = Properties.Resources.tdrc01_car01_b;
                    break;
                case 7:
                    image = Properties.Resources.clipart3005101;
                    break;
                case 8:
                    image = Properties.Resources.ger_png;
                    break;
                case 9:
                    image = Properties.Resources.blueCarIg_jpg;
                    break;
                default:
                    break;
            }

            return image;
        }

        public static void addCar(int index)
        {
            Character.cars.Add(index);
            string command = String.Format("INSERT INTO USER_CAR (id_user,id_car) VALUES ('{0}','{1}')", PublicClass.ID_USER, index);
            CommandSQL commandSQL = new CommandSQL();
            if (commandSQL.addData(command))
            {
                MessageBox.Show("Buy success! Let's check your inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Cannot buy, let's try later!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void setLogoCar(Button lb, int index)
        {
            switch (index)
            {
                case 0:
                    lb.BackgroundImage = Properties.Resources.defaultde;
                    break;
                case 2:
                    lb.BackgroundImage = Properties.Resources.logoDestroyer1;
                    break;
                case 3:
                    lb.BackgroundImage = Properties.Resources.logoR151;
                    break;
                case 4:
                    lb.BackgroundImage = Properties.Resources.logoPhoenix1;
                    break;
                case 5:
                    lb.BackgroundImage = Properties.Resources.logoLam1;
                    break;
                case 6:
                    lb.BackgroundImage = Properties.Resources.logoRocket;
                    break;
                case 7:
                    lb.BackgroundImage = Properties.Resources.logoF1;
                    break;
                case 8:
                    lb.BackgroundImage = Properties.Resources.logoSentiel1;
                    break;
                case 9:
                    lb.BackgroundImage = Properties.Resources.logoFreeze;
                    break;
            }
        }

        public static void setImageCar(PictureBox pic, Form form)
        {
            foreach(Control control in form.Controls)
            {
                if(control is Button && !control.Enabled)
                {
                    switch (control.Name)
                    {
                        case "pic2":
                            pic.Image = Properties.Resources.lackcar;
                            break;
                        case "pic3":
                            pic.Image = Properties.Resources.moto;
                            break;
                        case "pic4":
                            pic.Image = Properties.Resources.orangeCar;
                            break;
                        case "pic5":
                            pic.Image = Properties.Resources.lam;
                            break;
                        case "pic6":
                            pic.Image = Properties.Resources.white;
                            break;
                        case "pic7":
                            pic.Image = Properties.Resources.f1;
                            break;
                        case "pic8":
                            pic.Image = Properties.Resources.greencar;
                            break;
                        case "pic9":
                            pic.Image = Properties.Resources.ice;
                            break;
                    }
                }
            }
        }

        public static void selectTab(Button btn, Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button && !control.Enabled)
                {
                    switch (control.Name)
                    {
                        case "pic2":
                            btn.BackgroundImage = Properties.Resources.logoDestroyerSelected;
                            break;
                        case "pic3":
                            btn.BackgroundImage = Properties.Resources.logoR15Selected;
                            break;
                        case "pic4":
                            btn.BackgroundImage = Properties.Resources.logoPhoenixSelected;
                            break;
                        case "pic5":
                            btn.BackgroundImage = Properties.Resources.logoLamSelected;
                            break;
                        case "pic6":
                            btn.BackgroundImage = Properties.Resources.logoRocketSelected;
                            break;
                        case "pic7":
                            btn.BackgroundImage = Properties.Resources.logoF1Selected;
                            break;
                        case "pic8":
                            btn.BackgroundImage = Properties.Resources.logoSentielSelected;
                            break;
                        case "pic9":
                            btn.BackgroundImage = Properties.Resources.logoFreezeSelected;
                            break;
                    }
                }
            }
        }
    }
}
