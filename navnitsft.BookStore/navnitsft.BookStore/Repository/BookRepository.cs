using navnitsft.BookStore.Models;

namespace navnitsft.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public List<BookModel> GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).ToList();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title==title && x.Author==authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id=1, Title="MVC", Author="Ram"},
                new BookModel() {Id=2, Title="MVC", Author="Ram"},
                new BookModel() {Id=3, Title="C#", Author="Shyam"},
                new BookModel() {Id=4, Title="Java", Author="Mohan"},
                new BookModel() {Id=5, Title="Php", Author="Mohan"}
            };
        }
        
    }
}
