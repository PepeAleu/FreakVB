Public Class DetallesMonstruo

    Private Sub DetallesMonstruo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = Consultar("SELECT * FROM monstruos WHERE id_mon = " + Principal.modalt.ToString + ";")
        Try
            monstruo.Image = Image.FromFile("monstruos/" + dt(0)(0).ToString + ".jpg")
        Catch ex As Exception
            monstruo.Image = Image.FromFile("monstruos/0.jpg")
        End Try
        nombre.Text = dt(0)(1).ToString
        Try
            PictureBoxColor.Image = Image.FromFile("colores/" + dt(0)(2).ToString + ".png")
        Catch ex As Exception
            PictureBoxColor.Image = Image.FromFile("colores/Incoloro.png")
        End Try

        Try
            PictureBox1.Image = Image.FromFile("dificultades/" + dt(0)(3).ToString + ".png")
        Catch ex As Exception
            PictureBox1.Image = Image.FromFile("dificultades/Baja.png")
        End Try
        Labeldificultad.Text = dt(0)(3)
    End Sub
End Class