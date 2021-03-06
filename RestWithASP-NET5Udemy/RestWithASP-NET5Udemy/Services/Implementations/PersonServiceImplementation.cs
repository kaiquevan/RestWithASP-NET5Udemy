using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int cont;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i=0; i<8;i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Kaique",
                LastName = "D",
                Address = "ABC",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {

            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name"+i,
                LastName = "Person LastName"+i,
                Address = "Address "+i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref cont);
        }
    }
}
