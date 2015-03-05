Imports Entidades
Imports System.Collections.Generic
Public Interface IDAO

    Sub Insertar(ByVal newArticulo As Articulo)
    Function Listar() As List(Of Articulo)

End Interface
