using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
   public class Porsche : Araba
    {
        public Porsche()
        {
            Seri = "GT";
            Model = "911";
            MotorHacmi = 3000;
            MotorGucu = 300;
        }
        public override string Calistir()
        {
            return "Vrom Vrom Vrom";
        }
    }
}
