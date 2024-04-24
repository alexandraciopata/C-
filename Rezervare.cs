using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect2
{
    [Serializable]
    public class Rezervare : Camera, IComparabil, IRezervare
    {
        private float pret;
        private int nr_nopti;
        private string nume_cazat;

        public Rezervare()
        {
            this.nr_nopti = 0;
            this.pret = 0;
            this.nume_cazat = "Anonim";
        }

        public Rezervare(int nr_paturi, string denumire, int nr_bai, float pret, string nume_cazat, int nr_nopti) : base(nr_paturi, denumire, nr_bai)
        {
            this.pret = pret;
            this.nr_nopti = nr_nopti;
            this.nume_cazat = nume_cazat;
        }

        public float Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        public int Nr_nopti
        {
            get { return this.nr_nopti; }
            set { this.nr_nopti = value; }
        }

        public string Nume_cazat
        {
            get { return this.Nume_cazat; }
            set
            {
                this.Nume_cazat = value;
            }
        }

        public bool Compare(Rezervare r)
        {
            //throw new NotImplementedException();
            if (this.pret < r.pret)
                return false;
            else
                return true;
        }

        public override string? ToString()
        {
            return "Camera are o rezervare pentru " + this.nr_nopti + " nopti la pretul de " + this.pret
                + " pe numele " + this.nume_cazat;
        }

        public void MakeReservation()
        {
            Console.WriteLine("Rezervarea a fost efectuată.");
        }

        public void CancelReservation()
        {
            Console.WriteLine("Rezervarea a fost anulată.");
        }

    }
}
