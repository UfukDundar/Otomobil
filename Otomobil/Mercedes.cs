using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
    public class Mercedes:Araba
    {
        public Mercedes()
        {
            Seri = "C";
            Model = "180";
            MotorHacmi = 4000;
            MotorGucu = 350;
        }
        public override string Calistir()
        {
            return "vUUU vUU";
        }
    }
}
