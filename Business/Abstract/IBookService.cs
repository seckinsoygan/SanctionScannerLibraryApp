using Entities;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetById(int id);
        void AddBook(Book book);
        void UpdateBookStatus(Book book);
    }
}
