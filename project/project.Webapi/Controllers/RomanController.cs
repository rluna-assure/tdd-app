using Microsoft.AspNetCore.Mvc;
using project.Core;
namespace project.Webapi.Controllers
{
    [ApiController]
    [Route("roman")]

    public class RomanController : ControllerBase
    {

        [HttpGet("roman-to-literal/{romanNumber}")]
        public ActionResult<int> RomanToLiteral([FromRoute] string romanNumber)
        {
            var converter = new RomanConverter();
            var romanLiteral = converter.ConvertToInteger(romanNumber);
            return romanLiteral;
        }


        [HttpGet("number-to-roman/{number}")]
        public ActionResult<string> LiteralToRoman([FromRoute] string number)
        {
            var converter = new RomanConverter();
            var romanLiteral = converter.ConvertToRoman(int.Parse(number));
            return romanLiteral;
        }
    }
}