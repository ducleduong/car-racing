using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CarRacingDemo
{
    public class CommandSQL
    {
        SqlConnection connect = new SqlConnection(PublicClass.connectString);

        public bool login(string command)
        {
            bool check = false;
            string id = "";
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(command, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table != null)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        id = dr["id_user"].ToString();
                        PublicClass.ID_USER = id;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connect.Close();
            }

            if (id != "")
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;
        }

        public bool addData(string command)
        {
            connect.Open();
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand(command, connect);
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("duplicate") >= 0)
                {
                    System.Windows.Forms.MessageBox.Show("Username is already exist", "Error");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
                }
            }
            finally
            {
                connect.Close();
            }

            return check;
        }

        public DataTable readData(string command)
        {
            DataTable table = new DataTable();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(command, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connect.Close();
            }
            return table;
        }
    }
}
