using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacingDemo
{
    class Rank
    {
        public static DataTable dataReceive()
        {
            string command = "SELECT TOP 8 UserName,BestScore FROM CARUSER ORDER BY BestScore DESC";
            CommandSQL commandSQL = new CommandSQL();

            return commandSQL.readData(command);
        }
    }
}
