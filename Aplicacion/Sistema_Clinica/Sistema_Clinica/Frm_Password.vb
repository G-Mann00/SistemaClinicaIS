Public Class Frm_Password
    Private Sub Frm_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Limpiando campos
        Txt_Login.Text = ""
        Txt_Login.Text = ""
        Txt_Login.Focus()

        'Desbloqueando Campos
        Txt_Login.ReadOnly = False
        Txt_Login.ReadOnly = False
        Pb_Tiempo.Visible = False

    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        'Verificando Datos
        On Error GoTo HORROR

        If Txt_Login.Text = "" Or Txt_Password.Text = "" Then
            MessageBox.Show("Debe de digitar el Usuario o el Password!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Accesando al Sistema
        CONSULTA = "SELECT Usuario,Nombre_Usuario,Tipo_Usuario FROM Usuarios " _
                & "WHERE (Usuario = '" & Txt_Login.Text & "') AND (Clave = '" & Txt_Password.Text & "') AND (Activo = 1)"
        RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
        If (RS_CONSULTA.HasRows = True) Then
            RS_CONSULTA.Read()
            LOGIN_USER = RS_CONSULTA.Item(0).ToString
            NOMBRE_USER = RS_CONSULTA.Item(1).ToString
            TIPO_USER = RS_CONSULTA.Item(2).ToString
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            'Control del Tiempo
            Pb_Tiempo.Visible = True
            I = 0
            Pb_Tiempo.Maximum = 1000
            Do While I <= Pb_Tiempo.Maximum
                Pb_Tiempo.Value = I
                I = I + 5
            Loop
            Pb_Tiempo.Visible = False

            Frm_Principal.Show()
            Close()
        Else
            MessageBox.Show("Cuenta de Acceso No Existe o está de Baja!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_Login.Text = ""
            Txt_Password.Text = ""
            Txt_Login.Focus()
        End If
        Exit Sub

HORROR:
        MessageBox.Show("Datos Incorrectos de la Cuenta de Acceso!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Txt_Login.Text = ""
        Txt_Password.Text = ""
        Txt_Login.Focus()
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando el formulario Password
        End
    End Sub

    Private Sub Txt_Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Login.KeyPress
        'Ir al otro control
        If e.KeyChar = Chr(Keys.Enter) Then
            Txt_Password.Focus()
        End If

    End Sub

    Private Sub Txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Password.KeyPress
        'Ir al otro control
        If e.KeyChar = Chr(Keys.Enter) Then
            Btn_Ok_Click(sender, e)
        End If
    End Sub

    Private Sub Pb_Tiempo_Click(sender As Object, e As EventArgs) Handles Pb_Tiempo.Click

    End Sub
End Class