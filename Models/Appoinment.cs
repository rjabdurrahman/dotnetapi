using System;

namespace webapi.Models
{
    public class Appoinment
    {
        public int AppoinmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string Problem { get; set; }
        public string Prescription { get; set; }
    }
}
