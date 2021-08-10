<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Test.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label3" runat="server" Text="Iniciar Sesión" ForeColor="Red"></asp:Label>
            <br />
           
            <table>
                 <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_usuario" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_contresena" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btn_Inicio" runat="server" Text="Ingresar" OnClick="btn_Inicio_Click"/>
                        
                    </td>
                </tr>
            </table>

            <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="linkRegistrarse" runat="server" OnClick="linkRegistrarse_Click">Registrarse</asp:LinkButton>

        </div>
    </form>
</body>
</html>
