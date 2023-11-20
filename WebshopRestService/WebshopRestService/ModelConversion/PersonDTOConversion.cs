using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class PersonDTOConversion
    {
        // Convert from Person objects to PersonDTO objects
        public static List<PersonDTO>? FromPersonCollection(List<Person> inPersons)
        {
            List<PersonDTO>? aPersonReadDTOList = null;
            if (inPersons != null)
            {
                aPersonReadDTOList = new List<PersonDTO>();
                PersonDTO? tempDTO;
                foreach (Person aPerson in inPersons)
                {
                    if (aPerson != null)
                    {
                        tempDTO = FromPerson(aPerson);
                        aPersonReadDTOList.Add(tempDTO);
                    }
                }
            }
            return aPersonReadDTOList;
        }

        // Convert from Person object to PersonDTO object
        public static PersonDTO? FromPerson(Person inPerson)
        {
            PersonDTO? aPersonReadDTO = null;
            if (inPerson != null)
            {
                aPersonReadDTO = new PersonDTO(inPerson.FirstName, inPerson.LastName, inPerson.PhoneNo, inPerson.Email, inPerson.PersonType);
            }
            return aPersonReadDTO;
        }

        // Convert from PersonDTO object to Person object
        public static Person? ToPerson(PersonDTO inDTO)
        {
            Person? aPerson = null;
            if (inDTO != null)
            {
                aPerson = new Person(inDTO.FirstName, inDTO.LastName, inDTO.PhoneNo, inDTO.Email, inDTO.PersonType);
            }
            return aPerson;
        }
    }

}
}
