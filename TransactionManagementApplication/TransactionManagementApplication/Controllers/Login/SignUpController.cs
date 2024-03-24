using Microsoft.AspNetCore.Mvc;
using TransactionManagementApplication.Models.DB;

namespace TransactionManagementApplication.Controllers.Login
{
    public class SignUpController : Controller
    {
        private readonly ILogger<SignUpController> _logger;
        private readonly TransactionManagementContext _dbcontext;

        public SignUpController(ILogger<SignUpController> logger, TransactionManagementContext DbContext)
        {
            _logger = logger;
            _dbcontext = DbContext;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult AddUser(string username, string password, string fullname, string email, string phone)
        {
            decimal phoneNo;
            decimal.TryParse(phone, out phoneNo);

            var newUser = new User
            {
                UserName = username,
                Password = password,
                UserFullName = fullname,
                Email = email,
                PhoneNo = phoneNo
            };

            _dbcontext.Users.Add(newUser);

            _dbcontext.SaveChanges();

            return RedirectToAction("Login", "Login");
        }
    }
}
