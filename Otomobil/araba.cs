using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
    public abstract class Araba
    {
        public string Seri { get; set; }
        public string Model { get; set; }
        public int MotorHacmi { get; set; }
        public int MotorGucu { get; set; }

        public string Yazdir()
        {
        return string.Format("Seri\t: {0} \nModel \t: {1} \nMotorHacmi \t: {2} \nMotor Gücü \t: {3})", Seri, Model,MotorHacmi,MotorGucu);

        }
        public abstract string Calistir();
    }
}
