Public Class Frm_Principal
    Private Sub Frm_Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Fin de la Aplicación
        Dim Respuesta As Integer
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            e.Cancel = False
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'visualizando el formulario menu
        Frm_Menu.MdiParent = Me
        Frm_Menu.Show()

        'Visualizando el Formulario Presentacion
        Frm_Presentacion.MdiParent = Me
        Frm_Presentacion.Show()

        'visualizando el formulario pie de página
        Frm_Piedepagina.MdiParent = Me
        Frm_Piedepagina.Show()

        Me.Text = SISTEMA
        Me.Stb_Barra_Estado.Items(0).Text = Space(0) & "USUARIO: " & LOGIN_USER & Space(15) & "NOMBRE DEL USUARIO: " & NOMBRE_USER & Space(15) & "TIPO DE CUENTA: " & TIPO_USER
        Me.Stb_Barra_Estado.Items(1).Text = UCase(Format(Now, "SHORT DATE"))
        Me.Stb_Barra_Estado.Items(2).Text = UCase(Format(Now, "hh:mm: tt"))

        If TIPO_USER <> "ADMINISTRADOR" Then
            Me.Mnu_Admin_Usuarios.Enabled = False
            Frm_Menu.Btn_Usuarios.Enabled = False

        ElseIf TIPO_USER = "ADMINISTRADOR" Then
            Me.Mnu_Admin_Usuarios.Enabled = True
            Frm_Menu.Btn_Usuarios.Enabled = True

        End If
    End Sub

    Private Sub Mnu_Reg_Doctores_Click(sender As Object, e As EventArgs) Handles Mnu_Reg_Doctores.Click
        'Abriendo el Formulaio de Doctores
        Frm_Doctores.MdiParent = Me
        Frm_Doctores.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Reg_Enfermeras_Click(sender As Object, e As EventArgs) Handles Mnu_Reg_Enfermeras.Click
        'Abriendo el Formulaio de Doctores
        Frm_Enfermeras.MdiParent = Me
        Frm_Enfermeras.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Reg_Empleados_Click(sender As Object, e As EventArgs) Handles Mnu_Reg_Empleados.Click
        'Abriendo el Formulaio de Doctores
        Frm_Empleados.MdiParent = Me
        Frm_Empleados.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Trans_Pacientes_Click(sender As Object, e As EventArgs) Handles Mnu_Trans_Pacientes.Click
        'Abriendo el Formulaio de Doctores
        Frm_Pacientes.MdiParent = Me
        Frm_Pacientes.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Trans_Consultas_Click(sender As Object, e As EventArgs) Handles Mnu_Trans_Consultas.Click
        'Abriendo el Formulaio de Doctores
        Frm_Consultas.MdiParent = Me
        Frm_Consultas.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub
    Private Sub Mnu_Rpt_Doctores_Click(sender As Object, e As EventArgs) Handles Mnu_Rpt_Doctores.Click
        'Abriendo el Formulaio de Doctores
        Frm_Rpt_Doctores.MdiParent = Me
        Frm_Rpt_Doctores.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Rpt_Enfermeras_Click(sender As Object, e As EventArgs) Handles Mnu_Rpt_Enfermeras.Click
        'Abriendo el Formulaio de Doctores
        Frm_Rpt_Enfermeras.MdiParent = Me
        Frm_Rpt_Enfermeras.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Rpt_Empleados_Click(sender As Object, e As EventArgs) Handles Mnu_Rpt_Empleados.Click
        'Abriendo el Formulaio de Doctores
        Frm_Rpt_Empleados.MdiParent = Me
        Frm_Rpt_Empleados.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Rpt_Pacientes_Click(sender As Object, e As EventArgs) Handles Mnu_Rpt_Pacientes.Click
        'Abriendo el Formulaio de Doctores
        Frm_Rpt_Pacientes.MdiParent = Me
        Frm_Rpt_Pacientes.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub

    Private Sub Mnu_Rpt_Consultas_Click(sender As Object, e As EventArgs) Handles Mnu_Rpt_Consultas.Click
        'Abriendo el Formulaio de Doctores
        Frm_Rpt_Consultas.MdiParent = Me
        Frm_Rpt_Consultas.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub
    Private Sub Mnu_Admin_Usuarios_Click(sender As Object, e As EventArgs) Handles Mnu_Admin_Usuarios.Click
        'Abriendo el Formulaio de Doctores
        Frm_Usuarios.MdiParent = Me
        Frm_Usuarios.Show()

        'Desabilitando la barra de Menu 
        Me.Menu.Enabled = False

        'Ocultando el formulario Presentación
        Frm_Presentacion.Hide()

        'Habilitando el formulario Menu
        Frm_Menu.Enabled = False

    End Sub
    Private Sub Mnu_Acerca_Click(sender As Object, e As EventArgs) Handles Mnu_Acerca.Click

    End Sub

    Private Sub Mnu_Salir_Click(sender As Object, e As EventArgs) Handles Mnu_Salir.Click
        'Cerrando la aplicacion
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            End
        End If
    End Sub
End Class
