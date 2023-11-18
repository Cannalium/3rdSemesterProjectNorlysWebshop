using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopData.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(int personId, string? firstName, string? lastName, string? email) 
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
