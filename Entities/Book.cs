namespace Entities

{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookImage { get; set; }
        public string BookOwner { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool BookStatus { get; set; }
    }
}
