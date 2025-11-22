using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BookStore
{
    internal class Header
    {
        public static SqlConnection SqlConnection { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["computer"].ConnectionString);
        public static string FormErr { get; } = "ошибка при заполнении формы";
        public static string[] Options { get; } = { "название", "автор",
            "жанр" };
        public static string[] Periods { get; } = { "день", "неделя",
            "месяц", "год" };
        public static string[] Groups { get; } = { "новинки", "самые продаваемые книги",
            "самые популярные авторы", "самые популярные жанры" };
        public static void Load(Store store)
        {
            string sql = "select * from books";
            Select(sql, store.volumes);
            ComboBox[] comboBox = { store.option, store.period,
                store.group };
            string[][] contents = { Options, Periods,
                Groups };
            for (int i = 0; i < comboBox.Length; i++) comboBox[i].DataSource = contents[i];
        }
        public static void Select(string query, DataGridView dataGridView)
        {
            List<Book> bookList = new List<Book>();
            Add(query, bookList);
            dataGridView.DataSource = bookList;
        }
        public static void Add(string query, List<Book> list)
        {
            IDbCommand iDbCommand = new SqlCommand(query, SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            while (iDataReader.Read())
            {
                string isCont = (iDataReader.GetBoolean(9)) ? "да" : "нет";
                Book book = new Book(iDataReader.GetInt32(0), iDataReader.GetString(1),
                    iDataReader.GetString(2), iDataReader.GetString(3),
                    iDataReader.GetInt32(4), iDataReader.GetString(5),
                    iDataReader.GetInt32(6), iDataReader.GetInt32(7),
                    iDataReader.GetInt32(8), isCont,
                    iDataReader.GetDateTime(10), null);
                list.Add(book);
            }
            iDataReader.Close();
        }
        public static string SelFromBooks(int bookId) => $"select * from books where Id = {bookId}";
        public static List<Book> Select()
        {
            string sql = "select * from sales";
            IDbCommand iDbCommand = new SqlCommand(sql, SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            List<int> bookIds = new List<int>();
            List<DateTime> dateTimes = new List<DateTime>();
            while (iDataReader.Read())
            {
                bookIds.Add(iDataReader.GetInt32(1));
                dateTimes.Add(iDataReader.GetDateTime(2));
            }
            iDataReader.Close();
            List<Book> bookList = new List<Book>();
            foreach (int bookId in bookIds) Add(SelFromBooks(bookId), bookList);
            for (int i = 0; i < bookList.Count; i++) bookList[i].SetDateTimeOfSale(dateTimes[i]);
            return bookList;
        }
    }
}