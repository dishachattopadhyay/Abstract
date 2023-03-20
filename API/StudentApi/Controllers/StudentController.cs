using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
//using Newtonsoft.Json;
namespace StudentApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class StudentController:ControllerBase{
    
    private static List<Student> Students=new List<Student>(){
            new Student(){
                Id=1,
                Name="Disha",
                Age=92,
                city="Kolkata",
                Password = "wallah",
            }
        };
    [HttpGet]
    [Route("getStudents")]
    public async Task<ActionResult<Student>> GetStudents(){
        
        return Ok(Students);
    }
    [HttpGet]
    [Route("getStudent")]
    public async Task<ActionResult<Student>> GetStudent(int id){
        var student = Students.Find(x=>x.Id==id);
        if(student==null)
            return BadRequest("No student found!");
        return Ok(student);
    }
    [HttpPost]
    [Route("addStudent")]
    public async Task<ActionResult<Student>> AddStudent(Student request){
        Students.Add(request);
        return Ok(Students);
    }
    [HttpPut]
    [Route("updateStudent")]
    public async Task<ActionResult<Student>> UpdateStudent(Student request){
        var student = Students.Find(x=>x.Id==request.Id);
        if(student==null)
            return BadRequest("No student found!");
        student.Name=request.Name;
        student.Age=request.Age;
        student.city=request.city;
          
        return Ok(Students);
    }
    [HttpDelete]
    [Route("deleteStudent")]
    public async Task<ActionResult<Student>> DeleteStudent(int id){
        var student = Students.Find(x=>x.Id==id);
        if(student==null)
            return BadRequest("No student found!");
        Students.Remove(student);
          
        return Ok(Students);
    }
}
