﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    [Table("Profesor")]
    public class Profesor
    {
        public int ProfesorID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string DatumRodjenja { get; set; }
        public string DatumZaposlenja { get; set; }
        public byte[] Slika { get; set; }
        public string JMBG { get; set; }
        public string Ucionica { get; set; }
        public string RadnaPozicija { get; set; }
        public string SigurnosnaRijec { get; set; }
        public int Verifikacija { get; set; }

        public string Spol { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

    }
}
