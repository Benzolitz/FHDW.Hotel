using System;
using MySql.Data.MySqlClient;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseRepository
    {
        private const string connectionString = @"server=localhost;userid=root;password=root;database=fhdw.hotel";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_query"></param>
        /// <returns></returns>
        public object ExecuteQuery(string p_query)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString ))
                {
                    using (MySqlCommand com = new MySqlCommand(p_query, con))
                    {
                        return com.ExecuteNonQuery();
                    }   
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
