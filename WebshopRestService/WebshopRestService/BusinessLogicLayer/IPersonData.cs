namespace WebshopRestService.BusinessLogicLayer {
    public interface IPersonData {
        PersonDTO? Get(int id);
        List<PersonDTO>? Get();
        int Add(PersonDTO personToAdd);
        bool Put(PersonDTO personToUpdate);
        bool Delete(int id);

    }
}
