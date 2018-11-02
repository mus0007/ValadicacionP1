<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="www.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
            width: 557px;
        }
        .auto-style2 {
            width: 1024px;
        }
        .auto-style3 {
            height: 26px;
            width: 262px;
        }
        .auto-style4 {
            width: 262px;
        }
        .auto-style5 {
            width: 557px;
        }
        .auto-style6 {
            height: 68px;
        }
        .auto-style7 {
            height: 26px;
            width: 170px;
        }
        .auto-style8 {
            width: 170px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style2">
            <tr>
                <td colspan="2" class="auto-style6"><h1 style="text-align: center;">Inicio de Sesión</h1></td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                    <br />
                    Cuenta:</td>
                <td class="auto-style7">
                    <br />
                    <br />
                    <asp:TextBox ID="txtcuenta" runat="server" TextMode="Email" OnTextChanged="txtcuenta_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Contraseña:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtcontrena" runat="server" TextMode="Password" OnTextChanged="txtcontrena_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <div style="text-align: center;">
                        <asp:Label ID="lblError1" runat="server" ForeColor="Red"></asp:Label>
                        <asp:Label ID="lblError2" runat="server" ForeColor="Red"></asp:Label>
                        <br />
                    </div>
           
                </td>
                <td class="auto-style8">
                    <br />
                        <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
           
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
