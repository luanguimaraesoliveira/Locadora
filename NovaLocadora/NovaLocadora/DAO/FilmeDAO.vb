Imports System.Data.SqlClient

Namespace DAO

    Public Class FilmeDAO

        Public Shared strSql As String = "Server=PCAZURRA-047\SQLEXPRESS;Database=Locadora; user id=sa; password=@zurra77;"

        Function Listagem() As List(Of MApresentacao)
            Dim objconn As New SqlConnection(strSql)
            objconn.Open()

            Dim sql As String = "select  Filme.ID, Filme.NomeFilme, Genero.NomeGenero from Filme Inner join Genero On Filme.Idgenero = Genero.ID"
            Dim cmd As New SqlCommand(sql, objconn)
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()
            Dim filmes As New List(Of MApresentacao)

            While sqlread.Read
                Dim filme As New MApresentacao()
                filme.Id = Integer.Parse(sqlread.Item(0).ToString)
                filme.Nome = sqlread.Item(1).ToString
                filme.NomeGenero = sqlread.Item(2).ToString
                filmes.Add(filme)
            End While

            Return filmes
        End Function

        Public Sub inset(ByVal dvd As MDVD)
            Dim objconn As New SqlConnection(strSql)
            objconn.Open()

            Dim sql As String = "insert into Filme (NomeFilme, IdGenero) values (@nome, @IdGenero)"
            Dim objcmd As New SqlCommand(sql, objconn)

            objcmd.Parameters.AddWithValue("@nome", dvd.Nome)
            objcmd.Parameters.AddWithValue("@IdGenero", dvd.Id)
            objcmd.ExecuteNonQuery()
        End Sub

        Public Sub edit(ByVal dvd As MDVD)
            Dim objconn As New SqlConnection(strSql)
            objconn.Open()
            Dim sql As String = "UPDATE Filme set NomeFilme = @Nome, IdGenero = @IdGenero where ID = @Id"
            Dim objcmd As New SqlCommand(sql, objconn)
            objcmd.Parameters.AddWithValue("@ID", dvd.Id)
            objcmd.Parameters.AddWithValue("@Nome", dvd.Nome)
            objcmd.Parameters.AddWithValue("@IdGenero", dvd.IDGenero)
            objcmd.ExecuteNonQuery()
        End Sub

        Public Sub delete(id As Integer)
            Dim objconn As New SqlConnection(strSql)
            objconn.Open()
            Dim sql As String = "Delete from Filme where ID = @Id"
            Dim objcmd As New SqlCommand(sql, objconn)
            objcmd.Parameters.AddWithValue("@Id", id)

            objcmd.ExecuteNonQuery()
        End Sub
    End Class

End Namespace