using Microsoft.AspNetCore.Mvc;

namespace MVCpractice.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {

            Member members = new Member();
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Member member)
        {

            if (ModelState.IsValid == true)
            {
                BrightmvcContext db = new BrightmvcContext();
                db.Members.Add(member);
                db.SaveChanges();
            }

            return View(member);
        }
    }
}
