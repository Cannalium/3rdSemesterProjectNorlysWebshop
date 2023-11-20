using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.ServiceLayer
{
    public interface IPersonAccess
    {
        //Listen kan godt være tom - det kan Person ikke.
        Task<List<Person>>? GetPersons(int id = -1);
        Task<int> CreatePerson(Person person);
        
    }
}
