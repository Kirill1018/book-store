namespace BookStore
{
    public class Book
    {
        int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int PageCount { get; set; }
        public string? Genre { get; set; }
        public int Year { get; set; }
        public int CostPrice { get; set; }
        public int PriceForSale { get; set; }
        public string? IsCont { get; set; }
        DateTime DateTime { get; set; } = new DateTime();
        public Book(int id, string? name,
            string? author, string? publisher,
            int pageCount, string? genre,
            int year, int costPrice,
            int priceForSale, string? isCont,
            DateTime dateTime)
        {
            Id = id;
            Name = name;
            Author = author;
            Publisher = publisher;
            PageCount = pageCount;
            Genre = genre;
            Year = year;
            CostPrice = costPrice;
            PriceForSale = priceForSale;
            IsCont = isCont;
            DateTime = dateTime;
        }
        public int GetId() => this.Id;
        public DateTime GetDateTime() => this.DateTime;
    }
}