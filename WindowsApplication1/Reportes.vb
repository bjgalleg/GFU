Public Class Reportes
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub dtdesde_ValueChanged(sender As Object, e As EventArgs) Handles dtdesde.ValueChanged

    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnregresaringreso_Click(sender As Object, e As EventArgs) Handles btnregresaringreso.Click
        My.Forms.Form1.Show()
        My.Forms.Reportes.Close()
    End Sub
End Class