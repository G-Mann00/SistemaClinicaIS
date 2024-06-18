<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Busqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Busqueda))
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Lv_Listado = New System.Windows.Forms.ListView()
        Me.Txt_Filtro = New System.Windows.Forms.TextBox()
        Me.Lbl_Contador = New System.Windows.Forms.Label()
        Me.Opt_2 = New System.Windows.Forms.RadioButton()
        Me.Opt_1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.Color.White
        Me.Lbl_Titulo.Location = New System.Drawing.Point(42, 12)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(261, 22)
        Me.Lbl_Titulo.TabIndex = 82
        Me.Lbl_Titulo.Text = "Información de Busquedad:"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar.Location = New System.Drawing.Point(960, 10)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(68, 30)
        Me.Btn_Cerrar.TabIndex = 79
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'Lv_Listado
        '
        Me.Lv_Listado.BackColor = System.Drawing.Color.LightGray
        Me.Lv_Listado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lv_Listado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lv_Listado.FullRowSelect = True
        Me.Lv_Listado.GridLines = True
        Me.Lv_Listado.LabelWrap = False
        Me.Lv_Listado.Location = New System.Drawing.Point(11, 108)
        Me.Lv_Listado.MultiSelect = False
        Me.Lv_Listado.Name = "Lv_Listado"
        Me.Lv_Listado.ShowGroups = False
        Me.Lv_Listado.Size = New System.Drawing.Size(1023, 458)
        Me.Lv_Listado.TabIndex = 83
        Me.Lv_Listado.UseCompatibleStateImageBehavior = False
        Me.Lv_Listado.View = System.Windows.Forms.View.Details
        '
        'Txt_Filtro
        '
        Me.Txt_Filtro.BackColor = System.Drawing.Color.White
        Me.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Filtro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtro.Location = New System.Drawing.Point(11, 81)
        Me.Txt_Filtro.Name = "Txt_Filtro"
        Me.Txt_Filtro.Size = New System.Drawing.Size(864, 21)
        Me.Txt_Filtro.TabIndex = 85
        '
        'Lbl_Contador
        '
        Me.Lbl_Contador.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Contador.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Contador.Location = New System.Drawing.Point(881, 81)
        Me.Lbl_Contador.Name = "Lbl_Contador"
        Me.Lbl_Contador.Size = New System.Drawing.Size(153, 19)
        Me.Lbl_Contador.TabIndex = 84
        Me.Lbl_Contador.Text = "Registro:"
        '
        'Opt_2
        '
        Me.Opt_2.AutoSize = True
        Me.Opt_2.BackColor = System.Drawing.Color.Transparent
        Me.Opt_2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Opt_2.Location = New System.Drawing.Point(362, 56)
        Me.Opt_2.Name = "Opt_2"
        Me.Opt_2.Size = New System.Drawing.Size(111, 23)
        Me.Opt_2.TabIndex = 130
        Me.Opt_2.TabStop = True
        Me.Opt_2.Text = "Alternativa 2"
        Me.Opt_2.UseVisualStyleBackColor = False
        '
        'Opt_1
        '
        Me.Opt_1.AutoSize = True
        Me.Opt_1.BackColor = System.Drawing.Color.Transparent
        Me.Opt_1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Opt_1.Location = New System.Drawing.Point(129, 56)
        Me.Opt_1.Name = "Opt_1"
        Me.Opt_1.Size = New System.Drawing.Size(111, 23)
        Me.Opt_1.TabIndex = 129
        Me.Opt_1.TabStop = True
        Me.Opt_1.Text = "Alternativa 1"
        Me.Opt_1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Buscar por:"
        '
        'Frm_Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1044, 581)
        Me.Controls.Add(Me.Opt_2)
        Me.Controls.Add(Me.Opt_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Filtro)
        Me.Controls.Add(Me.Lbl_Contador)
        Me.Controls.Add(Me.Lv_Listado)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Busqueda"
        Me.Text = "Frm_Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Lv_Listado As ListView
    Friend WithEvents Txt_Filtro As TextBox
    Friend WithEvents Lbl_Contador As Label
    Friend WithEvents Opt_2 As RadioButton
    Friend WithEvents Opt_1 As RadioButton
    Friend WithEvents Label2 As Label
End Class
