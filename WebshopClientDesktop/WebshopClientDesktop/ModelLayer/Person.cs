using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopClientDesktop.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(int personId, string? firstName, string? lastName, string? phoneNo, string? email, string? personType)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
            PersonType = personType;
        }
        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
        public string? PersonType { get; set; }
    }
}
