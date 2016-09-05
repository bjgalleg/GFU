Imports System.Data.SqlClient
Public Class Modificarproyecto
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
            sqlcmd.CommandText = "modificarproyecto"
            sqlcmd.Parameters.Add(New SqlParameter("@nombre", SqlDbType.Text)).Value = txtproyecto.Text
            sqlcmd.Parameters.Add(New SqlParameter("@comunidad", SqlDbType.Text)).Value = txtcomunidad.Text
            sqlcmd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.Text)).Value = txttipo.Text
            sqlcmd.Parameters.Add(New SqlParameter("@fecha_inicio", SqlDbType.Date)).Value = finicio.Text
            sqlcmd.Parameters.Add(New SqlParameter("@fecha_final", SqlDbType.Date)).Value = ffinal.Text
            sqlcmd.Parameters.Add(New SqlParameter("@dptoID", SqlDbType.Text)).Value = cmbdpto.Text
            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()

            MsgBox("Persona Modificada")
            txtproyecto.Text = " "
            txtcomunidad.Text = " "
            txttipo.Text = " "
            finicio.Text = " "
            ffinal.Text = " "
            cmbdpto.Text = " "
        Catch ex As Exception
            MsgBox("Por favor llene todos los datos")
        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            If txtbuscar.Text = "" Then
                MsgBox("Por favor seleccione un proyecto")
            Else

                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()

                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validar_Proyecto"

                cmd.Parameters.Add(New SqlParameter("@nombreproyecto", SqlDbType.Text)).Value = txtbuscar.Text

                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("El proyecto no está registrado")
                    txtbuscar.Text = ""
                Else
                    Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    Dim cmdd As New SqlCommand
                    conn.Open()
                    cmdd.Connection = conn
                    cmdd.CommandType = CommandType.StoredProcedure
                    cmdd.CommandText = "buscarproyecto"
                    cmdd.Parameters.Add(New SqlParameter("@nombreproyecto", SqlDbType.Text)).Value = txtbuscar.Text
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter

                    da.SelectCommand = cmdd
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        txtproyecto.Text = dt.Rows(0)(1)
                        txtcomunidad.Text = dt.Rows(0)(2)
                        txttipo.Text = dt.Rows(0)(3)
                        finicio.Text = dt.Rows(0)(4)
                        ffinal.Text = dt.Rows(0)(5)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class