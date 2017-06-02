<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="buscar.aspx.cs" Inherits="cinehome.vista.buscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <h1>Buscar pelicula</h1> 


 
	    <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;
                nombre_pelicula&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_p_nombre" runat="server"></asp:TextBox>
                <br />
                <br>
                </br>
            </td>
        </tr>
	
	
	
            <td>
                &nbsp;&nbsp;
                audio&nbsp;&nbsp;
                <asp:TextBox ID="tb_au" runat="server"></asp:TextBox>
                <br>
                <br></br>
                </br>
            </td>
        </tr>
	
	
            <td class="auto-style3">
                &nbsp;&nbsp;
                <br>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="b_buscar" runat="server" OnClick="b_buscar_Click" Text="Buscar" Width="100px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="b_listar" runat="server" Text="Listar" Width="100px" OnClick="b_listar_Click" />
                <br>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
     <br />

     <br />
     <asp:GridView ID="t_pelicula" runat="server" BorderColor="#000000" BorderStyle="Inset">
     </asp:GridView>
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
