using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseRepository
    {
        static void Main(String[] args)
        {
            string connStr = CreateConnStr("localhost", "hotelappdb", "root", "admin");
            MySqlConnection connection = new MySqlConnection(connStr);

            connection.Open();
        }

        public static string CreateConnStr(string server, string databaseName, string user, string pass)
        {
            string connStr = "server=" + server + ";database=" + databaseName + ";uid=" + user + ";password=" + pass + ";";
            return connStr;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_query"></param>
        /// <returns></returns>
    }
}
