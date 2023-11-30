using System.ComponentModel;

namespace WebshopClientWeb.Model
{
    public class Person
    {

        public Person() { }

        public Person(string? email)
        {
            
            Email = email;
            
        }

        public Person(string? firstName, string? lastName, string? phoneNo, string? email, bool isAdmin) : this(email)
        {
          
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            IsAdmin = isAdmin;

        }

        public int PersonId { get; set; }

        [DisplayName("Fornavn :")]
        public string? FirstName { get; set; }

        [DisplayName("Efternavn :")]
        public string? LastName { get; set; }

        [DisplayName("Mobilnummer :")]
        public string? PhoneNo { get; set; }

        [DisplayName("Email :")]
        public string? Email { get; set; }
        public bool IsAdmin { get; }
        public string? UserId { get; set; }
    }
}
