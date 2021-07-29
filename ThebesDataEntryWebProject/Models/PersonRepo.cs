using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ThebesDataEntryWebProject.Models
{
    public class PersonRepo: IPersonRepo<Person>
    {
        private readonly ContextClass MYDB;
        public PersonRepo(ContextClass MYDB)
        {
            this.MYDB = MYDB;
        }

        public void AddPerson(Person AddedPerson)
        {
            MYDB.Person.Add(AddedPerson);
            MYDB.SaveChanges();
        }

        public Person FindData(string FullName)
        {
            return MYDB.Person.Where(x => x.Person_Name == FullName).SingleOrDefault();
        }

        public List<Person> GetAllPersons()
        {
            return MYDB.Person.ToList();
        }

        public void RemovePerson(string FullName)
        {
            MYDB.Person.Remove(FindData(FullName));
            MYDB.SaveChanges();
        }
    }
}
