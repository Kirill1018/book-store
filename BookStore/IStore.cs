using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore
{
    internal interface IStore
    {
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
        public static void Add(Book volume, int i,
            bool condition, List<Book> bookList)
        {
            volume.SetSaleCount(i);
            if (condition) bookList.Add(volume);
        }
        public static List<Book> GetTheMostFamAuth(List<Book> bookList)
        {
            List<string> authors = new List<string>();
            List<Book> tomes = new List<Book>();
            foreach (Book book in bookList)
            {
                string? author = book.Author;
                authors.Remove(author!);
                authors.Add(author!);
            }
            foreach (string author in authors) foreach (Book volume in bookList) if (volume.Author == author) tomes.Add(volume);
            return tomes;
        }
        public static List<Book> GetTheMostFamGenr(List<Book> bookList)
        {
            List<string> genres = new List<string>();
            List<Book> tomes = new List<Book>();
            foreach (Book book in bookList)
            {
                string? genre = book.Genre;
                genres.Remove(genre!);
                genres.Add(genre!);
            }
            foreach (string genre in genres) foreach (Book volume in bookList) if (volume.Genre == genre) tomes.Add(volume);
            return tomes;
        }
    }
}