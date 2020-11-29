using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Predmet
    {
        public int PredmetID { get; set; }
        public string NazivPredmeta { get; set; }
        public string GodinaStudija { get; set; }
        public int ECTS { get; set; }
        public byte[] Syllabus { get; set; }
        public int BrojSatiPredavanja { get; set; }
        public int BrojSatiVjezbi { get; set; }
        public double ProsjekOdrzanosti { get; set; }
        public int Ocjena { get; set; }
    }
}
