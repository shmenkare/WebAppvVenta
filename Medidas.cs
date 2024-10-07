using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppvVenta
{
    public class Medidas
    {
        public double Alto {get; set;}
        public double Ancho{get; set;}
        public double Peso { get; set; }

        public Medidas() { }

        public Medidas(double alto, double ancho, double peso)
        {
            this.Alto = alto;
            this.Ancho = ancho;
            this.Peso = peso;
        }
    }
}