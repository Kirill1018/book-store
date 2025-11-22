using Microsoft.Data.SqlClient;

namespace BookStore
{
    public partial class Revision : Form
    {
        Book Book { get; set; }
        Store Store { get; set; }
        public Revision(Book book, Store store)
        {
            InitializeComponent();
            this.Book = book;
            this.Store = store;
            title.Text = this.Book
                .Name;
            writer.Text = this.Book
                .Author;
            publisher.Text = this.Book
                .Publisher;
            pageAm.Text = this.Book
                .PageCount.ToString();
            category.Text = this.Book
                .Genre;
            edYear.Text = this.Book
                .Year.ToString();
            prodCost.Text = this.Book
                .CostPrice.ToString();
            costForSale.Text = this.Book
                .PriceForSale.ToString();
            if (this.Book.IsCont == "да") confirmation
                    .Checked = true;
            else denial.Checked = true;
        }

        private void OnClickMod(object sender, EventArgs e)
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
                string sql = $"update books set name = '{titleText}', author = '{writText}', "
                    + $"publisher = '{publText}', pageCount = {int.Parse(textOfPageAm)}, "
                    + $"genre = '{catText}', year = {int.Parse(textOfEdYear)}, "
                    + $"costPrice = {int.Parse(textOfProdCost)}, priceForSale = {int.Parse(textOfCostForSale)}, "
                    + $"isCont = '{isProl}' where Id = {this.Book.GetId()}";
                SqlCommand sqlCommand = new SqlCommand(sql, Header.SqlConnection);
                sqlCommand.ExecuteNonQuery();
                Header.Load(this.Store);
                Close();
            }
            catch (FormatException)
            {
                Notification notification = new Notification(Header.FormErr);
                notification.Show();
            }
        }
    }
}