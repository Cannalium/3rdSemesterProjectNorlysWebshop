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
        List<Person> GetPersons();
        int CreatePerson(Person personAdd);
        bool UpdatePerson(Person personUpdate);
        bool DeletePerson();

    }
}
