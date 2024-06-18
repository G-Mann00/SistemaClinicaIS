Imports Microsoft.VisualBasic
Public Class Frm_Consultas
    'Declaracion de Variables
    Dim Bol_Seleccion As Boolean, xDet As Double

    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(317, 0)
        End Select
    End Sub
    Private Sub Frm_Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bloqueando Campos
        Txt_Codigo.ReadOnly = True
        Txt_IdPaciente.ReadOnly = True
        Txt_Expediente.ReadOnly = True
        Txt_Paciente.ReadOnly = True
        Txt_IdDoctor.ReadOnly = True
        Txt_Medico.ReadOnly = True
        Cbo_Asegurado.Enabled = False
        Dtp_Fecha.Enabled = False
        Txt_Diagnostico.ReadOnly = True
        Chk_Anulada.Enabled = False

        'Ubicar el Primer Registro de la Tabla: Asignaciones
        Lv_Consultas.Items.Clear()
        Lv_Consultas.Refresh()

        'Bloquear ListView
        Lv_Consultas.Enabled = True

        'Agregando Registros
        CONSULTA = "SELECT Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas Order By Id_Consulta"
        RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
        If (RS_CONSULTA.HasRows = True) Then
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_IdPaciente.Text = RS_CONSULTA.Item(1).ToString
            Txt_Expediente.Text = RS_CONSULTA.Item(2).ToString
            Txt_Paciente.Text = RS_CONSULTA.Item(3).ToString
            Txt_IdDoctor.Text = RS_CONSULTA.Item(4).ToString
            Txt_Medico.Text = RS_CONSULTA.Item(5).ToString
            Dtp_Fecha.Text = RS_CONSULTA.Item(6).ToString
            Cbo_Asegurado.Text = RS_CONSULTA.Item(7).ToString
            Txt_Diagnostico.Text = RS_CONSULTA.Item(8).ToString
            Chk_Anulada.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(9).ToString) = 0, True, False))

            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            'Llenando el ListView
            CONSULTA = "SELECT Id_Detalle,Id_Consulta,Id_Paciente,Fecha,Asegurado,Diagnostico FROM dbo.Detalle_Consultas WHERE (Id_Consulta = " & Me.Txt_Codigo.Text & ") ORDER BY Id_Detalle;"
            Call Variables.Llenar_Listas(Lv_Consultas, CONSULTA, "DETALLE_CONSULTA", RS_CONSULTA)

            'Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Fincas.Items.Count.ToString()

            'Bloqueando Botones de Gestion
            Btn_Agregar.Enabled = True
            Btn_Guardar.Enabled = False
            Btn_Cancelar.Enabled = False
            Btn_Editar.Enabled = False
            Btn_Anular.Enabled = False
            Btn_Buscar.Enabled = True
            Btn_Cerrar.Enabled = True

            Btn_Buscar_Paciente.Enabled = False
            Btn_Buscar_Doctor.Enabled = False

            Btn_Agregar_Consultas.Enabled = False
            Btn_Quitar_Consultas.Enabled = False

        ElseIf RS_CONSULTA.HasRows = False Then
            'Campo Sin Informacion
            'Campo sin información
            Txt_Codigo.Text = "0"
            Txt_IdPaciente.Text = "0"
            Txt_Expediente.Text = "0"
            Txt_Paciente.Text = "SIN INFO"
            Txt_IdDoctor.Text = "0"
            Txt_Medico.Text = "SIN INFO"
            Cbo_Asegurado.Text = "SIN INFO"
            Txt_Diagnostico.Text = "SIN INFO"


            CONSULTA = "SELECT Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas WHERE (Id_Consulta = 0) Order By Id_Consulta"
            'Call Variables.Llenar_Listas(Lv_Fincas, CONSULTA, "FINCAS", RS_CONSULTA)

            'Detalle de Asignaciones
            CONSULTA = "SELECT Id_Detalle,Id_Consulta,Id_Paciente,Fecha,Asegurado,Diagnostico FROM dbo.Detalle_Consultas WHERE (Id_Consulta = " & Me.Txt_Codigo.Text & ") ORDER BY Id_Detalle;"
            Call Variables.Llenar_Listas(Lv_Consultas, CONSULTA, "DETALLE_CONSULTA", RS_CONSULTA)

            'Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Fincas.Items.Count.ToString()

            'Bloqueando Botones de Gestion
            Btn_Buscar_Paciente.Enabled = False
            Btn_Buscar_Doctor.Enabled = False

            Btn_Agregar_Consultas.Enabled = False
            Btn_Quitar_Consultas.Enabled = False

            'Botones de Comandos
            Btn_Agregar.Enabled = True
            Btn_Guardar.Enabled = False
            Btn_Cancelar.Enabled = False
            Btn_Editar.Enabled = False
            Btn_Anular.Enabled = False
            Btn_Buscar.Enabled = True
            Btn_Cerrar.Enabled = True
        End If

    End Sub
    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        'Agregando Registros
        'Desbloqueando Campos
        Txt_Codigo.ReadOnly = True
        Txt_Expediente.ReadOnly = True
        Txt_Paciente.ReadOnly = True
        Txt_IdDoctor.ReadOnly = True
        Txt_Medico.ReadOnly = True
        Cbo_Asegurado.Enabled = True
        Dtp_Fecha.Enabled = True
        Txt_Diagnostico.ReadOnly = False
        Chk_Anulada.Enabled = False

        Bol_Seleccion = False

        'Limpiando Campos
        Txt_Codigo.Text = Variables.Consecutivo("Consultas", "Id_Consulta", RS_CONSULTA).ToString
        xCod = CInt(Variables.Consecutivo("Consultas", "Id_Consulta", RS_CONSULTA).ToString)
        Txt_Expediente.Text = ""
        Txt_Paciente.Text = ""
        Txt_IdDoctor.Text = ""
        Txt_Medico.Text = ""
        Cbo_Asegurado.Text = ""
        Txt_Diagnostico.Text = ""
        Btn_Buscar_Doctor.Focus()

        'Desbloquear ListView
        Lv_Consultas.Enabled = True
        Lv_Consultas.Items.Clear()

        'Tipo de Accion
        Si_Agrego = True

        'Botones de Gestion
        Btn_Agregar.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Cancelar.Enabled = True
        Btn_Editar.Enabled = False
        Btn_Anular.Enabled = False
        Btn_Buscar.Enabled = False
        Btn_Cerrar.Enabled = False

        Btn_Buscar_Paciente.Enabled = True
        Btn_Buscar_Doctor.Enabled = True

        Btn_Agregar_Consultas.Enabled = True
        Btn_Quitar_Consultas.Enabled = True

    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        'Transaccion cancelada
        MessageBox.Show("Transacción cancelada con Exito!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Consultas_Load(sender, e)

    End Sub
    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click

    End Sub
    Private Sub Btn_Anular_Click(sender As Object, e As EventArgs) Handles Btn_Anular.Click

    End Sub
    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click

    End Sub
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando el Formulario de los Usuarios
        Respuesta = MessageBox.Show("¿Desea cerrar el Formulario Usuario?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            'Cerrando el Formulario
            Me.Close()

            'Visualizando el formulario Presentacion
            Frm_Presentacion.Show()

            'Habilitando la barra de Menu 
            Frm_Principal.Menu.Enabled = True

            'Haabilitando el formulario Menu
            Frm_Menu.Enabled = True
        End If

    End Sub
    Private Sub Btn_Agregar_Consultas_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Consultas.Click
        'Agregando Nuevos Registros al Listview
        If (Txt_IdPaciente.Text = "") Or (Txt_Paciente.Text = "") Or (Cbo_Asegurado.Text = "") Or (Txt_Diagnostico.Text = "") Then
            MessageBox.Show("Debe de Digitar todos los campos del Formulario!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Validando si no existe otro negocio igual
        I = 0
        If Lv_Consultas.Items.Count > 0 Then
            Do While (I <= Lv_Consultas.Items.Count - 1)
                If (Txt_IdPaciente.Text = Lv_Consultas.Items(I).SubItems(2).Text) Then
                    MessageBox.Show("Este Paciente ya fue ingresado en el Detalle!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Txt_IdPaciente.Text = ""
                    Txt_Expediente.Text = ""
                    Txt_Paciente.Text = ""
                    Cbo_Asegurado.Text = ""
                    Txt_Diagnostico.Text = ""
                    Exit Sub
                End If
                I = I + 1
            Loop
        End If

        'Agregando nuevos registros
        I = I + 1
        Fila_View = New ListViewItem(I.ToString, 0)
        Fila_View.SubItems.Add(Txt_Codigo.Text)
        Fila_View.SubItems.Add(Txt_IdPaciente.Text)
        Fila_View.SubItems.Add(Dtp_Fecha.Text)
        Fila_View.SubItems.Add(Cbo_Asegurado.Text)
        Fila_View.SubItems.Add(Txt_Diagnostico.Text)
        Lv_Consultas.Items.Add(Fila_View)

        'Mensaje de Confirmación
        MessageBox.Show("Registro Agregado Satisfactoriamente en el Detalle!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'Cbo_Asegurado.Text = ""
        'Txt_Diagnostico.Text = ""

        Bol_Seleccion = False

        Btn_Agregar_Consultas.Enabled = True
        Btn_Quitar_Consultas.Enabled = True

    End Sub

    Private Sub Btn_Quitar_Consultas_Click(sender As Object, e As EventArgs) Handles Btn_Quitar_Consultas.Click
        'Quitando Productos del Detalle
        If (Me.Lv_Consultas.Items.Count = 0) Then
            MessageBox.Show("No hay Registros Almacenados en el Detalle!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If (Bol_Seleccion = False) Then
            MessageBox.Show("No ha seleccionado el Registro a quitar del Detalle!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.Lv_Consultas.Items.RemoveAt(Me.Lv_Consultas.SelectedItems.Item(0).Index)
        Bol_Seleccion = False

        MessageBox.Show("Registro quitado satisfactoriamente del Detalle!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Txt_IdPaciente.Text = ""
        Txt_Expediente.Text = ""
        Txt_Paciente.Text = ""
        Cbo_Asegurado.Text = ""
        Txt_Diagnostico.Text = ""

        Bol_Seleccion = False
    End Sub

    Private Sub Lv_Consultas_Click(sender As Object, e As EventArgs) Handles Lv_Consultas.Click
        'Seleccionando un Registro
        If Me.Lv_Consultas.Items.Count > 0 Then
            Bol_Seleccion = True
        End If

    End Sub

    Private Sub Btn_Buscar_Doctor_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Doctor.Click
        'Visualizando el Formulario Busqueda
        Val_Band = 2

        'Abriendo el Formulaio Usuarios
        Frm_Busqueda.MdiParent = Frm_Principal
        Frm_Busqueda.Show()

    End Sub

    Private Sub Btn_Buscar_Paciente_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Paciente.Click
        'Visualizando el Formulario Busqueda
        Val_Band = 1

        'Abriendo el Formulaio Usuarios
        Frm_Busqueda.MdiParent = Frm_Principal
        Frm_Busqueda.Show()

    End Sub

End Class