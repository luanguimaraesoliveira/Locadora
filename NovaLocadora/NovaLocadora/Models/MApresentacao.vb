﻿Public Class MApresentacao
    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _nome As String
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Private _IdGenete As Integer

    Private _nomeGenero As String
    Public Property NomeGenero() As String
        Get
            Return _nomeGenero
        End Get
        Set(ByVal value As String)
            _nomeGenero = value
        End Set
    End Property


End Class