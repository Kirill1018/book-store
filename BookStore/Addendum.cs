using Microsoft.Data.SqlClient;

namespace BookStore
{
    public partial class Addendum : Form
    {
        Store Store { get; set; }
        public Addendum(Store store)
        {
            InitializeComponent();
            this.Store = store;
        }

        private void OnClickAdd(object sender, EventArgs e)
        {
            try
            {
                bool isConf = confirmation.Checked;
                string titleText = title.Text, writText = writer.Text,
                    publText = publisher.Text, textOfPageAm = pageAm.Text,
                    catText = category.Text, textOfEdYear = edYear.Text,
                    textOfProdCost = prodCost.Text, textOfCostForSale = costForSale.Text,
                    isProl = (isConf) ? "true" : "false";
                string[] texts = { titleText, writText,
                    publText, textOfPageAm,
                    catText, textOfEdYear,
                    textOfProdCost, textOfCostForSale };
                bool isEmpty = false;
                foreach (string text in texts) if (text == string.Empty) isEmpty = true;
                if (isEmpty) return;
                string sql = "insert into books(name, author, "
                    + "publisher, pageCount, "
                    + "genre, year, "
                    + "costPrice, priceForSale, "
                    + $"isCont, addDate) values('{titleText}', '{writText}', "
                    + $"'{publText}', {int.Parse(textOfPageAm)}, "
                    + $"'{catText}', {int.Parse(textOfEdYear)}, "
                    + $"{int.Parse(textOfProdCost)}, {int.Parse(textOfCostForSale)}, "
                    + $"'{isProl}', '{DateTime.Now}')";
                if (isConf || denial.Checked)
                {
                    SqlCommand sqlCommand = new SqlCommand(sql, Header.SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    IStore.Load(this.Store);
                    Close();
                }
                else return;
            }
            catch (FormatException)
            {
                Notification notification = new Notification(Header.FormErr);
                notification.Show();
            }
        }
    }
}