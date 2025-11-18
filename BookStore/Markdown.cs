using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    public partial class Markdown : Form
    {
        static SqlConnection SqlConnection { get; } = Header.SqlConnection;
        Book Book { get; set; }
        Store Store { get; set; }
        public Markdown(Book book, Store store)
        {
            InitializeComponent();
            this.Book = book;
            this.Store = store;
            string sql = "select * from discounts";
            IDbCommand iDbCommand = new SqlCommand(sql, SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            List<Discount> discList = new List<Discount>();
            while (iDataReader.Read())
            {
                Discount discount = new Discount(iDataReader.GetInt32(0), iDataReader.GetString(1),
                    (double)iDataReader.GetInt32(2) / 100);
                discList.Add(discount);
            }
            iDataReader.Close();
            markdowns.DataSource = discList;
        }

        private void OnClickUse(object sender, EventArgs e)
        {
            try
            {
                Discount discount = (Discount)markdowns.CurrentRow.DataBoundItem;
                int id = this.Book.GetId();
                string sql = $"insert into bookDisc(bookId, discId) values({id}, {discount.GetId()})";
                SqlCommand sqlCommand = new SqlCommand(sql, SqlConnection);
                sqlCommand.ExecuteNonQuery();
                sql = $"update books set priceForSale = {(int)(this.Book.PriceForSale * discount
                    .Size)} where Id = {id}";
                sqlCommand = new SqlCommand(sql, SqlConnection);
                sqlCommand.ExecuteNonQuery();
                IStore.Load(this.Store);
                Close();
            }
            catch (NullReferenceException) { }
        }
    }
}