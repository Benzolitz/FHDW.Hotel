using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGuestRepository
    {
        Guest GetByEmail(string p_email);

        Guest Insert(Guest p_guest);
        Guest Update(Guest p_guest);
    }
}