using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a = 0, double b = 0, string operation = "+")
        {
            if (operation == "+")
                return $"{a} + {b} = {a + b}";
            else if (operation == "-")
                return $"{a} - {b} = {a - b}";
            else if (operation == "*")
                return $"{a} * {b} = {a * b}";
            else
                return $"{a} + {b} = {a + b}";
        }
    }
}
