<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Password))
        Me.Pb_Tiempo = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pb_Tiempo
        '
        Me.Pb_Tiempo.BackColor = System.Drawing.Color.Black
        Me.Pb_Tiempo.ForeColor = System.Drawing.Color.Navy
        Me.Pb_Tiempo.Location = New System.Drawing.Point(8, 251)
        Me.Pb_Tiempo.MarqueeAnimationSpeed = 20
        Me.Pb_Tiempo.Name = "Pb_Tiempo"
        Me.Pb_Tiempo.Size = New System.Drawing.Size(529, 15)
        Me.Pb_Tiempo.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Pb_Tiempo.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 23)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "CLINICA SU MEDICO"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 55)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(257, 173)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 94
        Me.PictureBox4.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.Location = New System.Drawing.Point(502, 1)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(37, 23)
        Me.Btn_Cerrar.TabIndex = 92
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(459, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Version 1.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 15)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Copyright © Clinica Su Medico 2019"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(275, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 22)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "INICIO DE SESIÓN"
        '
        'Txt_Password
        '
        Me.Txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Password.Location = New System.Drawing.Point(275, 170)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(253, 23)
        Me.Txt_Password.TabIndex = 116
        Me.Txt_Password.WordWrap = False
        '
        'Btn_Ok
        '
        Me.Btn_Ok.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ok.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ok.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Ok.Image = CType(resources.GetObject("Btn_Ok.Image"), System.Drawing.Image)
        Me.Btn_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ok.Location = New System.Drawing.Point(279, 207)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(249, 24)
        Me.Btn_Ok.TabIndex = 115
        Me.Btn_Ok.Text = "Entrar"
        Me.Btn_Ok.UseVisualStyleBackColor = False
        '
        'Txt_Login
        '
        Me.Txt_Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Login.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Txt_Login.Location = New System.Drawing.Point(275, 120)
        Me.Txt_Login.MaxLength = 50
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(253, 23)
        Me.Txt_Login.TabIndex = 114
        Me.Txt_Login.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(275, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "CLAVE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(275, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "USUARIO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(278, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 4)
        Me.PictureBox1.TabIndex = 118
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 119
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 286)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(529, 4)
        Me.PictureBox3.TabIndex = 120
        Me.PictureBox3.TabStop = False
        '
        'Frm_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(551, 330)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.Txt_Login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pb_Tiempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Password"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Password"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pb_Tiempo As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Txt_Login As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
