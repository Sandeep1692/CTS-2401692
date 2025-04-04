using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalcPost.Models;

namespace CalcPost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpPost]
        public ActionResult<CalcResponse> Calculate([FromBody] Calc calc)
        {
            var response = new CalcResponse
            {
                Addition = Add(calc.firstnumber, calc.secondnumber),
                Subtraction = Subtract(calc.firstnumber, calc.secondnumber),
                Multiplication = Multiply(calc.firstnumber, calc.secondnumber),
                Division = Divide(calc.firstnumber, calc.secondnumber)
            };

            return response;
        }

        private int Add(int firstnumber, int secondnumber)
        {
            return firstnumber + secondnumber;
        }

        private int Subtract(int firstnumber, int secondnumber)
        {
            return firstnumber - secondnumber;
        }

        private int Multiply(int firstnumber, int secondnumber)
        {
            return firstnumber * secondnumber;
        }

        private int? Divide(int firstnumber, int secondnumber)
        {
            if (secondnumber == 0)
            {
                return null; 
            }
            return firstnumber / secondnumber;
        }
    }
}