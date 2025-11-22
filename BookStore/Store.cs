using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    public partial class Store : Form
    {
        static SqlConnection SqlConnection { get; } = Header.SqlConnection;
        static string IsWrittOff { get; } = "книга была списана";
        static string EmptyString { get; } = string.Empty;
        public object? CommSourceOfData { get; set; }
        static string[] Options { get; } = Header.Options;
        public object? SearchSourceOfData { get; set; }
        public object? QuestSourceOfData { get; set; }
        static string[] Periods { get; } = Header.Periods;
        static string[] Groups { get; } = Header.Groups;
        public Store()
        {
            InitializeComponent();
            Header.Load(this);
        }

        private void OnClickAdd(object sender, EventArgs e)
        {
            Addendum addendum = new Addendum(this);
            addendum.Show();
        }

        private void OnClickDel(object sender, EventArgs e)
        {
            try
            {
                Book book = (Book)volumes.CurrentRow.DataBoundItem;
                int id = book.GetId();
                string sql = $"delete from bookDisc where Id = (select Id from bookDisc where bookId = {id})";
                SqlCommand sqlCommand = new SqlCommand(sql, SqlConnection);
                sqlCommand.ExecuteNonQuery();
                string[] tables = { "orders", "sales",
                    "writeOffs" };
                foreach (string table in tables)
                {
                    sql = $"delete from {table} where bookId = {id}";
                    sqlCommand = new SqlCommand(sql, SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                sql = $"delete from books where Id = {id}";
                sqlCommand = new SqlCommand(sql, SqlConnection);
                sqlCommand.ExecuteNonQuery();
                Header.Load(this);
            }
            catch (NullReferenceException) { }
        }

        private void OnClickEd(object sender, EventArgs e)
        {
            try
            {
                Book book = (Book)volumes.CurrentRow.DataBoundItem;
                Revision revision = new Revision(book, this);
                revision.Show();
            }
            catch (NullReferenceException) { }
        }

        private void OnClickSale(object sender, EventArgs e)
        {
            try
            {
                Book book = (Book)volumes.CurrentRow.DataBoundItem;
                if (IStore.IsWrittOff(book))
                {
                    Notification notification = new Notification(IsWrittOff);
                    notification.Show();
                    return;
                }
                string sql = $"insert into sales(bookId, dateTimeOfSale) values({book.GetId()}, '{DateTime.Now}')";
                SqlCommand sqlCommand = new SqlCommand(sql, SqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (NullReferenceException) { }
        }

        private void OnClickCheckSal(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void OnClickDed(object sender, EventArgs e)
        {
            try
            {
                Book book = (Book)volumes.CurrentRow.DataBoundItem;
                if (IStore.IsWrittOff(book))
                {
                    Notification notification = new Notification(IsWrittOff);
                    notification.Show();
                    return;
                }
                string sql = $"insert into writeOffs(bookId) values({book.GetId()})";
                SqlCommand sqlCommand = new SqlCommand(sql, SqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (NullReferenceException) { }
        }

        private void OnClickWrittOffGoods(object sender, EventArgs e)
        {
            WrittOffGood writtOffGood = new WrittOffGood();
            writtOffGood.Show();
        }

        private void OnClickUseDisc(object sender, EventArgs e)
        {
            try
            {
                Book book = (Book)volumes.CurrentRow.DataBoundItem;
                if (IStore.IsWrittOff(book))
                {
                    Notification notification = new Notification(IsWrittOff);
                    notification.Show();
                    return;
                }
                string sql = "select * from bookDisc";
                IDbCommand iDbCommand = new SqlCommand(sql, SqlConnection);
                IDataReader iDataReader = iDbCommand.ExecuteReader();
                bool hasDisc = false;
                while (iDataReader.Read()) if (iDataReader.GetInt32(1) == book
                        .GetId()) hasDisc = true;
                iDataReader.Close();
                if (hasDisc)
                {
                    Notification notification = new Notification("у книги уже есть скидка");
                    notification.Show();
                    return;
                }
                Markdown markdown = new Markdown(book, this);
                markdown.Show();
            }
            catch (NullReferenceException) { }
        }

        private void OnClickReq(object sender, EventArgs e)
        {
            try
            {
                Book book = (Book)volumes.CurrentRow.DataBoundItem;
                if (IStore.IsWrittOff(book))
                {
                    Notification notification = new Notification(IsWrittOff);
                    notification.Show();
                    return;
                }
                Purchase purchase = new Purchase(book);
                purchase.Show();
            }
            catch (NullReferenceException) { }
        }

        private void OnClickOrg(object sender, EventArgs e)
        {
            Organization organization = new Organization();
            organization.Show();
        }

        private void OnClickSearch(object sender, EventArgs e)
        {
            string optText = option.Text, textOfSearchVal = searchVal.Text;
            if (textOfSearchVal == EmptyString) return;
            if (this.CommSourceOfData is null) this.CommSourceOfData = volumes
                    .DataSource;
            if (optText == Options.First()) IStore.SearchByName(this, textOfSearchVal);
            else if (optText == Options[1]) IStore.SearchByAuth(this, textOfSearchVal);
            else IStore.SearchByGenre(this, textOfSearchVal);
            this.SearchSourceOfData = volumes.DataSource;
        }

        private void OnClickRes(object sender, EventArgs e)
        {
            option.Text = Options.First();
            searchVal.Text = EmptyString;
            this.SearchSourceOfData = null;
            if (this.CommSourceOfData is null) return;
            if (this.QuestSourceOfData is null)
            {
                IStore.SetData(this);
                return;
            }
            volumes.DataSource = this.QuestSourceOfData;
        }

        private void OnClickQuest(object sender, EventArgs e)
        {
            string perText = period.Text, firstPer = Periods.First(),
                groupText = group.Text, firstGroup = Groups.First();
            if (this.CommSourceOfData is null) this.CommSourceOfData = volumes
                    .DataSource;
            DateTime dateTime = DateTime.Now;
            int year = dateTime.Year, month = dateTime.Month,
                day = dateTime.Day, weekDay = (int)dateTime.DayOfWeek;
            List<Book> bookList = (List<Book>)volumes.DataSource, bestsList = new List<Book>(),
                newListOfBooks = new List<Book>();
            if (perText == firstPer) foreach (Book book in bookList)
                {
                    bool isSold = false;
                    int iterator = 0;
                    foreach (Book soldBook in Header.Select())
                    {
                        DateTime dateTimeOfSale = soldBook.GetDateTimeOfSale();
                        if (soldBook.GetId() == book.GetId() && dateTimeOfSale
                            .Year == year
                            && dateTimeOfSale.Month == month && dateTimeOfSale.Day == day)
                        {
                            isSold = true;
                            iterator++;
                        }
                    }
                    IStore.Add(book, iterator,
                        isSold, bestsList);
                    bestsList = bestsList.OrderByDescending(volume => volume.GetSaleCount())
                        .ToList();
                    if (groupText == firstGroup)
                    {
                        DateTime dateTimeOfBook = book.GetDateTime();
                        if (dateTimeOfBook.Year == year && dateTimeOfBook.Month == month
                            && dateTimeOfBook.Day == day) newListOfBooks.Add(book);
                    }
                    else if (groupText == Groups[1]) newListOfBooks = bestsList;
                    else if (groupText == Groups[2]) newListOfBooks = IStore.GetTheMostFamAuth(bestsList);
                    else newListOfBooks = IStore.GetTheMostFamGenr(bestsList);
                }
            else if (perText == Periods[1]) foreach (Book book in bookList)
                {
                    bool isSold = false;
                    int iterator = 0;
                    foreach (Book soldBook in Header.Select())
                    {
                        DateTime dateTimeOfSale = soldBook.GetDateTimeOfSale();
                        if (soldBook.GetId() == book.GetId() && dateTimeOfSale
                            .Year == year
                            && dateTimeOfSale.Month == month && (day - dateTimeOfSale.Day) <= weekDay)
                        {
                            isSold = true;
                            iterator++;
                        }
                    }
                    IStore.Add(book, iterator,
                        isSold, bestsList);
                    bestsList = bestsList.OrderByDescending(volume => volume.GetSaleCount())
                        .ToList();
                    if (groupText == firstGroup)
                    {
                        DateTime dateTimeOfBook = book.GetDateTime();
                        if (dateTimeOfBook.Year == year && dateTimeOfBook.Month == month
                            && (day - dateTimeOfBook.Day) <= weekDay) newListOfBooks.Add(book);
                    }
                    else if (groupText == Groups[1]) newListOfBooks = bestsList;
                    else if (groupText == Groups[2]) newListOfBooks = IStore.GetTheMostFamAuth(bestsList);
                    else newListOfBooks = IStore.GetTheMostFamGenr(bestsList);
                }
            else if (perText == Periods[2]) foreach (Book book in bookList)
                {
                    bool isSold = false;
                    int iterator = 0;
                    foreach (Book soldBook in Header.Select())
                    {
                        DateTime dateTimeOfSale = soldBook.GetDateTimeOfSale();
                        if (soldBook.GetId() == book.GetId() && dateTimeOfSale
                            .Year == year)
                        {
                            isSold = true;
                            iterator++;
                        }
                    }
                    IStore.Add(book, iterator,
                        isSold, bestsList);
                    bestsList = bestsList.OrderByDescending(volume => volume.GetSaleCount())
                        .ToList();
                    if (groupText == firstGroup)
                    {
                        DateTime dateTimeOfBook = book.GetDateTime();
                        if (dateTimeOfBook.Year == year && dateTimeOfBook.Month == month) newListOfBooks
                                .Add(book);
                    }
                    else if (groupText == Groups[1]) newListOfBooks = bestsList;
                    else if (groupText == Groups[2]) newListOfBooks = IStore.GetTheMostFamAuth(bestsList);
                    else newListOfBooks = IStore.GetTheMostFamGenr(bestsList);
                }
            else foreach (Book book in bookList)
                {
                    bool isSold = false;
                    int iterator = 0;
                    foreach (Book soldBook in Header.Select())
                    {
                        DateTime dateTimeOfSale = soldBook.GetDateTimeOfSale();
                        if (soldBook.GetId() == book.GetId() && dateTimeOfSale
                            .Year == year)
                        {
                            isSold = true;
                            iterator++;
                        }
                    }
                    IStore.Add(book, iterator,
                        isSold, bestsList);
                    bestsList = bestsList.OrderByDescending(volume => volume.GetSaleCount())
                        .ToList();
                    if (groupText == firstGroup)
                    {
                        if (book.GetDateTime().Year == year) newListOfBooks
                            .Add(book);
                    }
                    else if (groupText == Groups[1]) newListOfBooks = bestsList;
                    else if (groupText == Groups[2]) newListOfBooks = IStore.GetTheMostFamAuth(bestsList);
                    else newListOfBooks = IStore.GetTheMostFamGenr(bestsList);
                }
            volumes.DataSource = newListOfBooks;
            this.QuestSourceOfData = newListOfBooks;
        }

        private void OnClickReb(object sender, EventArgs e)
        {
            period.Text = Periods.First();
            group.Text = Groups.First();
            this.QuestSourceOfData = null;
            if (this.CommSourceOfData is null) return;
            if (this.SearchSourceOfData is null)
            {
                IStore.SetData(this);
                return;
            }
            volumes.DataSource = this.SearchSourceOfData;
        }
    }
}