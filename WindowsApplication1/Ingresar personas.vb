Imports System.Data.SqlClient
Public Class Ingresarpersonas
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSDataSet.DEPARTAMENTO' Puede moverla o quitarla según sea necesario.
        Me.DEPARTAMENTOTableAdapter.Fill(Me.UNIDOSDataSet.DEPARTAMENTO)

    End Sub

    Private Sub txtcedula_TextChanged(sender As Object, e As EventArgs) Handles txtcedula.TextChanged

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If String.IsNullOrEmpty(txtcedula.Text) Or String.IsNullOrEmpty(cmbestado.Text) Or String.IsNullOrEmpty(cmbtipo.Text) Or
                String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(fecha.Text) Then

                MessageBox.Show("Favor llenar los campos obligatorios")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_cedula1"

                sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtcedula.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("La persona ya está registrada ")
                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    cmbtipo.Text = ""
                    txttelefono.Text = ""
                    txtdireccion.Text = ""
                    txtemail.Text = ""
                    fecha.Text = ""
                    cmbdpto.Text = ""
                    txtuniversidad.Text = ""
                    txtcarrera.Text = ""
                    cmbestado.Text = ""

                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion

                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresarusuario"

                    sqlcmdd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtcedula.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@nombres", SqlDbType.VarChar, 50)).Value = txtnombre.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cmbtipo.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@telefono", SqlDbType.VarChar, 50)).Value = txttelefono.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@direccion", SqlDbType.VarChar, 50)).Value = txtdireccion.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50)).Value = txtemail.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@fecha_de_nacimiento", SqlDbType.Date)).Value = fecha.Value
                    sqlcmdd.Parameters.Add(New SqlParameter("@departamento", SqlDbType.VarChar, 50)).Value = cmbdpto.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@universidad", SqlDbType.VarChar, 50)).Value = txtuniversidad.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@carrera", SqlDbType.VarChar, 50)).Value = txtcarrera.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@estado", SqlDbType.VarChar, 50)).Value = cmbestado.Text


                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Persona Registrada")

                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    cmbtipo.Text = ""
                    txttelefono.Text = ""
                    txtdireccion.Text = ""
                    txtemail.Text = ""
                    fecha.Text = ""
                    cmbdpto.Text = ""
                    txtuniversidad.Text = ""
                    txtcarrera.Text = ""
                    cmbestado.Text = ""

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