using Microsoft.Data.SqlClient;

namespace BookStore
{
    public partial class Purchase : Form
    {
        Book Book { get; set; }
        public Purchase(Book book)
        {
            InitializeComponent();
            this.Book = book;
        }

        private void OnClickSubm(object sender, EventArgs e)
        {
            string buyText = buyer.Text, sql = $"insert into orders(bookId, buyName) values({this.Book
                .GetId()}, '{buyText}')";
            if (buyText == string.Empty) return;
            SqlCommand sqlCommand = new SqlCommand(sql, Header.SqlConnection);
            sqlCommand.ExecuteNonQuery();
            Close();
        }
    }
}