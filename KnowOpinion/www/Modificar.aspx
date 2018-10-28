<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="www.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center;">Modificar Encuesta</h1>
        </div>
        Seleccione la encuesta:<asp:DropDownList ID="lisModificar" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Descripción de la encuesta:<br />
        <asp:TextBox ID="txtModificarDescripcion" runat="server" MaxLength="100" TextMode="MultiLine" Width="50%"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnModificar" runat="server" Height="10%" Text="Modificar" Width="10%" />
    </form>
</body>
</html>
