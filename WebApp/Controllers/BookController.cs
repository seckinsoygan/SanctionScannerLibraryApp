using AutoMapper;
using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;
        private readonly IMapper mapper;
        private readonly IBookActionService bookActionService;

        public BookController(IBookService bookService, IMapper mapper, IBookActionService bookActionService)
        {
            this.bookService = bookService;
            this.mapper = mapper;
            this.bookActionService = bookActionService;
        }

        public IActionResult Index()
        {
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
            book.ReturnDate = DateTime.Now;
            book.BookStatus = false;
            book.BookOwner = "Kütüphane";
            bookService.AddBook(book);
            return RedirectToAction("Index");
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
            model.BookStatus = true;
            var result = mapper.Map<Book>(model);
            bookService.UpdateBookStatus(result);
            return RedirectToAction("Index");
        }
    }
}
