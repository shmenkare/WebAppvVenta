using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppvVenta
{
    public class Producto
    {
        private string nombre;
        private double precio;
        private Medidas medidas;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Medidas Medidas
        {
            get { 
                //comprobar que medidas este inicializado antes de devolverlo
                //si no esta se inicializa
                if(medidas== null)
                {
                    medidas = new Medidas();
                }
                return medidas;
            }

            set { medidas = value; }

        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        

            public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Producto(){}
        
        public Producto(string nombre, double precio)
        {
            this.Precio = precio;
            this.Nombre = nombre;

            //Medidas no se inicializa aqui, sinoq  ie se implementa la inicializacion de la propiedad
        }

        public Producto(string nombre, double precio, Medidas medidas)
        {
            this.Precio = precio;
            this.Nombre = nombre;
            this.Medidas= medidas;
        }

    }
}