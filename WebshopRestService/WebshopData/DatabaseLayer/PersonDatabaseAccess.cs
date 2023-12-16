using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public class PersonDatabaseAccess : IPersonAccess
    {
        readonly string? _connectionString;
        public PersonDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("WebshopConnection");
        }

        // Constructor for testing purposes
        public PersonDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

       
        // Retrieves a person from the database based on the provided email and returns the corresponding Person object
        public Person GetPersonByEmail(string email)
        {
            Person foundPerson;

            string queryString = "select personId, firstName, lastName, phoneNo, email, isAdmin from Person where email = @Email";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter personIdParam = new SqlParameter("@Email", email);
                readCommand.Parameters.Add(personIdParam);

                con.Open();

                // Execute read
                SqlDataReader personReader = readCommand.ExecuteReader();
                foundPerson = new Person();
                while (personReader.Read())
                {
                    foundPerson = GetPersonFromReader(personReader);
                }
            }
            return foundPerson;
        }

        // Constructs a Person object from the data retrieved by the SqlDataReader
        private Person GetPersonFromReader(SqlDataReader personReader)
        {
            Person foundPerson;
            int tempPersonId;
            string tempFirstName, tempLastName;
            string tempPhoneNo;
            string tempEmail;
            bool tempIsAdmin;

            // Fetch values
            tempPersonId = personReader.GetInt32(personReader.GetOrdinal("personId"));
            tempFirstName = personReader.GetString(personReader.GetOrdinal("firstName"));
            tempLastName = personReader.GetString(personReader.GetOrdinal("lastName"));
            tempPhoneNo = personReader.GetString(personReader.GetOrdinal("phoneNo"));
            tempEmail = personReader.GetString(personReader.GetOrdinal("email"));
            tempIsAdmin = personReader.GetBoolean(personReader.GetOrdinal("isAdmin"));

            // Create object
            foundPerson = new Person(tempPersonId, tempFirstName, tempLastName, tempPhoneNo, tempEmail, tempIsAdmin);
            return foundPerson;
        }
    }
}
