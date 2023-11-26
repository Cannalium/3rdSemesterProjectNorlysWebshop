using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer 
{
    public interface IPersonData {
        PersonDTO? GetPersonById(int personId);
        PersonDTO? GetPersonByEmail(string userId);
        List<PersonDTO>? Get();
        int Add(PersonDTO personToAdd);
        bool Put(PersonDTO personToUpdate);
        bool Delete(int personId);
    }
}
