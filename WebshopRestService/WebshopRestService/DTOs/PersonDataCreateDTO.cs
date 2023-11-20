namespace WebshopRestService.DTOs {
    public class PersonDataCreateDTO 
    {

        public PersonDataCreateDTO() 
        {
        }

        public PersonDataCreateDTO(string? firstName, string? lastName, string? phoneNo, string? email, string? personType) {
            
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
            PersonType = personType;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNo { get; private set; }
        public string? Email { get; private set; }
        public string? PersonType { get; private set; }
    }
}
