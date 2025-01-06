using HW6_PRO.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW6_PRO.Controllers
{
    public class ProgrammingController : Controller
    {
        private static List<ProgrammingLanguage> _languages = new List<ProgrammingLanguage>()
       {
           new ProgrammingLanguage {Name = "C#", Description = "Language of programming about .Net", ExampleCode = "Console.WriteLine(\"Hello World!);"},
           new ProgrammingLanguage {Name = "C++",   Description = "Language of typization.", ExampleCode = "cout << \"Hello World!\";" },
           new ProgrammingLanguage {Name = "Java", Description = "Cross platform language", ExampleCode = "System.out.println(\"Hello, World!\");"}
       };

        public IActionResult Index() => View(_languages);

        public IActionResult Info(string language, string color = "black")
        {
            if (string.IsNullOrEmpty(language))
            {
                return BadRequest("Language parameter cannot be null or empty.");
            }

            var lang = _languages.Find(lan => lan.Name != null && lan.Name.ToLower() == language.ToLower());
            if (lang == null)
            {
                return NotFound();
            }

            ViewBag.Color = color;
            return View(lang);
        }

        public IActionResult Example(string language)
        {
            var lang = _languages.Find(lan => lan.Name.ToLower() == language.ToLower());
            if (lang == null)
                return NotFound();

            return View(lang);
        }
    }
}
