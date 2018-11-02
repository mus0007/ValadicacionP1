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
        Encuestas Activas:<asp:Label ID="lblListaEncuestas" runat="server"></asp:Label>
        <br />
        Encuestas No Activas:<asp:Label ID="lblListaEncuestasNA" runat="server"></asp:Label>
        <br />
        Escriba la encuesta que desee:<asp:TextBox ID="txtEncuestaSeleccionada" runat="server" MaxLength="15"></asp:TextBox>
        <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" Text="Seleccionar" />
        &nbsp;(Realiza la operación contraria al valor que tenía)<br />
        <br />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Height="10%" Text="Activar/Desactivar" Width="10%" OnClick="btnGuardar_Click" />
    </form>
</body>
</html>
