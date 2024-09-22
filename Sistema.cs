using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;

namespace WebAppvVenta
{
    public class Sistema
    {
        public static List<Producto> ProductosDisponibles()
        {
            List<Producto> productos = new List<Producto>();
            DataSet ds = new DataSet();
            ds.ReadXml(ConfigurationManager.AppSettings["XmlDataSource"].ToString());

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                Producto producto = new Producto();
                producto.Id = Convert.ToInt32(dr["Id"]);
                producto.Nombre = Convert.ToString(dr["Nombre"]);
                producto.Precio = Convert.ToDouble(dr["Precio"]);

               //Producto.medidas es un tipo referenciado

                producto.Medidas.Alto = Convert.ToDouble(dr["Alto"]);
                producto.Medidas.Ancho = Convert.ToDouble(dr["Ancho"]);
                producto.Medidas.Peso = Convert.ToDouble(dr["Peso"]);

                //Una vez q ue producto esta cargado, lo agregamos a la coleccion

                productos.Add(producto);
            }

            //Una vez cargada la coleccion la devolvemos

            return productos;
        }

        public static void ComprarProductos(ListItemCollection items)
        {
            foreach(ListItem li in items)
            {
                if(li.Selected)
                {
                    //Crear el producto uando el metodo cargarProducto

                    Producto producto = CargarProducto(Convert.ToInt32(li.Value));

                    //Registrar la compra aqui
                }
            }
         }

        private static Producto CargarProducto(int id)
        {
            //Ob
            List<Producto> productosDelSistema = ProductosDisponibles();

            //Buscar entre los productos del sistema

            foreach(Producto p in productosDelSistema)
            {
                if(p.Id == id)
                {
                    //si lo encuentra...
                    //crear un producto, llenarlo y devolverlo
                    //saliendo del metodo

                    Producto producto = new Producto();
                    producto.Id = id;
                    producto.Nombre = p.Nombre;
                    producto.Precio = p.Precio;
                    producto.Medidas = p.Medidas;

                    return producto;
                }
            }

            return null;
         }
    }
}