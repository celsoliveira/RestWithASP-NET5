using RestWithASPNET.data.Converter.Implementations;
using RestWithASPNET.data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Repository;

namespace RestWithASPNET.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Create(PersonVO person)
        {
            var entity = _converter.Parse(person); // converte de PersonVO para Person
            entity = _repository.Create(entity);

            return _converter.Parse(entity);    // converte de Person para PersonVO
        }

        public PersonVO Update(PersonVO person)
        {
            var entity = _converter.Parse(person); // converte de PersonVO para Person
            entity = _repository.Update(entity);

            return _converter.Parse(entity);    // converte de Person para PersonVO
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
