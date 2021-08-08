using Microsoft.AspNetCore.Mvc;
using DojoSurvModel.Models;

namespace YourNamespace.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("")]
    public IActionResult NewSurvey()
    {
      return View();
    }


  [HttpPost("user/create")]
public IActionResult Create(Survey survey)
{
    if(ModelState.IsValid)
    {
        // do somethng!  maybe insert into db?  then we will redirect
        return View("Results",survey);
    }
    else
    {
        // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
        return View("NewSurvey");
    }
}



  }
}
