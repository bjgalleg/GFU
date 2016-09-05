Imports System.Data.SqlClient
Public Class Modificardepartamento
    Private Sub Modificardepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "modificardepartamento"
            sqlcmd.Parameters.Add(New SqlParameter("@nombre", SqlDbType.Text)).Value = cmbdpto.Text
            sqlcmd.Parameters.Add(New SqlParameter("@funcion", SqlDbType.Text)).Value = txtfunciones.Text
            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()

            MsgBox("Departamento Modificado")
            cmbdpto.Text = " "
            txtfunciones.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btnbusdepart_Click(sender As Object, e As EventArgs) Handles btnbusdepart.Click
        Try

            Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()

            Dim reader As SqlDataReader
                reader = cmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
            If r = False Then
                MessageBox.Show("El proyecto no está registrado")
                cmbdpto.Text = ""
            Else
                Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmdd As New SqlCommand
                conn.Open()
                cmdd.Connection = conn
                cmdd.CommandType = CommandType.StoredProcedure
                cmdd.CommandText = "validardepartamento"
                cmdd.Parameters.Add(New SqlParameter("@dptoID", SqlDbType.Text)).Value = cmbdpto.Text
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter

                da.SelectCommand = cmdd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    txtfunciones.Text = dt.Rows(0)(2)

                End If

            End If
        Catch ex As Exception
            MsgBox("Revisar datos", vbCritical)
        End Try
    End Sub
End Class