Public Class AltaMonstruo

    Private Sub AltaMonstruo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelLineaH.Size = New Size(Me.Bounds.Width, 1)
        PanelLineaV.Size = New Size(1, Me.Bounds.Height)

        'Rellenar si es modificar
        If Principal.modalt <> -1 Then
            LabelTitulo.Text = "Modificar monstruo"

            Dim rw As New DataTable
            rw = Consultar("SELECT id_mon, nombre, color, dificultad FROM monstruos WHERE id_mon = " + Principal.modalt.ToString + ";")
            TextBoxNombre.Text = rw(0)(1).ToString
            If RadioButtonAmarillo.Tag = rw(0)(2).ToString Then
                RadioButtonAmarillo.Checked = True
            ElseIf RadioButtonAzul.Tag = rw(0)(2).ToString Then
                RadioButtonAzul.Checked = True
            ElseIf RadioButtonBlanco.Tag = rw(0)(2).ToString Then
                RadioButtonBlanco.Checked = True
            ElseIf RadioButtonGris.Tag = rw(0)(2).ToString Then
                RadioButtonGris.Checked = True
            ElseIf RadioButtonIncoloro.Tag = rw(0)(2).ToString Then
                RadioButtonIncoloro.Checked = True
            ElseIf RadioButtonLila.Tag = rw(0)(2).ToString Then
                RadioButtonLila.Checked = True
            ElseIf RadioButtonMarron.Tag = rw(0)(2).ToString Then
                RadioButtonMarron.Checked = True
            ElseIf RadioButtonMoco.Tag = rw(0)(2).ToString Then
                RadioButtonMoco.Checked = True
            ElseIf RadioButtonMulticolor.Tag = rw(0)(2).ToString Then
                RadioButtonMulticolor.Checked = True
            ElseIf RadioButtonNaranja.Tag = rw(0)(2).ToString Then
                RadioButtonNaranja.Checked = True
            ElseIf RadioButtonNegro.Tag = rw(0)(2).ToString Then
                RadioButtonNegro.Checked = True
            ElseIf RadioButtonRojo.Tag = rw(0)(2).ToString Then
                RadioButtonRojo.Checked = True
            ElseIf RadioButtonRosa.Tag = rw(0)(2).ToString Then
                RadioButtonRosa.Checked = True
            ElseIf RadioButtonRubio.Tag = rw(0)(2).ToString Then
                RadioButtonRosa.Checked = True
            ElseIf RadioButtonRubio.Tag = rw(0)(2).ToString Then
                RadioButtonRubio.Checked = True
            ElseIf RadioButtonVerde.Tag = rw(0)(2).ToString Then
                RadioButtonVerde.Checked = True
            End If
            If RadioButtonBaja.Tag = rw(0)(3).ToString Then
                RadioButtonBaja.Checked = True
            ElseIf RadioButtonMedia.Tag = rw(0)(3).ToString Then
                RadioButtonMedia.Checked = True
            ElseIf RadioButtonAlta.Tag = rw(0)(3).ToString Then
                RadioButtonAlta.Checked = True
            ElseIf RadioButtonExtrema.Tag = rw(0)(3).ToString Then
                RadioButtonExtrema.Checked = True
            End If

        Else
            LabelTitulo.Text = "Añadir monstruo"
            TextBoxNombre.Text = ""
            RadioButtonIncoloro.Checked = True
            RadioButtonBaja.Checked = True
        End If
    End Sub

    Private Sub RadioButtonIncoloro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonIncoloro.CheckedChanged
        TextBoxColor.Text = RadioButtonIncoloro.Tag.ToString
    End Sub

    Private Sub RadioButtonBlanco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonBlanco.CheckedChanged
        TextBoxColor.Text = RadioButtonBlanco.Tag.ToString
    End Sub

    Private Sub RadioButtonGris_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonGris.CheckedChanged
        TextBoxColor.Text = RadioButtonGris.Tag.ToString
    End Sub

    Private Sub RadioButtonNegro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNegro.CheckedChanged
        TextBoxColor.Text = RadioButtonNegro.Tag.ToString
    End Sub

    Private Sub RadioButtonRubio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRubio.CheckedChanged
        TextBoxColor.Text = RadioButtonRubio.Tag.ToString
    End Sub

    Private Sub RadioButtonAmarillo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAmarillo.CheckedChanged
        TextBoxColor.Text = RadioButtonAmarillo.Tag.ToString
    End Sub

    Private Sub RadioButtonNaranja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNaranja.CheckedChanged
        TextBoxColor.Text = RadioButtonNaranja.Tag.ToString
    End Sub

    Private Sub RadioButtonRojo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRojo.CheckedChanged
        TextBoxColor.Text = RadioButtonRojo.Tag.ToString
    End Sub

    Private Sub RadioButtonLila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonLila.CheckedChanged
        TextBoxColor.Text = RadioButtonLila.Tag.ToString
    End Sub

    Private Sub RadioButtonAzul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAzul.CheckedChanged
        TextBoxColor.Text = RadioButtonAzul.Tag.ToString
    End Sub

    Private Sub RadioButtonVerde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonVerde.CheckedChanged
        TextBoxColor.Text = RadioButtonVerde.Tag.ToString
    End Sub

    Private Sub RadioButtonMoco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMoco.CheckedChanged
        TextBoxColor.Text = RadioButtonMoco.Tag.ToString
    End Sub

    Private Sub RadioButtonRosa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRosa.CheckedChanged
        TextBoxColor.Text = RadioButtonRosa.Tag.ToString
    End Sub

    Private Sub RadioButtonMarron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMarron.CheckedChanged
        TextBoxColor.Text = RadioButtonMarron.Tag.ToString
    End Sub

    Private Sub RadioButtonMulticolor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMulticolor.CheckedChanged
        TextBoxColor.Text = RadioButtonMulticolor.Tag.ToString
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dificultad As String = ""
        If RadioButtonAlta.Checked Then
            dificultad = RadioButtonAlta.Tag.ToString
        ElseIf RadioButtonExtrema.Checked Then
            dificultad = RadioButtonExtrema.Tag.ToString
        ElseIf RadioButtonMedia.Checked Then
            dificultad = RadioButtonMedia.Tag.ToString
        ElseIf RadioButtonBaja.Checked Then
            dificultad = RadioButtonBaja.Tag.ToString
        End If

        If Principal.modalt = -1 Then
            Dim id As Integer = 0
            Dim dt As New DataTable
            dt = Consultar("select max(id_mon) from monstruos;")
            id = dt(0)(0)
            id += 1

            If TextBoxNombre.Text <> "" Then
                bdfriki.Ejecutar("INSERT INTO monstruos (id_mon, nombre , color, dificultad)  VALUES(" + id.ToString + ",'" + TextBoxNombre.Text + "','" + TextBoxColor.Text + "','" + dificultad + "');")
                BuscarMonstruo.DataGridViewMon.DataSource = Consultar("SELECT id_mon,nombre , color, dificultad FROM monstruos;")
                MsgBox("Monstruo Añadido.")
                Me.Close()
            Else
                MsgBox("Debes rellenar los campos obligatorios")
            End If
        Else
            If TextBoxNombre.Text <> "" Then
                Try
                    Ejecutar("UPDATE monstruos SET  nombre = '" + TextBoxNombre.Text + "',color = '" + TextBoxColor.Text + "',dificultad = '" + dificultad + "' WHERE id_mon = " + Principal.modalt.ToString + ";")
                    MsgBox("Monstruo actualizado.")
                    BuscarMonstruo.DataGridViewMon.DataSource = Consultar("SELECT id_mon,nombre, color, dificultad  FROM monstruos;")
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