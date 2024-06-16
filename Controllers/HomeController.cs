
using meetingApp_asp_education_part2.Models;
using Microsoft.AspNetCore.Mvc;


namespace meetingApp_asp_education_part2.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        int hour = DateTime.Now.Hour;
        ViewBag.hello = hour > 12 ? "Iyi gunler" : "Gunaydin";
        int UserCount = Repository.Users.Where(info => info.willAttend == true).Count();
        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "Istanbul, abc kongre merkezi",
            DateTime = new DateTime(2024, 01, 04, 20, 0, 0),
            NumberofPeople = UserCount
        };

        return View(meetingInfo);
    }
}
