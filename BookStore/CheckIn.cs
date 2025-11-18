using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void OnClickSubm(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Header.SqlConnection;
            sqlConnection.Close();
            sqlConnection.Open();
            string sql = "select * from users";
            IDbCommand iDbCommand = new SqlCommand(sql, sqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            bool isEnt = false;
            while (iDataReader.Read()) if (iDataReader.GetString(1) == this
                    .username.Text && iDataReader.GetString(2) == this
                    .parole.Text) isEnt = true;
            iDataReader.Close();
            if (isEnt)
            {
                Close();
                Thread thread = new Thread(() =>
                {
                    Store store = new Store();
                    Application.Run(store);
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
    }
}