using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepoository bookRepoository;

        public BookController(IBookRepoository bookRepoository)
        {
            this.bookRepoository = bookRepoository;
        }

        public IActionResult Index(int id)
        {
            Book book = bookRepoository.GetById(id);

            return View(book);
        }
    }
}