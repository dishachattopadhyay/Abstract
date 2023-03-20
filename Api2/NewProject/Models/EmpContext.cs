using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
namespace NewProject.Models; 
public class EmpContext : DbContext 
{ public EmpContext(DbContextOptions<EmpContext> options) : base(options) 
{

 } 
 public DbSet<EmpData> EmpDatas { get; set; } =null!;

 public List<EmpData> getEmpData() => EmpDatas.ToList();
 }