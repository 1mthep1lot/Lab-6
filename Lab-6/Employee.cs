using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    //Class that represents one Employee.
    internal class Employee 
    {
        //Properties that store the employee´s data.
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Gender { get; set; }  
        public int Salary { get; set; }

        // Constructor that sets all four values when a new Employee is created.

        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }   
    }
}
