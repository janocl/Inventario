Imports Entidades
Imports AccesoDatos

Public Class ArticuloBL


    Public Sub Insertar(ByVal newArticulo As Articulo)

        Try
            Dim dao As New DAO
            dao.Insertar(newArticulo)
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Function Listar() As List(Of Articulo)

        Dim lista As New List(Of Articulo)

        Try
            Dim dao As New DAO
            lista = dao.Listar

        Catch ex As Exception

        End Try

        Return lista

    End Function


End Class
