using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal bookDal;

        public BookManager(IBookDal bookDal)
        {
            this.bookDal = bookDal;
        }

        public void AddBook(Book book)
        {
            bookDal.AddBook(book);
        }

        public List<Book> GetBooks()
        {
            return bookDal.GetBooks().OrderBy(x => x.BookName).ToList();
        }

        public Book GetById(int id)
        {
            return bookDal.GetById(id);
        }

        public void UpdateBookStatus(Book book)
        {
            bookDal.UpdateBookStatus(book);
        }
    }
}
