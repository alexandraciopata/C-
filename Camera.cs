using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect2
{
    [Serializable]
        public class Camera : ICloneable
        {
            private int nr_paturi;
            private string denumire;
            private int nr_bai;

            public Camera()
            {
                this.nr_paturi = 0;
                this.denumire = "Anonim";
                this.nr_bai = 0;
            }

            public Camera(int nr_paturi, string denumire, int nr_bai)
            {
                this.nr_paturi = nr_paturi;
                this.denumire = denumire;
                this.nr_bai = nr_bai;
            }

            public Camera(Camera camere)
            {
                this.denumire = camere.denumire;
                this.nr_paturi = camere.nr_paturi;
                this.nr_bai = camere.nr_bai;
            }

            public int Nr_paturi
            {
                get { return this.nr_paturi; }
                set { this.nr_paturi = value; }
            }

            public string Denumire
            {
                get { return this.denumire; }
                set { this.denumire = value; }
            }

            public int Nr_bai
            {
                get { return this.nr_bai; }
                set { this.nr_bai = value; }
            }

            public override string? ToString()
            {
                return "Camera " + this.denumire + " are " + this.nr_paturi + " paturi si " + this.nr_bai + " bai.";

            }

            public object Clone()
            {
                //throw new NotImplementedException();
                return this.MemberwiseClone() as Camera;
            }
        }
    }

