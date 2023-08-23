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
                new BookModel() {Id=1, Title="MVC", Author="Ram", Description="This is the description from MVC book"},
                new BookModel() {Id=2, Title="MVC", Author="Ram", Description="This is the description from MVC book"},
                new BookModel() {Id=3, Title="C#", Author="Shyam", Description="This is the description from C# book"},
                new BookModel() {Id=4, Title="Java", Author="Mohan", Description = "This is the description from Java book"},
                new BookModel() {Id=5, Title="Php", Author="Mohan", Description="This is the description from Php book"},
                new BookModel() {Id=5, Title="Azure DevOps", Author="Lakshman", Description="This is the description from Azure DevOps book"}
            };
        }
        
    }
}
