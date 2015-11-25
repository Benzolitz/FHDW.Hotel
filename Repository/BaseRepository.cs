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
            return $"server={p_serverAddress};database={p_databaseName};uid={p_user};password={p_password};";
        }
    }
}
