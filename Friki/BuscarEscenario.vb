
Public Class BuscarEscenario

    Private Sub BuscarEscenario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxMayorque.SelectedIndex = 0
        ComboBoxMayorque2.SelectedIndex = 0
        Conectar()
        DataGridViewEsc.DataSource = bdfriki.Consultar(BuscarEsc())
    End Sub

    Public Function BuscarEsc()
        Dim con As String = "SELECT * FROM escenarios"
        If TextBoxEsc.Text <> "" Or ComboBoxMayorque.SelectedIndex <> 0 Or ComboBoxMayorque2.SelectedIndex <> 0 Or RadioButtonNo.Checked = True Or RadioButtonSi.Checked = True Then
            con += " WHERE id_esc = id_esc"
            If TextBoxEsc.Text <> "" Then
                con += " and nombre like '%" + TextBoxEsc.Text.ToString + "%'"
            End If
            If ComboBoxMayorque.SelectedIndex = 2 Then
                con += " and poblacion > " + NumericUpDownPoblacion.Value.ToString
            ElseIf ComboBoxMayorque.SelectedIndex = 3 Then
                con += " and poblacion < " + NumericUpDownPoblacion.Value.ToString
            ElseIf ComboBoxMayorque.SelectedIndex = 1 Then
                con += " and poblacion = " + NumericUpDownPoblacion.Value.ToString
            ElseIf ComboBoxMayorque.SelectedIndex = 0 Then
                con += ""
            End If
            If ComboBoxMayorque2.SelectedIndex = 2 Then
                con += " and poblacionmaxima > " + NumericUpDownMaxPoblacion.Value.ToString
            ElseIf ComboBoxMayorque2.SelectedIndex = 3 Then
                con += " and poblacionmaxima < " + NumericUpDownMaxPoblacion.Value.ToString
            ElseIf ComboBoxMayorque2.SelectedIndex = 1 Then
                con += " and poblacionmaxima = " + NumericUpDownMaxPoblacion.Value.ToString
            ElseIf ComboBoxMayorque2.SelectedIndex = 0 Then
                con += ""
            End If
            If RadioButtonSi.Checked Then
                con += " and esplaneta = 1"
            ElseIf RadioButtonNo.Checked Then
                con += " and esplaneta = 0"
            Else
                con += ""
            End If
        End If
        con += " ;"
        Return con
        con = ""
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataGridViewEsc.DataSource = Consultar(BuscarEsc())
    End Sub

    Private Sub TextBoxEsc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEsc.TextChanged
        DataGridViewEsc.DataSource = Consultar(BuscarEsc())
    End Sub

    Private Sub DataGridViewEsc_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewEsc.MouseWheel
        If e.Delta < 0 And DataGridViewEsc.SelectedCells(0).RowIndex < DataGridViewEsc.RowCount - 1 Then
            DataGridViewEsc.Rows(DataGridViewEsc.SelectedCells(0).RowIndex + 1).Cells(0).Selected = True
        ElseIf DataGridViewEsc.SelectedCells(0).RowIndex > 0 Then
            DataGridViewEsc.Rows(DataGridViewEsc.SelectedCells(0).RowIndex - 1).Cells(0).Selected = True
        End If
    End Sub



    Private Sub DataGridViewEsc_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewEsc.SelectionChanged
        Try
            PictureBoxEsc.Image = Image.FromFile("escenarios/" + DataGridViewEsc.SelectedCells(0).Value.ToString + ".jpg")
        Catch ex As Exception
            PictureBoxEsc.Image = Image.FromFile("escenarios/x.png")
        End Try
    End Sub


    Private Sub ComboBoxMayorque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMayorque.SelectedIndexChanged
        If ComboBoxMayorque.SelectedIndex = 0 Then
            NumericUpDownPoblacion.Enabled = False
        Else
            NumericUpDownPoblacion.Enabled = True
        End If
    End Sub


    Private Sub ComboBoxMayorque2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMayorque2.SelectedIndexChanged
        If ComboBoxMayorque2.SelectedIndex = 0 Then
            NumericUpDownMaxPoblacion.Enabled = False
        Else
            NumericUpDownMaxPoblacion.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDownPoblacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownPoblacion.ValueChanged
        DataGridViewEsc.DataSource = Consultar(BuscarEsc())
    End Sub

    Private Sub NumericUpDownMaxPoblacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownMaxPoblacion.ValueChanged
        DataGridViewEsc.DataSource = Consultar(BuscarEsc())
    End Sub

    Private Sub RadioButtonSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonSi.CheckedChanged
        DataGridViewEsc.DataSource = Consultar(BuscarEsc())
    End Sub

    Private Sub RadioButtonNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNo.CheckedChanged
        DataGridViewEsc.DataSource = Consultar(BuscarEsc())
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principal.modalt = -1
        AltaEscenario.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Principal.modalt = DataGridViewEsc.CurrentRow.Cells(0).Value
        AltaEscenario.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Está Seguro de borrar el registro seleccionado?", 1) = 1 Then
            Ejecutar("DELETE FROM escenarios WHERE id_esc = " + DataGridViewEsc.CurrentRow.Cells(0).Value.ToString + ";")
            DataGridViewEsc.DataSource = Consultar("select * from escenarios;")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.modalt = DataGridViewEsc.CurrentRow.Cells(0).Value
        DetallesEscenario.ShowDialog()
    End Sub
End Class