using System.Data.SqlClient;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// Every Request returning a Guest-Object will be handled in this Repository.
    /// </summary>
    public class GuestRepository : BaseRepository, IGuestRepository
    {
        /// <summary>
        /// Get a specific Guest by their Emailaddress.
        /// </summary>
        /// <param name="p_email">Emailaddress of the Guest.</param>
        /// <returns>The requested Guest. If no Guest exists, return NULL.</returns>
        public Guest GetByEmail(string p_email)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT * FROM guest WHERE Emailaddress = @Emailaddress"
            };

            cmd.Parameters.Add(new SqlParameter("@Emailadress", p_email));
            
            return new Guest();
                
        }

        /// <summary>
        /// Insert a new Guest into the database.
        /// </summary>
        /// <param name="p_guest">The new Guest.</param>
        /// <returns>The Newly created Guest. NULL, or Exception if an error occurs.</returns>
        public Guest Insert(Guest p_guest)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"INSERT INTO guest (ID, Firstname, Lastname, Emailaddress, Birthplace, Birthday, Password, Telephone )
                                VALUES (@ID, @Firstname, @Lastname, @Emailaddress, @Birthplace, @Birthday, @Password, @Telephone)"
            };

            cmd.Parameters.Add(new SqlParameter("@ID, @Firstname, @Lastname, @Emailaddress, @Birthplace, @Birthday, @Password, @Telephone", p_guest));

            return new Guest();
        }

        /// <summary>
        /// Update an existing Guest in the databse.
        /// </summary>
        /// <param name="p_guest">New Guest-Object.</param>
        /// <returns>The updated Guest-Object. NULL, or Exception if an error occurs.</returns>
        public Guest Update(Guest p_guest)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"UPDATE guest
	                            SET Firstname = @Firstname,
		                            Lastname =  @Lastname,
                                    Emailaddress = @Emailaddress, 
                                    Birthplace = @Birthplace, 
                                    Birthday =  @Birthday, 
                                    Password = @Password, 
                                    Telephone =  @Telephone
                                    
	                                WHERE ID = @ID"
            };

             return new Guest();
        }
    }
}