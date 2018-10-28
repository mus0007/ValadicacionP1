<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="www.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 1115px;
        }
        .auto-style3 {
            height: 26px;
            width: 371px;
        }
        .auto-style8 {
            width: 371px;
            height: 37px;
        }
        .auto-style9 {
            width: 371px;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"><h1 style="text-align: center;">Panel de Control</h1></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="btnadd" runat="server" Height="100%" OnClick="btnadd_Click" Text="Añadir" Width="100%" />
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9">
                        <asp:Button ID="btnborrar" runat="server" Height="100%" OnClick="btnborrar_Click" Text="Borrar" Width="100%" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Button ID="btnmodificar" runat="server" Height="100%" OnClick="btnmodificar_Click" Text="Modificar" Width="100%" />
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8">
                        <asp:Button ID="btnencuesta" runat="server" Height="100%" OnClick="btnencuesta_Click" Text="Activar/Desactivar" Width="100%" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
