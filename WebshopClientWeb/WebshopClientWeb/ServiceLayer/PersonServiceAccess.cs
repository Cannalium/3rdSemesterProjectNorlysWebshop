using Newtonsoft.Json;
using System.Net;
using System.Text;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public class PersonServiceAccess : IPersonServiceAccess
    {
        readonly IServiceConnection _personService;
        readonly String _serviceBaseUrl = "https://localhost:7249/api/persons/";

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public PersonServiceAccess()
        {
            _personService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<Person> GetPersonByUserId(string userId)
        {
            Person? personFromService = null;

            _personService.UseUrl = _personService.BaseUrl;
            _personService.UseUrl += userId;

            if (_personService != null)
            {
                try
                {
                    var serviceResponse = await _personService.CallServiceGet();
                    CurrentHttpStatusCode = serviceResponse.StatusCode;            // Used by PersonControl class
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                    {
                        if (serviceResponse.StatusCode == HttpStatusCode.OK)
                        {
                            var content = await serviceResponse.Content.ReadAsStringAsync();
                            personFromService = JsonConvert.DeserializeObject<Person>(content);
                        }
                        else
                        {
                            personFromService = new Person();
                        }
                    }
                    else
                    {
                        personFromService = null;
                    }
                }
                catch
                {
                    personFromService = null;
                }
            }
            return personFromService;
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
