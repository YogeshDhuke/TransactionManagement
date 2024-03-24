using Microsoft.AspNetCore.Mvc;

namespace TransactionManagementApplication.Controller
{
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Perform login logic here
            if (username == "Yogesh" && password == "Yogesh@123")
            {
                // Authentication successful, redirect to a dashboard or home page
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                // Authentication failed, return to the login page with an error message
                ViewBag.ErrorMessage = "Invalid username or password";
                return View("Login");
            }
        }
}
