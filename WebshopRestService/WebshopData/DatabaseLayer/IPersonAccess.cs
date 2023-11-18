using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopData.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IPersonAccess
    {
        List<Person> GetPersonAll();
        int CreatePerson(Person personAdd);
        bool UpdatePerson(Person personUpdate);
        Person GetPersonById(int id);
        bool DeletePerson();

    }
}
