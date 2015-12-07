﻿using System;
using MySql.Data.MySqlClient;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <creator>Viktoria Pierenkemper</creator>
    public class BaseRepository
    {
        protected readonly MySqlConnection currentConnection;
        
        /// <summary>
        /// 
        /// </summary>
        protected BaseRepository()
        {
            var connStr = CreateConnStr("localhost", "FHDWHotelContext", "root", "root");
            currentConnection = new MySqlConnection(connStr);
        }

        private static string CreateConnStr(string p_serverAddress, string p_databaseName, string p_user, string p_password)
        {
            return String.Format(@"server={0};database={1};uid={2};password={3};", p_serverAddress, p_databaseName, p_user, p_password);
        }
    }
}