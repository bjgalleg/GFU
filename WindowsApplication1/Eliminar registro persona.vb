Imports System.Data.SqlClient
Public Class Eliminarregistropersona
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As DialogResult
            eliminar = MessageBox.Show("Realmente desea eliminar", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (eliminar = DialogResult.Yes) Then

                Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                sqlConn.Open()
                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = sqlConn
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_cedula1"
                sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtced.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "eliminarusuario"
                    sqlcmdd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtced.Text

                    Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()

                    MsgBox("Usuario Eliminado")
                Else

                    MsgBox("Usuario no Encontrado")
                End If

                txtced.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub
End Class