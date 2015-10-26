using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAdminRepository
    {
        Admin GetByUsername(string p_username);
    }
}
