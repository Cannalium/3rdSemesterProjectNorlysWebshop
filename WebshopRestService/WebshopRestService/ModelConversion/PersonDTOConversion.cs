using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class PersonDTOConversion
    {
        // Convert from Person objects to PersonDTO objects
        public static List<PersonDTORead>? FromPersonCollection(List<Person> persons)
        {
            List<PersonDTORead>? personDTOReadList = null;
            if (persons != null)
            {
                personDTOReadList = new List<PersonDTORead>();
                PersonDTORead? tempDTO;
                foreach (Person aPerson in persons)
                {
                    if (aPerson != null)
                    {
                        tempDTO = FromPerson(aPerson);
                        personDTOReadList.Add(tempDTO);
                    }
                }
            }
            return personDTOReadList;
        }

        // Convert from Person object to PersonDTO object
        public static PersonDTORead? FromPerson(Person Person)
        {
            PersonDTORead? aPersonDTORead = null;
            if (Person != null)
            {
                aPersonDTORead = new PersonDTORead(Person.PersonId,Person.FirstName, Person.LastName, Person.PhoneNo, Person.Email, Person.IsAdmin); //usikker på om userId skal være her, fordi det er, når man laver DTO'en, og userId er ikke en del af personDataCreatDTO
            }
            return aPersonDTORead;
        }

        // Convert from PersonDTO object to Person object
        public static Person? ToPerson(PersonDTORead DTO)
        {
            Person? aPerson = null;
            if (DTO != null)
            {
                aPerson = new Person(DTO.PersonId, DTO.FirstName, DTO.LastName, DTO.PhoneNo, DTO.Email, DTO.IsAdmin);
            }
            return aPerson;
        }
    }
}

