using Newtonsoft.Json;
using System.Net;
using System.Text;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class PersonServiceAccess : IPersonServiceAccess
    {
        readonly IServiceConnection _personService;
        readonly String _serviceBaseUrl = "https://localhost:7173/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public PersonServiceAccess()
        {
            _personService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<Person> GetPersonByEmail(string email)
        {
            Person? personFromService = null;

            _personService.UseUrl = _personService.BaseUrl;
            _personService.UseUrl += $"api/person/{email}";

            if (_personService != null)
            {
                try
                {
                    var serviceResponse = await _personService.CallServiceGet();

                    // Check if serviceResponse is not null (added null check)
                    if (serviceResponse != null)
                    {
                        CurrentHttpStatusCode = serviceResponse.StatusCode; // Used by PersonControl class

                        if (serviceResponse.IsSuccessStatusCode)
                        {
                            if (serviceResponse.StatusCode == HttpStatusCode.OK)
                            {
                                var content = await serviceResponse.Content.ReadAsStringAsync();
                                personFromService = JsonConvert.DeserializeObject<Person>(content);
                            }
                            else
                            {
                                // Handle other successful status codes if needed
                                // For now, set personFromService to a default Person object
                                personFromService = new Person();
                            }
                        }
                        else
                        {
                            // Handle unsuccessful response
                            if (serviceResponse.StatusCode == HttpStatusCode.NotFound)
                            {
                                // Handle 404 Not Found
                                personFromService = null; // or set to a default Person object
                            }
                            else if (serviceResponse.StatusCode == HttpStatusCode.BadRequest)
                            {
                                // Handle 400 Bad Request
                                personFromService = null; // or set to a default Person object
                            }
                            // Add more conditions for other status codes as needed
                            else
                            {
                                // Handle other status codes
                                personFromService = null; // or set to a default Person object
                            }
                        }
                    }
                    else
                    {
                        // Handle the case where serviceResponse is null
                        // Set personFromService to a default Person object or handle accordingly
                        personFromService = new Person();
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception details (Step 3)
                    // You can use a logging library like Serilog, NLog, etc.
                    // Example: logger.LogError(ex, "An error occurred while getting a person by email");

                    // Optionally, rethrow the exception if needed
                    throw;
                }
            }

            return personFromService!;
        }


        public async Task<Person?> SavePerson(Person savePerson)
        {

            Person? personFromService = null;

            _personService.UseUrl = _personService.BaseUrl;

            if (_personService != null)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(savePerson);
                    var inContent = new StringContent(json, Encoding.UTF8, "application/json");

                    var serviceResponse = await _personService.CallServicePost(inContent);
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                    {
                        var resultContent = await serviceResponse.Content.ReadAsStringAsync();
                        personFromService = JsonConvert.DeserializeObject<Person>(resultContent);
                    }
                }
                catch
                {
                    personFromService = null;
                }
            }
            return personFromService;
        }

    }
}
