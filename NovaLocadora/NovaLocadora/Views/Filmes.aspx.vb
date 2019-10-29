Imports NovaLocadora.DAO

Public Class Filmes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            PopulaGridView()
        End If

    End Sub

    Private Sub PopulaGridView()
        Dim dao As New FilmeDAO
        GridFilme.DataSource = dao.Listagem
        GridFilme.DataBind()
    End Sub

    Protected Sub GridFilme_RowCreated(sender As Object, e As GridViewRowEventArgs)
        If e.Row.Cells.Count > 1 Then
            e.Row.Cells(1).Visible = False
        End If
    End Sub


    Protected Sub btnNovo_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/FilmeNovo.aspx")
    End Sub

    Protected Sub GridFilme_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        Dim dao As New FilmeDAO()
        If e.CommandName.Equals("edit") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim row As GridViewRow = GridFilme.Rows(index)
            Response.Redirect("/Views/FilmeNovo.aspx?id=" & row.Cells(1).Text)
        End If
        If e.CommandName.Equals("delete") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim row As GridViewRow = GridFilme.Rows(index)
            Dim id As Integer = row.Cells(1).Text
            dao.delete(id)
            Response.Redirect("/Views/Filmes.aspx")
        End If
    End Sub
End Class