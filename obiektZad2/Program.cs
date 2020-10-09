using System;

namespace obiektZad2
{   class Osoba
    {
        protected string imie;
        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
        }
        protected string nazwisko;
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }
        protected string dataUrodzenia;
        public string DataUrodzenia
        {
            get
            {
                return dataUrodzenia;
            }
            set
            {
                dataUrodzenia = value;
            }
        }

        public  Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Nazwisko: "+ nazwisko);
            Console.WriteLine("Data Urodzenia: " + dataUrodzenia);
        }
    }

    class Student: Osoba
    {
        private int rok;
        public int Rok
        {
            get
            {
                return rok;
            }
            set
            {
                rok = value;
            }
        }

        private int grupa;
        public int Grupa
        {
            get
            {
                return grupa;
            }
            set
            {
                grupa = value;
            }
        }
        private int nrIndeksu;
        public int NrIndeksu
        {
            get
            {
                return nrIndeksu;
            }
            set
            {
                nrIndeksu = value;
            }
        }
        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_):
            base(imie_, nazwisko_, dataUrodzenia_) 
        {
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data Urodzenia: " + dataUrodzenia);
            Console.WriteLine("rok: " + rok);
            Console.WriteLine("grupa: " + grupa);
            Console.WriteLine("Nr Indeksu: " + nrIndeksu);
            
        }
    }
    class Pilkarz: Osoba
    {
        private string pozycja;
        public string Pozycja
        {
            get
            {
                return pozycja;
            }
            set
            {
                pozycja = value;
            }
        }

        private string klub;
        public string Klub
        {
            get
            {
                return klub;
            }
            set
            {
                klub = value;
            }
        }

        private int liczbaGoli;
        public int LiczbaGoli
        {
            get
            {
                return liczbaGoli;
            }
            set
            {
                liczbaGoli = value;
            }
        }

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_):
            base(imie_, nazwisko_, dataUrodzenia_)
        {
            pozycja = pozycja_;
            klub = klub_;       
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data Urodzenia: " + dataUrodzenia);
            Console.WriteLine("pozycja: " + pozycja);
            Console.WriteLine("klub: " + klub);
            Console.WriteLine("Liczba goli: " + liczbaGoli);
        }
        public void StrzelGola()
        {
            liczbaGoli = liczbaGoli + 1;

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");

            o.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "Fc Politechnika");

            s.WypiszInfo();
            p.WypiszInfo();

            ((Pilkarz)o3).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o3.WypiszInfo();
            p.WypiszInfo();

            Console.ReadKey();
        }
    }
}
