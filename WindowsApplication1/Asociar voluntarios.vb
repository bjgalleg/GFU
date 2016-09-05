Imports System.Data.SqlClient
Public Class Form6
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvoluntario.SelectedIndexChanged

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSBGDataSet5.PERSONAS' Puede moverla o quitarla según sea necesario.
        Me.PERSONASTableAdapter.Fill(Me.UNIDOSBGDataSet5.PERSONAS)
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSBGDataSet5.PROYECTOS' Puede moverla o quitarla según sea necesario.
        Me.PROYECTOSTableAdapter.Fill(Me.UNIDOSBGDataSet5.PROYECTOS)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnbuscarvol_Click(sender As Object, e As EventArgs) Handles btnbuscarvol.Click
        Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
        Dim sqlcmd As New SqlCommand
        connexion.Open()
        sqlcmd.Connection = connexion
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "buscarvoluntarios"
        sqlcmd.Parameters.Add(New SqlParameter("@nombreproyecto", SqlDbType.VarChar, 20)).Value = cmbproyecto.Text
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        da.SelectCommand = sqlcmd

        If dt.Rows.Count > 0 Then


        End If


    End Sub
End Class