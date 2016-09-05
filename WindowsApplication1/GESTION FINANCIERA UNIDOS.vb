Imports System.Data.SqlClient
Public Class Form1
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnsalirprograma.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        If String.IsNullOrEmpty(txtcedula.Text) Or String.IsNullOrEmpty(txtusuario.Text) Then

                MessageBox.Show("Favor llenar todos los campos")


            Else

                Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                sqlConn.Open()
                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = sqlConn
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "consultarusuario"

            sqlcmd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtcedula.Text

            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
                If reader.HasRows Then
                    Do While reader.Read()
                    If Trim(reader.GetString(2)) = "Voluntario" Then
                        Menú.Visible = True
                        Label1.Visible = False
                        Label2.Visible = False
                        Label3.Visible = False
                        txtcedula.Visible = False
                        txtusuario.Visible = False
                        btningresar.Visible = False
                        btnlimpiar.Visible = False
                        btnsalir.Visible = False
                        btnsalirprograma.Visible = True
                    ElseIf Trim(reader.GetString(2)) = "Donante" Then
                        Reportes.Show()

                    End If

                    Loop
                Else
                    MsgBox("Verificar usuario", MsgBoxStyle.Critical)
                End If
            End If

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menú.ItemClicked

    End Sub

    Private Sub DEPARTAMENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEPARTAMENTOSToolStripMenuItem.Click

    End Sub

    Private Sub EliminarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDepartamentoToolStripMenuItem.Click
        Eliminardepartamento.Show()
    End Sub

    Private Sub ModificarDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDepartamentosToolStripMenuItem.Click
        Modificardepartamento.Show()
    End Sub

    Private Sub NuevoDepartamentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDepartamentiToolStripMenuItem.Click
        Nuevodepartamento.Show()
    End Sub

    Private Sub IngresarNuevoProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarNuevoProyectoToolStripMenuItem.Click
        Nuevoproyecto.Show()
    End Sub

    Private Sub btnsalirprograma_Click(sender As Object, e As EventArgs) Handles btnsalirprograma.Click
        Menú.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        txtcedula.Visible = True
        txtusuario.Visible = True
        btningresar.Visible = True
        btnlimpiar.Visible = True
        btnsalir.Visible = True
        txtcedula.Text = ""
        txtusuario.Text = ""
    End Sub

    Private Sub IngresarNuevaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarNuevaPersonaToolStripMenuItem.Click
        Ingresarpersonas.Show()
    End Sub

    Private Sub ModificarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPersonaToolStripMenuItem.Click
        Modificarpersonas.Show()
    End Sub

    Private Sub EliminarRegistroPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRegistroPersonaToolStripMenuItem.Click
        Eliminarregistropersona.Show()
    End Sub

    Private Sub RegistrarIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarIngresosToolStripMenuItem.Click
        Ingresos.Show()
    End Sub

    Private Sub RegistrarGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarGastosToolStripMenuItem.Click
        Gastos.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Reportes.Show()
    End Sub

    Private Sub RegistrarProductoNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProductoNuevoToolStripMenuItem.Click
        AgregarProducto.Show()
    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        Modificarproducto.Show()
    End Sub

    Private Sub EliminarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProductoToolStripMenuItem.Click

    End Sub

    Private Sub ModificarDatosProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosProyectoToolStripMenuItem.Click
        Modificarproyecto.Show()
    End Sub

    Private Sub EliminarProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProyectoToolStripMenuItem.Click
        Eliminar_proyecto.Show()
    End Sub

    Private Sub VincularVoluntariosAProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VincularVoluntariosAProyectoToolStripMenuItem.Click
        Form6.Show()
    End Sub
End Class
