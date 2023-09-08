using Entities;

namespace Business.Abstract
{
    public interface IBookActionService
    {
        BookAction GetById(int id);
        void AddBookAction(BookAction bookAction);
    }
}
