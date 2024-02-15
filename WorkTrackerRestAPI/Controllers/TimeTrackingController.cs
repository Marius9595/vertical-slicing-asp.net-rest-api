using Microsoft.AspNetCore.Mvc;

namespace WorkTrackerRestAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TimeTrackingController : ControllerBase
{
    
    private readonly ILogger<TimeTrackingController> _logger;

    public TimeTrackingController(ILogger<TimeTrackingController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public void Get()
    {

    }
}