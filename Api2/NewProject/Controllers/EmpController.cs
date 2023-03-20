using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace NewProject.Controllers;
[Authorize]
[ApiController]
[Route("api/[controller]")]
public class EmpController : ControllerBase
{

    private readonly EmpContext _empContext; 
    public EmpController(EmpContext empContext)
    {
        _empContext = empContext;

    }


    [HttpGet]
    [Route("getAllEmpData")]
    public List<EmpData> GetAllEmpData() => _empContext.getEmpData();

    [HttpGet]
    [Route("getEmpData")]
    public async Task<ActionResult<EmpData>> GetEmp(int id){
        var emp = _empContext.EmpDatas.ToList().Find(x=> x.Id==id);
        if(emp==null)
            return BadRequest("No Employee found!");
        return Ok(emp);
    }

    [HttpPost]
    [Route("addEmpData")]
    public async Task<ActionResult<EmpData>> AddPostEmpData(EmpData empData)  //EmpData empData)
    {
        //var newEmp = new EmpData { Name = name, Address = address,Userid=userid, Password=password };

        _empContext.EmpDatas.Add(empData);

        await _empContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAllEmpData), empData);
        // _empContext.EmpDatas.Add(empData);
        // await _empContext.SaveChangesAsync();

        //return Ok(_empContext);

        //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        // return CreatedAtAction(nameof(GetEmpData), new { id = empData.Id }, empData);
    }

    [HttpPut]
    [Route("updateEmpData")]
    public async Task<IActionResult> UpdateEmpData( int id, string name, string address, string userid , string password)
    {
        // var oldStudent = await _context.Students.FindAsync(id);
        var newStudent = new EmpData{ Id=id , Name=name, Address=address,Userid=userid, Password=password};

        _empContext.Entry(newStudent).State = EntityState.Modified;

        try
        {
            await _empContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("ID DOES NOT EXIST!!!");
        }

        return NoContent();
    }

    [HttpDelete]
    [Route("deleteStudent")]
    public async Task<IActionResult> DeleteEmpData(int id)
    {
        var emp = await _empContext.EmpDatas.FindAsync(id);
        if (emp == null)
        {
            return NotFound();
        }

        _empContext.EmpDatas.Remove(emp);
        await _empContext.SaveChangesAsync();

        return NoContent();
    }

};
