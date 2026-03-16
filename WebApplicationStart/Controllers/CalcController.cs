using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            //if (string.IsNullOrEmpty(c))
            //    return $"{a} + {b} = {a + b}";

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
                    return $"Не верный знак, используйте только: +, -, *, /";
            }
        }
    }
}
