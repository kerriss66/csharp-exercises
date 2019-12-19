using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        private static int count = 0;

        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type ='text' name='name' />" + 
                "< select name = 'lang' >" +   
                "< option value = 'english' selected> English </ option >" +        
                "< option value = 'spanish' > Spanish </ option >" +         
                "< option value = 'french' > French </ option >" +          
                "< option value = 'german' > German </ option >" +           
                "< option value = 'portuguese' > Portuguese </ option >" +            
                "< option value = 'swedish' > Swedish </ option >" +  
                "</select>" + 
                "<input type='submit' value='Greet me!' />" +
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
                case "english":
                    greeting = "Hello World";
                    break;
                case "french":
                    greeting = "Bonjour le monde";
                    break;
                case "spanish":
                    greeting = "Hola Mundo";
                    break;
                case "german":
                    greeting = "Hallo Welt";
                    break;
                case "portuguese":
                    greeting = "Olá Mundo";
                    break;
                case "swedish":
                    greeting = "Hej världen";
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