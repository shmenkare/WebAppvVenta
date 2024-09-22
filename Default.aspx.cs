using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebAppvVenta
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ProductosListBox.DataSource = Sistema.ProductosDisponibles();
                ProductosListBox.DataTextField = "Nombre";
                ProductosListBox.DataValueField = "Id";
                ProductosListBox.DataBind();
            }
        }

        protected void RealizarPedido(object sender, EventArgs e)
        {
            //Usamos el metodo ComprarProductos especializado para obtener una lista ListItem
            
            Sistema.ComprarProductos(ProductosListBox.Items);
            Mensaje.Text = @"Su compra ha sido realizada con exito. Nos contactaremos con usted";
        }

        
    }
}