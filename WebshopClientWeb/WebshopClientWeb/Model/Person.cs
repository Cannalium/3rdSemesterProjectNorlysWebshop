using System.ComponentModel;

namespace WebshopClientWeb.Model
{
    public class Person
    {
        public Person() { }

        public Person(int personId, string? firstName, string? lastName, string? phoneNo, string? email)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
        }

        public int PersonId { get; set; }

        [DisplayName("Fornavn:")]
        public string? FirstName { get; set; }

        [DisplayName("Efternavn:")]
        public string? LastName { get; set; }

        [DisplayName("Mobilnummer:")]
        public string? PhoneNo { get; set; }

        [DisplayName("Email:")]
        public string? Email { get; set; }
        public string? UserId { get; set; }
    }
}
