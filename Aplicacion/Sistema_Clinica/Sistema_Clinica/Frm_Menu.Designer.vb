<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Acerca = New System.Windows.Forms.Button()
        Me.Btn_Usuarios = New System.Windows.Forms.Button()
        Me.Btn_Rpt_Doctores = New System.Windows.Forms.Button()
        Me.Btn_Rpt_Pacientes = New System.Windows.Forms.Button()
        Me.Btn_Rpt_Consultas = New System.Windows.Forms.Button()
        Me.Btn_Rpt_Enfermeras = New System.Windows.Forms.Button()
        Me.Btn_Rpt_Empleados = New System.Windows.Forms.Button()
        Me.Btn_Consultas = New System.Windows.Forms.Button()
        Me.Btn_Empleados = New System.Windows.Forms.Button()
        Me.Btn_Pacientes = New System.Windows.Forms.Button()
        Me.Btn_Enfermeras = New System.Windows.Forms.Button()
        Me.Btn_Doctores = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Salir.FlatAppearance.BorderSize = 0
        Me.Btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Salir.Image = CType(resources.GetObject("Btn_Salir.Image"), System.Drawing.Image)
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(12, 541)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(249, 26)
        Me.Btn_Salir.TabIndex = 70
        Me.Btn_Salir.Text = "       Salir del Sistema      "
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_Acerca
        '
        Me.Btn_Acerca.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Acerca.FlatAppearance.BorderSize = 0
        Me.Btn_Acerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Acerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Acerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Acerca.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Acerca.Image = CType(resources.GetObject("Btn_Acerca.Image"), System.Drawing.Image)
        Me.Btn_Acerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Acerca.Location = New System.Drawing.Point(12, 507)
        Me.Btn_Acerca.Name = "Btn_Acerca"
        Me.Btn_Acerca.Size = New System.Drawing.Size(249, 26)
        Me.Btn_Acerca.TabIndex = 71
        Me.Btn_Acerca.Text = "       Acerca del Sistema   "
        Me.Btn_Acerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Acerca.UseVisualStyleBackColor = False
        '
        'Btn_Usuarios
        '
        Me.Btn_Usuarios.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Usuarios.FlatAppearance.BorderSize = 0
        Me.Btn_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Usuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Usuarios.Image = CType(resources.GetObject("Btn_Usuarios.Image"), System.Drawing.Image)
        Me.Btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Usuarios.Location = New System.Drawing.Point(12, 475)
        Me.Btn_Usuarios.Name = "Btn_Usuarios"
        Me.Btn_Usuarios.Size = New System.Drawing.Size(249, 26)
        Me.Btn_Usuarios.TabIndex = 72
        Me.Btn_Usuarios.Text = "       Registrar Usuarios    "
        Me.Btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Usuarios.UseVisualStyleBackColor = False
        '
        'Btn_Rpt_Doctores
        '
        Me.Btn_Rpt_Doctores.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Rpt_Doctores.FlatAppearance.BorderSize = 0
        Me.Btn_Rpt_Doctores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Rpt_Doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rpt_Doctores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rpt_Doctores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Rpt_Doctores.Image = CType(resources.GetObject("Btn_Rpt_Doctores.Image"), System.Drawing.Image)
        Me.Btn_Rpt_Doctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Doctores.Location = New System.Drawing.Point(15, 276)
        Me.Btn_Rpt_Doctores.Name = "Btn_Rpt_Doctores"
        Me.Btn_Rpt_Doctores.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Rpt_Doctores.TabIndex = 69
        Me.Btn_Rpt_Doctores.Text = "       Listado de Doctores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_Rpt_Doctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Doctores.UseVisualStyleBackColor = False
        '
        'Btn_Rpt_Pacientes
        '
        Me.Btn_Rpt_Pacientes.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Rpt_Pacientes.FlatAppearance.BorderSize = 0
        Me.Btn_Rpt_Pacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Rpt_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rpt_Pacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rpt_Pacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Rpt_Pacientes.Image = CType(resources.GetObject("Btn_Rpt_Pacientes.Image"), System.Drawing.Image)
        Me.Btn_Rpt_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Pacientes.Location = New System.Drawing.Point(15, 372)
        Me.Btn_Rpt_Pacientes.Name = "Btn_Rpt_Pacientes"
        Me.Btn_Rpt_Pacientes.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Rpt_Pacientes.TabIndex = 68
        Me.Btn_Rpt_Pacientes.Text = "       Listado de Pacientes"
        Me.Btn_Rpt_Pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Pacientes.UseVisualStyleBackColor = False
        '
        'Btn_Rpt_Consultas
        '
        Me.Btn_Rpt_Consultas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Rpt_Consultas.FlatAppearance.BorderSize = 0
        Me.Btn_Rpt_Consultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Rpt_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rpt_Consultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rpt_Consultas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Rpt_Consultas.Image = CType(resources.GetObject("Btn_Rpt_Consultas.Image"), System.Drawing.Image)
        Me.Btn_Rpt_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Consultas.Location = New System.Drawing.Point(15, 404)
        Me.Btn_Rpt_Consultas.Name = "Btn_Rpt_Consultas"
        Me.Btn_Rpt_Consultas.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Rpt_Consultas.TabIndex = 66
        Me.Btn_Rpt_Consultas.Text = "       Listado de Consultas"
        Me.Btn_Rpt_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Consultas.UseVisualStyleBackColor = False
        '
        'Btn_Rpt_Enfermeras
        '
        Me.Btn_Rpt_Enfermeras.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Rpt_Enfermeras.FlatAppearance.BorderSize = 0
        Me.Btn_Rpt_Enfermeras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Rpt_Enfermeras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rpt_Enfermeras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rpt_Enfermeras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Rpt_Enfermeras.Image = CType(resources.GetObject("Btn_Rpt_Enfermeras.Image"), System.Drawing.Image)
        Me.Btn_Rpt_Enfermeras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Enfermeras.Location = New System.Drawing.Point(15, 308)
        Me.Btn_Rpt_Enfermeras.Name = "Btn_Rpt_Enfermeras"
        Me.Btn_Rpt_Enfermeras.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Rpt_Enfermeras.TabIndex = 67
        Me.Btn_Rpt_Enfermeras.Text = "       Listado de Enfermeras"
        Me.Btn_Rpt_Enfermeras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Enfermeras.UseVisualStyleBackColor = False
        '
        'Btn_Rpt_Empleados
        '
        Me.Btn_Rpt_Empleados.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Rpt_Empleados.FlatAppearance.BorderSize = 0
        Me.Btn_Rpt_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Rpt_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rpt_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rpt_Empleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Rpt_Empleados.Image = CType(resources.GetObject("Btn_Rpt_Empleados.Image"), System.Drawing.Image)
        Me.Btn_Rpt_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Empleados.Location = New System.Drawing.Point(15, 340)
        Me.Btn_Rpt_Empleados.Name = "Btn_Rpt_Empleados"
        Me.Btn_Rpt_Empleados.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Rpt_Empleados.TabIndex = 65
        Me.Btn_Rpt_Empleados.Text = "       Listado de Empleados"
        Me.Btn_Rpt_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Rpt_Empleados.UseVisualStyleBackColor = False
        '
        'Btn_Consultas
        '
        Me.Btn_Consultas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Consultas.FlatAppearance.BorderSize = 0
        Me.Btn_Consultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Consultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Consultas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Consultas.Image = CType(resources.GetObject("Btn_Consultas.Image"), System.Drawing.Image)
        Me.Btn_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Consultas.Location = New System.Drawing.Point(15, 206)
        Me.Btn_Consultas.Name = "Btn_Consultas"
        Me.Btn_Consultas.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Consultas.TabIndex = 62
        Me.Btn_Consultas.Text = "       Registrar consultas"
        Me.Btn_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Consultas.UseVisualStyleBackColor = False
        '
        'Btn_Empleados
        '
        Me.Btn_Empleados.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Empleados.FlatAppearance.BorderSize = 0
        Me.Btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Empleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Empleados.Image = CType(resources.GetObject("Btn_Empleados.Image"), System.Drawing.Image)
        Me.Btn_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Empleados.Location = New System.Drawing.Point(12, 106)
        Me.Btn_Empleados.Name = "Btn_Empleados"
        Me.Btn_Empleados.Size = New System.Drawing.Size(249, 26)
        Me.Btn_Empleados.TabIndex = 64
        Me.Btn_Empleados.Text = "       Registrar Empleados"
        Me.Btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Empleados.UseVisualStyleBackColor = False
        '
        'Btn_Pacientes
        '
        Me.Btn_Pacientes.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Pacientes.FlatAppearance.BorderSize = 0
        Me.Btn_Pacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Pacientes.Image = CType(resources.GetObject("Btn_Pacientes.Image"), System.Drawing.Image)
        Me.Btn_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pacientes.Location = New System.Drawing.Point(15, 174)
        Me.Btn_Pacientes.Name = "Btn_Pacientes"
        Me.Btn_Pacientes.Size = New System.Drawing.Size(246, 26)
        Me.Btn_Pacientes.TabIndex = 60
        Me.Btn_Pacientes.Text = "       Agregar Pacientes"
        Me.Btn_Pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pacientes.UseVisualStyleBackColor = False
        '
        'Btn_Enfermeras
        '
        Me.Btn_Enfermeras.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Enfermeras.FlatAppearance.BorderSize = 0
        Me.Btn_Enfermeras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Enfermeras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Enfermeras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enfermeras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Enfermeras.Image = CType(resources.GetObject("Btn_Enfermeras.Image"), System.Drawing.Image)
        Me.Btn_Enfermeras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Enfermeras.Location = New System.Drawing.Point(12, 74)
        Me.Btn_Enfermeras.Name = "Btn_Enfermeras"
        Me.Btn_Enfermeras.Size = New System.Drawing.Size(249, 26)
        Me.Btn_Enfermeras.TabIndex = 63
        Me.Btn_Enfermeras.Text = "       Registrar Enfermeras"
        Me.Btn_Enfermeras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Enfermeras.UseVisualStyleBackColor = False
        '
        'Btn_Doctores
        '
        Me.Btn_Doctores.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Doctores.FlatAppearance.BorderSize = 0
        Me.Btn_Doctores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Btn_Doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Doctores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Doctores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Doctores.Image = CType(resources.GetObject("Btn_Doctores.Image"), System.Drawing.Image)
        Me.Btn_Doctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Doctores.Location = New System.Drawing.Point(12, 42)
        Me.Btn_Doctores.Name = "Btn_Doctores"
        Me.Btn_Doctores.Size = New System.Drawing.Size(249, 26)
        Me.Btn_Doctores.TabIndex = 61
        Me.Btn_Doctores.Text = "       Registrar Doctores"
        Me.Btn_Doctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Doctores.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Registrar:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 4)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 4)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Trasacciones:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 264)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(249, 4)
        Me.PictureBox3.TabIndex = 78
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Reportes:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 461)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(249, 4)
        Me.PictureBox4.TabIndex = 80
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Administrador:"
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 581)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Acerca)
        Me.Controls.Add(Me.Btn_Usuarios)
        Me.Controls.Add(Me.Btn_Rpt_Doctores)
        Me.Controls.Add(Me.Btn_Rpt_Pacientes)
        Me.Controls.Add(Me.Btn_Rpt_Consultas)
        Me.Controls.Add(Me.Btn_Rpt_Enfermeras)
        Me.Controls.Add(Me.Btn_Rpt_Empleados)
        Me.Controls.Add(Me.Btn_Consultas)
        Me.Controls.Add(Me.Btn_Empleados)
        Me.Controls.Add(Me.Btn_Pacientes)
        Me.Controls.Add(Me.Btn_Enfermeras)
        Me.Controls.Add(Me.Btn_Doctores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Menu"
        Me.Text = "Frm_Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Acerca As Button
    Friend WithEvents Btn_Usuarios As Button
    Friend WithEvents Btn_Rpt_Doctores As Button
    Friend WithEvents Btn_Rpt_Pacientes As Button
    Friend WithEvents Btn_Rpt_Consultas As Button
    Friend WithEvents Btn_Rpt_Enfermeras As Button
    Friend WithEvents Btn_Rpt_Empleados As Button
    Friend WithEvents Btn_Consultas As Button
    Friend WithEvents Btn_Empleados As Button
    Friend WithEvents Btn_Pacientes As Button
    Friend WithEvents Btn_Enfermeras As Button
    Friend WithEvents Btn_Doctores As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
End Class
