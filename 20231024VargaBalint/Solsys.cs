using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231024VargaBalint
{
    internal class Solsys
    {
        public string BolygoNev { get; set; }
        public int HoldSzam { get; set; }
        public double Arany { get; set; }

        public Solsys(string s)
        {
            var v = s.Split(';');
            this.BolygoNev = v[0];
            this.HoldSzam = int.Parse(v[1]);
            this.Arany = double.Parse(v[2]);
        }
    }
    
}
