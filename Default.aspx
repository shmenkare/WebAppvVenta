<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppvVenta._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pedidos</title>
    <link rel=Stylesheet href= styleCss.css />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <h1>Pedido de Productos</h1>
    <p>Seleccione el/los productos de la lista y presione
     el boton "Realizar pedido" para continuar</p>

     <asp:Label ID=Label1 runat=server Text="Productos disponibles"></asp:Label>
     <br />
     <asp:ListBox ID= ProductosListBox runat=server SelectionMode=Multiple></asp:ListBox>
     <br />
     <asp:Button ID= SubmitButton runat=server Text="Realizar pedido" />    

    </div>
    </form>
</body>
</html>
