using COMP003B.MiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.MiniProject.Controllers
{
    public class PreOrderController : Controller
    {
        [HttpGet("PreOrder/{platformId}")]
        public IActionResult PreOrder([FromForm] string platformId)
        {
            var model = new PreOrder { Platform = platformId };
            return View(model);
        }

        [HttpGet]
        public IActionResult PreOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PreOrder([FromForm] PreOrder model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Success", model);
        }

        [HttpGet]
        public IActionResult Success(PreOrder model)
        {
            return View(model); 
        }
    }
}
