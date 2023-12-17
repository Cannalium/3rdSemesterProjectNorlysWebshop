namespace WebshopModel.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(string? firstName, string? lastName, string? phoneNo, string? email) 
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
        }

        public Person(int personId, string? firstName, string? lastName, string? phoneNo, string? email) : this (firstName, lastName, phoneNo, email)
        {
            PersonId = personId;
        }

        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
    }
}
