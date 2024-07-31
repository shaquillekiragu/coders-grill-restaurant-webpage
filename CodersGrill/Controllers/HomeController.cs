using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodersGrill.Data;

namespace CodersGrill.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var contents = await _context.TextContents.ToListAsync();
            return View(contents);
        }
    }
}
