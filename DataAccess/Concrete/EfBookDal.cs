using DataAccess.Abstract;
using DataAccess.Shared;
using Entities;

namespace DataAccess.Concrete
{
    public class EfBookDal : IBookDal
    {
        private readonly AppDbContext context;

        public EfBookDal(AppDbContext context)
        {
            this.context = context;
        }

        public void AddBook(Book book)
        {
            context.Add(book);
            context.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return context.Books.Find(id);
        }

        public void UpdateBookStatus(Book book)
        {
            context.Update(book);
            context.SaveChanges();
        }
    }
}
