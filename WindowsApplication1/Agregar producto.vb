Imports System.Data.SqlClient
Public Class AgregarProducto
    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(txtprecio.Text) Or String.IsNullOrEmpty(txtstock.Text) Then
                MessageBox.Show("Favor llenar todos los campos")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validarproducto"

                sqlcmd.Parameters.Add(New SqlParameter("@nombreprod", SqlDbType.VarChar, 50)).Value = txtnombre.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("El producto está registrado")
                    txtnombre.Text = ""
                    txtprecio.Text = ""
                    txtstock.Text = ""

                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion

                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresarproducto"

                    sqlcmdd.Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 50)).Value = txtnombre.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@precio", SqlDbType.Money)).Value = txtprecio.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@cantidad", SqlDbType.Int)).Value = txtstock.Text

                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Registro guardado con éxito")

                    txtprecio.Text = ""
                    txtstock.Text = ""

                End If
            End If

        Catch ex As Exception
            MsgBox("Revise los datos", vbCritical)
        End Try

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub
End Class