Imports Friki.bdfriki
Public Class AltaAventura
   
   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Principal.modalt = -1 Then
            Dim id As Integer = 0
            Dim dt As New DataTable
            dt = Consultar("select max(id_ave) from aventuras")
            id = dt(0)(0)
            id += 1
            If ComboBoxEscenarioAlta.SelectedIndex <> -1 And TextBoxNombreAventuraAlta.Text <> "" And TextBoxDescripcionAlta.Text <> "" Then
                bdfriki.Ejecutar("INSERT INTO aventuras (id_ave, id_esc, nombre, descripcion) VALUES(" + id.ToString + "," + ComboBoxIdAlta.SelectedItem.ToString + ",'" + TextBoxNombreAventuraAlta.Text + "','" + TextBoxDescripcionAlta.Text + "');")
                BuscarAventura.DataGridViewAve.DataSource = Consultar("SELECT id_ave, id_esc, nombre, descripcion FROM aventuras;")
                MsgBox("Aventura Añadida")
                Me.Close()
            Else
                MsgBox("Debes rellenar todos los campos")
            End If
        Else
            If ComboBoxEscenarioAlta.SelectedIndex <> -1 And TextBoxNombreAventuraAlta.Text <> "" And TextBoxDescripcionAlta.Text <> "" Then
                Try
                    Ejecutar("UPDATE aventuras SET  nombre = '" + TextBoxNombreAventuraAlta.Text.ToString + "',descripcion = '" + TextBoxDescripcionAlta.Text.ToString + "' WHERE id_ave = " + Principal.modalt.ToString + ";")
                    MsgBox("Fila Modificada")
                    BuscarAventura.DataGridViewAve.DataSource = Consultar("SELECT id_ave, id_esc, nombre, descripcion FROM aventuras ORDER BY id_ave;")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("ERROR :" & vbCrLf & _
                                ex.Message, "---", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Close()
            Else
                MsgBox("Debes rellenar todos los campos")
            End If
        End If
    End Sub

    Private Sub ComboBoxEscenarioAlta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEscenarioAlta.SelectedIndexChanged
        ComboBoxIdAlta.SelectedIndex = ComboBoxEscenarioAlta.SelectedIndex
    End Sub

    Private Sub AltaAventura_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PanelLineaH.Size = New Size(Me.Bounds.Width, 1)
        PanelLineaV.Size = New Size(1, Me.Bounds.Height)

        Dim escenarios As New DataTable
        escenarios = Consultar("SELECT id_esc, nombre FROM escenarios;")
        
        For i = 0 To escenarios.Rows.Count - 1
            ComboBoxIdAlta.Items.Add(escenarios(i)(0))
            ComboBoxEscenarioAlta.Items.Add(escenarios(i)(1))
        Next
        ComboBoxIdAlta.SelectedIndex = 0
        ComboBoxEscenarioAlta.SelectedIndex = 0

        'Rellenar si es modificar
        If Principal.modalt <> -1 Then
            LabelTitulo.Text = "Modificar la aventura"

            Dim rw As New DataTable
            rw = Consultar("SELECT * FROM aventuras WHERE id_ave = " + Principal.modalt.ToString + ";")
            ComboBoxIdAlta.SelectedItem = rw(0)(1).ToString
            TextBoxNombreAventuraAlta.Text = rw(0)(2).ToString
            TextBoxDescripcionAlta.Text = rw(0)(3).ToString
        Else
            LabelTitulo.Text = "Añadir una aventura"
            ComboBoxIdAlta.SelectedIndex = 0
            TextBoxNombreAventuraAlta.Text = ""
            TextBoxDescripcionAlta.Text = ""
        End If
    End Sub

End Class
