<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FilmeNovo.aspx.vb" Inherits="NovaLocadora.MFilmeNovo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Filme"></asp:Label>
    <asp:TextBox ID="txtfilme" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Genero"></asp:Label>
    <asp:DropDownList ID="cboGenero" runat="server"></asp:DropDownList>
    <br /><br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
</asp:Content>
