using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IPersonAccess
    {
        int CreatePerson(Person personToCreate);
        Person GetPersonByEmail(string email);
        Person GetPersonById(int personId);
        bool UpdatePerson(Person personToUpdate);
        bool DeletePerson(int personId);
    }
}
