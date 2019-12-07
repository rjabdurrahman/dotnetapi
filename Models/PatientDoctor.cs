using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class PatientDoctor
    {
        [Key]
        public int AppoinmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string Problem { get; set; }
        public string Prescription { get; set; }
        public string Name { get; set; }
        public int Specialist { get; set; }
        public string Institution { get; set; }
        public string Mobile { get; set; }
    }
}
