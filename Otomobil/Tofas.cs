using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
   public class Tofas :Araba
    {
        public Tofas()
        {
            Seri = "Serçe";
            Model = "Murat 131";
            MotorGucu = 30;
            MotorHacmi = 1400;
        }
        public override string Calistir()
        {
            return "tır tır tır";
        }
    }
}
