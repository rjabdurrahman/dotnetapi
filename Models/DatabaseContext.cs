using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public List<User> getUsers () => Users.ToList();

        public List<Doctor> getDoctors() => Doctors.ToList();

        public void AddUser(User user)
        { 
            Users.Add(user);
            this.SaveChanges();
            return;
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            this.SaveChanges();
            return;
        }
    }
}