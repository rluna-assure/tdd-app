using Microsoft.AspNetCore.Mvc;
using project.Core;
namespace project.Webapi.Controllers
{
    [ApiController]
    [Route("roman")]

    public class RomanController : ControllerBase
    {

        [HttpGet("arabic/{romanNumber}")]
        public ActionResult<int> RomanToLiteral([FromRoute] string romanNumber)
        {
            var converter = new RomanConverter();
            var romanLiteral = converter.ConvertToInteger(romanNumber);
            return romanLiteral;
        }

        [HttpGet("{number}")]
        public ActionResult<string> LiteralToRoman([FromRoute] string number)
        {
            if (!int.TryParse(number, out int numericValue))
            {
                return BadRequest("Invalid number format.");
            }
            var converter = new RomanConverter();
            var romanLiteral = converter.ConvertToRoman(numericValue);
            return romanLiteral;
        }
    }
}