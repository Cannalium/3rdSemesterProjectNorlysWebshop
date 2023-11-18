using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopData.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public class PersonDatabaseAccess : IPersonAccess
    {
        readonly string? _connectionString;    
        public PersonDatabaseAccess(IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString("CompanyConnection"); 
        }
        // For test
        public PersonDatabaseAccess(string inConnectionString) { _connectionString = inConnectionString; }

        public int CreatePerson(Person aPerson)
        {
            int insertedId = -1;
            //
            string insertString = "insert into Person(firstName, lastName, email) OUTPUT INSERTED.ID values(@FirstName, @LastName, @Email)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {
                // Prepace SQL
                SqlParameter fNameParam = new("@FirstName", aPerson.FirstName);
                CreateCommand.Parameters.Add(fNameParam);
                SqlParameter lNameParam = new("@LastName", aPerson.LastName);
                CreateCommand.Parameters.Add(lNameParam);
                SqlParameter emailParam = new("@Email", aPerson.Email);
                CreateCommand.Parameters.Add(emailParam);
                //
                con.Open();
                // Execute save and read generated key (ID)
                insertedId = (int)CreateCommand.ExecuteScalar();
            }
            return insertedId;
        }


        public bool DeletePerson()
        {
            throw new NotImplementedException();
        }

        /* Three possible returns: * A List<Person> with content * A List<Person> with no content (no rows found in table) * Null - Some error occurred */
        public List<Person> GetPersonAll()
        {
            List<Person> foundPersons; 
            Person readPerson; 
            //
            string queryString = "select id, firstName, lastName, phoneNo, email, personType from Person"; 
            using (SqlConnection con = new SqlConnection(_connectionString)) 
            using (SqlCommand readCommand = new SqlCommand(queryString, con)) 
            { con.Open(); 
                // Execute read
                SqlDataReader personReader = readCommand.ExecuteReader(); 
                // Collect data
                foundPersons = new List<Person>(); 
                while (personReader.Read()) {
                    readPerson = GetPersonFromReader(personReader); 
                    foundPersons.Add(readPerson);
                }
            } 
            return foundPersons; 
        }

        /* Three possible returns:
         * A Person object
         * An empty Person object (no match on id)
         * Null - Some error occurred
        */
        public Person GetPersonById(int findId)
        {
            Person foundPerson;
            //
            string queryString = "select id, firstName, lastName, mobilePhone from Person where id = @Id";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Prepace SQL
                SqlParameter idParam = new SqlParameter("@Id", findId);
                readCommand.Parameters.Add(idParam);
                //
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
            throw new NotImplementedException();
        }

        private Person GetPersonFromReader(SqlDataReader personReader)
        {
            Person foundPerson;
            int tempId;
            bool isNotNull;     // Test for null value in mobilePhone
            string? tempMobilePhone;
            string tempFirstName, tempLastName;
            // Fetch values
            tempId = personReader.GetInt32(personReader.GetOrdinal("id"));
            tempFirstName = personReader.GetString(personReader.GetOrdinal("firstName"));
            tempLastName = personReader.GetString(personReader.GetOrdinal("lastName"));
            isNotNull = !personReader.IsDBNull(personReader.GetOrdinal("mobilePhone"));
            tempMobilePhone = isNotNull ? personReader.GetString(personReader.GetOrdinal("mobilePhone")) : null;
            // Create object
            foundPerson = new Person(tempId, tempFirstName, tempLastName, tempMobilePhone);
            return foundPerson;
        }

    }
}
