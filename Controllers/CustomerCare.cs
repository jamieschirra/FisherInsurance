using Microsoft.AspNetCore.Mvc;

[Route("claim")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    [Route("fileclaim")]
    public IActionResult FileClaim()
    {
        return Ok("This is for the file claim from the CustomerCareController");
    }
    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is a claim history from the CustomerCareController");
    }
}