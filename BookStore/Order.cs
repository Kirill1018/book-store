namespace BookStore
{
    internal class Order
    {
        int BookId { get; set; }
        public string? Buyer { get; set; }
        public Order(int bookId, string? buyer)
        {
            BookId = bookId;
            this.Buyer = buyer;
        }
        public int GetBookId() => this.BookId;
    }
}