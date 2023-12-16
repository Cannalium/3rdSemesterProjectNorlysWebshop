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

        // Retrieves a person by email from the PersonService, handling various HTTP status codes and exceptions
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
                                personFromService = null;
                            }
                            else if (serviceResponse.StatusCode == HttpStatusCode.BadRequest)
                            {
                                // Handle 400 Bad Request
                                personFromService = null;
                            }
                            else
                            {
                                // Handle other status codes
                                personFromService = null;
                            }
                        }
                    }
                    else
                    {
                        // Handle the case where serviceResponse is null
                        personFromService = new Person();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return personFromService!;
        }
    }
}
