using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Dogadjaj
    {
        public int DogadjajID { get; set; }
        public string DatumDogadjaja { get; set; }
        public string  Ucionica { get; set; }

        public override string ToString()
        {
            return $"{DatumDogadjaja} {Ucionica}";
        }
    }
}
