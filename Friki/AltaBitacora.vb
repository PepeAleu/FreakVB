Public Class AltaBitacora
    Private Sub AltaBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = Consultar("select id_ave, nombre from aventuras;")
        For i = 0 To dt.Rows.Count - 1
            ComboBoxIdAve.Items.Add(dt(i)(0))
            ComboBoxAve.Items.Add(dt(i)(1))
        Next
        

        dt = New DataTable
        dt = Consultar("select id_per, nombre from personajes;")
        For i = 0 To dt.Rows.Count - 1
            ComboBoxIdPer.Items.Add(dt(i)(0))
            ComboBoxPer.Items.Add(dt(i)(1))
        Next
        

        dt = New DataTable
        dt = Consultar("select id_mon, nombre from monstruos;")
        For i = 0 To dt.Rows.Count - 1
            ComboBoxIdMon.Items.Add(dt(i)(0))
            ComboBoxMon.Items.Add(dt(i)(1))
        Next
        

        RadioButtonFracaso.Checked = True

        If Principal.modalt <> -1 Then
            LabelTitulo.Text = "Modificar personaje"

            Dim rw As New DataTable
            MsgBox(Principal.modalt.ToString)
            rw = Consultar("SELECT * FROM bitacora WHERE (id_ave||id_per||id_mon) like '" + Principal.modalt.ToString + "';")

            ComboBoxIdAve.SelectedItem = rw(0)(0).ToString
            ComboBoxIdPer.SelectedItem = rw(0)(1).ToString
            ComboBoxIdMon.SelectedItem = rw(0)(2).ToString
            If rw(0)(4).ToString = "Fracaso" Then
                RadioButtonFracaso.Checked = True
            ElseIf rw(0)(4).ToString = "Normal" Then
                RadioButtonNormal.Checked = True
            ElseIf rw(0)(4).ToString = "Epico" Then
                RadioButtonEpico.Checked = True
            End If

            ComboBoxIdAve.Enabled = False
            ComboBoxAve.Enabled = False
            ComboBoxIdMon.Enabled = False
            ComboBoxMon.Enabled = False
            ComboBoxIdPer.Enabled = False
            ComboBoxPer.Enabled = False
        Else
            ComboBoxIdAve.SelectedIndex = 0
            ComboBoxAve.SelectedIndex = 0
            ComboBoxIdPer.SelectedIndex = 0
            ComboBoxPer.SelectedIndex = 0
            ComboBoxIdMon.SelectedIndex = 0
            ComboBoxMon.SelectedIndex = 0
        End If
    End Sub

    Private Sub ComboBoxAve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxAve.SelectedIndexChanged
        ComboBoxIdAve.SelectedIndex = ComboBoxAve.SelectedIndex

        Dim dt As New DataTable

        Try
            dt = Consultar("select id_esc from escenarios where id_esc = " + ComboBoxIdAve.SelectedItem.ToString + ";")
            PictureBoxAve.BackgroundImage = Image.FromFile("escenarios/" + dt(0)(0).ToString + ".jpg")
        Catch
            PictureBoxAve.BackgroundImage = Image.FromFile("nada.png")
        End Try
    End Sub

    Private Sub ComboBoxIdAve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdAve.SelectedIndexChanged
        ComboBoxAve.SelectedIndex = ComboBoxIdAve.SelectedIndex
    End Sub

    Private Sub ComboBoxPer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPer.SelectedIndexChanged
        ComboBoxIdPer.SelectedIndex = ComboBoxPer.SelectedIndex
        Try
            PictureBoxPer.BackgroundImage = Image.FromFile("personajes/" + ComboBoxIdPer.SelectedItem.ToString + ".jpg")
        Catch
            PictureBoxPer.BackgroundImage = Image.FromFile("nada.png")
        End Try
    End Sub

    Private Sub ComboBoxMon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMon.SelectedIndexChanged
        ComboBoxIdMon.SelectedIndex = ComboBoxMon.SelectedIndex
        Try
            PictureBoxMon.BackgroundImage = Image.FromFile("monstruos/" + ComboBoxIdMon.SelectedItem.ToString + ".jpg")
        Catch
            PictureBoxMon.BackgroundImage = Image.FromFile("nada.png")
        End Try
    End Sub

    Private Sub ComboBoxIdPer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdPer.SelectedIndexChanged
        ComboBoxPer.SelectedIndex = ComboBoxIdPer.SelectedIndex
    End Sub

    Private Sub ComboBoxIdMon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdMon.SelectedIndexChanged
        ComboBoxMon.SelectedIndex = ComboBoxIdMon.SelectedIndex
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim modo As String = "NULL"
        If RadioButtonEpico.Checked Then
            modo = RadioButtonEpico.Tag
        ElseIf RadioButtonFracaso.Checked Then
            modo = RadioButtonFracaso.Tag
        ElseIf RadioButtonNormal.Checked Then
            modo = RadioButtonNormal.Tag
        End If
        If Principal.modalt = -1 Then
            Try
                Ejecutar("INSERT INTO bitacora VALUES (" + ComboBoxIdAve.SelectedItem.ToString + "," + ComboBoxIdAve.SelectedItem.ToString + "," + ComboBoxIdAve.SelectedItem.ToString + ",'" + DateTimePicker1.Value.ToString + "','" + modo + "')")
            Catch ex As Exception

            End Try
            MsgBox("Bitácora Añadida.")
            BuscarBitacora.DataGridViewBit.DataSource = bdfriki.Consultar("SELECT * FROM bitacora;")
            Me.Close()
        Else

            Try

                Ejecutar("UPDATE bitacora SET modo = '" + modo + "',fecha = '" + DateTimePicker1.Value.ToString + "' WHERE id_ave = " + ComboBoxIdAve.SelectedItem.ToString + " and id_per = " + ComboBoxIdPer.SelectedItem.ToString + " and id_mon = " + ComboBoxIdMon.SelectedItem.ToString + " ;")
                MsgBox("Bitacora actualizada.")
                BuscarUniverso.DataGridViewUni.DataSource = Consultar("SELECT * FROM universos;")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("ERROR :" & vbCrLf & _
                            ex.Message, "---", _
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Me.Close()
        End If
    End Sub
End Class