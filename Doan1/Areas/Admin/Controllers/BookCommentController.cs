using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Doan1.Models;
using Doan1.Ulitities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Doan1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookCommentController : Controller
    {
        private readonly DataContext _context;
        public BookCommentController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var items = _context.Books.ToList();
            return View(items);
        }
        public IActionResult ListComment(int id)
        {
            Functions.Cmt = id;
            var items = _context.BookComments.Where(m => m.BookID==id).ToList();
            ViewBag.contact = _context.Accounts.ToList();
            return View(items);
        }
    }
}
