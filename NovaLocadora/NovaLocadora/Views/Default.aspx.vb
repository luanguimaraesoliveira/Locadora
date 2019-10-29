Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
     

    End Sub

    Protected Sub btnfilme_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/Filmes.aspx")
    End Sub

    Protected Sub btngenero_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Views/Generos.aspx")
    End Sub
End Class