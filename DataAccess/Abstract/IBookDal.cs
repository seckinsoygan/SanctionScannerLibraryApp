using Entities;

namespace DataAccess.Abstract
{
    public interface IBookDal
    {
        List<Book> GetBooks();
        Book GetById(int id);
        void AddBook(Book book);
        void UpdateBookStatus(Book book);
    }
}
