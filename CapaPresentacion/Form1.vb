Imports Entidades
Imports Logica

Public Class Form1

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            Dim articulo As New Articulo() With {.Nombre = tbxNombre.Text, _
                                                 .Codigo = tbxCodigo.Text, _
                                                 .Descripcion = tbxDescrip.Text.ToString(), _
                                                 .IdBodega = tbxBodega.Text}
            Dim logica As New ArticuloBL
            logica.Insertar(articulo)

        Catch ex As Exception

        End Try



    End Sub


    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click

        dgvListar.DataSource = ArticuloBL.Listar()

    End Sub
End Class
