Imports Friki.bdfriki
Public Class Principal
    Public modalt As Integer
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BuscarPersonaje.Show()
        BuscarPersonaje.BringToFront()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BuscarMonstruo.Show()
        BuscarMonstruo.BringToFront()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BuscarEscenario.Show()
        BuscarEscenario.BringToFront()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BuscarAventura.Show()
        BuscarAventura.BringToFront()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BuscarUniverso.Show()
        BuscarUniverso.BringToFront()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conectar()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BuscarBitacora.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Duelo.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Torneo.ShowDialog()
    End Sub
End Class