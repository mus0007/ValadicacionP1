<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SugerirEncuesta.aspx.cs" Inherits="www.SugerirEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td><h1 style="text-align: center;">Sugerir Encuesta</h1></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        Nombre de la encuesta:<br />
                        <asp:TextBox ID="txtSugerirNombre" runat="server" MaxLength="100" Width="50%" OnTextChanged="txtSugerirNombre_TextChanged"></asp:TextBox>
                        <br />
                        <br />
                        Descripción de la encuesta:<br />
                        <asp:TextBox ID="txtSugerirDescripcion" runat="server" MaxLength="100" Width="50%" TextMode="MultiLine" OnTextChanged="txtSugerirDescripcion_TextChanged"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <div style="text-align: center; margin-top: 5%;">
                            <asp:Button ID="btnEnviar" runat="server" OnClick="enviar" Text="Enviar" Height="5%" Width="5%" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
