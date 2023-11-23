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

        public Person(string? firstName, string? lastName, string? phoneNo, string? email, string? userId) 
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
            UserId = userId;
        }

        public Person(int personId, string? firstName, string? lastName, string? phoneNo, string? email, bool isAdmin, string? userId) : this (firstName, lastName, phoneNo, email, userId)
        {
            PersonId = personId;
            IsAdmin = isAdmin;
        }

        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
        public bool IsAdmin { get; }
        public string? UserId { get; set; }
    }
}
