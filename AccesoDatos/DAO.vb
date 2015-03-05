Imports Entidades
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Linq
Imports System.Collections.Generic

Public Class DAO

    Public Sub Insertar(ByVal newArticulo As Articulo)


        Using conn As New SqlConnection(My.Settings.InventarioConnectionString)

            Dim query As String = "INSERT INTO Articulos (Nombre, Codigo, Descripcion, IdBodega) VALUES (@Nombre, @Codigo, @Descripcion, @IdBodega)"
            Dim command As New SqlCommand(query, conn)
            command.Parameters.AddWithValue("Nombre", newArticulo.Nombre)
            command.Parameters.AddWithValue("Codigo", newArticulo.Codigo)
            command.Parameters.AddWithValue("Descripcion", newArticulo.Descripcion)
            command.Parameters.AddWithValue("IdBodega", newArticulo.IdBodega)

            conn.Open()
            command.ExecuteNonQuery()


        End Using

    End Sub


    Public Shared Function Listar() As List(Of Articulo)

        Using conn As New SqlConnection(My.Settings.InventarioConnectionString)
            Dim lista As New List(Of Articulo)
            Dim sql As String = "SELECT * FROM Articulos"

            Dim command As New SqlCommand(sql, conn)
            conn.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()
                lista.Add(loadProductos(reader))
            End While

            Return lista
        End Using

    End Function

    Private Shared Function loadProductos(reader As IDataReader) As Articulo

        Dim articulo As New Articulo()
        articulo.Nombre = Convert.ToString(reader("Nombre"))
        articulo.Codigo = Convert.ToInt32(reader("Codigo"))
        articulo.Descripcion = Convert.ToString(reader("Descripcion"))
        articulo.IdBodega = Convert.ToInt32(reader("IdBodega"))

        Return articulo

    End Function




End Class
