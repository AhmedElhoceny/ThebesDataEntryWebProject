using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThebesDataEntryWebProject.Models
{
    interface IPersonRepo<T>
    {
        void AddPerson(T AddedPerson);
        void RemovePerson(string FullName);
        List<T> GetAllPersons();
        T FindData(string FullName);
    }
}
