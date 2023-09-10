using AutoMapper;
using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;
using WebApp.ValidationRules.BookValidationRules;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;
        private readonly IMapper mapper;
        private readonly ILogger<BookController> logger;

        public BookController(IBookService bookService, IMapper mapper, ILogger<BookController> logger)
        {
            this.bookService = bookService;
            this.mapper = mapper;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Kütüphanedeki kitaplar listelendi.");
            var result = bookService.GetBooks();
            return View(result);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            var validator = new AddBookValidator();
            var result = validator.Validate(book);

            if (result.IsValid)
            {
                book.ReturnDate = DateTime.Now;
                book.BookStatus = false;
                book.BookOwner = "Kütüphane";
                bookService.AddBook(book);
                return RedirectToAction("Index");
            }
            else
            {
                logger.LogError("Boş veri girilemez.");
                return View();
            }
        }
        [HttpGet]
        public IActionResult LendBook(int id)
        {
            var value = mapper.Map<LendBookViewModel>(bookService.GetById(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult LendBook(LendBookViewModel model)
        {
            var validator = new LendBookValidator();
            var validateResult = validator.Validate(model);

            if (validateResult.IsValid)
            {
                model.BookStatus = true;
                var result = mapper.Map<Book>(model);
                bookService.UpdateBookStatus(result);
                return RedirectToAction("Index");
            }
            else
            {
                logger.LogError("Boş veri girilemez.");
                return View(model);
            }
        }
        public IActionResult HomeBook(int id)
        {
            var value = bookService.GetById(id);
            value.BookStatus = false;
            bookService.UpdateBookStatus(value);
            return RedirectToAction("Index");
        }
    }
}
