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

        // For test
        public PersonDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

        public int CreatePerson(Person aPerson) 
        {
            int insertedId = -1;
            string insertString = "insert into Person(firstName, lastName, phoneNo, email, isAdmin) OUTPUT INSERTED.ID values(@FirstName, @LastName, @PhoneNo, @Email, @isAdmin)";
            
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con)) 
            {
                // Prepare SQL
                SqlParameter firstNameParam = new("@FirstName", aPerson.FirstName);
                CreateCommand.Parameters.Add(firstNameParam);
                SqlParameter lastNameParam = new("@LastName", aPerson.LastName);
                CreateCommand.Parameters.Add(lastNameParam);
                SqlParameter phoneNoParam = new("@PhoneNo", aPerson.PhoneNo);
                CreateCommand.Parameters.Add(phoneNoParam);
                SqlParameter emailParam = new("@Email", aPerson.Email);
                CreateCommand.Parameters.Add(emailParam);
                SqlParameter isAdminParam = new("@IsAdmin", aPerson.IsAdmin);
                CreateCommand.Parameters.Add(isAdminParam);

                con.Open();

                // Execute save and read generated key (ID)
                insertedId = (int)CreateCommand.ExecuteScalar();
            }
            return insertedId;
        }


        public bool DeletePerson(int personId) {
            bool personDeleted = false;
            string queryString = "DELETE FROM Person WHERE personId = @PersonId";

            using(SqlConnection connection = new SqlConnection(_connectionString))
            using(SqlCommand deleteCommand = new SqlCommand(queryString, connection))
            {
                //Prepare SQL
                SqlParameter personIdParam = new SqlParameter("@PersonId", personId);
                deleteCommand.Parameters.Add(personIdParam);

                connection.Open();

                //Execute delete
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                //Check if the delete operation was succesful
                personDeleted = rowsAffected > 0;
            }
            return personDeleted;
        }

        public List<Person> GetPersonAll()
        {
            List<Person> foundPersons;
            Person readPerson;
            
            string queryString = "select personId, firstName, lastName, phoneNo, email, isAdmin from Person";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();
                // Execute read
                SqlDataReader personReader = readCommand.ExecuteReader();
                // Collect data
                foundPersons = new List<Person>();
                while (personReader.Read())
                {
                    readPerson = GetPersonFromReader(personReader);
                    foundPersons.Add(readPerson);
                }
            }
            return foundPersons;
        }

        public Person GetPersonById(int findPersonId)
        {
            Person foundPerson;
            
            string queryString = "select personId, firstName, lastName, phoneNo, email, isAdmin from Person where personId = @PersonId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepare SQL
                SqlParameter personIdParam = new SqlParameter("@PersonId", findPersonId);
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


        public bool UpdatePerson(Person personUpdate)
        {
            bool personUpdated = false;
            string queryString = "UPDATE Person SET firstName = @FirstName, lastName = @LastName, " +
                                 "phoneNo = @PhoneNo, email = @Email, isAdmin = @IsAdmin " +
                                 "WHERE personId = @PersonId";
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            using (SqlCommand updateCommand  = new SqlCommand(queryString, connection)) 
            {
                //Prepare SQL
                SqlParameter personIdParam = new SqlParameter("@PersonId", personUpdate.PersonId);
                updateCommand.Parameters.Add(personIdParam);

                SqlParameter firstNameParam = new SqlParameter("@FirstName", personUpdate.FirstName);
                updateCommand.Parameters.Add(firstNameParam);

                SqlParameter lastNameParam = new SqlParameter("@LastName", personUpdate.LastName);
                updateCommand.Parameters.Add(lastNameParam);

                SqlParameter phoneNoParam = new SqlParameter("@PhoneNo", personUpdate.PhoneNo);
                updateCommand.Parameters.Add(phoneNoParam);

                SqlParameter emailParam = new SqlParameter("@Email", personUpdate.Email);
                updateCommand.Parameters.Add(emailParam);

                SqlParameter isAdminParam = new SqlParameter("@IsAdmin", personUpdate.IsAdmin);
                updateCommand.Parameters.Add(isAdminParam);

                connection.Open();

                //Execute update
                int rowsAffected = updateCommand.ExecuteNonQuery();

                //Check if the update operation was succesful
                personUpdated = rowsAffected > 0;
            }
            return personUpdated;
        }

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
            tempIsAdmin = personReader.GetBoolean(personReader.GetOrdinal("personType"));

            // Create object
            foundPerson = new Person(tempPersonId, tempFirstName, tempLastName, tempPhoneNo, tempEmail, tempIsAdmin);
            return foundPerson;
        }
    }
}
