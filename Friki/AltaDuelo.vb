Public Class AltaDuelo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PanelBuscarPersonaje.Visible Then
            PanelBuscarPersonaje.Hide()
        Else
            PanelBuscarPersonaje.Show()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PanelBuscarPersonaje.Hide()
    End Sub
End Class