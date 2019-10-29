<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Filmes.aspx.vb" Inherits="NovaLocadora.Filmes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="GridFilme" runat="server" OnRowCreated="GridFilme_RowCreated" OnRowCommand="GridFilme_RowCommand">
        <Columns>
               <asp:TemplateField>
                   <ItemTemplate>
                       <asp:ImageButton ImageUrl="~/Imagem/edit.png" runat="server" Width="20px" Height="20px" CommandName="edit" CommandArgument="<%# Container.DataItemIndex %>" />
                       <asp:ImageButton ImageUrl="~/Imagem/delete.png" runat="server" Width="20px" Height="20px" CommandName="delete"  CommandArgument="<%# Container.DataItemIndex %>"/>
                   </ItemTemplate>
               </asp:TemplateField> 
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnNovo" runat="server" Text="Novo"  OnClick="btnNovo_Click"/>
</asp:Content>
