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

        public async Task<IActionResult> FAQ() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
