using Microsoft.AspNetCore.Mvc;
using TransactionManagementApplication.Models.DB;

namespace TransactionManagementApplication.Controllers.Login
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly TransactionManagementContext _dbcontext;

        public LoginController(ILogger<LoginController> logger, TransactionManagementContext DbContext)
        {
            _logger = logger;
            _dbcontext = DbContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult UserLogin(string username, string password)
        {
            User user = _dbcontext.Users.Where(i => i.UserName.Equals(username)).FirstOrDefault();

            if (user != null && user.Password.Equals(password))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View("Login");
            }
        }
    }
}
