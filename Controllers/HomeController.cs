using System.Diagnostics;
using System.Threading.Tasks;
using Asr.Data;
using Microsoft.AspNetCore.Mvc;
using Asr.Models;
using Microsoft.EntityFrameworkCore;

namespace Asr.Controllers
{
    public class HomeController : Controller
    {
        private readonly AsrContext _context;

        public HomeController(AsrContext context) => _context = context;

        public async Task<IActionResult> Index() => View();
            //View(await _context.Slot.Include(s => s.Room).Include(s => s.Staff).Include(s => s.Student).ToListAsync());
        
        public async Task<IActionResult> Rooms() => View(await _context.Room.ToListAsync());

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
