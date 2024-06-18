Public Class Frm_Piedepagina
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(0, 582)
        End Select
    End Sub
    Private Sub Frm_Piedepagina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class