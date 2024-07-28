using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodersGrill.Data;

namespace CodersGrill.Controllers
{
    public class HomeController(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<IActionResult> Index()
        {
            var contents = await _context.TextContents.ToListAsync();
            return View(contents);
        }
    }
}