Imports System.Data.SqlClient
Public Class Modificarpersonas
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try


            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()

            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "buscarusuario"
            sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtbuscar.Text

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter

            da.SelectCommand = sqlcmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtnombre.Text = dt.Rows(0)(1)
                cmbtipo.Text = dt.Rows(0)(2)
                txttelefono.Text = dt.Rows(0)(3)
                txtdireccion.Text = dt.Rows(0)(4)
                txtemail.Text = dt.Rows(0)(5)
                fecha.Value = dt.Rows(0)(6)
                cmbdpto.Text = dt.Rows(0)(7)
                txtuniversidad.Text = dt.Rows(0)(8)
                txtcarrera.Text = dt.Rows(0)(9)
                cmbestado.Text = dt.Rows(0)(10)
            Else
                MsgBox("Persona no existe")

            End If
        Catch ex As Exception
            MsgBox("Revisar datos")
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "modificarusuario"
            sqlcmd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtbuscar.Text
            sqlcmd.Parameters.Add(New SqlParameter("@nombres", SqlDbType.VarChar, 50)).Value = txtnombre.Text
            sqlcmd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cmbtipo.Text
            sqlcmd.Parameters.Add(New SqlParameter("@telefono", SqlDbType.VarChar, 50)).Value = txttelefono.Text
            sqlcmd.Parameters.Add(New SqlParameter("@direccion", SqlDbType.VarChar, 50)).Value = txtdireccion.Text
            sqlcmd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50)).Value = txtemail.Text
            sqlcmd.Parameters.Add(New SqlParameter("@fecha_de_nacimiento", SqlDbType.Date)).Value = fecha.Value
            sqlcmd.Parameters.Add(New SqlParameter("@departamento", SqlDbType.VarChar, 50)).Value = cmbdpto.Text
            sqlcmd.Parameters.Add(New SqlParameter("@universidad", SqlDbType.VarChar, 50)).Value = txtuniversidad.Text
            sqlcmd.Parameters.Add(New SqlParameter("@carrera", SqlDbType.VarChar, 50)).Value = txtcarrera.Text
            sqlcmd.Parameters.Add(New SqlParameter("@estado", SqlDbType.VarChar, 50)).Value = cmbestado.Text

            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
            MsgBox("Persona Modificada")
            txtnombre.Text = " "
            cmbtipo.Text = " "
            txttelefono.Text = " "
            txtdireccion.Text = " "
            txtemail.Text = " "
            fecha.Value = " "
            cmbdpto.Text = " "
            txtuniversidad.Text = " "
            txtcarrera.Text = " "
            cmbestado.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class