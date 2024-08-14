using Microsoft.AspNetCore.Mvc;
using CodersGrill.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CodersGrill.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                _logger.LogInformation("Fetching all text contents from the database.");

                var contents = _context.TextContents.ToList();

                _logger.LogInformation($"Retrieved {contents.Count} text contents.");

                return View(contents);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching text contents.");

                return View("Error");
            }
        }
    }
}
