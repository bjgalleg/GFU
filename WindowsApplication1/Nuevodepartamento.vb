Imports System.Data.SqlClient

Public Class Nuevodepartamento
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If String.IsNullOrEmpty(txtnombredpto.Text) Or String.IsNullOrEmpty(txtfunciones.Text) Then
                MessageBox.Show("Favor llenar todos los campos")

            Else
            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validardepartamento"

                sqlcmd.Parameters.Add(New SqlParameter("@DptoID", SqlDbType.VarChar, 20)).Value = txtnombredpto.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("El departamento ya está registrado ")
                    txtnombredpto.Text = " "
                    txtfunciones.Text = " "

                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()
                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "nuevodepartamento"

                    sqlcmdd.Parameters.Add(New SqlParameter("@DptoID", SqlDbType.VarChar, 20)).Value = txtnombredpto.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@funcion", SqlDbType.VarChar, 50)).Value = txtfunciones.Text


                    Dim read As SqlDataReader

                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Departamento registrado exitosamente")
                    txtnombredpto.Text = " "
                    txtfunciones.Text = " "
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub
End Class