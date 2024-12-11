using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szotanulo_alkalmazas
{
    internal class Szo
    {
        string magyarSzo, angolSzo;

        public Szo(string sor)
        {
            var mezo = sor.Split(" - ");
            this.angolSzo = mezo[0];
            this.magyarSzo = mezo[1];
        }

        public string MagyarSzo { get => magyarSzo; set => magyarSzo = value; }
        public string AngolSzo { get => angolSzo; set => angolSzo = value; }
    }
}
