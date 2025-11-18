using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    internal interface IStore
    {
        public static void Load(Store store)
        {
            string sql = "select * from books";
            Header.Select(sql, store.volumes);
            store.option.DataSource = Header
                .Options;
            store.period.DataSource = Header
                .Periods;
        }
        public static void Add(string query, List<Book> list)
        {
            IDbCommand iDbCommand = new SqlCommand(query, Header.SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            while (iDataReader.Read())
            {
                string isCont = (iDataReader.GetBoolean(9)) ? "да" : "нет";
                Book book = new Book(iDataReader.GetInt32(0), iDataReader.GetString(1),
                    iDataReader.GetString(2), iDataReader.GetString(3),
                    iDataReader.GetInt32(4), iDataReader.GetString(5),
                    iDataReader.GetInt32(6), iDataReader.GetInt32(7),
                    iDataReader.GetInt32(8), isCont,
                    iDataReader.GetDateTime(10));
                list.Add(book);
            }
            iDataReader.Close();
        }
        public static bool IsWrittOff(Book book)
        {
            string sql = "select * from writeOffs";
            IDbCommand iDbCommand = new SqlCommand(sql, Header.SqlConnection);
            IDataReader iDataReader = iDbCommand.ExecuteReader();
            bool condition = false;
            while (iDataReader.Read()) if (iDataReader.GetInt32(1) == book
                    .GetId()) condition = true;
            iDataReader.Close();
            return condition;
        }
        public static void SearchByName(Store store, string title)
        {
            List<Book> bookList = new List<Book>();
            foreach (Book book in (List<Book>)store.volumes.DataSource) if (book
                    .Name == title) bookList.Add(book);
            store.volumes.DataSource = bookList;
        }
        public static void SearchByAuth(Store store, string writer)
        {
            List<Book> bookList = new List<Book>();
            foreach (Book book in (List<Book>)store.volumes.DataSource) if (book
                    .Author == writer) bookList.Add(book);
            store.volumes.DataSource = bookList;
        }
        public static void SearchByGenre(Store store, string category)
        {
            List<Book> bookList = new List<Book>();
            foreach (Book book in (List<Book>)store.volumes.DataSource) if (book
                    .Genre == category) bookList.Add(book);
            store.volumes.DataSource = bookList;
        }
        public static void SetData(Store store)
        {
            store.volumes.DataSource = store
                .CommSourceOfData;
            store.CommSourceOfData = null;
        }
    }
}