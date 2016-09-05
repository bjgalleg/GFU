Imports System.Data.SqlClient


Public Class Eliminar_proyecto
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As DialogResult
            eliminar = MessageBox.Show("Realmente desea eliminar", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (eliminar = DialogResult.Yes) Then
                Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                connexion.Open()

                Dim sqlcmdd As New SqlCommand
                sqlcmdd.Connection = connexion
                sqlcmdd.CommandType = CommandType.StoredProcedure
                sqlcmdd.CommandText = "eliminarproyecto"
                sqlcmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = cmbeliminarproyecto.Text

                Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()

                MsgBox("Proyecto Eliminado")
                cmbeliminarproyecto.Text = ""
            Else

                MsgBox("Proyecto no Encontrado")
                cmbeliminarproyecto.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSBGDataSet1.PROYECTOS' Puede moverla o quitarla según sea necesario.
        Me.PROYECTOSTableAdapter.Fill(Me.UNIDOSBGDataSet1.PROYECTOS)

    End Sub
End Class