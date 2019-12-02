using System;

namespace webapi.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialist { get; set; }
        public string Institution { get; set; }
        public string Mobile { get; set; }
    }
}
