Public Class DetallesAventura

    Private Sub DetallesAventura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = Consultar("SELECT * FROM aventuras WHERE id_ave = " + Principal.modalt.ToString + ";")
        Try
            escenario.Image = Image.FromFile("escenarios/" + dt(0)(1).ToString + ".jpg")
        Catch ex As Exception
            escenario.Image = Image.FromFile("escenarios/0.jpg")
        End Try
        nombre.Text = dt(0)(2).ToString
        descripcion.Text = dt(0)(3).ToString

    End Sub
End Class