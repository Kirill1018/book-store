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
        DateTime DateTimeOfSale { get; set; } = new DateTime();
        int? SaleCount { get; set; }
        public Book(int id, string? name,
            string? author, string? publisher,
            int pageCount, string? genre,
            int year, int costPrice,
            int priceForSale, string? isCont,
            DateTime dateTime, int? saleCount)
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
            SaleCount = saleCount;
        }
        public int GetId() => this.Id;
        public DateTime GetDateTime() => this.DateTime;
        public DateTime GetDateTimeOfSale() => this.DateTimeOfSale;
        public void SetDateTimeOfSale(DateTime dateTimeOfSale) => this.DateTimeOfSale = dateTimeOfSale;
        public int? GetSaleCount() => this.SaleCount;
        public void SetSaleCount(int saleCount) => this.SaleCount = saleCount;
    }
}