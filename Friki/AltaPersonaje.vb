Public Class AltaPersonaje
    Dim fue As Integer = 15
    Dim agi As Integer = 15
    Dim int As Integer = 15
    Dim imgf As New PictureBox
    Dim imga As New PictureBox
    Dim imgi As New PictureBox
    Private Sub AltaPersonaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        imgf.Size = New Size(fue, 19)
        imgf.BackColor = Color.Transparent
        imgf.Image = Image.FromFile("statsico/stat.gif")
        imgf.SizeMode = PictureBoxSizeMode.StretchImage
        PanelFuerza.Controls.Add(imgf)

        imga.Size = New Size(agi, 19)
        imga.BackColor = Color.Transparent
        imga.Image = Image.FromFile("statsico/stat.gif")
        imga.SizeMode = PictureBoxSizeMode.StretchImage
        PanelAgilidad.Controls.Add(imga)

        imgi.Size = New Size(int, 19)
        imgi.BackColor = Color.Transparent
        imgi.Image = Image.FromFile("statsico/stat.gif")
        imgi.SizeMode = PictureBoxSizeMode.StretchImage
        PanelInteligencia.Controls.Add(imgi)

        ComboBoxClases.Items.Add("--")
        Dim clases As New DataTable
        clases = Consultar("select distinct(clase) from personajes;")
        For i = 0 To clases.Rows.Count - 1
            ComboBoxClases.Items.Add(clases(i)(0).ToString)
        Next

        ComboBoxRaza.Items.Add("--")
        Dim razas As New DataTable
        razas = Consultar("select distinct(raza) from personajes;")
        For i = 0 To razas.Rows.Count - 1
            ComboBoxRaza.Items.Add(razas(i)(0).ToString)
        Next

        Dim universos As New DataTable
        universos = Consultar("select id_uni, nombre from universos;")
        For i = 0 To universos.Rows.Count - 1
            ComboBoxIdUni.Items.Add(universos(i)(0).ToString)
            ComboBoxUni.Items.Add(universos(i)(1).ToString)
        Next

        'Rellenar si es modificar
        If Principal.modalt <> -1 Then
            LabelTitulo.Text = "Modificar personaje"

            Dim rw As New DataTable
            rw = Consultar("SELECT * FROM personajes WHERE id_per = " + Principal.modalt.ToString + ";")

            TextBoxNombre.Text = rw(0)(1).ToString
            TextBoxApe.Text = rw(0)(2).ToString
            TextBoxAlias.Text = rw(0)(3).ToString
            ComboBoxRaza.SelectedItem = rw(0)(4).ToString
            If rw(0)(5).ToString = "Bueno" Then
                RadioButtonBueno.Checked = True
            ElseIf rw(0)(5).ToString = "Neutral" Then
                RadioButtonNeutral.Checked = True
            ElseIf rw(0)(5).ToString = "Malvado" Then
                RadioButtonMalvado.Checked = True
            End If
            ComboBoxClases.SelectedItem = rw(0)(6).ToString
            If rw(0)(7).ToString = "Masculino" Then
                RadioButtonV.Checked = True
            ElseIf rw(0)(7).ToString = "Femenino" Then
                RadioButtonF.Checked = True
            End If
            DateTimePickerFecha.Value = rw(0)(8).ToString
            ComboBoxIdUni.SelectedItem = rw(0)(12).ToString
            fue = rw(0)(9) * 15
            imgf.Size = New Size(fue, 19)
            agi = rw(0)(10) * 15
            imga.Size = New Size(agi, 19)
            int = rw(0)(11) * 15
            imgi.Size = New Size(int, 19)
        Else
            LabelTitulo.Text = "Añadir personaje"

            TextBoxNombre.Text = ""
            TextBoxApe.Text = ""
            TextBoxAlias.Text = ""
            ComboBoxRaza.SelectedIndex = 0
            RadioButtonBueno.Checked = False
            RadioButtonNeutral.Checked = False
            RadioButtonMalvado.Checked = False
            ComboBoxClases.SelectedIndex = 0
            RadioButtonV.Checked = False
            RadioButtonF.Checked = False
            DateTimePickerFecha.Value = "01/05/2011"
            ComboBoxIdUni.SelectedIndex = 0
            fue = 15
            imgf.Size = New Size(fue, 19)
            agi = 15
            imga.Size = New Size(agi, 19)
            int = 15
            imgi.Size = New Size(int, 19)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        fue += 15
        If fue >= 150 Then
            fue = 150
        End If
        imgf.Size = New Size(fue, 19)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        fue -= 15
        If fue <= 15 Then
            fue = 15
        End If
        imgf.Size = New Size(fue, 19)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        agi -= 15
        If agi <= 15 Then
            agi = 15
        End If
        imga.Size = New Size(agi, 19)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        agi += 15
        If agi >= 150 Then
            agi = 150
        End If
        imga.Size = New Size(agi, 19)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        int -= 15
        If int <= 15 Then
            int = 15
        End If
        imgi.Size = New Size(Int, 19)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Int += 15
        If int >= 150 Then
            int = 150
        End If
        imgi.Size = New Size(Int, 19)

    End Sub

    Private Sub ComboBoxIdUni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdUni.SelectedIndexChanged
        ComboBoxUni.SelectedIndex = ComboBoxIdUni.SelectedIndex
    End Sub

    Private Sub ComboBoxUni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxUni.SelectedIndexChanged
        ComboBoxIdUni.SelectedIndex = ComboBoxUni.SelectedIndex
    End Sub

    Private Sub TextBoxClase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxClase.TextChanged
        ComboBoxClases.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxClases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClases.SelectedIndexChanged
        TextBoxClase.Text = ""
    End Sub

    Private Sub ComboBoxRaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxRaza.SelectedIndexChanged
        TextBoxRaza.Text = ""
    End Sub

    Private Sub TextBoxRaza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxRaza.TextChanged
        ComboBoxRaza.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim alin As String = ""
        Dim sexo As String = ""
        Dim raza As String = ""
        Dim clas As String = ""

        If RadioButtonBueno.Checked Then
            alin = RadioButtonBueno.Tag.ToString
        ElseIf RadioButtonMalvado.Checked Then
            alin = RadioButtonMalvado.Tag.ToString
        ElseIf RadioButtonNeutral.Checked Then
            alin = RadioButtonNeutral.Tag.ToString
        End If
        If RadioButtonF.Checked Then
            sexo = RadioButtonF.Tag.ToString
        ElseIf RadioButtonV.Checked Then
            sexo = RadioButtonV.Tag.ToString
        End If

        If ComboBoxClases.SelectedIndex = 0 Then
            clas = TextBoxClase.Text
        Else
            clas = ComboBoxClases.SelectedItem.ToString
        End If

        If ComboBoxRaza.SelectedIndex = 0 Then
            raza = TextBoxRaza.Text
        Else
            raza = ComboBoxRaza.SelectedItem.ToString
        End If

        If Principal.modalt = -1 Then
            Dim idper As Integer = 0
            Dim dt As New DataTable
            dt = Consultar("select max(id_per) from personajes")
            idper = dt(0)(0)
            idper += 1
            If TextBoxNombre.Text = "" And TextBoxAlias.Text = "" And TextBoxApe.Text = "" Then
                MsgBox("Debes rellenar algun nombre, alias o apellido aunque sea")
            Else
                Try
                    Ejecutar("INSERT INTO personajes VALUES (" + idper.ToString + ",'" + TextBoxNombre.Text.ToString + "','" + TextBoxAlias.Text.ToString + "','" + TextBoxApe.Text.ToString + "','" + raza.ToString + "','" + alin.ToString + "','" + clas.ToString + "','" + sexo.ToString + "','" + DateTimePickerFecha.Value.ToString + "'," + CStr(fue / 15) + "," + CStr(agi / 15) + "," + CStr(int / 15) + "," + ComboBoxIdUni.SelectedItem.ToString + ");")
                    MsgBox("Fila Añadida")
                    BuscarPersonaje.DataGridViewPer.DataSource = Consultar("SELECT * FROM personajes ORDER BY id_per;")

                Catch ex As Exception
                    MessageBox.Show("ERROR :" & vbCrLf & _
                                ex.Message, "---", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Close()
            End If
            
        Else
            If TextBoxNombre.Text = "" And TextBoxAlias.Text = "" And TextBoxApe.Text = "" Then
                MsgBox("Debes rellenar algun nombre, alias o apellido aunque sea")
            Else
                Try
                    Ejecutar("UPDATE personajes SET  nombre = '" + TextBoxNombre.Text.ToString + "',alias = '" + TextBoxAlias.Text.ToString + "',apellidos = '" + TextBoxApe.Text.ToString + "',raza = '" + raza.ToString + "', alineamiento = '" + alin.ToString + "', clase = '" + clas.ToString + "',sexo = '" + sexo.ToString + "',fecnac = '" + DateTimePickerFecha.Value.ToString + "',fuerza = " + CStr(fue / 15) + ",agilidad = " + CStr(agi / 15) + ", inteligencia = " + CStr(int / 15) + ",id_uni = " + ComboBoxIdUni.SelectedItem.ToString + " WHERE id_per = " + Principal.modalt.ToString + ";")
                    MsgBox("Fila Modificada")
                    BuscarPersonaje.DataGridViewPer.DataSource = Consultar("SELECT * FROM personajes ORDER BY id_per;")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("ERROR :" & vbCrLf & _
                                ex.Message, "---", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Close()
            End If
        End If

    End Sub
End Class