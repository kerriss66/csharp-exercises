using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        private static int count = 0;



        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name'>" +
                "<select name='lang'>" +
                "<option value='en' selected>English</option>" +
                "<option value='fr'>French</option>" +
                "<option value='sp'>Spanish</option>" +
                "<option value='oth'>Other</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!'>" +
                "</form>";

            return Content(html, "text/html");
        }


        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string lang, string name = "World")
        {
            string greetingHtml = CreateMessage(name, lang);
            count++;

            return Content(greetingHtml +
                "<br><p>You have been greeted " + count + " times!</p>",
                "text/html");
        }


        public static string CreateMessage(string name, string langOption)
        {
            string greeting = "";

            switch (langOption)
            {
                case "en":
                    greeting = "Hello";
                    break;
                case "fr":
                    greeting = "Bonjour";
                    break;
                case "sp":
                    greeting = "Hola";
                    break;
                case "oth":
                default:
                    greeting = "WAZZZZZZZZZZZZZZZZZZUP";
                    break;
            }

            return "<h1>" + greeting + " " + name + "</h1>";
        }


        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}