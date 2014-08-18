Public Class DetallesPersonaje
    Dim imgf As New PictureBox
    Dim imga As New PictureBox
    Dim imgi As New PictureBox
    Private Sub DetallesPersonaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim dt As New DataTable
        dt = Consultar("SELECT * FROM personajes WHERE id_per = " + Principal.modalt.ToString + ";")
        Try
            personaje.Image = Image.FromFile("personajes/" + dt(0)(0).ToString + ".jpg")
        Catch ex As Exception
            personaje.Image = Image.FromFile("personajes/00.jpg")
        End Try
        If dt(0)(1).ToString <> "" Then
            nombre.Text = dt(0)(1).ToString
        ElseIf dt(0)(2).ToString <> "" Then
            nombre.Text = dt(0)(2).ToString
        ElseIf dt(0)(3).ToString <> "" Then
            nombre.Text = dt(0)(3).ToString
        End If
        LabelNombre.Text = dt(0)(1).ToString
        LabelAlias.Text = dt(0)(2).ToString
        LabelApe.Text = dt(0)(3).ToString
        LabelRaza.Text = dt(0)(4).ToString
        Try
            PictureBoxAli.Image = Image.FromFile(dt(0)(5).ToString + ".jpg")
        Catch ex As Exception
            PictureBoxAli.Image = Image.FromFile("neutral.jpg")
        End Try
        LabelAli.Text = dt(0)(5).ToString
        LabelClase.Text = dt(0)(6).ToString

        If dt(0)(7).ToString = "Masculino" Then
            PictureBoxsexo.Image = Image.FromFile("Hombre.png")
        ElseIf dt(0)(7).ToString = "Femenino" Then
            PictureBoxsexo.Image = Image.FromFile("Mujer.png")
        Else
            PictureBoxsexo.Image = Image.FromFile("vacio.png")
        End If
        Labelfecnac.Text = dt(0)(8).ToString
        imgf.Size = New Size(CStr(dt(0)(9) * 15), 19)
        imgf.BackColor = Color.Transparent
        imgf.Image = Image.FromFile("statsico/stat.gif")
        imgf.SizeMode = PictureBoxSizeMode.StretchImage
        PanelFuerza.Controls.Add(imgf)

        imga.Size = New Size(CStr(dt(0)(10) * 15), 19)
        imga.BackColor = Color.Transparent
        imga.Image = Image.FromFile("statsico/stat.gif")
        imga.SizeMode = PictureBoxSizeMode.StretchImage
        PanelAgilidad.Controls.Add(imga)

        imgi.Size = New Size(CStr(dt(0)(11) * 15), 19)
        imgi.BackColor = Color.Transparent
        imgi.Image = Image.FromFile("statsico/stat.gif")
        imgi.SizeMode = PictureBoxSizeMode.StretchImage
        PanelInteligencia.Controls.Add(imgi)

        Try
            PictureBoxUni.Image = Image.FromFile("universos/" + dt(0)(12).ToString + ".jpg")
        Catch ex As Exception
            PictureBoxUni.Image = Image.FromFile("universos/0.jpg")
        End Try
    End Sub

End Class