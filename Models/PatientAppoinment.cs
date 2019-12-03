using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class PatientAppoinment
    {
        [Key]
        public int AppoinmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string Problem { get; set; }
        public string Prescription { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}
