using System;
using RestWithASPNET.data.Converter.Implementations;
using RestWithASPNET.data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Repository;

namespace RestWithASPNET.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Create(BookVO book)
        {
            var entity = _converter.Parse(book); // converte de BookVO para Book
            entity = _repository.Create(entity);

            return _converter.Parse(entity);    // converte de Book para BookVO
        }

        public BookVO Update(BookVO book)
        {
            var entity = _converter.Parse(book); // converte de BookVO para Book
            entity = _repository.Update(entity);

            return _converter.Parse(entity);    // converte de Book para BookVO
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
