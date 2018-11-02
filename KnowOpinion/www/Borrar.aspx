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
        Encuestas Disponibles:<asp:Label ID="lblListaEncuestas" runat="server"></asp:Label>
        <br />
        Escriba la encuesta que desee:<asp:TextBox ID="txtEncuestaSeleccionada" runat="server" MaxLength="15"></asp:TextBox>
        <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" Text="Seleccionar" />
        <br />
        <br />
        Descripcion de la encuesta:<asp:Label ID="lblPregunta" runat="server" Width="67%" EnableTheming="True"></asp:Label>
                <br />
        <br />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnBorrar" runat="server" Height="10%" Text="Borrar" Width="10%" OnClick="btnBorrar_Click" />
    </form>
</body>
</html>
