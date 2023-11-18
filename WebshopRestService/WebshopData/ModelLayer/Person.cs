using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopData.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(int personId, string? fName, string? lName, string? phoneNo, string? email, string tempPersonType) 
        {
            PersonId = personId;
            FirstName = fName;
            LastName = lName;
            PhoneNo = phoneNo;
            Email = email;
        }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNo { get; private set; }
        public string Email { get; set; }
        public SqlDbType PersonType { get; internal set; }
    }
}
