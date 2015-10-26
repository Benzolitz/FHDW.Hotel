using System;
using System.Data;
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
        public object ExecuteQuery<T>(string p_query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(p_query, connection))
                    {
                        return command.ExecuteReader();
                    }   
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
