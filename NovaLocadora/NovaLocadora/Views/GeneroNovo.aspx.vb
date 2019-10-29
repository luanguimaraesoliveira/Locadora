
Public Class MGeneroNovoaspx

    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnsalvar_Click(sender As Object, e As EventArgs)
        Dim id As Integer


        If Request.QueryString("id") <> Nothing Then
            id = Request.QueryString("id")
        End If

        If id = 0 Then
            Dim genero As New MGeneros()
            genero.Nome = txtgenero.Text
            Dim dao As New GeneroDAO()
            dao.insert(genero)
        Else
            Dim genero As New MGeneros()
            genero.Id = id
            genero.Nome = txtgenero.Text
            Dim dao As New GeneroDAO()
            dao.edit(genero)
        End If

    End Sub

    Protected Sub btncancelar_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/Generos.aspx")
    End Sub
End Class