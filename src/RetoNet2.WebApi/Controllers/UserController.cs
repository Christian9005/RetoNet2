using Microsoft.AspNetCore.Mvc;
using RetoNet2.WebApi.Services.Interfaces;

namespace RetoNet2.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IAppServices appServices;

    public UserController(ILogger<UserController> logger, IAppServices appServices)
    {
        _logger = logger;
        this.appServices = appServices;
    }

    [HttpGet("[action]/{cedula}")]
    public string GetCedula(CedulaDto cedula)
    {
        return appServices.GetCedula(cedula);
    }
}
