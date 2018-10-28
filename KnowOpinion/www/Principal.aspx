<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="www.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 241px;
        }
        .auto-style2 {
            width: 237px;
        }
        .auto-style3 {
            width: 222px;
        }
        .auto-style4 {
            width: 63%;
            margin-left: 300px;
        }
        .auto-style6 {
            height: 29px;
        }
        .auto-style7 {
            width: 210px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-align: center;">Bienvenido a EncuestasUBU</h1>
        <div style="text-align: center;">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar sesión" />
        </div>
        <br />
        <br />
        Seleccione la encuesta:<asp:DropDownList ID="ListaEncuestaActivas" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <table class="auto-style4">
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblPregunta" runat="server" Text="Descripcion" Width="92%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                    <br />
                    <asp:ImageButton ID="Boton1" runat="server" OnClick="ImageButton1_Click" Height="200px" ImageUrl="./Imagenes/1.png" Width="200px" ImageAlign="Middle" />
                </td>
                <td class="auto-style2">
                    <br />
                    <br />
                    <asp:ImageButton ID="Boton2" runat="server" Height="200px" ImageUrl="./Imagenes/2.png" Width="200px" ImageAlign="Middle" />
                </td>
                <td class="auto-style3">
                    <br />
                    <br />
                    <asp:ImageButton ID="Boton3" runat="server" Height="200px" ImageUrl="./Imagenes/3.png" Width="200px" ImageAlign="Middle" />
                </td>
                <td class="auto-style7">
                    <br />
                    <br />
                    <asp:ImageButton ID="Boton4" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="./Imagenes/4N.png" Width="200px" />
                    <br />
                </td>
                <td>
                    <br />
                    <br />
                    <asp:ImageButton ID="BotonAdd" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="./Imagenes/add.png" OnClick="BotonAdd_Click" Width="200px" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <br />
                    <br />
                    Introduce comentario (opcional):</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="5">
                    <asp:TextBox ID="tdxcomentario" runat="server" TextMode="MultiLine" Width="92%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="5">
                    <br />
                    <br />
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
