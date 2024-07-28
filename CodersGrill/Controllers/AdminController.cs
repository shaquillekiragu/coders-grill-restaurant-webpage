using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodersGrill.Data;
using CodersGrill.Models;

namespace CodersGrill.Controllers
{
    public class AdminController(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<IActionResult> Index()
        {
            var contents = await _context.TextContents.ToListAsync();
            return View(contents);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Section,ContentType,HtmlContent")] TextContent content)
        {
            if (ModelState.IsValid)
            {
                _context.Add(content);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(content);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var content = await _context.TextContents.FindAsync(id);
            if (content == null)
            {
                return NotFound();
            }
            return View(content);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Section,ContentType,HtmlContent")] TextContent content)
        {
            if (id != content.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(content);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentExists(content.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(content);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var content = await _context.TextContents.FindAsync(id);
            if (content != null)
            {
                _context.TextContents.Remove(content);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        private bool ContentExists(int id)
        {
            return _context.TextContents.Any(e => e.Id == id);
        }
    }
}
