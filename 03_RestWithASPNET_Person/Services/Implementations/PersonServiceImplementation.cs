using _02_RestWithASPNET.Model;

namespace _02_RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count; 

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            // codigo a implementar
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = incrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Some Address " + i,
                Gender = "Male"
            };
        }

        private long incrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = id,
                FirstName = "Celso",
                LastName = "Costa",
                Address = "São Bernardo do Campo, São Paulo",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
