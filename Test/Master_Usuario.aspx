<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Master_Usuario.aspx.cs" Inherits="Test.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   
<body>
            <div>

              <asp:LinkButton OnClick="lbl_clickV">Ver Datos</asp:LinkButton>
                     

             <asp:HiddenField ID="hfContactID" runat="server" />

           
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Nombres"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_contrasena" runat="server" ></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Cedula"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_cedula" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Provincia"></asp:Label>
                    </td>
                    <td colspan="2">
                        
                        <asp:DropDownList ID="dlist_provincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ProvinciaSelecciona"></asp:DropDownList>

                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Ciudad"></asp:Label>
                    </td>
                    <td colspan="2">
                        
                        <asp:DropDownList ID="dlist_ciudad" runat="server" AutoPostBack="True"></asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_correo" runat="server" ></asp:TextBox>
                    </td>
                </tr>

               
                <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btn_save" runat="server" Text="Save" OnClick="btn_save_Click"  />
                        <asp:Button ID="bnt_clear" runat="server" Text="Clear"  />
                    </td>
                </tr>

                  <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        
                        <asp:Label ID="lblSuccefullMessagge" runat="server" Text="" ForeColor="Blue"></asp:Label>

                    </td>
                </tr>

                  <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Label ID="lblerrorMessagge" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
               
            </table>

           

        </div>
  
</body>




</asp:Content>
