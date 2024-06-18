Public Class Frm_Pacientes
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(317, 0)
        End Select
    End Sub

    Private Sub Frm_Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bloqueando Campos
        Txt_Codigo.ReadOnly = True
        Txt_Expediente.ReadOnly = True
        Txt_Paciente.ReadOnly = True
        Txt_Cedula.ReadOnly = True
        Txt_Edad.ReadOnly = True
        Txt_Telefono.ReadOnly = True
        Txt_Direccion.ReadOnly = True
        Chk_Activo.Enabled = False

        'Ubicar el Primer Registro de la Tabla: Usuario
        Lv_Pacientes.Items.Clear()
        Lv_Pacientes.Refresh()

        'Agregando Registros
        CONSULTA = "SELECT Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo From Pacientes Order By Id_Paciente"
        RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
        If (RS_CONSULTA.HasRows = True) Then
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_Expediente.Text = RS_CONSULTA.Item(1).ToString
            Txt_Paciente.Text = RS_CONSULTA.Item(2).ToString
            Txt_Cedula.Text = RS_CONSULTA.Item(3).ToString
            Txt_Edad.Text = RS_CONSULTA.Item(4).ToString
            Txt_Telefono.Text = RS_CONSULTA.Item(5).ToString
            Txt_Direccion.Text = RS_CONSULTA.Item(6).ToString
            Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(7).ToString) = 1, True, False))
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            'Llenando el ListView
            CONSULTA = "SELECT Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo From Pacientes Order By Id_Paciente"
            Call Variables.Llenar_Listas(Lv_Pacientes, CONSULTA, "PACIENTES", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Pacientes.Items.Count.ToString()

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
            Txt_Expediente.Text = "0"
            Txt_Paciente.Text = "SIN INFO"
            Txt_Cedula.Text = "SIN INFO"
            Txt_Edad.Text = "SIN INFO"
            Txt_Telefono.Text = "SIN INFO"
            Txt_Direccion.Text = "SIN INFO"
            Chk_Activo.Checked = False

            Call Variables.Llenar_Listas(Lv_Pacientes, CONSULTA, "PACIENTES", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Pacientes.Items.Count.ToString()

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
        Txt_Paciente.ReadOnly = False
        Txt_Expediente.ReadOnly = False
        Txt_Cedula.ReadOnly = False
        Txt_Edad.ReadOnly = False
        Txt_Telefono.ReadOnly = False
        Txt_Direccion.ReadOnly = False

        'Limpiando Campos
        Txt_Codigo.Text = Variables.Consecutivo("Pacientes", "Id_Paciente", RS_CONSULTA).ToString
        xCod = CInt(Variables.Consecutivo("Pacientes", "Id_Paciente", RS_CONSULTA).ToString)
        Txt_Expediente.Text = ""
        Txt_Paciente.Text = ""
        Txt_Cedula.Text = ""
        Txt_Edad.Text = ""
        Txt_Telefono.Text = ""
        Txt_Direccion.Text = ""
        Txt_Expediente.Focus()
        Chk_Activo.Checked = True

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
        If (Txt_Expediente.Text = "") Or (Txt_Paciente.Text = "") Or (Txt_Cedula.Text = "") Or (Txt_Edad.Text = "") Or (Txt_Telefono.Text = "") Or (Txt_Direccion.Text = "") Then
            MessageBox.Show("Debe de Digitar Todos los Campos", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Si_Agrego = True Then
            CONSULTA = "INSERT INTO Pacientes(Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo) " _
                    & "VALUES(" & xCod & ",'" & Txt_Expediente.Text & "','" & Txt_Paciente.Text & "','" & Txt_Cedula.Text & "','" & Txt_Edad.Text & "','" & Txt_Telefono.Text _
                    & "','" & Txt_Direccion.Text & "',1)"
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Grabados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Si_Agrego = False Then
            If Chk_Activo.Checked = True Then
                CONSULTA = "UPDATE Pacientes SET No_Expediente = '" & Txt_Expediente.Text & "',Paciente = '" & Txt_Paciente.Text & "',No_Cedula = '" & Txt_Cedula.Text _
                    & "',Edad = '" & Txt_Edad.Text & "',No_Telefono = '" & Txt_Telefono.Text & "',Direccion= '" & Txt_Direccion.Text & "',Activo = 1 WHERE (Id_Paciente = " & xCod & ")"
            ElseIf Chk_Activo.Checked = False Then
                CONSULTA = "UPDATE Pacientes SET No_Expediente = '" & Txt_Expediente.Text & "',Paciente = '" & Txt_Paciente.Text & "',No_Cedula = '" & Txt_Cedula.Text _
                    & "',Edad = '" & Txt_Edad.Text & "',No_Telefono = '" & Txt_Telefono.Text & "',Direccion= '" & Txt_Direccion.Text & "',Activo = 0 WHERE (Id_Paciente = " & xCod & ")"
            End If
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Actualizados Satisfactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        Call Frm_Pacientes_Load(sender, e)

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        'Transaccion cancelada
        MessageBox.Show("Transacción cancelada con Exito!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Pacientes_Load(sender, e)

    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        'Editando y/o Modificando Registros
        'Desbloqueando Campos
        Txt_Expediente.ReadOnly = False
        Txt_Paciente.ReadOnly = False
        Txt_Cedula.ReadOnly = False
        Txt_Edad.ReadOnly = False
        Txt_Telefono.ReadOnly = False
        Txt_Direccion.ReadOnly = False
        Txt_Expediente.Focus()
        Chk_Activo.Enabled = True

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

        CONSULTA = "DELETE FROM Pacientes WHERE (Id_Paciente = " & xCod & ")"
        Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)

        MessageBox.Show("Datos Eliminados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Pacientes_Load(sender, e)

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
    Private Sub Lv_Doctores_Click(sender As Object, e As EventArgs) Handles Lv_Pacientes.Click
        If Lv_Pacientes.Items.Count > 0 Then 'Verifica si hay filas
            xCod = CInt(Lv_Pacientes.SelectedItems.Item(0).SubItems(0).Text)
            CONSULTA = "SELECT Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo From Pacientes WHERE (Id_Paciente = " & xCod & ")"
            RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_Expediente.Text = RS_CONSULTA.Item(1).ToString
            Txt_Paciente.Text = RS_CONSULTA.Item(2).ToString
            Txt_Cedula.Text = RS_CONSULTA.Item(3).ToString
            Txt_Edad.Text = RS_CONSULTA.Item(4).ToString
            Txt_Telefono.Text = RS_CONSULTA.Item(5).ToString
            Txt_Direccion.Text = RS_CONSULTA.Item(6).ToString
            Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(7).ToString) = 1, True, False))
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
                CONSULTA = "SELECT  Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo From Pacientes Order By Id_Paciente"
            Else
                CONSULTA = "SELECT  Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo From Pacientes WHERE (Paciente LIKE '" & Txt_Filtro.Text & "%' or No_Expediente LIKE '" & Txt_Filtro.Text & "%') ORDER  BY Id_Paciente"
            End If
            Call Variables.Llenar_Listas(Lv_Pacientes, CONSULTA, "PACIENTES", RS_CONSULTA)
            If Lv_Pacientes.Items.Count > 0 Then
                xCod = CInt(Lv_Pacientes.SelectedItems.Item(0).SubItems(0).Text)
                CONSULTA = "SELECT  Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,No_Telefono,Direccion,Activo From Pacientes WHERE (Id_Paciente = " & xCod & ")"
                RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
                RS_CONSULTA.Read()
                Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
                Txt_Expediente.Text = RS_CONSULTA.Item(1).ToString
                Txt_Paciente.Text = RS_CONSULTA.Item(2).ToString
                Txt_Cedula.Text = RS_CONSULTA.Item(3).ToString
                Txt_Edad.Text = RS_CONSULTA.Item(4).ToString
                Txt_Telefono.Text = RS_CONSULTA.Item(5).ToString
                Txt_Direccion.Text = RS_CONSULTA.Item(6).ToString
                Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(7).ToString) = 1, True, False))
                Call Variables.Cierra_Conexion()
                RS_CONSULTA.Close()

                Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Pacientes.Items.Count.ToString()
            Else
                Lbl_Contador.Text = "TOTAL REGISTROS: 0"
            End If
        End If

    End Sub
    Private Sub Txt_Expediente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Expediente.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Paciente.Focus()
        End If
    End Sub
    Private Sub Txt_Paciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Paciente.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Cedula.Focus()
        End If
    End Sub
    Private Sub Txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cedula.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Edad.Focus()
        End If
    End Sub
    Private Sub Txt_Edad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Edad.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Telefono.Focus()
        End If
    End Sub
    Private Sub Txt_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Telefono.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Direccion.Focus()
        End If
    End Sub
    Private Sub Txt_Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Direccion.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Btn_Guardar.Focus()
        End If
    End Sub

End Class