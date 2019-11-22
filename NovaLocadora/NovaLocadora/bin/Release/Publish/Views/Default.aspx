<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="NovaLocadora._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Locadora</h1> 
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="btnfilme" runat="server" Text="Filmes" OnClick="btnfilme_Click"/>
            <asp:Button ID="btngenero" runat="server" Text="Generos" OnClick="btngenero_Click"/>
        </div>  
    </div>
</asp:Content>
