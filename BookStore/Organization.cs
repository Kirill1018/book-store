using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    public partial class Organization : Form
    {
        public Organization()
        {
            InitializeComponent();
            string sql = "select * from orders";
            IDbCommand iDbCommand = new SqlCommand(sql, Header.SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            List<Order> ordList = new List<Order>();
            while (iDataReader.Read())
            {
                Order order = new Order(iDataReader.GetInt32(1), iDataReader.GetString(2));
                ordList.Add(order);
            }
            iDataReader.Close();
            requests.DataSource = ordList;
        }

        private void OnClickView(object sender, EventArgs e)
        {
            try
            {
                Order order = (Order)requests.CurrentRow.DataBoundItem;
                Buying buying = new Buying(order.GetBookId());
                buying.Show();
            }
            catch (NullReferenceException) { }
        }
    }
}