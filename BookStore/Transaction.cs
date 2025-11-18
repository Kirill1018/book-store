using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
            string sql = "select * from sales";
            IDbCommand iDbCommand = new SqlCommand(sql, Header.SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            List<int> bookIds = new List<int>();
            while (iDataReader.Read()) bookIds.Add(iDataReader
                .GetInt32(1));
            iDataReader.Close();
            List<Book> bookList = new List<Book>();
            deals.DataSource = Header.Select(bookIds);
        }
    }
}