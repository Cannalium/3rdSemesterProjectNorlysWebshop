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
        public static PersonDTO? FromPerson(Person Person)
        {
            PersonDTO? aPersonReadDTO = null;
            if (Person != null)
            {
                aPersonReadDTO = new PersonDTO(Person.FirstName, Person.LastName, Person.PhoneNo, Person.Email); //usikker på om userId skal være her, fordi det er, når man laver DTO'en, og userId er ikke en del af personDataCreatDTO
            }
            return aPersonReadDTO;
        }

        // Convert from PersonDTO object to Person object
        public static Person? ToPerson(PersonDTO DTO)
        {
            Person? aPerson = null;
            if (DTO != null)
            {
                aPerson = new Person(DTO.FirstName,DTO.LastName, DTO.PhoneNo, DTO.Email);
            }
            return aPerson;
        }
    }
}

