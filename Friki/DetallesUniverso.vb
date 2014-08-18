Public Class DetallesUniverso

    Private Sub DetallesUniverso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = Consultar("SELECT * FROM universos WHERE id_uni = " + Principal.modalt.ToString + ";")
        Try
            universo.Image = Image.FromFile("universos/" + dt(0)(0).ToString + ".jpg")
        Catch ex As Exception
            universo.Image = Image.FromFile("universos/0.jpg")
        End Try
        nombre.Text = dt(0)(1).ToString
        LabelNombre.Text = dt(0)(1).ToString
        LabelTipo.Text = dt(0)(2).ToString
        Try
            If dt(0)(2).ToString = "Videojuego" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Videojuego.png")
            ElseIf dt(0)(2).ToString = "Realidad" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Realidad.png")
            ElseIf dt(0)(2).ToString = "Cine" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Cine.png")
            ElseIf dt(0)(2).ToString = "Literatura" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Literatura.png")
            ElseIf dt(0)(2).ToString = "Manga" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Manga.png")
            ElseIf dt(0)(2).ToString = "Comic" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Comic.png")
            ElseIf dt(0)(2).ToString = "Televisión" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Television.png")
            ElseIf dt(0)(2).ToString = "Juego de mesa" Then
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Juego.png")
            Else
                PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Television.png")
            End If
        Catch ex As Exception
            PictureBoxTipo.BackgroundImage = Image.FromFile("tipouni/Television.png")
        End Try
       
        
    End Sub
End Class