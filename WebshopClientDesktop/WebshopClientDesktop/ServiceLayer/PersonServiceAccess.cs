using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.ServiceLayer
{
    public class PersonServiceAccess : IPersonAccess
    {
        readonly IServiceConnection _personService;

        //Mangler url samt port number - sat til null for nu.
        readonly String _serviceBaseUrl = null;

        public PersonServiceAccess()
        {
            _personService = new ServiceConnection(_serviceBaseUrl);
        }

        //Retrieve Person(s)
        public async Task<List<Person>>? GetPersons(int id = -1)
        {
            List<Person> personsFromService = null;

            if (_personService != null)
            {
                _personService.UseUrl = _personService.BaseUrl;
                bool onePersonById = (id > 0);
                if (onePersonById)
                {
                    _personService.UseUrl += id;
                }
                try
                {
                    var serviceResponse = await _personService.CallServiceGet();
                    //If success (200-299)
                    if (serviceResponse is not null && serviceResponse.IsSuccessStatusCode)
                    //200 with data returned
                    {
                        if (serviceResponse.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            //If 1 Person returned - else all Persons returned
                            if (onePersonById)
                            {
                                Person foundPerson = JsonConvert.DeserializeObject<Person>(responseData);
                                if (foundPerson != null)
                                {
                                    personsFromService = new List<Person> { foundPerson }; //Must return List

                                }
                            }
                            else
                            {
                                personsFromService = JsonConvert.DeserializeObject<List<Person>>(responseData);
                            }
                            //204 no data
                        }
                        else if (serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            personsFromService = new List<Person>();
                        }
                    }
                }
                catch
                {
                    personsFromService = null;
                }
            }
            return personsFromService;
        }
        public Task<int> CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }

    }
}
