<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Borrar.aspx.cs" Inherits="www.Borrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center;">Borrar Encuesta</h1>
        </div>
        Seleccione la encuesta:<asp:DropDownList ID="lisBorrar" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnBorrar" runat="server" Height="10%" Text="Borrar" Width="10%" />
    </form>
</body>
</html>
