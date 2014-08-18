Public Class BuscarPersonaje
    Dim fue As Integer = 15
    Dim agi As Integer = 15
    Dim int As Integer = 15
    Dim imgf As New PictureBox
    Dim imga As New PictureBox
    Dim imgi As New PictureBox
    Private Sub BuscarPersonaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Dim raza As New DataTable
        raza = Consultar("SELECT distinct(raza) FROM personajes;")
        ComboBoxRaza.Items.Add("--")
        For i = 0 To raza.Rows.Count - 1
            ComboBoxRaza.Items.Add(raza(i)(0))
        Next

        Dim clase As New DataTable
        clase = Consultar("SELECT distinct(clase) FROM personajes;")
        ComboBoxClase.Items.Add("--")
        For i = 0 To clase.Rows.Count - 1
            ComboBoxClase.Items.Add(clase(i)(0))
        Next

        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Public Sub declararStats()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        fue += 15
        If fue >= 150 Then
            fue = 150
        End If
        imgf.Size = New Size(fue, 19)
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        fue -= 15
        If fue <= 15 Then
            fue = 15
        End If
        imgf.Size = New Size(fue, 19)
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        agi -= 15
        If agi <= 15 Then
            agi = 15
        End If
        imga.Size = New Size(agi, 19)
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        agi += 15
        If agi >= 150 Then
            agi = 150
        End If
        imga.Size = New Size(agi, 19)
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        int -= 15
        If int <= 15 Then
            int = 15
        End If
        imgi.Size = New Size(int, 19)
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        int += 15
        If int >= 150 Then
            int = 150
        End If
        imgi.Size = New Size(int, 19)
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Public Function BuscarPer()
        Dim con As String = "SELECT * FROM personajes"
        If TextBoxPer.Text <> "" Or ComboBoxClase.SelectedIndex <> -1 Or ComboBoxRaza.SelectedIndex <> -1 Or CheckBoxStats.Checked Or ComboBoxClase.SelectedIndex <> -1 Or RadioButtonBueno.Checked Or RadioButtonMalvado.Checked Or RadioButtonNeutral.Checked Or RadioButtonF.Checked Or RadioButtonV.Checked Then
            con += " WHERE id_per = id_per"
            If TextBoxPer.Text <> "" Then
                con += " and (nombre like '%" + TextBoxPer.Text.ToString + "%' or apellidos like '%" + TextBoxPer.Text.ToString + "%' or alias like '%" + TextBoxPer.Text.ToString + "%')"
            End If
            If ComboBoxRaza.SelectedIndex <> -1 And ComboBoxRaza.SelectedIndex <> 0 Then
                con += " and raza like '" + ComboBoxRaza.SelectedItem.ToString + "'"
            End If
            If ComboBoxClase.SelectedIndex <> -1 And ComboBoxClase.SelectedIndex <> 0 Then
                con += " and clase like '" + ComboBoxClase.SelectedItem.ToString + "'"
            End If
            If RadioButtonBueno.Checked Then
                con += " and alineamiento like '" + RadioButtonBueno.Tag.ToString + "'"
            End If
            If RadioButtonNeutral.Checked Then
                con += " and alineamiento like '" + RadioButtonNeutral.Tag.ToString + "'"
            End If
            If RadioButtonMalvado.Checked Then
                con += " and alineamiento like '" + RadioButtonMalvado.Tag.ToString + "'"
            End If
            If RadioButtonV.Checked Then
                con += " and sexo like '" + RadioButtonV.Tag.ToString + "'"
            End If
            If RadioButtonF.Checked Then
                con += " and sexo like '" + RadioButtonF.Tag.ToString + "'"
            End If
            If CheckBoxStats.Checked Then
                con += " and (fuerza like " + CStr(fue / 15) + ""
                con += " or agilidad like " + CStr(agi / 15) + ""
                con += " or inteligencia like " + CStr(int / 15) + ")"
            End If
        End If
        con += " ;"
        Return con
        con = ""
    End Function

    Private Sub TextBoxPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPer.TextChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub ComboBoxRaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxRaza.SelectedIndexChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub ComboBoxClase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClase.SelectedIndexChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub RadioButtonBueno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonBueno.CheckedChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub RadioButtonNeutral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNeutral.CheckedChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub RadioButtonMalvado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMalvado.CheckedChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub RadioButtonV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonV.CheckedChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub RadioButtonF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonF.CheckedChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub CheckBoxStats_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStats.CheckedChanged
        DataGridViewPer.DataSource = bdfriki.Consultar(BuscarPer())
    End Sub

    Private Sub DataGridViewPer_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewPer.SelectionChanged
        Try
            PictureBoxEsc.Image = Image.FromFile("personajes/" + DataGridViewPer.SelectedCells(0).Value.ToString + ".jpg")
        Catch ex As Exception
            PictureBoxEsc.Image = Image.FromFile("personajes/0.jpg")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principal.modalt = -1
        AltaPersonaje.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Principal.modalt = DataGridViewPer.CurrentRow.Cells(0).Value
        AltaPersonaje.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MsgBox("¿Está Seguro de borrar el registro seleccionado?", 1) = 1 Then
            Ejecutar("DELETE FROM personajes WHERE id_per = " + DataGridViewPer.CurrentRow.Cells(0).Value.ToString + ";")
            DataGridViewPer.DataSource = Consultar("SELECT * FROM personajes")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.modalt = DataGridViewPer.CurrentRow.Cells(0).Value
        DetallesPersonaje.ShowDialog()
    End Sub
End Class