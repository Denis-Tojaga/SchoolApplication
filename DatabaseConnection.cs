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
        public static DbSet<Profesor> Profesori { get; set; }
        public static DbSet<Predmet> Predmeti { get; set; }

        public DatabaseConnection() : base("PutanjaDoBaze")
        {
           
        }

        public static void DodajBuiltInPredmete()
        {
            Predmeti.Add(new Predmet()
            {
                //no need for ID because its autoincrement in database
                NazivPredmeta="Programiranje 2",
                GodinaStudija="Prva godina",
                ECTS=7,
                Syllabus=null,
                BrojSatiPredavanja=50,
                BrojSatiVjezbi=20,
                ProsjekOdrzanosti=0,
                Ocjena=8
            });

            Predmeti.Add(new Predmet()
            {
                //no need for ID because its autoincrement in database
                NazivPredmeta = "Matematika 1",
                GodinaStudija = "Prva godina",
                ECTS = 6,
                Syllabus = null,
                BrojSatiPredavanja = 40,
                BrojSatiVjezbi = 30,
                ProsjekOdrzanosti = 0,
                Ocjena = 9
            });

            Predmeti.Add(new Predmet()
            {
                //no need for ID because its autoincrement in database
                NazivPredmeta = "Web razvoj i dizajn",
                GodinaStudija = "Prva godina",
                ECTS = 5,
                Syllabus = null,
                BrojSatiPredavanja = 40,
                BrojSatiVjezbi = 20,
                ProsjekOdrzanosti = 0,
                Ocjena = 10
            });

            Predmeti.Add(new Predmet()
            {
                //no need for ID because its autoincrement in database
                NazivPredmeta = "Baze podataka",
                GodinaStudija = "Druga godina",
                ECTS = 7,
                Syllabus = null,
                BrojSatiPredavanja = 50,
                BrojSatiVjezbi = 25,
                ProsjekOdrzanosti = 0,
                Ocjena = 7
            });

            Predmeti.Add(new Predmet()
            {
                //no need for ID because its autoincrement in database
                NazivPredmeta = "Razvoj softvera 2",
                GodinaStudija = "Treca godina",
                ECTS = 10,
                Syllabus = null,
                BrojSatiPredavanja = 60,
                BrojSatiVjezbi = 35,
                ProsjekOdrzanosti = 0,
                Ocjena = 10
            });
        }

        public static void DodajBuiltInProfesore()
        {
            Profesori.Add(new Profesor()
            {
                //no need for ID because its autoincrement in database
                Ime = "Mohamed",
                Prezime = "Zayat",
                KorisnickoIme = "Mohamed",
                Lozinka = "123123",
                Email = "mohamed.zayat@edu.fit.ba",
                BrojTelefona = "061123123",
                Slika = null,
                DatumRodjenja = "1.1.1990",
                DatumZaposlenja = "1.10.2015",
                JMBG = "01010001400024",
                Ucionica = "Amfiteatar 2"
            });

            Profesori.Add(new Profesor()
            {
                //no need for ID because its autoincrement in database
                Ime = "ProfesorTest",
                Prezime = "ProfesorTest",
                KorisnickoIme = "ProfesorTest",
                Lozinka = "123123",
                Email = "profesor.test@edu.fit.ba",
                BrojTelefona = "051241233",
                Slika = null,
                DatumRodjenja = "1.1.1990",
                DatumZaposlenja = "1.1.2020",
                JMBG = "0141113333024",
                Ucionica = "Ucionica 1"
            });
        }
    }
}
