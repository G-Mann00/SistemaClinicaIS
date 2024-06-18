Public Class Frm_Empleados
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(317, 0)
        End Select

    End Sub
    Private Sub Frm_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bloqueando Campos
        Txt_Codigo.ReadOnly = True
        Txt_Empelado.ReadOnly = True
        Txt_Cedula.ReadOnly = True
        Txt_Direccion.ReadOnly = True
        Txt_Telefono.ReadOnly = True
        Txt_Cargo.ReadOnly = True
        Txt_Departamento.ReadOnly = True
        Pb_Foto.Enabled = False
        Chk_Activo.Enabled = False

        'Ubicar el Primer Registro de la Tabla: Usuario
        Lv_Empleados.Items.Clear()
        Lv_Empleados.Refresh()

        'Agregando Registros
        CONSULTA = "SELECT Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo From Empleados Order By Id_Empleado"
        RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
        If (RS_CONSULTA.HasRows = True) Then
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_Empelado.Text = RS_CONSULTA.Item(1).ToString
            Txt_Cedula.Text = RS_CONSULTA.Item(2).ToString
            Txt_Direccion.Text = RS_CONSULTA.Item(3).ToString
            Txt_Telefono.Text = RS_CONSULTA.Item(4).ToString
            Txt_Cargo.Text = RS_CONSULTA.Item(5).ToString
            Txt_Departamento.Text = RS_CONSULTA.Item(6).ToString

            IMAGEN_FOTO = RS_CONSULTA.Item(7).ToString
            If IMAGEN_FOTO.Length > 0 Then
                Pb_Foto.Load(IMAGEN_FOTO)
            Else : Pb_Foto.Load("C:\Sistema de Clinica\Fotos\interrogacion.png")
            End If

            Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(8).ToString) = 1, True, False))
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            'Llenando el ListView
            CONSULTA = "SELECT Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo From Empleados Order By Id_Empleado"
            Call Variables.Llenar_Listas(Lv_Empleados, CONSULTA, "EMPLEADOS", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Empleados.Items.Count.ToString()

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
            Txt_Empelado.Text = "SIN INFO"
            Txt_Cedula.Text = "SIN INFO"
            Txt_Direccion.Text = "SIN INFO"
            Txt_Telefono.Text = "SIN INFO"
            Txt_Cargo.Text = "SIN INFO"
            Txt_Departamento.Text = "SIN INFO"
            Pb_Foto.Enabled = False
            Pb_Foto.Load("C:\Sistema de Clinica\Fotos\interrogacion.png")
            Chk_Activo.Checked = False

            Call Variables.Llenar_Listas(Lv_Empleados, CONSULTA, "EMPLEADOS", RS_CONSULTA)
            Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Empleados.Items.Count.ToString()

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
        Txt_Empelado.ReadOnly = False
        Txt_Cedula.ReadOnly = False
        Txt_Direccion.ReadOnly = False
        Txt_Telefono.ReadOnly = False
        Txt_Cargo.ReadOnly = False
        Txt_Departamento.ReadOnly = False

        'Limpiando Campos
        Txt_Codigo.Text = Variables.Consecutivo("Empleados", "Id_Empleado", RS_CONSULTA).ToString
        xCod = CInt(Variables.Consecutivo("Empleados", "Id_Empleado", RS_CONSULTA).ToString)
        Txt_Empelado.Text = ""
        Txt_Cedula.Text = ""
        Txt_Direccion.Text = ""
        Txt_Telefono.Text = ""
        Txt_Cargo.Text = ""
        Txt_Departamento.Text = ""
        Txt_Empelado.Focus()
        Chk_Activo.Checked = True
        Pb_Foto.Enabled = True

        Pb_Foto.Load("C:\Sistema de Clinica\Fotos\interrogacion.png")
        IMAGEN_FOTO = String.Empty

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
        If (Txt_Empelado.Text = "") Or (Txt_Cedula.Text = "") Or (Txt_Direccion.Text = "") Or (Txt_Telefono.Text = "") Or (Txt_Cargo.Text = "") Or (Txt_Departamento.Text = "") Then
            MessageBox.Show("Debe de Digitar Todos los Campos", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Si_Agrego = True Then
            CONSULTA = "INSERT INTO Empleados(Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo) " _
                    & "VALUES(" & xCod & ",'" & Txt_Empelado.Text & "','" & Txt_Cedula.Text & "','" & Txt_Direccion.Text & "','" & Txt_Telefono.Text _
                    & "','" & Txt_Cargo.Text & "','" & Txt_Departamento.Text & "','" & IMAGEN_FOTO & "',1)"
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Grabados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Si_Agrego = False Then
            If Chk_Activo.Checked = True Then
                CONSULTA = "UPDATE Empleados SET Empleado = '" & Txt_Empelado.Text & "',No_Cedula = '" & Txt_Cedula.Text & "',Direccion = '" & Txt_Direccion.Text _
                    & "',No_Telefono = '" & Txt_Telefono.Text & "',Cargo = '" & Txt_Cargo.Text & "',Departamento = '" & Txt_Departamento.Text & "',Fotos = '" & IMAGEN_FOTO & "',Activo = 1 WHERE (Id_Empleado = " & xCod & ")"
            ElseIf Chk_Activo.Checked = False Then
                CONSULTA = "UPDATE Empleados SET Empleado = '" & Txt_Empelado.Text & "',No_Cedula = '" & Txt_Cedula.Text & "',Direccion = '" & Txt_Direccion.Text _
                    & "',No_Telefono = '" & Txt_Telefono.Text & "',Cargo = '" & Txt_Cargo.Text & "',Departamento = '" & Txt_Departamento.Text & "',Fotos = '" & IMAGEN_FOTO & "',Activo = 0 WHERE (Id_Empleado = " & xCod & ")"
            End If
            Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            MessageBox.Show("Datos Actualizados Satisfactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        Call Frm_Empleados_Load(sender, e)

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        'Transaccion cancelada
        MessageBox.Show("Transacción cancelada con Exito!!!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Empleados_Load(sender, e)

    End Sub
    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        'Editando y/o Modificando Registros
        'Desbloqueando Campos
        Txt_Empelado.ReadOnly = False
        Txt_Cedula.ReadOnly = False
        Txt_Direccion.ReadOnly = False
        Txt_Telefono.ReadOnly = False
        Txt_Cargo.ReadOnly = False
        Txt_Departamento.ReadOnly = False
        Txt_Empelado.Focus()
        Chk_Activo.Enabled = True
        Pb_Foto.Enabled = True

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

        CONSULTA = "DELETE FROM Empleados WHERE (Id_Empleado = " & xCod & ")"
        Call Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)

        MessageBox.Show("Datos Eliminados Sastifactoriamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call Frm_Empleados_Load(sender, e)

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
    Private Sub Lv_Empleados_Click(sender As Object, e As EventArgs) Handles Lv_Empleados.Click
        If Lv_Empleados.Items.Count > 0 Then 'Verifica si hay filas
            xCod = CInt(Lv_Empleados.SelectedItems.Item(0).SubItems(0).Text)
            CONSULTA = "SELECT Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo From Empleados WHERE (Id_Empleado = " & xCod & ")"
            RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
            RS_CONSULTA.Read()
            Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
            Txt_Empelado.Text = RS_CONSULTA.Item(1).ToString
            Txt_Cedula.Text = RS_CONSULTA.Item(2).ToString
            Txt_Direccion.Text = RS_CONSULTA.Item(3).ToString
            Txt_Telefono.Text = RS_CONSULTA.Item(4).ToString
            Txt_Cargo.Text = RS_CONSULTA.Item(5).ToString
            Txt_Departamento.Text = RS_CONSULTA.Item(6).ToString
            IMAGEN_FOTO = RS_CONSULTA.Item(7).ToString
            If IMAGEN_FOTO.Length > 0 Then
                Pb_Foto.Load(IMAGEN_FOTO)
            Else : Pb_Foto.Load("C:\Sistema de Clinica\Fotos\interrogacion.png")
            End If
            Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(8).ToString) = 1, True, False))
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
                CONSULTA = "SELECT  Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo From Empleados Order By Id_Empleado"
            Else
                CONSULTA = "SELECT  Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo From Empleados WHERE (Empleado LIKE '" & Txt_Filtro.Text & "%') ORDER  BY Id_Empleado"
            End If
            Call Variables.Llenar_Listas(Lv_Empleados, CONSULTA, "EMPLEADOS", RS_CONSULTA)
            If Lv_Empleados.Items.Count > 0 Then
                xCod = CInt(Lv_Empleados.SelectedItems.Item(0).SubItems(0).Text)
                CONSULTA = "SELECT  Id_Empleado,Empleado,No_Cedula,Direccion,No_Telefono,Cargo,Departamento,Fotos,Activo From Empleados WHERE (Id_Empleado = " & xCod & ")"
                RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)
                RS_CONSULTA.Read()
                Txt_Codigo.Text = RS_CONSULTA.Item(0).ToString
                Txt_Empelado.Text = RS_CONSULTA.Item(1).ToString
                Txt_Cedula.Text = RS_CONSULTA.Item(2).ToString
                Txt_Direccion.Text = RS_CONSULTA.Item(3).ToString
                Txt_Telefono.Text = RS_CONSULTA.Item(4).ToString
                Txt_Cargo.Text = RS_CONSULTA.Item(5).ToString
                Txt_Departamento.Text = RS_CONSULTA.Item(6).ToString
                IMAGEN_FOTO = RS_CONSULTA.Item(7).ToString

                If IMAGEN_FOTO.Length > 0 Then
                    Pb_Foto.Load(IMAGEN_FOTO)
                Else : Pb_Foto.Load("C:\Sistema de Clinica\Fotos\interrogacion.png")
                End If

                Chk_Activo.Checked = CBool(IIf(CInt(RS_CONSULTA.Item(8).ToString) = 1, True, False))
                Call Variables.Cierra_Conexion()
                RS_CONSULTA.Close()

                Lbl_Contador.Text = "TOTAL REGISTROS: " & Lv_Empleados.Items.Count.ToString()
            Else
                Lbl_Contador.Text = "TOTAL REGISTROS: 0"
            End If
        End If

    End Sub
    Private Sub Txt_Empelado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Empelado.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Cedula.Focus()
        End If
    End Sub
    Private Sub Txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cedula.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Direccion.Focus()
        End If
    End Sub
    Private Sub Txt_Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Direccion.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Telefono.Focus()
        End If
    End Sub
    Private Sub Txt_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Telefono.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Cargo.Focus()
        End If
    End Sub
    Private Sub Txt_Cargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cargo.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Txt_Departamento.Focus()
        End If
    End Sub
    Private Sub Txt_Departamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Departamento.KeyPress
        'Ir al siguiente Campo
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Btn_Guardar.Focus()
        End If
    End Sub

    Private Sub Pb_Foto_Click(sender As Object, e As EventArgs) Handles Pb_Foto.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                IMAGEN_FOTO = OpenFileDialog1.FileName
                Dim largo As Integer = IMAGEN_FOTO.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN_FOTO), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "PNG" And imagen2 <> "png" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN_FOTO), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato de imagen no valido, seleccione otra imagen") : Exit Sub
                    End If
                    If imagen2 <> "log1" Then Exit Sub
                End If
                Pb_Foto.Load(IMAGEN_FOTO)
            End If
        Catch ex As Exception
            Pb_Foto.Load(Application.StartupPath & "\interrogacion.JPG")
        End Try

    End Sub

End Class