namespace WebApp.Models.ViewModels
{
    public class LendBookViewModel
    {
        public int BookId { get; set; }
        public string BookOwner { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool BookStatus { get; set; }
    }
}
