<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rpt_Consultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Rpt_Consultas))
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Rpt_Consultas1 = New Sistema_Clinica.Rpt_Consultas()
        Me.SuspendLayout()
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.Color.White
        Me.Lbl_Titulo.Location = New System.Drawing.Point(41, 13)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(349, 22)
        Me.Lbl_Titulo.TabIndex = 86
        Me.Lbl_Titulo.Text = "Reporte del Listado de las Consultas:"
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
        Me.Btn_Cerrar.Location = New System.Drawing.Point(959, 11)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(68, 30)
        Me.Btn_Cerrar.TabIndex = 85
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 52)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Rpt_Consultas1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1020, 518)
        Me.CrystalReportViewer1.TabIndex = 87
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frm_Rpt_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1044, 581)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Rpt_Consultas"
        Me.Text = "Frm_Rpt_Consultas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Rpt_Consultas1 As Rpt_Consultas
End Class
