using System;
using System.Collections.Generic;
using System.IO;
using Directory_file.Models;
using Newtonsoft.Json;

namespace Directory_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee {
                Age = 25,
                Name = "lorem",
                Surname = "ipsum"
                
            };

            Department department = new Department
            {   
                Id =1,
                Name = "ABC",
                Employees = new List<Employee>
                {
                    employee
                }
            };
            var serialize = JsonConvert.SerializeObject(department);

            using (StreamWriter sr =  new StreamWriter(@"C:\Users\tu25tyfpp\Desktop\6-7_Practic\Directory_file\Directory_file\Data\json1.json") )
            {
                sr.WriteLine(serialize);
            }

            string result;


            using (StreamReader dr = new StreamReader(@"C:\Users\tu25tyfpp\Desktop\6-7_Practic\Directory_file\Directory_file\Data\json1.json"))
            {
                result =dr.ReadToEnd();
            }

            Department deserialize = JsonConvert.DeserializeObject<Department>(result);
            Console.WriteLine(deserialize.Name);
        }

    }
}
