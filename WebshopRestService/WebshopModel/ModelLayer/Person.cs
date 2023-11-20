using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(string? firstName, string? lastName, string? phoneNo, string? email, bool? isAdmin) { }

        public Person(int personId, string? firstName, string? lastName, string? phoneNo, string? email, bool? isAdmin) 
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
            IsAdmin = isAdmin;
        }

        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
        public bool? IsAdmin { get; }
    }
}
