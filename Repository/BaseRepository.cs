using System;
using MySql.Data.MySqlClient;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseRepository
    {
        private BaseRepository()
        {
            var connStr = createConnStr("localhost", "fhdwhotel", "root", "admin");
            MySqlConnection connection = new MySqlConnection(connStr);

            connection.Open();
        }

        private string createConnStr(string p_serverAddress, string p_databaseName, string p_user, string p_password)
        {
            return String.Format(@"server={0};database={1};uid={2};password={3};", p_serverAddress, p_databaseName, p_user, p_password);
        }
    }
}
