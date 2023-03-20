using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace NewProject.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpPost("Authenticate")]
    public async Task<IActionResult> Authenticate([FromBody] UserCred usercred)  //creating a method 
    {   
        return Ok();
    }
}