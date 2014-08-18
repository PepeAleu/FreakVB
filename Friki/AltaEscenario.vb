Public Class AltaEscenario
    Dim con As String
    Private Sub AltaEscenario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim esc As New DataTable
        esc = Consultar("select id_esc,nombre from escenarios;")
        ComboBoxIdEsc.Items.Add("NULL")
        ComboBoxEscNombre.Items.Add("NULL")

        For i = 0 To esc.Rows.Count - 1
            ComboBoxIdEsc.Items.Add(esc(i)(0))
            ComboBoxEscNombre.Items.Add(esc(i)(1))
        Next

        esc = New DataTable
        esc = Consultar("select id_uni,nombre from universos;")
        For i = 0 To esc.Rows.Count - 1
            ComboBoxiduni.Items.Add(esc(i)(0))
            ComboBoxuninombre.Items.Add(esc(i)(1))
        Next
        ComboBoxiduni.SelectedIndex = 0
        ComboBoxuninombre.SelectedIndex = 0
        ComboBoxIdEsc.SelectedIndex = 0
        ComboBoxEscNombre.SelectedIndex = 0
        RadioButton1.Checked = True

        'Rellenar si es modificar
        If Principal.modalt <> -1 Then
            LabelTitulo.Text = "Modificar escenario"

            Dim rw As New DataTable
            rw = Consultar("SELECT * FROM escenarios WHERE id_esc = " + Principal.modalt.ToString + ";")

            TextBoxNombreEscenario.Text = rw(0)(1).ToString
            NumericUpDownPoblacionMaxima.Value = rw(0)(2).ToString
            NumericUpDownPoblacion.Value = rw(0)(3).ToString
            If rw(0)(4).ToString = "1" Then
                RadioButton1.Checked = True
            ElseIf rw(0)(4).ToString = "0" Then
                RadioButton2.Checked = True
            End If
            ComboBoxIdEsc.SelectedItem = rw(0)(5).ToString
            ComboBoxiduni.SelectedItem = rw(0)(6).ToString
        Else
            LabelTitulo.Text = "Añadir escenario"

            TextBoxNombreEscenario.Text = ""
            NumericUpDownPoblacionMaxima.Value = 0
            NumericUpDownPoblacion.Value = 0
            RadioButton1.Checked = True
            ComboBoxIdEsc.SelectedIndex = 0
            ComboBoxiduni.SelectedIndex = 0
        End If
    End Sub

    Private Sub ComboBoxEscNombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEscNombre.SelectedIndexChanged
        ComboBoxIdEsc.SelectedIndex = ComboBoxEscNombre.SelectedIndex
    End Sub

    Private Sub ComboBoxIdEsc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdEsc.SelectedIndexChanged
        ComboBoxEscNombre.SelectedIndex = ComboBoxIdEsc.SelectedIndex
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim esplaneta As String = ""
        If RadioButton1.Checked Then
            esplaneta = RadioButton1.Tag
        ElseIf RadioButton2.Checked Then
            esplaneta = RadioButton2.Tag
        End If
        If Principal.modalt = -1 Then
            Dim id As Integer = 0
            Dim dt As New DataTable
            dt = Consultar("select max(id_esc) from escenarios;")
            id = dt(0)(0)
            id += 1


            If TextBoxNombreEscenario.Text <> "" And ComboBoxiduni.SelectedIndex <> -1 Then
                bdfriki.Ejecutar("INSERT INTO escenarios  VALUES(" + id.ToString + ",'" + TextBoxNombreEscenario.Text + "'," + NumericUpDownPoblacionMaxima.Value.ToString + "," + NumericUpDownPoblacion.Value.ToString + "," + esplaneta.ToString + "," + ComboBoxIdEsc.SelectedItem.ToString + "," + ComboBoxiduni.SelectedItem.ToString + ");")
                BuscarEscenario.DataGridViewEsc.DataSource = Consultar("SELECT * FROM escenarios;")
                MsgBox("Escenario Añadido")
                Me.Close()
            Else
                MsgBox("Debes rellenar los campos obligatorios")
            End If
        Else
            If TextBoxNombreEscenario.Text <> "" And ComboBoxiduni.SelectedIndex <> -1 Then
                Try
                    Ejecutar("UPDATE escenarios SET  nombre = '" + TextBoxNombreEscenario.Text + "',poblacionmaxima = " + NumericUpDownPoblacionMaxima.Value.ToString + ",poblacion = " + NumericUpDownPoblacion.Value.ToString + ", esplaneta = " + esplaneta + ", esc_padre = " + ComboBoxIdEsc.SelectedItem.ToString + ", id_uni = " + ComboBoxiduni.SelectedItem.ToString + " WHERE id_esc = " + Principal.modalt.ToString + ";")
                    MsgBox("Fila Modificada")
                    BuscarEscenario.DataGridViewEsc.DataSource = Consultar("SELECT * FROM escenarios;")
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