<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Activar-Desactivar.aspx.cs" Inherits="www.Activar_Desactivar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center;">Activar/Desactivar encuesta</h1>
        </div>
        Seleccione la encuesta:<asp:DropDownList ID="lisActvDesv" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Height="10%" Text="Guardar" Width="10%" />
    </form>
</body>
</html>
