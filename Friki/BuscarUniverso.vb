Public Class BuscarUniverso

    Private Sub BuscarUniverso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conectar()
        DataGridViewUni.DataSource = bdfriki.Consultar(BuscarUni())
        Dim tipo As New DataTable
        tipo = Consultar("SELECT distinct(tipo) FROM universos;")
        ComboBoxTipo.Items.Add("--")
        For i = 0 To tipo.Rows.Count - 1
            ComboBoxTipo.Items.Add(tipo(i)(0))
        Next
    End Sub

    Private Function BuscarUni()
        Dim con As String = "SELECT * FROM universos"
        If TextBoxUni.Text <> "" Or ComboBoxTipo.SelectedIndex <> -1 Then
            con += " WHERE id_uni = id_uni"
            If TextBoxUni.Text <> "" Then
                con += " and nombre like '%" + TextBoxUni.Text.ToString + "%'"
            End If
            If ComboBoxTipo.SelectedIndex <> 0 And ComboBoxTipo.SelectedIndex <> -1 Then
                con += " and tipo like '" + ComboBoxTipo.SelectedItem.ToString + "'"
            End If
        End If
        con += " ;"
        Return con
        con = ""
    End Function

    Private Sub TextBoxUni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUni.TextChanged
        DataGridViewUni.DataSource = bdfriki.Consultar(BuscarUni())
    End Sub

    Private Sub ComboBoxTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipo.SelectedIndexChanged
        DataGridViewUni.DataSource = bdfriki.Consultar(BuscarUni())
    End Sub

    Private Sub DataGridViewUni_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewUni.SelectionChanged
        Try
            PictureBoxUni.Image = Image.FromFile("universos/" + DataGridViewUni.SelectedCells(0).Value.ToString + ".jpg")
        Catch ex As Exception
            PictureBoxUni.Image = Image.FromFile("universos/0.jpg")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principal.modalt = -1
        AltaUniverso.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Principal.modalt = DataGridViewUni.CurrentRow.Cells(0).Value.ToString
        AltaUniverso.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Está Seguro de borrar el registro seleccionado?", 1) = 1 Then
            Ejecutar("DELETE FROM universos WHERE id_uni = " + DataGridViewUni.CurrentRow.Cells(0).Value.ToString + ";")
            DataGridViewUni.DataSource = Consultar("select *  from universos;")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.modalt = DataGridViewUni.CurrentRow.Cells(0).Value.ToString
        DetallesUniverso.ShowDialog()
    End Sub
End Class