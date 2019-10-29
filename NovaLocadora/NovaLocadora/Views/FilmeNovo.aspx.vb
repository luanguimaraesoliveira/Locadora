Imports NovaLocadora.DAO

Public Class MFilmeNovo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim dao As New GeneroDAO()
            cboGenero.DataTextField = "Nome"
            cboGenero.DataValueField = "Id"
            cboGenero.DataSource = dao.Items()
            cboGenero.DataBind()
        End If
    End Sub



    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/Filmes.aspx")
    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs)
        Dim id As Integer
        If Request.QueryString("id") <> Nothing Then
            id = Request.QueryString("id")
        End If

        If id = 0 Then
            Dim dvd As New MDVD
            dvd.Nome = txtfilme.Text
            dvd.Id = cboGenero.SelectedValue()
            Dim dao As New FilmeDAO()
            dao.inset(dvd)
            Response.Redirect("/Views/Filmes.aspx")
        Else
            Dim dvd As New MDVD
            dvd.Id = id
            dvd.Nome = txtfilme.Text
            dvd.IDGenero = cboGenero.SelectedValue()
            Dim dao As New FilmeDAO()
            dao.edit(dvd)
            Response.Redirect("/Views/Filmes.aspx")
        End If

    End Sub
End Class