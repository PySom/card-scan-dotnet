using Microsoft.AspNetCore.Mvc;
using recognizer;
using Vision.ViewModels;

namespace Vision.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditCardController : ControllerBase
{
  

    [HttpPost(Name = "Scan Card")]
    public async Task<IActionResult> Get([FromForm]FileViewModel model)
    {
        var result = await UltUsage.Process(model.File);
        return Ok(result);
    }
}
