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
        Dtp_Fecha.Enabled = False
        Cbo_Asegurado.Enabled = False
        Txt_Diagnostico.ReadOnly = True
        Chk_Anulada.Enabled = False

        'Ubicar el Primer Registro de la Tabla: Usuario
        Lv_Consultas.Items.Clear()
        Lv_Consultas.Refresh()

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
            Chk_Anulada.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(9).ToString) = 1, True, False))
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            'Llenando el ListView
            CONSULTA = "SELECT Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas Order By Id_Consulta"
            Call Variables.Llenar_Listas(Lv_Consultas, CONSULTA, "CONSULTAS", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Consultas.Items.Count.ToString()

            'Bloqueando Botones de Gestion
            Btn_Agregar.Enabled = True
            Btn_Guardar.Enabled = False
            Btn_Cancelar.Enabled = False
            Btn_Editar.Enabled = True
            Btn_Eliminar.Enabled = True
            Btn_Cerrar.Enabled = True

        ElseIf RS_CONSULTA.HasRows = False Then
            'Campo Sin Informacion
            Txt_Codigo.Text = "0"
            Txt_IdPaciente.Text = "SIN INFO"
            Txt_Expediente.Text = "SIN INFO"
            Txt_Paciente.Text = "SIN INFO"
            Txt_IdDoctor.Text = "SIN INFO"
            Txt_Medico.Text = "SIN INFO"
            Dtp_Fecha.Enabled = False
            Cbo_Asegurado.Enabled = False
            Txt_Diagnostico.Text = "SIN INFO"
            Chk_Anulada.Checked = False

            Call Variables.Llenar_Listas(Lv_Consultas, CONSULTA, "CONSULTAS", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Consultas.Items.Count.ToString()

            'Botones de Gestion
            Btn_Agregar.Enabled = True
            Btn_Guardar.Enabled = False
            Btn_Cancelar.Enabled = False
            Btn_Editar.Enabled = False
            Btn_Eliminar.Enabled = False
            Btn_Cerrar.Enabled = True
        End If

    End Sub
    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        'Agregando Registros
        'Desbloqueando Campos
        Txt_Codigo.ReadOnly = False
        Txt_IdPaciente.ReadOnly = False
        Txt_Expediente.ReadOnly = False
        Txt_Paciente.ReadOnly = False
        Txt_IdDoctor.ReadOnly = False
        Txt_Medico.ReadOnly = False
        Dtp_Fecha.Enabled = True
        Cbo_Asegurado.Enabled = True
        Txt_Diagnostico.ReadOnly = False

        'Limpiando Campos
        Txt_Codigo.Text = Variables.Consecutivo("Consultas", "Id_Consulta", RS_CONSULTA).ToString
        xCod = CInt(Variables.Consecutivo("Consultas", "Id_Consulta", RS_CONSULTA).ToString)
        Txt_IdPaciente.Text = ""
        Txt_Expediente.Text = ""
        Txt_Paciente.Text = ""
        Txt_IdDoctor.Text = ""
        Txt_Medico.Text = ""
        Dtp_Fecha.Enabled = True
        Cbo_Asegurado.Text = ""
        Txt_Diagnostico.Text = ""
        Txt_IdDoctor.Focus()
        Chk_Anulada.Checked = False

        'Tipo de Accion
        Si_Agrego = True

        'Botones de Gestion
        Btn_Agregar.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Cancelar.Enabled = True
        Btn_Editar.Enabled = False
        Btn_Eliminar.Enabled = False
        Btn_Cerrar.Enabled = False

    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        'Insertando Datos
        If (Txt_Expediente.Text = "") Or (Txt_Paciente.Text = "") Or (Txt_IdDoctor.Text = "") Or (Txt_Medico.Text = "") Or (Cbo_Asegurado.Text = "") Or (Txt_Diagnostico.Text = "") Then
            MessageBox.Show("Debe de Digitar Todos los Campos", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Si_Agrego = True Then
            CONSULTA = "INSERT INTO Consultas (Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada) " _
                    & "VALUES(" & xCod & ",'" & Txt_IdPaciente.Text & "','" & Txt_Expediente.Text & "','" & Txt_Paciente.Text & "','" & Txt_IdDoctor.Text _
                    & "','" & Txt_Medico.Text & "','" & Dtp_Fecha.Text & "','" & Cbo_Asegurado.Text & "','" & Txt_Diagnostico.Text & "',0)"
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Grabados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Si_Agrego = False Then
            If Chk_Anulada.Checked = False Then
                CONSULTA = "UPDATE Consultas SET Id_Paciente = '" & Txt_IdPaciente.Text & "',No_Expediente = '" & Txt_Expediente.Text & "',Paciente = '" & Txt_Paciente.Text _
                    & "',Id_Doctor = '" & Txt_IdDoctor.Text & "',Medico = '" & Txt_Medico.Text & "',Fecha = '" & Dtp_Fecha.Text & "',Asegurado = '" & Cbo_Asegurado.Text & "',Diagnostico= '" & Txt_Diagnostico.Text & "',Anulada = 0 WHERE (Id_Consulta = " & xCod & ")"
            ElseIf Chk_Anulada.Checked = True Then
                CONSULTA = "UPDATE Consultas SET Id_Paciente = '" & Txt_IdPaciente.Text & "',No_Expediente = '" & Txt_Expediente.Text & "',Paciente = '" & Txt_Paciente.Text _
                    & "',Id_Doctor = '" & Txt_IdDoctor.Text & "',Medico = '" & Txt_Medico.Text & "',Fecha = '" & Dtp_Fecha.Text & "',Asegurado = '" & Cbo_Asegurado.Text & "',Diagnostico= '" & Txt_Diagnostico.Text & "',Anulada = 1 WHERE (Id_Consulta = " & xCod & ")"
            End If
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Actualizados Satisfactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        Call Frm_Consultas_Load(sender, e)

    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        'Transaccion cancelada
        MessageBox.Show("Transacción cancelada con Exito!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Consultas_Load(sender, e)

    End Sub
    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        'Editando y/o Modificando Registros
        'Desbloqueando Campos
        Txt_Codigo.ReadOnly = False
        Txt_IdPaciente.ReadOnly = False
        Txt_Expediente.ReadOnly = False
        Txt_Paciente.ReadOnly = False
        Txt_IdDoctor.ReadOnly = False
        Txt_Medico.ReadOnly = False
        Dtp_Fecha.Enabled = True
        Cbo_Asegurado.Enabled = True
        Txt_Diagnostico.ReadOnly = False
        Txt_IdDoctor.Focus()
        Chk_Anulada.Enabled = True

        'Tipos de Accion
        Si_Agrego = False

        'Botones de Gestion
        Btn_Agregar.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Cancelar.Enabled = True
        Btn_Editar.Enabled = False
        Btn_Eliminar.Enabled = False
        Btn_Cerrar.Enabled = False

    End Sub
    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        'Eliminando un Registro
        Respuesta = MessageBox.Show("¿Desea Borrar el Registro?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbNo) Then
            Exit Sub
        End If

        CONSULTA = "DELETE FROM Consultas WHERE (Id_Consulta = " & xCod & ")"
        Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)

        MessageBox.Show("Datos Eliminados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Consultas_Load(sender, e)

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
    Private Sub Lv_Consultas_Click(sender As Object, e As EventArgs) Handles Lv_Consultas.Click
        If Lv_Consultas.Items.Count > 0 Then 'Verifica si hay filas
            xCod = CInt(Lv_Consultas.SelectedItems.Item(0).SubItems(0).Text)
            CONSULTA = "SELECT Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas WHERE (Id_Consulta = " & xCod & ")"
            RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
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
            Chk_Anulada.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(9).ToString) = 1, True, False))
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()
        End If

    End Sub
    Private Sub Txt_Filtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Filtro.KeyPress
        'Buscando un Registro
        If e.KeyChar = Chr(Keys.Enter) Then
            If Txt_Filtro.ReadOnly = True Then
                e.Handled = True
                Exit Sub
            End If

            If Txt_Filtro.Text = "" Then
                CONSULTA = "SELECT  Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas Order By Id_Consulta"
            Else
                CONSULTA = "SELECT  Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas WHERE (Paciente LIKE '" & Txt_Filtro.Text & "%') ORDER  BY Id_Consulta"
            End If
            Call Variables.Llenar_Listas(Lv_Consultas, CONSULTA, "CONSULTAS", RS_CONSULTA)
            If Lv_Consultas.Items.Count > 0 Then
                xCod = CInt(Lv_Consultas.SelectedItems.Item(0).SubItems(0).Text)
                CONSULTA = "SELECT  Id_Consulta,Id_Paciente,No_Expediente,Paciente,Id_Doctor,Medico,Fecha,Asegurado,Diagnostico,Anulada From Consultas WHERE (Id_Consulta = " & xCod & ")"
                RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
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
                Chk_Anulada.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(9).ToString) = 1, True, False))
                Call Variables.Cierra_Conexion()
                RS_CONSULTA.Close()

                Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Consultas.Items.Count.ToString()
            Else
                Lbl_Contador.Text = "TOTAL REGISTROS: 0"
            End If
        End If

    End Sub
    Private Sub Cbo_Asegurado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbo_Asegurado.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Diagnostico.Focus()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_Diagnostico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Diagnostico.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Btn_Guardar.Focus()
        End If
    End Sub
End Class