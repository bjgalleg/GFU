Imports System.Data.SqlClient
Module CONEXIONUNIDOS
    Public sqlconn As New SqlConnection
    Public Sub crearconexion()
        sqlconn.ConnectionString = "Data Source=USUARIO\SQLEXPRESS;Initial Catalog=UNIDOSBG;Integrated Security=True"
        sqlconn.Open()
    End Sub

    Public Sub CerrarConexion()
        sqlconn.Close()
    End Sub
End Module
