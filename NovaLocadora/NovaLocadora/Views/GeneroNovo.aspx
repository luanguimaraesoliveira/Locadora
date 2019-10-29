<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GeneroNovo.aspx.vb" Inherits="NovaLocadora.MGeneroNovoaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Genero"></asp:Label>
    <asp:TextBox ID="txtgenero" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnsalvar" runat="server" Text="Salvar" OnClick="btnsalvar_Click"/>
    <asp:Button ID="btncancelar" runat="server" Text="Cancelar" OnClick="btncancelar_Click"/>
</asp:Content>
