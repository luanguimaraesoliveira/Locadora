Public Class Generos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Populagridview()
        End If
    End Sub

    Public Sub Populagridview()
        Dim dao As New GeneroDAO()
        GenerosGridView.DataSource = dao.Listagem()
        DataBind()

    End Sub

    Protected Sub btnvoltar_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/default.aspx")
    End Sub

    Protected Sub GenerosGridView_RowCreated(sender As Object, e As GridViewRowEventArgs)
        If e.Row.Cells.Count > 1 Then
            e.Row.Cells(1).Visible = False
        End If
    End Sub

    Protected Sub btnNovo_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/GeneroNovo.aspx")
    End Sub

    Protected Sub GenerosGridView_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        Dim dao As New GeneroDAO()
        If e.CommandName.Equals("edit") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim row As GridViewRow = GenerosGridView.Rows(index)
            Dim id As Integer = row.Cells(1).Text
            Response.Redirect("/Views/GeneroNovo.aspx?id=" & id)
        End If
        If e.CommandName.Equals("delete") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim row As GridViewRow = GenerosGridView.Rows(index)
            Dim id As Integer = row.Cells(1).Text
            dao.Delete(id)
            Response.Redirect("/Views/Generos.aspx")
        End If
    End Sub
End Class