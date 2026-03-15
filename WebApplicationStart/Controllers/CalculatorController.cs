using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string operation)
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
