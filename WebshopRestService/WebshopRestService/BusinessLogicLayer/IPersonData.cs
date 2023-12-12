using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer 
{
    public interface IPersonData {
        PersonDTORead? GetPersonById(int personId);
        PersonDTORead? GetPersonByEmail(string userId);
        List<PersonDTORead>? Get();
        int Add(PersonDTOWrite personToAdd);
        bool Put(PersonDTOWrite personToUpdate);
        bool Delete(int personId);
    }
}
