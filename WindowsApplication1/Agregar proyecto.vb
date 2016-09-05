Imports System.Data.SqlClient
Public Class Nuevoproyecto
    Private Sub Nuevoproyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSBGDataSet4.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
        Me.DEPARTAMENTOSTableAdapter.Fill(Me.UNIDOSBGDataSet4.DEPARTAMENTOS)

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click


        Try
            If String.IsNullOrEmpty(txtnombreproy.Text) Or String.IsNullOrEmpty(txtcomunidad.Text) Or
                String.IsNullOrEmpty(cmbtipo.Text) Or String.IsNullOrEmpty(finicio.Text) Or String.IsNullOrEmpty(ffinal.Text) Then

                MessageBox.Show("Favor llenar todos los campos")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_Proyecto"

                sqlcmd.Parameters.Add(New SqlParameter("@nombreproyecto", SqlDbType.VarChar, 50)).Value = txtnombreproy.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("El Proyecto ya está registrado ")
                    txtnombreproy.Text = ""
                    txtcomunidad.Text = ""
                    cmbtipo.Text = ""
                    finicio.Text = ""
                    ffinal.Text = ""
                    cmbdpto.Text = " "


                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()
                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresarproyectos"

                    sqlcmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txtnombreproy.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Comunidad", SqlDbType.VarChar, 50)).Value = txtcomunidad.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar, 50)).Value = cmbtipo.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Fecha_inicio", SqlDbType.Date)).Value = finicio.Value
                    sqlcmdd.Parameters.Add(New SqlParameter("@Fecha_final", SqlDbType.Date)).Value = ffinal.Value
                    sqlcmdd.Parameters.Add(New SqlParameter("@dpto", SqlDbType.VarChar, 20)).Value = cmbdpto.Text

                    Dim read As SqlDataReader

                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Proyecto registrado exitosamente")
                    txtcomunidad.Text = ""
                    cmbtipo.Text = ""
                    txtnombreproy.Text = ""
                    finicio.Text = ""
                    ffinal.Text = ""
                    cmbdpto.Text = " "
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Nuevoproyecto.Close()
        My.Forms.Form1.Show()
    End Sub
End Class