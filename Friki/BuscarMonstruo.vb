Public Class BuscarMonstruo

    Private Sub BuscarMonstruo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
        Dim dificultad As New DataTable
        
    End Sub

    Private Function BuscarMon()
        Dim con As String = "SELECT id_mon, nombre, color, dificultad FROM monstruos"
        If TextBoxMon.Text <> "" Or RadioButtonAlta.CheckAlign Or RadioButtonBaja.Checked Or RadioButtonExtrema.Checked Or RadioButtonMedia.Checked Or TextBoxColor.Text <> "" Then
            con += " WHERE id_mon = id_mon"
            If TextBoxMon.Text <> "" Then
                con += " and nombre like '%" + TextBoxMon.Text.ToString + "%'"
            End If
            If TextBoxColor.Text <> "" Then
                con += " and color like '" + TextBoxColor.Text.ToString + "'"
            End If
            If RadioButtonAlta.Checked Then
                con += " and dificultad like '" + RadioButtonAlta.Tag.ToString + "'"
            ElseIf RadioButtonMedia.Checked Then
                con += " and dificultad like '" + RadioButtonMedia.Tag.ToString + "'"
            ElseIf RadioButtonBaja.Checked Then
                con += " and dificultad like '" + RadioButtonBaja.Tag.ToString + "'"
            ElseIf RadioButtonExtrema.Checked Then
                con += " and dificultad like '" + RadioButtonExtrema.Tag.ToString + "'"
            End If
        End If
        con += " ;"
        Return con
        con = ""
    End Function

    Private Sub RadioButtonIncoloro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonIncoloro.CheckedChanged
        TextBoxColor.Text = RadioButtonIncoloro.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonBlanco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonBlanco.CheckedChanged
        TextBoxColor.Text = RadioButtonBlanco.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonGris_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonGris.CheckedChanged
        TextBoxColor.Text = RadioButtonGris.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonNegro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNegro.CheckedChanged
        TextBoxColor.Text = RadioButtonNegro.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonRubio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRubio.CheckedChanged
        TextBoxColor.Text = RadioButtonRubio.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonAmarillo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAmarillo.CheckedChanged
        TextBoxColor.Text = RadioButtonAmarillo.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonNaranja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNaranja.CheckedChanged
        TextBoxColor.Text = RadioButtonNaranja.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonRojo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRojo.CheckedChanged
        TextBoxColor.Text = RadioButtonRojo.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonLila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonLila.CheckedChanged
        TextBoxColor.Text = RadioButtonLila.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonAzul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAzul.CheckedChanged
        TextBoxColor.Text = RadioButtonAzul.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonVerde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonVerde.CheckedChanged
        TextBoxColor.Text = RadioButtonVerde.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonMoco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMoco.CheckedChanged
        TextBoxColor.Text = RadioButtonMoco.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonRosa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRosa.CheckedChanged
        TextBoxColor.Text = RadioButtonRosa.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonMarron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMarron.CheckedChanged
        TextBoxColor.Text = RadioButtonMarron.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonMulticolor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMulticolor.CheckedChanged
        TextBoxColor.Text = RadioButtonMulticolor.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTodos.CheckedChanged
        TextBoxColor.Text = RadioButtonTodos.Tag.ToString
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub DataGridViewMon_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewMon.SelectionChanged
        Try
            PictureBoxEsc.Image = Image.FromFile("monstruos/" + DataGridViewMon.SelectedCells(0).Value.ToString + ".jpg")
        Catch ex As Exception
            PictureBoxEsc.Image = Image.FromFile("monstruos/0.jpg")
        End Try
    End Sub

    Private Sub TextBoxMon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMon.TextChanged
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub ComboBoxDificultad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonBaja.CheckedChanged
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonMedia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMedia.CheckedChanged
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonAlta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAlta.CheckedChanged
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub RadioButtonExtrema_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonExtrema.CheckedChanged
        DataGridViewMon.DataSource = bdfriki.Consultar(BuscarMon())
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Principal.modalt = DataGridViewMon.CurrentRow.Cells(0).Value
        AltaMonstruo.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principal.modalt = -1
        AltaMonstruo.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Está Seguro de borrar el registro seleccionado?", 1) = 1 Then
            Ejecutar("DELETE FROM monstruos WHERE id_mon = " + DataGridViewMon.CurrentRow.Cells(0).Value.ToString + ";")
            DataGridViewMon.DataSource = Consultar("select id_mon, nombre, color, dificultad  from monstruos;")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.modalt = DataGridViewMon.CurrentRow.Cells(0).Value
        DetallesMonstruo.ShowDialog()
    End Sub
End Class