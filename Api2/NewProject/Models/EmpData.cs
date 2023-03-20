using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProject.Models;
using Microsoft.EntityFrameworkCore;

namespace NewProject.Models
{
    public class EmpData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Userid { get; set; }
        public string? Password { get; set; }



    
    }
}