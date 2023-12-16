using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer 
{
    public interface IPersonData 
    {
        PersonDTORead? GetPersonByEmail(string email);
    }
}
