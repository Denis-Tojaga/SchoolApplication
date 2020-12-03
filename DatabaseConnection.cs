using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class DatabaseConnection : DbContext
    {
        public  DbSet<Profesor> Profesori { get; set; }
        public  DbSet<Predmet> Predmeti { get; set; }
        public  DbSet<Student> Studenti { get; set; }

        public DatabaseConnection() : base("PutanjaDoBaze")
        {
           
        }
    }
}
