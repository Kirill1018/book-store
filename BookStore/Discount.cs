namespace BookStore
{
    internal class Discount
    {
        int Id { get; set; }
        public string? Name { get; set; }
        public double Size { get; set; }
        public Discount(int id, string? name,
            double size)
        {
            Id = id;
            Name = name;
            Size = size;
        }
        public int GetId() => this.Id;
    }
}