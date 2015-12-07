﻿using System;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// 
        /// </summary>
        public enum RoomType
        {
            Single = 0,
            Double = 1,
            Family = 2
        }

        /// <summary>
        /// 
        /// </summary>
        public enum RoomCategory
        {
            Standard = 0,
            Comfort = 1,
            Superior = 2
        }
        
        /// <summary>
        /// 
        /// </summary>
        public enum SortOrder
        {
            ASC = 0,
            DESC = 1
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class EnumExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
