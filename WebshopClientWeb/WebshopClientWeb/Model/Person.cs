namespace WebshopClientWeb.Model
{
    public class Person
    {

        public Person() { }

        public Person(string? email, string? userId)
        {
            
            Email = email;
            UserId = userId;
        }

        public Person(string? firstName, string? lastName, string? phoneNo, string? email, bool isAdmin, string? userId) : this(email, userId)
        {
          
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
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
