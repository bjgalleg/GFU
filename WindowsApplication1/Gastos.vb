Imports System.Data.SqlClient
Public Class Gastos
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If String.IsNullOrEmpty(cmbsubtipo.Text) Or String.IsNullOrEmpty(fecha.Text) Or String.IsNullOrEmpty(txtmonto.Text) Then

                MessageBox.Show("Falta llenar campos obligatorios")


            Else

                Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                connexion.Open()
                Dim sqlcmdd As New SqlCommand
                sqlcmdd.Connection = connexion
                sqlcmdd.CommandType = CommandType.StoredProcedure
                sqlcmdd.CommandText = "INGRESOMOVIMIENTO"
                sqlcmdd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = txttipo.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@subtipo", SqlDbType.VarChar, 50)).Value = cmbsubtipo.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@proyectoID", SqlDbType.VarChar, 50)).Value = cmbproyecto.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@fecha", SqlDbType.Date)).Value = fecha.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@detalle", SqlDbType.VarChar, 50)).Value = txtdetalle.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@monto", SqlDbType.Int)).Value = txtmonto.Text

                Dim read As SqlDataReader
                read = sqlcmdd.ExecuteReader
                MessageBox.Show("La transaccion fue registrado de manera exitosa")
                read.Close()
                cmbsubtipo.Text = ""
                cmbproyecto.Text = ""
                fecha.Value = ""
                txtdetalle.Text = ""
                txtmonto.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub
End Class