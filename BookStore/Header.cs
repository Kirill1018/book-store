using Microsoft.Data.SqlClient;
using System.Configuration;

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
        public static void Select(string query, DataGridView dataGridView)
        {
            List<Book> bookList = new List<Book>();
            IStore.Add(query, bookList);
            dataGridView.DataSource = bookList;
        }
        public static List<Book> Select(List<int> ids)
        {
            List<Book> bookList = new List<Book>();
            foreach (int bookId in ids)
            {
                string sql = $"select * from books where Id = {bookId}";
                IStore.Add(sql, bookList);
            }
            return bookList;
        }
    }
}