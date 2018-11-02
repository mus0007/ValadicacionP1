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
        Encuestas Disponibles:<asp:Label ID="lblListaEncuestas" runat="server"></asp:Label>
        <br />
        Escriba la encuesta que desee:<asp:TextBox ID="txtEncuestaSeleccionada" runat="server" MaxLength="15"></asp:TextBox>
        <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" Text="Seleccionar" />
        <br />
        <br />
        Descripción de la encuesta:<br />
        <asp:TextBox ID="txtModificarDescripcion" runat="server" MaxLength="100" TextMode="MultiLine" Width="50%" OnTextChanged="txtModificarDescripcion_TextChanged"></asp:TextBox>
        <br />
        <br />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnModificar" runat="server" Height="10%" Text="Modificar" Width="10%" OnClick="btnModificar_Click" />
    </form>
</body>
</html>
