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
        public ViewResult GetAllBooks()
        {
            var getAllBook = _bookRepository.GetAllBooks();

            return View(getAllBook);
        }

        public ViewResult GetBook(int id)
        {
            var getBookById = _bookRepository.GetBookById(id);

            return View(getBookById);
        }

        public List<BookModel> SearchBook(string bookName, string authorName) 
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
