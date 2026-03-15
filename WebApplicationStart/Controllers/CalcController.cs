using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, string c = "+")
        {
            switch (c)
            {
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "*":
                    return $"{a} * {b} = {a * b}";
                case "/":
                    if (b == 0)
                        return "На ноль делить нельзя";
                    else
                        return $"{a} : {b} = {a / b}";
                default:
                    return $"{0} + {0} = {0 + 0}";
            }
        }
    }
}
