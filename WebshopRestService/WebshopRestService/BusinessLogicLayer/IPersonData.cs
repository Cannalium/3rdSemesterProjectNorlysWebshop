using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer 
{
    public interface IPersonData {
        PersonDTORead? GetPersonById(int personId);
        PersonDTORead? GetPersonByEmail(string userId);
        List<PersonDTORead>? Get();
        int Add(PersonDTORead personToAdd);
        bool Put(PersonDTORead personToUpdate);
        bool Delete(int personId);
    }
}
