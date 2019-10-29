Imports System.Data.SqlClient

Public Class GeneroDAO

    Public Shared strSql As String = "Server=PCAZURRA-047\SQLEXPRESS; Database=Locadora; User Id=sa; Password=@zurra77"

    Function Listagem() As List(Of MGeneros)
        Try

            Dim objconn As New SqlConnection(strSql)
            objconn.Open()

            Dim sql As String = "Select * from Genero"
            Dim objcmd As New SqlCommand(sql, objconn)
            Dim objdataread As SqlDataReader = objcmd.ExecuteReader()
            Dim generos As New List(Of MGeneros)

            While objdataread.Read
                Dim genero As New MGeneros()
                genero.Id = Integer.Parse(objdataread.Item(0).ToString())
                genero.Nome = objdataread.Item(1).ToString()
                generos.Add(genero)
            End While

            Return generos

        Catch ex As Exception
            MsgBox("Erro:", MsgBoxStyle.Critical)
            Return Nothing
        End Try

    End Function

    Public Function Items() As List(Of MGeneros)
        Dim objconn As New SqlConnection(strSql)
        objconn.Open()
        Dim sql As String = "Select * from Genero"
        Dim objcmd As New SqlCommand(sql, objconn)
        Dim objDataRead As SqlDataReader = objcmd.ExecuteReader()
        Dim generos As New List(Of MGeneros)

        While objDataRead.Read
            Dim genero As New MGeneros()
            genero.Id = Integer.Parse(objDataRead.Item(0).ToString)
            genero.Nome = objDataRead.Item(1).ToString
            generos.Add(genero)
        End While

        Return generos

    End Function

    Function insert(ByVal genero As MGeneros)
        Dim objconn As New SqlConnection(strSql)
        objconn.Open()

        Dim sql As String = "Insert into Genero (Nome) values (@nome)"
        Dim objcmd As New SqlCommand(sql, objconn)
        objcmd.Parameters.AddWithValue("@nome", genero.Nome)
        objcmd.ExecuteNonQuery()
        Return genero
    End Function

    Public Function edit(ByVal genero As MGeneros)
        Dim objconn As New SqlConnection(strSql)
        objconn.Open()
        Dim sql As String = "Update Genero set  Nome = @nome where Id = @id"
        Dim objcmd As New SqlCommand(sql, objconn)
        Dim umgenero As New MGeneros()
        objcmd.Parameters.AddWithValue("@id", genero.Id)
        objcmd.Parameters.AddWithValue("@nome", genero.Nome)
        objcmd.ExecuteNonQuery()
        Return umgenero
    End Function
End Class
