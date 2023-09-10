using Entities;

namespace DataAccess.Abstract
{
    //SOLID prensiplerine ve bağımlılığı azaltmak için interfaceler üzerinden işlem yapmak daha sağlıklı olacaktır.
    public interface IBookDal
    {
        List<Book> GetBooks();
        Book GetById(int id);
        void AddBook(Book book);
        void UpdateBookStatus(Book book);
    }
}
