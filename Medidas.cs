using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppvVenta
{
    public class Medidas
    {
        private double alto;
        private double peso;
        private double ancho;

        public double Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Medidas() { }

        public Medidas(double alto, double ancho, double peso)
        {
            this.Alto = alto;
            this.Ancho = ancho;
            this.Peso = peso;
        }

    }
}