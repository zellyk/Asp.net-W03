using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        // Returns home so Index is set as the homepage.
        public IActionResult Index()
        {
            return Content("Home");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No ID supplied.");
            }
            else
            {
                return Content("ID: " + id);
            }
        }

        //Routes the URL so that when we load this site we run the application
        // without typing the path /home/countdown
        //giving conditions, such that we can decide where the loop starts and
        //ends. The "?" symbol in the curly braces means that the segment of the
        //URL is optional
        [Route("[action]/{start}/{end?}/{message?}")]
        //Loop that is a countdown and returns the output of the countdown 
        // then prints the result on the page
        public IActionResult Countdown(int start, int end = 0, string message="")
        {
            string contentString = "Counting down: \n"; // Assign value
            for (int i = start; i >= end; i--) // Start loop
            {
                contentString += i + "\n"; // Appending value
            }
            contentString += message + "\n"; // prints the string if included
            return Content(contentString); // Return message as a string
        }
    }
}
