using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    [Table("Student")]
    public class Student
    {
        public int StudentID { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeOca { get; set; }
        public string Email { get; set; }
        public string DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public int Godine { get; set; }
        public byte[] Slika { get; set; }
        public string GodinaStudija { get; set; }


        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
