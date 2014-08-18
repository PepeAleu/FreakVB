Public Class AltaUniverso
    Private Sub AltaUniverso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelLineaH.Size = New Size(Me.Bounds.Width, 1)
        PanelLineaV.Size = New Size(1, Me.Bounds.Height)

        Dim dt As New DataTable
        dt = Consultar("select distinct(tipo) from universos;")
        For i = 0 To dt.Rows.Count - 1
            ComboBoxTipo.Items.Add(dt(i)(0).ToString)
        Next

        'Rellenar si es modificar
        If Principal.modalt <> -1 Then
            Dim rw As New DataTable
            rw = Consultar("SELECT * FROM universos WHERE id_uni = " + Principal.modalt.ToString + ";")
            TextBoxNombre.Text = rw(0)(1).ToString
            ComboBoxTipo.SelectedItem = rw(0)(2).ToString
        Else
            TextBoxNombre.Text = ""
            ComboBoxTipo.SelectedIndex = 0
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Principal.modalt = -1 Then
            Dim id As Integer = 0
            Dim dt As New DataTable
            dt = Consultar("select max(id_uni) from universos;")
            id = dt(0)(0)
            id += 1

            If TextBoxNombre.Text <> "" Then
                bdfriki.Ejecutar("INSERT INTO universos VALUES(" + id.ToString + ",'" + TextBoxNombre.Text + "','" + ComboBoxTipo.SelectedItem.ToString + "');")
                BuscarUniverso.DataGridViewUni.DataSource = Consultar("SELECT * FROM universos;")
                MsgBox("Universo Añadido.")
                Me.Close()
            Else
                MsgBox("Debes rellenar los campos obligatorios")
            End If
        Else
            If TextBoxNombre.Text <> "" Then
                Try
                    Ejecutar("UPDATE universos SET  nombre = '" + TextBoxNombre.Text + "',tipo = '" + ComboBoxTipo.SelectedItem.ToString + "' WHERE id_uni = " + Principal.modalt.ToString + ";")
                    MsgBox("Universo actualizado.")
                    BuscarUniverso.DataGridViewUni.DataSource = Consultar("SELECT * FROM universos;")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("ERROR :" & vbCrLf & _
                                ex.Message, "---", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Close()
            Else
                MsgBox("Debes rellenar los campos obligatorios")
            End If
        End If
    End Sub
End Class