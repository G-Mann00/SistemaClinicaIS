<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.Mnu_Registrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Reg_Doctores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mnu_Reg_Enfermeras = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mnu_Reg_Empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Trasacciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Trans_Pacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Trans_Consultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Generales = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Doctores = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Enfermeras = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Especificos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Pacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Rpt_Consultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Administrador = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Admin_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Acerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stb_Barra_Estado = New System.Windows.Forms.StatusStrip()
        Me.Panel_1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel_2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel_3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Menu.SuspendLayout()
        Me.Stb_Barra_Estado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackgroundImage = CType(resources.GetObject("Menu.BackgroundImage"), System.Drawing.Image)
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Registrar, Me.Mnu_Trasacciones, Me.Mnu_Reportes, Me.Mnu_Administrador, Me.Mnu_Acerca, Me.Mnu_Salir})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(985, 24)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
        '
        'Mnu_Registrar
        '
        Me.Mnu_Registrar.BackColor = System.Drawing.Color.Transparent
        Me.Mnu_Registrar.BackgroundImage = CType(resources.GetObject("Mnu_Registrar.BackgroundImage"), System.Drawing.Image)
        Me.Mnu_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mnu_Registrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Reg_Doctores, Me.ToolStripSeparator1, Me.Mnu_Reg_Enfermeras, Me.ToolStripSeparator2, Me.Mnu_Reg_Empleados})
        Me.Mnu_Registrar.ForeColor = System.Drawing.Color.White
        Me.Mnu_Registrar.Name = "Mnu_Registrar"
        Me.Mnu_Registrar.Size = New System.Drawing.Size(71, 20)
        Me.Mnu_Registrar.Text = "  Registrar"
        Me.Mnu_Registrar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Mnu_Reg_Doctores
        '
        Me.Mnu_Reg_Doctores.Image = CType(resources.GetObject("Mnu_Reg_Doctores.Image"), System.Drawing.Image)
        Me.Mnu_Reg_Doctores.Name = "Mnu_Reg_Doctores"
        Me.Mnu_Reg_Doctores.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.Mnu_Reg_Doctores.Size = New System.Drawing.Size(173, 22)
        Me.Mnu_Reg_Doctores.Text = "Doctores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'Mnu_Reg_Enfermeras
        '
        Me.Mnu_Reg_Enfermeras.Image = CType(resources.GetObject("Mnu_Reg_Enfermeras.Image"), System.Drawing.Image)
        Me.Mnu_Reg_Enfermeras.Name = "Mnu_Reg_Enfermeras"
        Me.Mnu_Reg_Enfermeras.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.Mnu_Reg_Enfermeras.Size = New System.Drawing.Size(173, 22)
        Me.Mnu_Reg_Enfermeras.Text = "Enfermeras"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'Mnu_Reg_Empleados
        '
        Me.Mnu_Reg_Empleados.Image = CType(resources.GetObject("Mnu_Reg_Empleados.Image"), System.Drawing.Image)
        Me.Mnu_Reg_Empleados.Name = "Mnu_Reg_Empleados"
        Me.Mnu_Reg_Empleados.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Mnu_Reg_Empleados.Size = New System.Drawing.Size(173, 22)
        Me.Mnu_Reg_Empleados.Text = "Empleados"
        '
        'Mnu_Trasacciones
        '
        Me.Mnu_Trasacciones.BackColor = System.Drawing.Color.Transparent
        Me.Mnu_Trasacciones.BackgroundImage = CType(resources.GetObject("Mnu_Trasacciones.BackgroundImage"), System.Drawing.Image)
        Me.Mnu_Trasacciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mnu_Trasacciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Trans_Pacientes, Me.Mnu_Trans_Consultas})
        Me.Mnu_Trasacciones.ForeColor = System.Drawing.Color.White
        Me.Mnu_Trasacciones.Name = "Mnu_Trasacciones"
        Me.Mnu_Trasacciones.Size = New System.Drawing.Size(102, 20)
        Me.Mnu_Trasacciones.Text = "   Transacciones"
        Me.Mnu_Trasacciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mnu_Trans_Pacientes
        '
        Me.Mnu_Trans_Pacientes.Image = CType(resources.GetObject("Mnu_Trans_Pacientes.Image"), System.Drawing.Image)
        Me.Mnu_Trans_Pacientes.Name = "Mnu_Trans_Pacientes"
        Me.Mnu_Trans_Pacientes.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Mnu_Trans_Pacientes.Size = New System.Drawing.Size(168, 22)
        Me.Mnu_Trans_Pacientes.Text = "Pacientes"
        '
        'Mnu_Trans_Consultas
        '
        Me.Mnu_Trans_Consultas.Image = CType(resources.GetObject("Mnu_Trans_Consultas.Image"), System.Drawing.Image)
        Me.Mnu_Trans_Consultas.Name = "Mnu_Trans_Consultas"
        Me.Mnu_Trans_Consultas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Mnu_Trans_Consultas.Size = New System.Drawing.Size(168, 22)
        Me.Mnu_Trans_Consultas.Text = "Consultas"
        '
        'Mnu_Reportes
        '
        Me.Mnu_Reportes.BackColor = System.Drawing.Color.Transparent
        Me.Mnu_Reportes.BackgroundImage = CType(resources.GetObject("Mnu_Reportes.BackgroundImage"), System.Drawing.Image)
        Me.Mnu_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mnu_Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Rpt_Generales, Me.Mnu_Rpt_Especificos})
        Me.Mnu_Reportes.ForeColor = System.Drawing.Color.White
        Me.Mnu_Reportes.Name = "Mnu_Reportes"
        Me.Mnu_Reportes.Size = New System.Drawing.Size(74, 20)
        Me.Mnu_Reportes.Text = "   Reportes"
        Me.Mnu_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mnu_Rpt_Generales
        '
        Me.Mnu_Rpt_Generales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Rpt_Doctores, Me.Mnu_Rpt_Enfermeras, Me.Mnu_Rpt_Empleados})
        Me.Mnu_Rpt_Generales.Image = CType(resources.GetObject("Mnu_Rpt_Generales.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Generales.Name = "Mnu_Rpt_Generales"
        Me.Mnu_Rpt_Generales.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Rpt_Generales.Text = "Generales"
        '
        'Mnu_Rpt_Doctores
        '
        Me.Mnu_Rpt_Doctores.Image = CType(resources.GetObject("Mnu_Rpt_Doctores.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Doctores.Name = "Mnu_Rpt_Doctores"
        Me.Mnu_Rpt_Doctores.Size = New System.Drawing.Size(190, 22)
        Me.Mnu_Rpt_Doctores.Text = "Listado de Doctores"
        '
        'Mnu_Rpt_Enfermeras
        '
        Me.Mnu_Rpt_Enfermeras.Image = CType(resources.GetObject("Mnu_Rpt_Enfermeras.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Enfermeras.Name = "Mnu_Rpt_Enfermeras"
        Me.Mnu_Rpt_Enfermeras.Size = New System.Drawing.Size(190, 22)
        Me.Mnu_Rpt_Enfermeras.Text = "Listado de Enfermeras"
        '
        'Mnu_Rpt_Empleados
        '
        Me.Mnu_Rpt_Empleados.Image = CType(resources.GetObject("Mnu_Rpt_Empleados.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Empleados.Name = "Mnu_Rpt_Empleados"
        Me.Mnu_Rpt_Empleados.Size = New System.Drawing.Size(190, 22)
        Me.Mnu_Rpt_Empleados.Text = "Listado de Empleados"
        '
        'Mnu_Rpt_Especificos
        '
        Me.Mnu_Rpt_Especificos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Rpt_Pacientes, Me.Mnu_Rpt_Consultas})
        Me.Mnu_Rpt_Especificos.Image = CType(resources.GetObject("Mnu_Rpt_Especificos.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Especificos.Name = "Mnu_Rpt_Especificos"
        Me.Mnu_Rpt_Especificos.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Rpt_Especificos.Text = "Especificos"
        '
        'Mnu_Rpt_Pacientes
        '
        Me.Mnu_Rpt_Pacientes.Image = CType(resources.GetObject("Mnu_Rpt_Pacientes.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Pacientes.Name = "Mnu_Rpt_Pacientes"
        Me.Mnu_Rpt_Pacientes.Size = New System.Drawing.Size(167, 22)
        Me.Mnu_Rpt_Pacientes.Text = "Lista de Pacientes"
        '
        'Mnu_Rpt_Consultas
        '
        Me.Mnu_Rpt_Consultas.Image = CType(resources.GetObject("Mnu_Rpt_Consultas.Image"), System.Drawing.Image)
        Me.Mnu_Rpt_Consultas.Name = "Mnu_Rpt_Consultas"
        Me.Mnu_Rpt_Consultas.Size = New System.Drawing.Size(167, 22)
        Me.Mnu_Rpt_Consultas.Text = "Lista de Consulta"
        '
        'Mnu_Administrador
        '
        Me.Mnu_Administrador.BackColor = System.Drawing.Color.Transparent
        Me.Mnu_Administrador.BackgroundImage = CType(resources.GetObject("Mnu_Administrador.BackgroundImage"), System.Drawing.Image)
        Me.Mnu_Administrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mnu_Administrador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Admin_Usuarios})
        Me.Mnu_Administrador.ForeColor = System.Drawing.Color.White
        Me.Mnu_Administrador.Name = "Mnu_Administrador"
        Me.Mnu_Administrador.Size = New System.Drawing.Size(104, 20)
        Me.Mnu_Administrador.Text = "   Administrador"
        Me.Mnu_Administrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mnu_Admin_Usuarios
        '
        Me.Mnu_Admin_Usuarios.Image = CType(resources.GetObject("Mnu_Admin_Usuarios.Image"), System.Drawing.Image)
        Me.Mnu_Admin_Usuarios.Name = "Mnu_Admin_Usuarios"
        Me.Mnu_Admin_Usuarios.Size = New System.Drawing.Size(114, 22)
        Me.Mnu_Admin_Usuarios.Text = "Usuario"
        '
        'Mnu_Acerca
        '
        Me.Mnu_Acerca.BackColor = System.Drawing.Color.Transparent
        Me.Mnu_Acerca.BackgroundImage = CType(resources.GetObject("Mnu_Acerca.BackgroundImage"), System.Drawing.Image)
        Me.Mnu_Acerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mnu_Acerca.ForeColor = System.Drawing.Color.White
        Me.Mnu_Acerca.Name = "Mnu_Acerca"
        Me.Mnu_Acerca.Size = New System.Drawing.Size(67, 20)
        Me.Mnu_Acerca.Text = "   Acerca "
        Me.Mnu_Acerca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mnu_Salir
        '
        Me.Mnu_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Mnu_Salir.BackgroundImage = CType(resources.GetObject("Mnu_Salir.BackgroundImage"), System.Drawing.Image)
        Me.Mnu_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mnu_Salir.ForeColor = System.Drawing.Color.White
        Me.Mnu_Salir.Name = "Mnu_Salir"
        Me.Mnu_Salir.Size = New System.Drawing.Size(50, 20)
        Me.Mnu_Salir.Text = "   Salir"
        Me.Mnu_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Stb_Barra_Estado
        '
        Me.Stb_Barra_Estado.BackgroundImage = CType(resources.GetObject("Stb_Barra_Estado.BackgroundImage"), System.Drawing.Image)
        Me.Stb_Barra_Estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Panel_1, Me.Panel_2, Me.Panel_3})
        Me.Stb_Barra_Estado.Location = New System.Drawing.Point(0, 422)
        Me.Stb_Barra_Estado.Name = "Stb_Barra_Estado"
        Me.Stb_Barra_Estado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Stb_Barra_Estado.Size = New System.Drawing.Size(985, 22)
        Me.Stb_Barra_Estado.TabIndex = 2
        Me.Stb_Barra_Estado.Text = "StatusStrip1"
        '
        'Panel_1
        '
        Me.Panel_1.AutoSize = False
        Me.Panel_1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_1.ForeColor = System.Drawing.Color.White
        Me.Panel_1.Image = CType(resources.GetObject("Panel_1.Image"), System.Drawing.Image)
        Me.Panel_1.Name = "Panel_1"
        Me.Panel_1.Size = New System.Drawing.Size(1120, 17)
        Me.Panel_1.Text = "Usuario:"
        '
        'Panel_2
        '
        Me.Panel_2.AutoSize = False
        Me.Panel_2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_2.ForeColor = System.Drawing.Color.White
        Me.Panel_2.Image = CType(resources.GetObject("Panel_2.Image"), System.Drawing.Image)
        Me.Panel_2.Name = "Panel_2"
        Me.Panel_2.Size = New System.Drawing.Size(100, 17)
        Me.Panel_2.Text = "Fecha:"
        '
        'Panel_3
        '
        Me.Panel_3.AutoSize = False
        Me.Panel_3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_3.ForeColor = System.Drawing.Color.White
        Me.Panel_3.Name = "Panel_3"
        Me.Panel_3.Size = New System.Drawing.Size(100, 17)
        Me.Panel_3.Text = "Hora:"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 444)
        Me.Controls.Add(Me.Stb_Barra_Estado)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Frm_Principal"
        Me.Text = "SISTEMA DE CLINICA..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.Stb_Barra_Estado.ResumeLayout(False)
        Me.Stb_Barra_Estado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Stb_Barra_Estado As StatusStrip
    Friend WithEvents Mnu_Registrar As ToolStripMenuItem
    Friend WithEvents Mnu_Reg_Doctores As ToolStripMenuItem
    Friend WithEvents Mnu_Reg_Enfermeras As ToolStripMenuItem
    Friend WithEvents Mnu_Trasacciones As ToolStripMenuItem
    Friend WithEvents Mnu_Trans_Pacientes As ToolStripMenuItem
    Friend WithEvents Mnu_Trans_Consultas As ToolStripMenuItem
    Friend WithEvents Mnu_Reportes As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Generales As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Doctores As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Enfermeras As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Empleados As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Especificos As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Pacientes As ToolStripMenuItem
    Friend WithEvents Mnu_Rpt_Consultas As ToolStripMenuItem
    Friend WithEvents Mnu_Administrador As ToolStripMenuItem
    Friend WithEvents Mnu_Admin_Usuarios As ToolStripMenuItem
    Friend WithEvents Mnu_Acerca As ToolStripMenuItem
    Friend WithEvents Mnu_Salir As ToolStripMenuItem
    Friend WithEvents Panel_1 As ToolStripStatusLabel
    Friend WithEvents Panel_2 As ToolStripStatusLabel
    Friend WithEvents Panel_3 As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Mnu_Reg_Empleados As ToolStripMenuItem
End Class
