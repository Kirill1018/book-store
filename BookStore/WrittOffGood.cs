using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    public partial class WrittOffGood : Form
    {
        public WrittOffGood()
        {
            InitializeComponent();
            string sql = "select * from writeOffs";
            IDbCommand iDbCommand = new SqlCommand(sql, Header.SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            List<int> bookIds = new List<int>();
            while (iDataReader.Read()) bookIds.Add(iDataReader
                .GetInt32(1));
            iDataReader.Close();
            goods.DataSource = Header.Select(bookIds);
        }
    }
}