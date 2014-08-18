Public Class Torneo
    Dim estado As Integer = 1
    Dim c1j1 As String
    Dim c1j2 As String
    Dim c2j1 As String
    Dim c2j2 As String
    Dim c3j1 As String
    Dim c3j2 As String
    Dim c4j1 As String
    Dim c4j2 As String
    Dim modo As String
    Private Sub Torneo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelGador2.Text = ""
        LabelGanador1.Text = ""
        LabelGanador3.Text = ""
        LabelGanador4.Text = ""
        Dim dt As New DataTable
        dt = Consultar("SELECT id_ave,nombre from aventuras;")
        For i = 0 To dt.Rows.Count - 1
            ComboBoxIdAve.Items.Add(dt(i)(0).ToString)
            ComboBoxAve.Items.Add(dt(i)(1).ToString)
        Next
        ComboBoxAve.SelectedIndex = 0

        dt = Consultar("SELECT * from personajes;")
        Dim ale As New Random
        

        c1j1 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc1j1.BackgroundImage = Image.FromFile("personajes/" + c1j1 + ".jpg")
        Catch ex As Exception
            PictureBoxc1j1.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c1j2 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc1j2.BackgroundImage = Image.FromFile("personajes/" + c1j2 + ".jpg")
        Catch ex As Exception
            PictureBoxc1j2.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c2j1 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc2j1.BackgroundImage = Image.FromFile("personajes/" + c2j1 + ".jpg")
        Catch ex As Exception
            PictureBoxc2j1.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c2j2 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc2j2.BackgroundImage = Image.FromFile("personajes/" + c2j2 + ".jpg")
        Catch ex As Exception
            PictureBoxc2j2.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c3j1 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc3j1.BackgroundImage = Image.FromFile("personajes/" + c3j1 + ".jpg")
        Catch ex As Exception
            PictureBoxc3j1.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c3j2 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc3j2.BackgroundImage = Image.FromFile("personajes/" + c3j2 + ".jpg")
        Catch ex As Exception
            PictureBoxc3j2.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c4j1 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc4j1.BackgroundImage = Image.FromFile("personajes/" + c4j1 + ".jpg")
        Catch ex As Exception
            PictureBoxc4j1.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try
        c4j2 = ale.Next(0, dt.Rows.Count - 2).ToString
        Try
            PictureBoxc4j2.BackgroundImage = Image.FromFile("personajes/" + c4j2 + ".jpg")
        Catch ex As Exception
            PictureBoxc4j2.BackgroundImage = Image.FromFile("personajes/0.jpg")
        End Try




    End Sub

    Private Sub ComboBoxAve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxAve.SelectedIndexChanged
        ComboBoxIdAve.SelectedIndex = ComboBoxAve.SelectedIndex
    End Sub

    Private Sub ComboBoxIdAve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdAve.SelectedIndexChanged
        ComboBoxAve.SelectedIndex = ComboBoxIdAve.SelectedIndex
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As DataTable
        Dim dt2 As DataTable
        Dim ale As New Random
        Dim media1 As Decimal
        Dim media2 As Decimal
        Dim modo As String

        If estado = 1 Then
            ComboBoxIdAve.Enabled = False
            ComboBoxAve.Enabled = False
            DateTimePicker1.Enabled = False

            LabelRondas.Text = "Semifinal"

            'Combate 1
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c1j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c1j2 + ";")
            media2 = (((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelGanador1.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                PictureBoxc1j2.Image = Image.FromFile("escenarios/x2.png")
                c1j1 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelGanador1.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                PictureBoxc1j1.Image = Image.FromFile("escenarios/x2.png")
                c1j1 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelGanador1.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c1j1 + "," + c1j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")

            'Combate 2
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c2j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c2j2 + ";")
            media2 = (((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelGador2.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                PictureBoxc2j2.Image = Image.FromFile("escenarios/x2.png")
                c1j2 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelGador2.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                PictureBoxc2j1.Image = Image.FromFile("escenarios/x2.png")
                c1j2 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelGador2.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c2j1 + "," + c2j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")

            'Combate 3
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c3j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c3j2 + ";")
            media2 = (((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelGanador3.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                PictureBoxc3j2.Image = Image.FromFile("escenarios/x2.png")
                c2j1 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelGanador3.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                PictureBoxc3j1.Image = Image.FromFile("escenarios/x2.png")
                c2j1 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelGanador3.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c3j1 + "," + c3j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")

            'Combate 4
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c4j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c4j2 + ";")
            media2 = (((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelGanador4.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                PictureBoxc4j2.Image = Image.FromFile("escenarios/x2.png")
                c2j2 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelGanador4.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                PictureBoxc4j1.Image = Image.FromFile("escenarios/x2.png")
                c2j2 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelGanador4.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c4j1 + "," + c4j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")

            PictureBoxsemi1.Visible = True
            PictureBoxsemi2.Visible = True

            Try
                PictureBoxs1j1.BackgroundImage = Image.FromFile("personajes/" + c1j1 + ".jpg")
            Catch ex As Exception
                PictureBoxs1j1.BackgroundImage = Image.FromFile("personajes/0.jpg")
            End Try
            Try
                PictureBoxs1j2.BackgroundImage = Image.FromFile("personajes/" + c1j2 + ".jpg")
            Catch ex As Exception
                PictureBoxs1j2.BackgroundImage = Image.FromFile("personajes/0.jpg")
            End Try
            Try
                PictureBoxs2j1.BackgroundImage = Image.FromFile("personajes/" + c2j1 + ".jpg")
            Catch ex As Exception
                PictureBoxs2j1.BackgroundImage = Image.FromFile("personajes/0.jpg")
            End Try
            Try
                PictureBoxs2j2.BackgroundImage = Image.FromFile("personajes/" + c2j2 + ".jpg")
            Catch ex As Exception
                PictureBoxs2j2.BackgroundImage = Image.FromFile("personajes/0.jpg")
            End Try
        ElseIf estado = 2 Then

            LabelRondas.Text = "Final"

            'Combate 1 semifinal
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c1j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c1j2 + ";")
            media2 = (((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelSG1.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                PictureBoxs1j2.Image = Image.FromFile("escenarios/x2.png")
                c1j1 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelSG1.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                PictureBoxs1j1.Image = Image.FromFile("escenarios/x2.png")
                c1j1 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelSG1.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c1j1 + "," + c1j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")

            'Combate 2 semifinal
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c2j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c2j2 + ";")
            media2 = Math.Round((((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5)))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelSG2.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                PictureBoxs2j2.Image = Image.FromFile("escenarios/x2.png")
                c1j2 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelSG2.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                PictureBoxs2j1.Image = Image.FromFile("escenarios/x2.png")
                c1j2 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelSG2.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c2j1 + "," + c2j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")

            PictureBoxfinal.Visible = True

            Try
                PictureBoxf1.BackgroundImage = Image.FromFile("personajes/" + c1j1 + ".jpg")
            Catch ex As Exception
                PictureBoxf1.BackgroundImage = Image.FromFile("personajes/0.jpg")
            End Try
            Try
                PictureBoxf2.BackgroundImage = Image.FromFile("personajes/" + c1j2 + ".jpg")
            Catch ex As Exception
                PictureBoxf2.BackgroundImage = Image.FromFile("personajes/0.jpg")
            End Try
        ElseIf estado = 3 Then
            'Final 
            dt = New DataTable
            dt = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c1j1 + ";")
            media1 = (((dt(0)(0) + dt(0)(1) + dt(0)(2)) / 3) + ale.Next(0, 5))
            dt2 = New DataTable
            dt2 = Consultar("SELECT fuerza, agilidad, inteligencia, id_per, nombre, alias, apellidos from personajes where id_per = " + c1j2 + ";")
            media2 = (((dt2(0)(0) + dt2(0)(1) + dt2(0)(2)) / 3) + ale.Next(0, 5))
            If media1 > media2 Then
                modo = "Victoria1"
                LabelFinal.Text = "Gana " + dt(0)(4) + " " + dt(0)(5) + " " + dt(0)(6) + "!"
                Try
                    PictureBoxGanador.Image = Image.FromFile("personajes/" + c1j1 + ".jpg")
                Catch ex As Exception
                    PictureBoxGanador.Image = Image.FromFile("personajes/0.jpg")
                End Try
                PictureBoxf2.Image = Image.FromFile("escenarios/x2.png")
                c1j1 = dt(0)(3).ToString
            ElseIf media2 > media1 Then
                modo = "Victoria2"
                LabelFinal.Text = "Gana " + dt2(0)(4) + " " + dt2(0)(5) + " " + dt2(0)(6) + "!"
                Try
                    PictureBoxGanador.Image = Image.FromFile("personajes/" + c1j2 + ".jpg")
                Catch ex As Exception
                    PictureBoxGanador.Image = Image.FromFile("personajes/0.jpg")
                End Try
                PictureBoxf1.Image = Image.FromFile("escenarios/x2.png")
                c1j1 = dt2(0)(3).ToString
            Else
                modo = "Empate"
                LabelFinal.Text = "Empate!"
            End If
            Ejecutar("insert into duelo values(" + ComboBoxIdAve.SelectedItem.ToString + "," + c1j1 + "," + c1j2 + ",'" + DateTimePicker1.Text + "','" + modo + "')")
        Else
            MsgBox("Duelos guardados")
            Me.Close()
        End If
        estado += 1


    End Sub
End Class