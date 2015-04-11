using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5G9
{
    abstract class Trokut
    {
        public Trokut()
        {
            
        }

        public float A
        {
            get;
            set;
        }

        public float B
        {
            get;
            set;
        }

        public float C
        {
            get;
            set;
        }

        public float Gama
        {
            get;
            set;
        }

        public TipTrokuta Tip
        {
            get;
            set;
        }

        public void IzracunajC()
        {
            C = (float)Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2) - (2*A*B*Math.Cos(DegreeToRadian(Gama))));
            
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
