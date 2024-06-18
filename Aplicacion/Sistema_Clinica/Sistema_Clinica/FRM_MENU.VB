Public Class Frm_Menu
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(0, 0)
        End Select
    End Sub
    Private Sub Frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Doctores_Click(sender As Object, e As EventArgs) Handles Btn_Doctores.Click
        'Abriendo el Formulaio Usuario
        Frm_Doctores.MdiParent = Frm_Principal
        Frm_Doctores.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False

    End Sub

    Private Sub Btn_Enfermeras_Click(sender As Object, e As EventArgs) Handles Btn_Enfermeras.Click
        'Abriendo el Formulaio Usuario
        Frm_Enfermeras.MdiParent = Frm_Principal
        Frm_Enfermeras.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False

    End Sub

    Private Sub Btn_Empleados_Click(sender As Object, e As EventArgs) Handles Btn_Empleados.Click
        'Abriendo el Formulaio Usuario
        Frm_Empleados.MdiParent = Frm_Principal
        Frm_Empleados.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Pacientes_Click(sender As Object, e As EventArgs) Handles Btn_Pacientes.Click
        'Abriendo el Formulaio Usuario
        Frm_Pacientes.MdiParent = Frm_Principal
        Frm_Pacientes.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Consultas_Click(sender As Object, e As EventArgs) Handles Btn_Consultas.Click
        'Abriendo el Formulaio Usuario
        Frm_Consultas.MdiParent = Frm_Principal
        Frm_Consultas.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Rpt_Doctores_Click(sender As Object, e As EventArgs) Handles Btn_Rpt_Doctores.Click
        'Abriendo el Formulaio Usuario
        Frm_Rpt_Doctores.MdiParent = Frm_Principal
        Frm_Rpt_Doctores.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Rpt_Enfermeras_Click(sender As Object, e As EventArgs) Handles Btn_Rpt_Enfermeras.Click
        'Abriendo el Formulaio Usuario
        Frm_Rpt_Enfermeras.MdiParent = Frm_Principal
        Frm_Rpt_Enfermeras.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Rpt_Empleados_Click(sender As Object, e As EventArgs) Handles Btn_Rpt_Empleados.Click
        'Abriendo el Formulaio Usuario
        Frm_Rpt_Empleados.MdiParent = Frm_Principal
        Frm_Rpt_Empleados.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Rpt_Pacientes_Click(sender As Object, e As EventArgs) Handles Btn_Rpt_Pacientes.Click
        'Abriendo el Formulaio Usuario
        Frm_Rpt_Pacientes.MdiParent = Frm_Principal
        Frm_Rpt_Pacientes.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Rpt_Consultas_Click(sender As Object, e As EventArgs) Handles Btn_Rpt_Consultas.Click
        'Abriendo el Formulaio Usuario
        Frm_Rpt_Consultas.MdiParent = Frm_Principal
        Frm_Rpt_Consultas.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Usuarios_Click(sender As Object, e As EventArgs) Handles Btn_Usuarios.Click
        'Abriendo el Formulaio Usuario
        Frm_Usuarios.MdiParent = Frm_Principal
        Frm_Usuarios.Show()

        'Desabilitando la barra de Menu 
        Frm_Principal.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Me.Enabled = False
    End Sub

    Private Sub Btn_Acerca_Click(sender As Object, e As EventArgs) Handles Btn_Acerca.Click

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        'Cerrando la aplicacion
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            End
        End If
    End Sub
End Class