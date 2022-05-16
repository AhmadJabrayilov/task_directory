using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_file.Models
{
    class Department
    {
     
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
