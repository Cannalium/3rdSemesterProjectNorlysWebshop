﻿using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;

namespace WebshopRestService.BusinessLogicLayer
{
    public class PersonDataControl : IPersonData
    {
        private readonly IPersonAccess _personAccess;

        public PersonDataControl(IPersonAccess inPersonAccess)
        {
            _personAccess = inPersonAccess;

        }
        public int Add(PersonDTO personToAdd)
        {
            int insertedId = 0;
            try
            {
                Person? foundPerson = ModelConversion.PersonDtoConvert.ToPerson(newPerson);
                if (foundPerson != null)
                {
                    insertedId = _personAccess.CreatePerson(foundPerson);
                }
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PersonDTO? Get(int id)
        {
            PersonDTO? foundPersonDto;
            try
            {
                Person? foundPerson = _personAccess.GetPersonById(idToMatch);
                foundPersonDto = ModelConversion.PersonDtoConvert.FromPerson(foundPerson);
            }
            catch
            {
                foundPersonDto = null;
            }
            return foundPersonDto;

        }

        public List<PersonDTO>? Get()
        {
            List<PersonDTO>? foundDtos;
            try
            {
                List<Person>? foundPersons = _personAccess.GetPersonAll();
                foundDtos = ModelConversion.PersonDtoConvert.FromPersonCollection(foundPersons);
            }
            catch
            {
                foundDtos = null;
            }
            return foundDtos;

        }

        public bool Put(PersonDTO personToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
