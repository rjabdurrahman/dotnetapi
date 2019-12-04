using System;
using System.ComponentModel.DataAnnotations;


namespace webapi.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }
}
