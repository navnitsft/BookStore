using Microsoft.AspNetCore.Mvc;
using navnitsft.BookStore.Models;
using navnitsft.BookStore.Repository;

namespace navnitsft.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
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

        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewBook(BookModel bookModel)
        {
            int id = _bookRepository.AddNewBook(bookModel);
            if (id > 0)
            {
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
            }

            return View();
        }
    }
}
