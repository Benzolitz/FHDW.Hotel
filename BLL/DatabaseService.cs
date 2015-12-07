using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class DatabaseService
    {
        #region Dependencies
        public IDatabaseRepository DatabaseRepository;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public DatabaseService()
        {
            DatabaseRepository = new DatabaseRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateDatabaseWithTestData()
        {
            CreateDatabase();
            AddTestDataInDatabase();
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddTestDataInDatabase()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateDatabase()
        {

        }
    }
}
