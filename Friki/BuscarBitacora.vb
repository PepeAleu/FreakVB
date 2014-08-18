Public Class BuscarBitacora

    Private Sub BuscarBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Function buscarBitacora()
        Dim con As String = "SELECT * FROM bitacora"
        If TextBoxAventura.Text <> "" Or TextBoxMonstruo.Text <> "" Or TextBoxPersonaje.Text = "" Or RadioButtonEpico.Checked Or RadioButtonFracaso.Checked Or RadioButtonNormal.Checked Then
            con += " WHERE id_per = id_per"
            If TextBoxPersonaje.Text <> "" Then
                con += " and id_per = " + TextBoxPersonaje.Text.ToString + ""
            End If
            If TextBoxAventura.Text <> "" Then
                con += " and id_ave = " + TextBoxAventura.Text + ""
            End If
            If TextBoxMonstruo.Text <> "" Then
                con += " and id_mon = " + TextBoxMonstruo.Text + ""
            End If
            If RadioButtonEpico.Checked Then
                con += " and modo = '" + RadioButtonEpico.Tag.ToString + "'"
            ElseIf RadioButtonFracaso.Checked Then
                con += " and modo = '" + RadioButtonFracaso.Tag.ToString + "'"
            ElseIf RadioButtonNormal.Checked Then
                con += " and modo = '" + RadioButtonNormal.Tag.ToString + "'"
            End If
        End If
        con += " ;"
        Return con
        con = ""
    End Function

    Private Sub TextBoxPersonaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPersonaje.TextChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub TextBoxAventura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAventura.TextChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub TextBoxMonstruo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMonstruo.TextChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub RadioButtonFracaso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonFracaso.CheckedChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub RadioButtonNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNormal.CheckedChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub RadioButtonEpico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonEpico.CheckedChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        DataGridViewBit.DataSource = bdfriki.Consultar(buscarBitacora())
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principal.modalt = -1
        AltaBitacora.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Principal.modalt = DataGridViewBit.CurrentRow.Cells(0).Value.ToString + DataGridViewBit.CurrentRow.Cells(1).Value.ToString + DataGridViewBit.CurrentRow.Cells(2).Value.ToString
        AltaBitacora.ShowDialog()
    End Sub
End Class