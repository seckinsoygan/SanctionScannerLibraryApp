using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class BookActionManager : IBookActionService
    {
        private readonly IBookActionDal bookactionDal;

        public BookActionManager(IBookActionDal bookactionDal)
        {
            this.bookactionDal = bookactionDal;
        }

        public void AddBookAction(BookAction bookAction)
        {
            bookactionDal.AddBookAction(bookAction);
        }

        public BookAction GetById(int id)
        {
            return bookactionDal.GetById(id);
        }
    }
}
