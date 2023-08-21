using Microsoft.AspNetCore.Mvc;
using navnitsft.BookStore.Models;
using navnitsft.BookStore.Repository;

namespace navnitsft.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public List<BookModel> GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string bookName, string authorName) 
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
