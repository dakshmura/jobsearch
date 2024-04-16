using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(User model)
    {
        if (ModelState.IsValid)
        {
            // Save user data to database or perform any necessary actions
            return RedirectToAction("Login");
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(User model)
    {
        if (ModelState.IsValid)
        {
            // Authenticate user (check username and password)
            // Redirect to home page if authentication successful
            // Otherwise, display error message
        }
        return View(model);
    }
}
