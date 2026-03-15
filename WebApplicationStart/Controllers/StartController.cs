using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 0 && hour < 6)
                return "Доброй ночи";
            else if (hour >= 6 && hour < 12)
                return "Доброе утро";
            else if (hour >= 12 && hour < 18)
                return "Добрый день";
            else
                return "Добрый вечер";
        }
    }
}
