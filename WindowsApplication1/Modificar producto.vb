Imports System.Data.SqlClient
Public Class Modificarproducto
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txttipo_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try


            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()

            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "buscarproducto"
            sqlcmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = txtbuscar.Text

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter

            da.SelectCommand = sqlcmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmbpersona.Text = dt.Rows(0)(1)
                txtnombre.Text = dt.Rows(0)(2)
                txtprecio.Text = dt.Rows(0)(3)
                txtstock.Text = dt.Rows(0)(4)
            Else
                MsgBox("Registro no encontrado")

            End If
        Catch ex As Exception
            MsgBox("Revisar datos")
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "modificarproducto"
            sqlcmd.Parameters.Add(New SqlParameter("@nombre", SqlDbType.Int)).Value = txtnombre.Text
            sqlcmd.Parameters.Add(New SqlParameter("@precio", SqlDbType.Money)).Value = txtprecio.Text
            sqlcmd.Parameters.Add(New SqlParameter("@stock", SqlDbType.Int)).Value = txtstock.Text

            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()

            MsgBox("Porducto Modificado")
            txtnombre.Text = " "
            txtprecio.Text = " "
            txtstock.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class