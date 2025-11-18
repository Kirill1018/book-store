namespace BookStore
{
    public partial class Buying : Form
    {
        int Identifier { get; set; }
        public Buying(int identifier)
        {
            InitializeComponent();
            this.Identifier = identifier;
            string sql = $"select * from books where Id = {this.Identifier}";
            Header.Select(sql, purchase);
        }
    }
}