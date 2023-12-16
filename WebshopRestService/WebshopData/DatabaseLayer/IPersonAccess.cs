using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IPersonAccess
    {
        Person GetPersonByEmail(string email);
    }
}
