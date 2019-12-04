using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<PatientAppoinment> AppoinmentsAll { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public List<User> getUsers() => Users.ToList();

        public List<Doctor> getDoctors() => Doctors.ToList();
        public List<Appoinment> getAppoinments() => Appoinments.ToList();
        public List<PatientAppoinment> getPAppoinments() => AppoinmentsAll.ToList();
        public List<Employee> getEmployee() => Employees.ToList();

        public void AddUser(User user)
        {
            Users.Add(user);
            this.SaveChanges();
            return;
        }

        public void AddEmployee(Employee em)
        {
            Employees.Add(em);
            this.SaveChanges();
            return;
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            this.SaveChanges();
            return;
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
            this.SaveChanges();
            return;
        }

        public void AddAppoinment(Appoinment appoinment)
        {
            Appoinments.Add(appoinment);
            this.SaveChanges();
            return;
        }
    }
}