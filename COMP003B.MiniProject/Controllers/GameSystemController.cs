using COMP003B.MiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.MiniProject.Controllers
{
    public class GameSystemController : Controller
    {
        public IActionResult Index()
        {
            var gameSystems = new List<GameSystem>
            {
                new GameSystem { Id = 1, Platform = "Sony PlayStation", Summary = "Power to the player." },
                new GameSystem { Id = 2, Platform = "Microsoft Xbox", Summary = "This is Xbox." }
            };

            return View(gameSystems);
        }
        public IActionResult Details(int id)
        {
            var gameSystem = new GameSystem { Id = id, Platform = $"Platform {id}", Summary = "Detailed content coming soon." };
            return View(gameSystem);
        }
    }
}
