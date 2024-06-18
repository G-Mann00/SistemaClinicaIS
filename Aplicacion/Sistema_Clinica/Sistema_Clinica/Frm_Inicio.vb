Public Class Frm_Inicio
    'medidor del tiempo
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static btecontenedor As Byte
        If btecontenedor = 1 Then
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Hide()
            Frm_Password.Show()
        Else
            btecontenedor = btecontenedor + 1
        End If
    End Sub

    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pb_Tiempo.Visible = True
    End Sub

    Private Sub Cmd_Cerrar_Click(sender As Object, e As EventArgs) Handles Cmd_Cerrar.Click
        'Cerrando el formulario de Inicio
        End
    End Sub

End Class