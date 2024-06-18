<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consultas))
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_IdPaciente = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar_Paciente = New System.Windows.Forms.Button()
        Me.Txt_Expediente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Paciente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Quitar_Consultas = New System.Windows.Forms.Button()
        Me.Btn_Agregar_Consultas = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cbo_Asegurado = New System.Windows.Forms.ComboBox()
        Me.Dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Diagnostico = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lv_Consultas = New System.Windows.Forms.ListView()
        Me.Chk_Anulada = New System.Windows.Forms.CheckBox()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Anular = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Buscar_Doctor = New System.Windows.Forms.Button()
        Me.Txt_IdDoctor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Medico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Btn_Agregar.TabIndex = 67
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_IdPaciente)
        Me.GroupBox1.Controls.Add(Me.Btn_Buscar_Paciente)
        Me.GroupBox1.Controls.Add(Me.Txt_Expediente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_Paciente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Btn_Quitar_Consultas)
        Me.GroupBox1.Controls.Add(Me.Btn_Agregar_Consultas)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Cbo_Asegurado)
        Me.GroupBox1.Controls.Add(Me.Dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Txt_Diagnostico)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Lv_Consultas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 378)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Paciente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Paciente:"
        '
        'Txt_IdPaciente
        '
        Me.Txt_IdPaciente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_IdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IdPaciente.ForeColor = System.Drawing.Color.Black
        Me.Txt_IdPaciente.Location = New System.Drawing.Point(11, 17)
        Me.Txt_IdPaciente.Name = "Txt_IdPaciente"
        Me.Txt_IdPaciente.Size = New System.Drawing.Size(10, 20)
        Me.Txt_IdPaciente.TabIndex = 260
        Me.Txt_IdPaciente.Visible = False
        '
        'Btn_Buscar_Paciente
        '
        Me.Btn_Buscar_Paciente.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Buscar_Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar_Paciente.ForeColor = System.Drawing.Color.White
        Me.Btn_Buscar_Paciente.Image = CType(resources.GetObject("Btn_Buscar_Paciente.Image"), System.Drawing.Image)
        Me.Btn_Buscar_Paciente.Location = New System.Drawing.Point(106, 21)
        Me.Btn_Buscar_Paciente.Name = "Btn_Buscar_Paciente"
        Me.Btn_Buscar_Paciente.Size = New System.Drawing.Size(22, 20)
        Me.Btn_Buscar_Paciente.TabIndex = 252
        Me.Btn_Buscar_Paciente.UseVisualStyleBackColor = False
        '
        'Txt_Expediente
        '
        Me.Txt_Expediente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Expediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Expediente.ForeColor = System.Drawing.Color.Black
        Me.Txt_Expediente.Location = New System.Drawing.Point(129, 21)
        Me.Txt_Expediente.Name = "Txt_Expediente"
        Me.Txt_Expediente.Size = New System.Drawing.Size(157, 20)
        Me.Txt_Expediente.TabIndex = 249
        Me.Txt_Expediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(143, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 248
        Me.Label6.Text = "No. Expediente"
        '
        'Txt_Paciente
        '
        Me.Txt_Paciente.BackColor = System.Drawing.Color.White
        Me.Txt_Paciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Paciente.ForeColor = System.Drawing.Color.Black
        Me.Txt_Paciente.Location = New System.Drawing.Point(286, 21)
        Me.Txt_Paciente.Name = "Txt_Paciente"
        Me.Txt_Paciente.Size = New System.Drawing.Size(528, 20)
        Me.Txt_Paciente.TabIndex = 246
        Me.Txt_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Paciente.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(424, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 16)
        Me.Label7.TabIndex = 245
        Me.Label7.Text = "Nombre Completo del Paciente"
        '
        'Btn_Quitar_Consultas
        '
        Me.Btn_Quitar_Consultas.BackColor = System.Drawing.Color.White
        Me.Btn_Quitar_Consultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quitar_Consultas.ForeColor = System.Drawing.Color.Black
        Me.Btn_Quitar_Consultas.Image = CType(resources.GetObject("Btn_Quitar_Consultas.Image"), System.Drawing.Image)
        Me.Btn_Quitar_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Quitar_Consultas.Location = New System.Drawing.Point(944, 90)
        Me.Btn_Quitar_Consultas.Name = "Btn_Quitar_Consultas"
        Me.Btn_Quitar_Consultas.Size = New System.Drawing.Size(70, 26)
        Me.Btn_Quitar_Consultas.TabIndex = 242
        Me.Btn_Quitar_Consultas.Text = "   Quitar"
        Me.Btn_Quitar_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Quitar_Consultas.UseVisualStyleBackColor = False
        '
        'Btn_Agregar_Consultas
        '
        Me.Btn_Agregar_Consultas.BackColor = System.Drawing.Color.White
        Me.Btn_Agregar_Consultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Consultas.ForeColor = System.Drawing.Color.Black
        Me.Btn_Agregar_Consultas.Image = CType(resources.GetObject("Btn_Agregar_Consultas.Image"), System.Drawing.Image)
        Me.Btn_Agregar_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Consultas.Location = New System.Drawing.Point(944, 64)
        Me.Btn_Agregar_Consultas.Name = "Btn_Agregar_Consultas"
        Me.Btn_Agregar_Consultas.Size = New System.Drawing.Size(70, 26)
        Me.Btn_Agregar_Consultas.TabIndex = 241
        Me.Btn_Agregar_Consultas.Text = "    Agregar"
        Me.Btn_Agregar_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Consultas.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(930, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "Asegurado"
        '
        'Cbo_Asegurado
        '
        Me.Cbo_Asegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Asegurado.FormattingEnabled = True
        Me.Cbo_Asegurado.Items.AddRange(New Object() {"SI", "NO"})
        Me.Cbo_Asegurado.Location = New System.Drawing.Point(928, 21)
        Me.Cbo_Asegurado.Name = "Cbo_Asegurado"
        Me.Cbo_Asegurado.Size = New System.Drawing.Size(86, 21)
        Me.Cbo_Asegurado.TabIndex = 130
        '
        'Dtp_Fecha
        '
        Me.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Fecha.Location = New System.Drawing.Point(815, 21)
        Me.Dtp_Fecha.Name = "Dtp_Fecha"
        Me.Dtp_Fecha.Size = New System.Drawing.Size(113, 21)
        Me.Dtp_Fecha.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(846, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Fecha"
        '
        'Txt_Diagnostico
        '
        Me.Txt_Diagnostico.BackColor = System.Drawing.Color.White
        Me.Txt_Diagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Diagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Diagnostico.ForeColor = System.Drawing.Color.Black
        Me.Txt_Diagnostico.Location = New System.Drawing.Point(106, 63)
        Me.Txt_Diagnostico.Multiline = True
        Me.Txt_Diagnostico.Name = "Txt_Diagnostico"
        Me.Txt_Diagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Diagnostico.Size = New System.Drawing.Size(838, 53)
        Me.Txt_Diagnostico.TabIndex = 127
        Me.Txt_Diagnostico.WordWrap = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 16)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Diagnostico:"
        '
        'Lv_Consultas
        '
        Me.Lv_Consultas.BackColor = System.Drawing.Color.LightGray
        Me.Lv_Consultas.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lv_Consultas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lv_Consultas.FullRowSelect = True
        Me.Lv_Consultas.GridLines = True
        Me.Lv_Consultas.LabelWrap = False
        Me.Lv_Consultas.Location = New System.Drawing.Point(6, 120)
        Me.Lv_Consultas.MultiSelect = False
        Me.Lv_Consultas.Name = "Lv_Consultas"
        Me.Lv_Consultas.ShowGroups = False
        Me.Lv_Consultas.Size = New System.Drawing.Size(1008, 252)
        Me.Lv_Consultas.TabIndex = 42
        Me.Lv_Consultas.UseCompatibleStateImageBehavior = False
        Me.Lv_Consultas.View = System.Windows.Forms.View.Details
        '
        'Chk_Anulada
        '
        Me.Chk_Anulada.AutoSize = True
        Me.Chk_Anulada.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Anulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Anulada.ForeColor = System.Drawing.Color.White
        Me.Chk_Anulada.Location = New System.Drawing.Point(190, 20)
        Me.Chk_Anulada.Name = "Chk_Anulada"
        Me.Chk_Anulada.Size = New System.Drawing.Size(84, 20)
        Me.Chk_Anulada.TabIndex = 247
        Me.Chk_Anulada.Text = "Anulada"
        Me.Chk_Anulada.UseVisualStyleBackColor = False
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo.ForeColor = System.Drawing.Color.Black
        Me.Txt_Codigo.Location = New System.Drawing.Point(107, 20)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(75, 20)
        Me.Txt_Codigo.TabIndex = 244
        Me.Txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 243
        Me.Label8.Text = "Id. Consulta:"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(305, 58)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Cancelar.TabIndex = 69
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 22)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Registro de Datos de las Consultas:"
        '
        'Btn_Anular
        '
        Me.Btn_Anular.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Anular.ForeColor = System.Drawing.Color.White
        Me.Btn_Anular.Image = CType(resources.GetObject("Btn_Anular.Image"), System.Drawing.Image)
        Me.Btn_Anular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Anular.Location = New System.Drawing.Point(602, 58)
        Me.Btn_Anular.Name = "Btn_Anular"
        Me.Btn_Anular.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Anular.TabIndex = 72
        Me.Btn_Anular.Text = "Anular"
        Me.Btn_Anular.UseVisualStyleBackColor = False
        '
        'Btn_Editar
        '
        Me.Btn_Editar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Editar.ForeColor = System.Drawing.Color.White
        Me.Btn_Editar.Image = CType(resources.GetObject("Btn_Editar.Image"), System.Drawing.Image)
        Me.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Editar.Location = New System.Drawing.Point(454, 58)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Editar.TabIndex = 70
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
        Me.Btn_Cerrar.TabIndex = 71
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
        Me.Btn_Guardar.Location = New System.Drawing.Point(158, 58)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Guardar.TabIndex = 68
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.ForeColor = System.Drawing.Color.White
        Me.Btn_Buscar.Image = CType(resources.GetObject("Btn_Buscar.Image"), System.Drawing.Image)
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(749, 58)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Buscar.TabIndex = 72
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Btn_Buscar_Doctor)
        Me.GroupBox2.Controls.Add(Me.Txt_IdDoctor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_Medico)
        Me.GroupBox2.Controls.Add(Me.Chk_Anulada)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Txt_Codigo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1020, 92)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Medico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Medico:"
        '
        'Btn_Buscar_Doctor
        '
        Me.Btn_Buscar_Doctor.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Buscar_Doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar_Doctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar_Doctor.ForeColor = System.Drawing.Color.White
        Me.Btn_Buscar_Doctor.Image = CType(resources.GetObject("Btn_Buscar_Doctor.Image"), System.Drawing.Image)
        Me.Btn_Buscar_Doctor.Location = New System.Drawing.Point(106, 46)
        Me.Btn_Buscar_Doctor.Name = "Btn_Buscar_Doctor"
        Me.Btn_Buscar_Doctor.Size = New System.Drawing.Size(22, 20)
        Me.Btn_Buscar_Doctor.TabIndex = 264
        Me.Btn_Buscar_Doctor.UseVisualStyleBackColor = False
        '
        'Txt_IdDoctor
        '
        Me.Txt_IdDoctor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_IdDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IdDoctor.ForeColor = System.Drawing.Color.Black
        Me.Txt_IdDoctor.Location = New System.Drawing.Point(129, 46)
        Me.Txt_IdDoctor.Name = "Txt_IdDoctor"
        Me.Txt_IdDoctor.Size = New System.Drawing.Size(157, 20)
        Me.Txt_IdDoctor.TabIndex = 263
        Me.Txt_IdDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(171, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "Id. Doctor"
        '
        'Txt_Medico
        '
        Me.Txt_Medico.BackColor = System.Drawing.Color.White
        Me.Txt_Medico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Medico.ForeColor = System.Drawing.Color.Black
        Me.Txt_Medico.Location = New System.Drawing.Point(286, 46)
        Me.Txt_Medico.Name = "Txt_Medico"
        Me.Txt_Medico.Size = New System.Drawing.Size(728, 20)
        Me.Txt_Medico.TabIndex = 261
        Me.Txt_Medico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Medico.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(494, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 16)
        Me.Label5.TabIndex = 260
        Me.Label5.Text = "Nombre Completo del Doctor"
        '
        'Frm_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1044, 581)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Btn_Anular)
        Me.Controls.Add(Me.Btn_Editar)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Consultas"
        Me.Text = "Frm_Consultas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lv_Consultas As ListView
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Anular As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Quitar_Consultas As Button
    Friend WithEvents Btn_Agregar_Consultas As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Cbo_Asegurado As ComboBox
    Friend WithEvents Dtp_Fecha As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Diagnostico As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_Buscar_Paciente As Button
    Friend WithEvents Txt_Expediente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Paciente As TextBox
    Friend WithEvents Chk_Anulada As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents Txt_IdPaciente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Buscar_Doctor As Button
    Friend WithEvents Txt_IdDoctor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Medico As TextBox
    Friend WithEvents Label5 As Label
End Class
