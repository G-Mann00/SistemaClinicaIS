<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Usuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Filtro = New System.Windows.Forms.TextBox()
        Me.Lbl_Contador = New System.Windows.Forms.Label()
        Me.Lv_Usuarios = New System.Windows.Forms.ListView()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Chk_Activo = New System.Windows.Forms.CheckBox()
        Me.Cbo_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 22)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Registro de Usuarios:"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.ForeColor = System.Drawing.Color.White
        Me.Btn_Eliminar.Image = CType(resources.GetObject("Btn_Eliminar.Image"), System.Drawing.Image)
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(730, 64)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Eliminar.TabIndex = 48
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'Btn_Editar
        '
        Me.Btn_Editar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Editar.ForeColor = System.Drawing.Color.White
        Me.Btn_Editar.Image = CType(resources.GetObject("Btn_Editar.Image"), System.Drawing.Image)
        Me.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Editar.Location = New System.Drawing.Point(550, 64)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Editar.TabIndex = 46
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar.Location = New System.Drawing.Point(898, 64)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Cerrar.TabIndex = 47
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Guardar.Location = New System.Drawing.Point(190, 64)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Guardar.TabIndex = 44
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(367, 64)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Cancelar.TabIndex = 45
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.ForeColor = System.Drawing.Color.White
        Me.Btn_Agregar.Image = CType(resources.GetObject("Btn_Agregar.Image"), System.Drawing.Image)
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(12, 64)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Agregar.TabIndex = 43
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_Filtro)
        Me.GroupBox1.Controls.Add(Me.Lbl_Contador)
        Me.GroupBox1.Controls.Add(Me.Lv_Usuarios)
        Me.GroupBox1.Controls.Add(Me.Txt_Login)
        Me.GroupBox1.Controls.Add(Me.Chk_Activo)
        Me.GroupBox1.Controls.Add(Me.Cbo_Tipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Password)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_Usuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_Codigo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 461)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales de los Usuarios:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 15)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Buscar Usuario por nombre:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Filtro
        '
        Me.Txt_Filtro.BackColor = System.Drawing.Color.White
        Me.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Filtro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtro.Location = New System.Drawing.Point(201, 433)
        Me.Txt_Filtro.Name = "Txt_Filtro"
        Me.Txt_Filtro.Size = New System.Drawing.Size(654, 21)
        Me.Txt_Filtro.TabIndex = 44
        '
        'Lbl_Contador
        '
        Me.Lbl_Contador.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Contador.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contador.ForeColor = System.Drawing.Color.White
        Me.Lbl_Contador.Location = New System.Drawing.Point(861, 435)
        Me.Lbl_Contador.Name = "Lbl_Contador"
        Me.Lbl_Contador.Size = New System.Drawing.Size(153, 19)
        Me.Lbl_Contador.TabIndex = 43
        Me.Lbl_Contador.Text = "Registro:"
        '
        'Lv_Usuarios
        '
        Me.Lv_Usuarios.BackColor = System.Drawing.Color.LightGray
        Me.Lv_Usuarios.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lv_Usuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lv_Usuarios.FullRowSelect = True
        Me.Lv_Usuarios.GridLines = True
        Me.Lv_Usuarios.LabelWrap = False
        Me.Lv_Usuarios.Location = New System.Drawing.Point(6, 119)
        Me.Lv_Usuarios.MultiSelect = False
        Me.Lv_Usuarios.Name = "Lv_Usuarios"
        Me.Lv_Usuarios.ShowGroups = False
        Me.Lv_Usuarios.Size = New System.Drawing.Size(1008, 308)
        Me.Lv_Usuarios.TabIndex = 42
        Me.Lv_Usuarios.UseCompatibleStateImageBehavior = False
        Me.Lv_Usuarios.View = System.Windows.Forms.View.Details
        '
        'Txt_Login
        '
        Me.Txt_Login.BackColor = System.Drawing.Color.White
        Me.Txt_Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Login.Location = New System.Drawing.Point(147, 58)
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(428, 21)
        Me.Txt_Login.TabIndex = 34
        Me.Txt_Login.WordWrap = False
        '
        'Chk_Activo
        '
        Me.Chk_Activo.AutoSize = True
        Me.Chk_Activo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Activo.ForeColor = System.Drawing.Color.White
        Me.Chk_Activo.Location = New System.Drawing.Point(223, 31)
        Me.Chk_Activo.Name = "Chk_Activo"
        Me.Chk_Activo.Size = New System.Drawing.Size(67, 19)
        Me.Chk_Activo.TabIndex = 41
        Me.Chk_Activo.Text = "Activo"
        Me.Chk_Activo.UseVisualStyleBackColor = True
        '
        'Cbo_Tipo
        '
        Me.Cbo_Tipo.BackColor = System.Drawing.Color.White
        Me.Cbo_Tipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Tipo.FormattingEnabled = True
        Me.Cbo_Tipo.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO"})
        Me.Cbo_Tipo.Location = New System.Drawing.Point(698, 86)
        Me.Cbo_Tipo.Name = "Cbo_Tipo"
        Me.Cbo_Tipo.Size = New System.Drawing.Size(316, 22)
        Me.Cbo_Tipo.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(582, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Tipo de Usuario:"
        '
        'Txt_Password
        '
        Me.Txt_Password.BackColor = System.Drawing.Color.White
        Me.Txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Password.Location = New System.Drawing.Point(698, 57)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(316, 21)
        Me.Txt_Password.TabIndex = 38
        Me.Txt_Password.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(608, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Contraseña:"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.BackColor = System.Drawing.Color.White
        Me.Txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Usuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Usuario.Location = New System.Drawing.Point(146, 86)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(429, 21)
        Me.Txt_Usuario.TabIndex = 36
        Me.Txt_Usuario.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Nombre_Usuario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(81, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Usuario:"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Codigo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo.Location = New System.Drawing.Point(147, 32)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(69, 21)
        Me.Txt_Codigo.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(62, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Id. Usuario:"
        '
        'Frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1044, 581)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Editar)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Usuarios"
        Me.Text = "Frm_Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Filtro As TextBox
    Friend WithEvents Lbl_Contador As Label
    Friend WithEvents Lv_Usuarios As ListView
    Friend WithEvents Txt_Login As TextBox
    Friend WithEvents Chk_Activo As CheckBox
    Friend WithEvents Cbo_Tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label8 As Label
End Class
