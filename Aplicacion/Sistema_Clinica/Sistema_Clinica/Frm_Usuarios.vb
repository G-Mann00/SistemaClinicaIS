Public Class Frm_Usuarios
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(317, 0)
        End Select
    End Sub

    Private Sub Frm_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bloqueando Campos
        Txt_Codigo.ReadOnly = True
        Txt_Login.ReadOnly = True
        Txt_Password.ReadOnly = True
        Txt_Usuario.ReadOnly = True
        Cbo_Tipo.Enabled = False
        Chk_Activo.Enabled = False

        'Ubicar el Primer Registro de la Tabla: Usuario
        Lv_Usuarios.Items.Clear()
        Lv_Usuarios.Refresh()

        'Agregando Registros
        CONSULTA = "SELECT Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo From Usuarios Order By Id_Usuario"
        RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
        If (RS_CONSULTA.HasRows = True) Then
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_Login.Text = RS_CONSULTA.Item(1).ToString
            Txt_Password.Text = RS_CONSULTA.Item(2).ToString
            Txt_Usuario.Text = RS_CONSULTA.Item(3).ToString
            Cbo_Tipo.Text = RS_CONSULTA.Item(4).ToString
            Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(5).ToString) = 1, True, False))
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            'Llenando el ListView
            CONSULTA = "SELECT Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo From Usuarios Order By Id_Usuario"
            Call Variables.Llenar_Listas(Lv_Usuarios, CONSULTA, "USUARIOS", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Usuarios.Items.Count.ToString()

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
            Txt_Login.Text = "SIN INFO"
            Txt_Password.Text = "SIN INFO"
            Txt_Usuario.Text = "SIN INFO"
            Cbo_Tipo.Text = "SIN INFO"
            Chk_Activo.Checked = False

            Call Variables.Llenar_Listas(Lv_Usuarios, CONSULTA, "USUARIOS", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Usuarios.Items.Count.ToString()

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
        Txt_Login.ReadOnly = False
        Txt_Password.ReadOnly = False
        Txt_Usuario.ReadOnly = False
        Cbo_Tipo.Enabled = True

        'Limpiando Campos
        Txt_Codigo.Text = Variables.Consecutivo("Usuarios", "Id_Usuario", RS_CONSULTA).ToString
        xCod = CInt(Variables.Consecutivo("Usuarios", "Id_Usuario", RS_CONSULTA).ToString)
        Txt_Login.Text = ""
        Txt_Password.Text = ""
        Txt_Usuario.Text = ""
        Cbo_Tipo.Text = ""
        Txt_Login.Focus()
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
        If (Txt_Login.Text = "") Or (Txt_Password.Text = "") Or (Txt_Usuario.Text = "") Or (Cbo_Tipo.Text = "") Then
            MessageBox.Show("Debe de Digitar Todos los Campos", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Si_Agrego = True Then
            CONSULTA = "INSERT INTO Usuarios(Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo) " _
                    & "VALUES(" & xCod & ",'" & Txt_Login.Text & "','" & Txt_Password.Text & "','" & Txt_Usuario.Text _
                    & "','" & Cbo_Tipo.Text & "',1)"
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Grabados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Si_Agrego = False Then
            If Chk_Activo.Checked = True Then
                CONSULTA = "UPDATE Usuarios SET Usuario = '" & Txt_Login.Text & "',Clave = '" & Txt_Password.Text & "',Nombre_Usuario = '" & Txt_Usuario.Text _
                    & "',Tipo_Usuario = '" & Cbo_Tipo.Text & "',Activo = 1 WHERE (Id_Usuario = " & xCod & ")"
            ElseIf Chk_Activo.Checked = False Then
                CONSULTA = "UPDATE Usuarios SET Usuario = '" & Txt_Login.Text & "',Clave = '" & Txt_Password.Text & "',Nombre_Usuario = '" & Txt_Usuario.Text _
                    & "',Tipo_Usuario = '" & Cbo_Tipo.Text & "',Activo = 0 WHERE (Id_Usuario = " & xCod & ")"
            End If
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Actualizados Satisfactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        Call Frm_Usuarios_Load(sender, e)

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        'Transaccion cancelada
        MessageBox.Show("Transacción cancelada con Exito!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Usuarios_Load(sender, e)

    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        'Editando y/o Modificando Registros
        'Desbloqueando Campos
        Txt_Codigo.ReadOnly = True
        Txt_Login.ReadOnly = False
        Txt_Password.ReadOnly = False
        Txt_Usuario.ReadOnly = False
        Cbo_Tipo.Enabled = True
        Txt_Login.Focus()
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

        CONSULTA = "DELETE FROM Usuarios WHERE (Id_Usuario = " & xCod & ")"
        Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)

        MessageBox.Show("Datos Eliminados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Usuarios_Load(sender, e)

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

    Private Sub Lv_Usuarios_Click(sender As Object, e As EventArgs) Handles Lv_Usuarios.Click
        If Lv_Usuarios.Items.Count > 0 Then 'Verifica si hay filas
            xCod = CInt(Lv_Usuarios.SelectedItems.Item(0).SubItems(0).Text)
            CONSULTA = "SELECT Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo From Usuarios WHERE (Id_Usuario = " & xCod & ")"
            RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_Login.Text = RS_CONSULTA.Item(1).ToString
            Txt_Password.Text = RS_CONSULTA.Item(2).ToString
            Txt_Usuario.Text = RS_CONSULTA.Item(3).ToString
            Cbo_Tipo.Text = RS_CONSULTA.Item(4).ToString
            Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(5).ToString) = 1, True, False))
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
                CONSULTA = "SELECT Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo FROM Usuarios Order By Id_Usuario"
            Else
                CONSULTA = "SELECT Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo FROM Usuarios WHERE (Nombre_Usuario LIKE '" & Txt_Filtro.Text & "%') ORDER  BY Id_Usuario"
            End If
            Call Variables.Llenar_Listas(Lv_Usuarios, CONSULTA, "USUARIOS", RS_CONSULTA)
            If Lv_Usuarios.Items.Count > 0 Then
                xCod = CInt(Lv_Usuarios.SelectedItems.Item(0).SubItems(0).Text)
                CONSULTA = "SELECT Id_Usuario,Usuario,Clave,Nombre_Usuario,Tipo_Usuario,Activo FROM Usuarios WHERE (Id_Usuario = " & xCod & ")"
                RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
                RS_CONSULTA.Read()
                Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
                Txt_Login.Text = RS_CONSULTA.Item(1).ToString
                Txt_Password.Text = RS_CONSULTA.Item(2).ToString
                Txt_Usuario.Text = RS_CONSULTA.Item(3).ToString
                Cbo_Tipo.Text = RS_CONSULTA.Item(4).ToString
                Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(5).ToString) = 1, True, False))
                Call Variables.Cierra_Conexion()
                RS_CONSULTA.Close()

                Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Usuarios.Items.Count.ToString()
            Else
                Lbl_Contador.Text = "TOTAL REGISTROS: 0"
            End If
        End If

    End Sub

    Private Sub Txt_Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Login.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Password.Focus()
        End If

    End Sub

    Private Sub Txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Password.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Usuario.Focus()
        End If

    End Sub

    Private Sub Txt_Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Usuario.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Cbo_Tipo.Focus()
        End If
    End Sub

    Private Sub Cbo_Tipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbo_Tipo.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Btn_Guardar.Focus()
        Else
            e.Handled = True
        End If
    End Sub
End Class