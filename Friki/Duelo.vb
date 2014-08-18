Public Class Duelo
    Dim imgf As New PictureBox
    Dim imga As New PictureBox
    Dim imgi As New PictureBox
    Dim imgf2 As New PictureBox
    Dim imga2 As New PictureBox
    Dim imgi2 As New PictureBox
    Private Sub Duelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridViewDuelos.DataSource = Consultar("SELECT * FROM duelo;")
        Dim dt As New DataTable
        dt = Consultar("SELECT id_per,nombre, alias, apellidos from personajes;")
        LabelGanador.Visible = False
        For i = 0 To dt.Rows.Count - 1
            ComboBoxIdPer1.Items.Add(dt(i)(0).ToString)
            ComboBoxIdPer2.Items.Add(dt(i)(0).ToString)
            ComboBoxPer1.Items.Add(dt(i)(1).ToString + " " + dt(i)(2).ToString + " " + dt(i)(3).ToString)
            ComboBoxPer2.Items.Add(dt(i)(1).ToString + " " + dt(i)(2).ToString + " " + dt(i)(3).ToString)
        Next

        dt = New DataTable
        dt = Consultar("SELECT id_ave,nombre from aventuras;")
        For i = 0 To dt.Rows.Count - 1
            ComboBoxIdAve.Items.Add(dt(i)(0).ToString)
            ComboBoxAve.Items.Add(dt(i)(1).ToString)
        Next
        ComboBoxAve.SelectedIndex = 0
        ComboBoxIdPer1.SelectedIndex = 0
        ComboBoxIdPer2.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxIdPer1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdPer1.SelectedIndexChanged
        ComboBoxPer1.SelectedIndex = ComboBoxIdPer1.SelectedIndex
    End Sub

    Private Sub ComboBoxPer1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPer1.SelectedIndexChanged
        ComboBoxIdPer1.SelectedIndex = ComboBoxPer1.SelectedIndex
        Dim dt As New DataTable
        dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per from personajes where id_per = " + ComboBoxIdPer1.SelectedItem.ToString + ";")
        imgf.Size = New Size(CStr(dt(0)(0) * 15), 19)
        imgf.BackColor = Color.Transparent
        imgf.Image = Image.FromFile("statsico/stat.gif")
        imgf.SizeMode = PictureBoxSizeMode.StretchImage
        Panelf1.Controls.Add(imgf)

        imga.Size = New Size(CStr(dt(0)(1) * 15), 19)
        imga.BackColor = Color.Transparent
        imga.Image = Image.FromFile("statsico/stat.gif")
        imga.SizeMode = PictureBoxSizeMode.StretchImage
        Panela1.Controls.Add(imga)

        imgi.Size = New Size(CStr(dt(0)(2) * 15), 19)
        imgi.BackColor = Color.Transparent
        imgi.Image = Image.FromFile("statsico/stat.gif")
        imgi.SizeMode = PictureBoxSizeMode.StretchImage
        Paneli1.Controls.Add(imgi)
        Try
            personaje1.Image = Image.FromFile("personajes/" + dt(0)(3).ToString + ".jpg")
        Catch ex As Exception
            personaje1.Image = Image.FromFile("personajes/0.jpg")
        End Try

        
    End Sub

    Private Sub ComboBoxIdPer2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdPer2.SelectedIndexChanged
        ComboBoxPer2.SelectedIndex = ComboBoxIdPer2.SelectedIndex
    End Sub

    Private Sub ComboBoxPer2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPer2.SelectedIndexChanged
        ComboBoxIdPer2.SelectedIndex = ComboBoxPer2.SelectedIndex
        Dim dt As New DataTable

        dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per from personajes where id_per = " + ComboBoxIdPer2.SelectedItem.ToString + ";")
        imgf2.Size = New Size(CStr(dt(0)(0) * 15), 19)
        imgf2.BackColor = Color.Transparent
        imgf2.Image = Image.FromFile("statsico/stat.gif")
        imgf2.SizeMode = PictureBoxSizeMode.StretchImage
        Panelf2.Controls.Add(imgf2)

        imga2.Size = New Size(CStr(dt(0)(1) * 15), 19)
        imga2.BackColor = Color.Transparent
        imga2.Image = Image.FromFile("statsico/stat.gif")
        imga2.SizeMode = PictureBoxSizeMode.StretchImage
        PanelA2.Controls.Add(imga2)

        imgi2.Size = New Size(CStr(dt(0)(2) * 15), 19)
        imgi2.BackColor = Color.Transparent
        imgi2.Image = Image.FromFile("statsico/stat.gif")
        imgi2.SizeMode = PictureBoxSizeMode.StretchImage
        PanelI2.Controls.Add(imgi2)
        Try
            personaje2.Image = Image.FromFile("personajes/" + dt(0)(3).ToString + ".jpg")
        Catch ex As Exception
            personaje2.Image = Image.FromFile("personajes/0.jpg")
        End Try
    End Sub

    Private Sub ComboBoxAve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxAve.SelectedIndexChanged
        ComboBoxIdAve.SelectedIndex = ComboBoxAve.SelectedIndex
    End Sub

    Private Sub ComboBoxIdAve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdAve.SelectedIndexChanged
        ComboBoxAve.SelectedIndex = ComboBoxIdAve.SelectedIndex
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim modo As String = "Empate"
        Dim dt As New DataTable
        dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per from personajes where id_per = " + ComboBoxIdPer1.SelectedItem.ToString + ";")
        Dim fue1 As Integer = dt(0)(0)
        Dim agi1 As Integer = dt(0)(1)
        Dim int1 As Integer = dt(0)(2)
        Dim media1 As Decimal = (fue1 + agi1 + int1) / 3
        dt = New DataTable
        dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per from personajes where id_per = " + ComboBoxIdPer2.SelectedItem.ToString + ";")
        Dim fue2 As Integer = dt(0)(0)
        Dim agi2 As Integer = dt(0)(1)
        Dim int2 As Integer = dt(0)(2)
        Dim media2 As Decimal = (fue2 + agi2 + int2) / 3
        Dim rd As New Random
        media1 = rd.Next(0, 5) + media1
        media2 = rd.Next(0, 5) + media2
        LabelGanador.Visible = True
        If media1 > media2 Then
            LabelGanador.Text = "Gana " + ComboBoxPer1.SelectedItem.ToString
            modo = "Victoria1"
        ElseIf media2 > media1 Then
            LabelGanador.Text = "Gana " + ComboBoxPer2.SelectedItem.ToString
            modo = "Victoria2"
        Else
            LabelGanador.Text = "Empate!"
            modo = "Empate"
        End If
        Try
            Ejecutar("INSERT INTO duelo VALUES (" + ComboBoxIdAve.SelectedItem.ToString + "," + ComboBoxIdPer1.SelectedItem.ToString + "," + ComboBoxIdPer2.SelectedItem.ToString + ",'" + DateTimePickerFecha.Value.ToString + "','" + modo.ToString + "');")
            DataGridViewDuelos.DataSource = Consultar("SELECT * FROM duelo;")
            MsgBox("Duelo guardado")
        Catch ex As Exception
            MsgBox("Ya existe")
        End Try
       

    End Sub
End Class