namespace Entities
{
    public class BookAction
    {
        public int BookActionId { get; set; }
        public int BookId { get; set; }
        public string PersonName { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
