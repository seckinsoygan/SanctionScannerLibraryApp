using DataAccess.Abstract;
using DataAccess.Shared;
using Entities;

namespace DataAccess.Concrete
{
    public class EfBookActionDal : IBookActionDal
    {
        private readonly AppDbContext context;

        public EfBookActionDal(AppDbContext context)
        {
            this.context = context;
        }

        public void AddBookAction(BookAction bookAction)
        {
            context.Add(bookAction);
        }

        public BookAction GetById(int id)
        {
            return context.BookActions.Find(id);
        }
    }
}
