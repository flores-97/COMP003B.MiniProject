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
                new GameSystem { Id = 1, Platform = "Sony PlayStation", Summary = "Power to the player. Sony has been a fan favorite and the players choice, and highly saught after.", Price = 400, StorageGB = 1 },
                new GameSystem { Id = 2, Platform = "Microsoft Xbox", Summary = "This is Xbox. Xbox has had loyal players, especially due to it's exclusives. The Halo games keep players coming back.", Price = 500, StorageGB = 1},
                new GameSystem { Id = 3, Platform = "Computer Gaming", Summary = "Build your PC to your liking. You can have the specs you want and the price range you can afford. Whether you want high end or medium, the choice is yours.", Price = 500, StorageGB = 1}
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
