Public Class DetallesEscenario

    Private Sub DetallesEscenario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = Consultar("SELECT * FROM escenarios WHERE id_esc = " + Principal.modalt.ToString + ";")
        Try
            escenario.Image = Image.FromFile("escenarios/" + dt(0)(0).ToString + ".jpg")
        Catch ex As Exception
            escenario.Image = Image.FromFile("escenarios/00.jpg")
        End Try
        nombre.Text = dt(0)(1).ToString
        maxima.Text = "Tiene una población máxima de " + dt(0)(2).ToString + " habitantes."
        poblacion.Text = "Tiene una población de " + dt(0)(3).ToString + " habitantes."
        If dt(0)(4) = 1 Then
            esplaneta.Text = "Es un planeta"
        Else
            esplaneta.Text = "No es un planeta"
        End If
        Try
            padre.Image = Image.FromFile("escenarios/" + dt(0)(5).ToString + ".jpg")
        Catch ex As Exception
            padre.Image = Image.FromFile("escenarios/00.jpg")
        End Try
        Try
            PictureBoxuni.Image = Image.FromFile("universos/" + dt(0)(6).ToString + ".jpg")
        Catch ex As Exception
            PictureBoxuni.Image = Image.FromFile("universos/0.jpg")
        End Try
    End Sub
End Class