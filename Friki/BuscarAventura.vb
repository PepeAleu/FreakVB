Public Class BuscarAventura

    Private Sub BuscarAventura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conectar()
        DataGridViewAve.DataSource = bdfriki.Consultar(BuscarAve())
    End Sub

    Private Sub TextBoxNombreAventuraAlta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNombreAventura.TextChanged
        DataGridViewAve.DataSource = bdfriki.Consultar(BuscarAve())
    End Sub
    Private Sub TextBoxDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDescripcion.TextChanged
        DataGridViewAve.DataSource = bdfriki.Consultar(BuscarAve())
    End Sub

    Private Function BuscarAve()
        Dim con As String = "SELECT id_ave,id_esc, nombre, descripcion FROM aventuras"
        If TextBoxNombreAventura.Text <> "" Or TextBoxDescripcion.Text <> "" Then
            con += " WHERE id_ave = id_ave"
            If TextBoxNombreAventura.Text <> "" Then
                con += " and nombre like '%" + TextBoxNombreAventura.Text.ToString + "%'"
            End If
            If TextBoxDescripcion.Text <> "" Then
                con += " and descripcion like '%" + TextBoxDescripcion.Text.ToString + "%'"
            End If
        End If
        con += " ;"
        Return con
        con = ""
    End Function

    
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principal.modalt = -1
        AltaAventura.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Principal.modalt = DataGridViewAve.CurrentRow.Cells(0).Value
        AltaAventura.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Está Seguro de borrar el registro seleccionado?", 1) = 1 Then
            Ejecutar("DELETE FROM aventuras WHERE id_ave = " + DataGridViewAve.CurrentRow.Cells(0).Value.ToString + ";")
            DataGridViewAve.DataSource = Consultar("select id_ave, id_esc, nombre, descripcion from aventuras;")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.modalt = DataGridViewAve.CurrentRow.Cells(0).Value
        DetallesAventura.ShowDialog()
    End Sub
End Class