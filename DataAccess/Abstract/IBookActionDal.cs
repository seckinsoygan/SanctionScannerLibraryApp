using Entities;

namespace DataAccess.Abstract
{
    public interface IBookActionDal
    {
        BookAction GetById(int id);
        void AddBookAction(BookAction bookAction);
    }
}
