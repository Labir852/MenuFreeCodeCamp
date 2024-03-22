using Microsoft.AspNetCore.Mvc;
using MenuFreeCodeCamp.Data;
using MenuFreeCodeCamp.Models;
using Microsoft.EntityFrameworkCore;
namespace MenuFreeCodeCamp.Controllers
{
    public class Menu : Controller
    {
        private readonly MenuContext _context;
        public Menu(MenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dishes.ToListAsync());
        }
    }
}
