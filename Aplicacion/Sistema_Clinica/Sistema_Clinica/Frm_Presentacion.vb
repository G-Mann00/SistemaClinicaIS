Public Class Frm_Presentacion
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(317, 0)
        End Select
    End Sub
    Private Sub Frm_Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class