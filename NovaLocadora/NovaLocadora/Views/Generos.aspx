<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Generos.aspx.vb" Inherits="NovaLocadora.Generos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="GenerosGridView" runat="server" OnRowCreated="GenerosGridView_RowCreated" OnRowCommand="GenerosGridView_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ImageUrl="~/imagem/edit.png" runat="server" CommandName="edit" Width="20px" Height="20px" ToolTip="Editar" CommandArgument="<%# Container.DataItemIndex %>"/>
                    <asp:ImageButton ImageUrl="~/imagem/delete.png" runat="server" CommandName="delete" Width="20px" Height="20px" ToolTip="Editar" CommandArgument="<%# Container.DataItemIndex %>"/>
                    </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click"/>
    <asp:Button ID="btnvoltar" runat="server" Text="Voltar" OnClick="btnvoltar_Click" />
</asp:Content>
