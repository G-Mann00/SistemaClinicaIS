<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Enfermeras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Enfermeras))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Pb_Foto = New System.Windows.Forms.PictureBox()
        Me.Txt_Titulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Filtro = New System.Windows.Forms.TextBox()
        Me.Lbl_Contador = New System.Windows.Forms.Label()
        Me.Lv_Enfermeras = New System.Windows.Forms.ListView()
        Me.Txt_Enfermera = New System.Windows.Forms.TextBox()
        Me.Chk_Activo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Cedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        CType(Me.Pb_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 22)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Registro de Datos de las Enfermeras:"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.ForeColor = System.Drawing.Color.White
        Me.Btn_Eliminar.Image = CType(resources.GetObject("Btn_Eliminar.Image"), System.Drawing.Image)
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(730, 58)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Eliminar.TabIndex = 64
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
        Me.Btn_Editar.Location = New System.Drawing.Point(550, 58)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Editar.TabIndex = 62
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
        Me.Btn_Cerrar.Location = New System.Drawing.Point(898, 58)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Cerrar.TabIndex = 63
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
        Me.Btn_Guardar.Location = New System.Drawing.Point(190, 58)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Guardar.TabIndex = 60
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
        Me.Btn_Cancelar.Location = New System.Drawing.Point(367, 58)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Cancelar.TabIndex = 61
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(37, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Agregar Foto"
        '
        'Pb_Foto
        '
        Me.Pb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pb_Foto.Location = New System.Drawing.Point(12, 28)
        Me.Pb_Foto.Name = "Pb_Foto"
        Me.Pb_Foto.Size = New System.Drawing.Size(141, 137)
        Me.Pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb_Foto.TabIndex = 49
        Me.Pb_Foto.TabStop = False
        '
        'Txt_Titulo
        '
        Me.Txt_Titulo.BackColor = System.Drawing.Color.White
        Me.Txt_Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Titulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Titulo.Location = New System.Drawing.Point(636, 144)
        Me.Txt_Titulo.Name = "Txt_Titulo"
        Me.Txt_Titulo.Size = New System.Drawing.Size(378, 21)
        Me.Txt_Titulo.TabIndex = 48
        Me.Txt_Titulo.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(805, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Titulada/o"
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.BackColor = System.Drawing.Color.White
        Me.Txt_Telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Telefono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Telefono.Location = New System.Drawing.Point(159, 144)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(471, 21)
        Me.Txt_Telefono.TabIndex = 46
        Me.Txt_Telefono.WordWrap = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Pb_Foto)
        Me.GroupBox1.Controls.Add(Me.Txt_Titulo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Telefono)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_Filtro)
        Me.GroupBox1.Controls.Add(Me.Lbl_Contador)
        Me.GroupBox1.Controls.Add(Me.Lv_Enfermeras)
        Me.GroupBox1.Controls.Add(Me.Txt_Enfermera)
        Me.GroupBox1.Controls.Add(Me.Chk_Activo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Cedula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_Direccion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_Codigo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 474)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales de la Enfermera:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 15)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Buscar Doctor por nombre:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Filtro
        '
        Me.Txt_Filtro.BackColor = System.Drawing.Color.White
        Me.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Filtro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtro.Location = New System.Drawing.Point(195, 447)
        Me.Txt_Filtro.Name = "Txt_Filtro"
        Me.Txt_Filtro.Size = New System.Drawing.Size(660, 21)
        Me.Txt_Filtro.TabIndex = 44
        '
        'Lbl_Contador
        '
        Me.Lbl_Contador.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Contador.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contador.ForeColor = System.Drawing.Color.White
        Me.Lbl_Contador.Location = New System.Drawing.Point(861, 448)
        Me.Lbl_Contador.Name = "Lbl_Contador"
        Me.Lbl_Contador.Size = New System.Drawing.Size(153, 19)
        Me.Lbl_Contador.TabIndex = 43
        Me.Lbl_Contador.Text = "Registro:"
        '
        'Lv_Enfermeras
        '
        Me.Lv_Enfermeras.BackColor = System.Drawing.Color.LightGray
        Me.Lv_Enfermeras.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lv_Enfermeras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lv_Enfermeras.FullRowSelect = True
        Me.Lv_Enfermeras.GridLines = True
        Me.Lv_Enfermeras.LabelWrap = False
        Me.Lv_Enfermeras.Location = New System.Drawing.Point(12, 187)
        Me.Lv_Enfermeras.MultiSelect = False
        Me.Lv_Enfermeras.Name = "Lv_Enfermeras"
        Me.Lv_Enfermeras.ShowGroups = False
        Me.Lv_Enfermeras.Size = New System.Drawing.Size(1002, 258)
        Me.Lv_Enfermeras.TabIndex = 42
        Me.Lv_Enfermeras.UseCompatibleStateImageBehavior = False
        Me.Lv_Enfermeras.View = System.Windows.Forms.View.Details
        '
        'Txt_Enfermera
        '
        Me.Txt_Enfermera.BackColor = System.Drawing.Color.White
        Me.Txt_Enfermera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Enfermera.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Enfermera.Location = New System.Drawing.Point(159, 48)
        Me.Txt_Enfermera.Name = "Txt_Enfermera"
        Me.Txt_Enfermera.Size = New System.Drawing.Size(471, 21)
        Me.Txt_Enfermera.TabIndex = 34
        Me.Txt_Enfermera.WordWrap = False
        '
        'Chk_Activo
        '
        Me.Chk_Activo.AutoSize = True
        Me.Chk_Activo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Activo.ForeColor = System.Drawing.Color.White
        Me.Chk_Activo.Location = New System.Drawing.Point(355, 23)
        Me.Chk_Activo.Name = "Chk_Activo"
        Me.Chk_Activo.Size = New System.Drawing.Size(67, 19)
        Me.Chk_Activo.TabIndex = 41
        Me.Chk_Activo.Text = "Activo"
        Me.Chk_Activo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(290, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "No. Telefono"
        '
        'Txt_Cedula
        '
        Me.Txt_Cedula.BackColor = System.Drawing.Color.White
        Me.Txt_Cedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Cedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cedula.Location = New System.Drawing.Point(636, 48)
        Me.Txt_Cedula.Name = "Txt_Cedula"
        Me.Txt_Cedula.Size = New System.Drawing.Size(378, 21)
        Me.Txt_Cedula.TabIndex = 38
        Me.Txt_Cedula.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(779, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "No. Cedula"
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.BackColor = System.Drawing.Color.White
        Me.Txt_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Direccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Direccion.Location = New System.Drawing.Point(159, 90)
        Me.Txt_Direccion.Multiline = True
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Direccion.Size = New System.Drawing.Size(855, 34)
        Me.Txt_Direccion.TabIndex = 36
        Me.Txt_Direccion.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(559, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Dirección"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(352, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Enfermera/o"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo.Location = New System.Drawing.Point(276, 22)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(69, 21)
        Me.Txt_Codigo.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(159, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 15)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Id. Enfermera/o:"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.ForeColor = System.Drawing.Color.White
        Me.Btn_Agregar.Image = CType(resources.GetObject("Btn_Agregar.Image"), System.Drawing.Image)
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(12, 58)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Agregar.TabIndex = 59
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'Frm_Enfermeras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1044, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Editar)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_Enfermeras"
        Me.Text = "Frm_Enfermeras"
        CType(Me.Pb_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Pb_Foto As PictureBox
    Friend WithEvents Txt_Titulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Telefono As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Filtro As TextBox
    Friend WithEvents Lbl_Contador As Label
    Friend WithEvents Lv_Enfermeras As ListView
    Friend WithEvents Txt_Enfermera As TextBox
    Friend WithEvents Chk_Activo As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Cedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Direccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_Agregar As Button
End Class
