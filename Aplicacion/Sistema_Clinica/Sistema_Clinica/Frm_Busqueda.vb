Public Class Frm_Busqueda
    'Declaracion de Variables
    Dim Dbl_Cod_Lista As Double

    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(317, 0)
        End Select

    End Sub
    Private Sub Frm_Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Recibe la Consulta
        Lv_Listado.Clear()
        Call Listado_Opciones(Val_Band)

    End Sub
    Private Sub Listado_Opciones(ByVal Int_Opc As Integer)
        'Listado de Opciones
        Select Case Int_Opc
            Case 1 'Listado de Pacientes
                'Configuracion de las opciones
                Opt_1.Visible = True
                Opt_2.Visible = True

                Opt_1.Text = "No. Expediente"
                Opt_2.Text = "Nombre del Paciente: "

                Opt_1.Checked = True
                Opt_2.Checked = False

                Txt_Filtro.Text = ""
                Lbl_Titulo.Text = "Lista de Pacientes:"

                CONSULTA = "SELECT Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,Direccion,No_Telefono,Activo From Pacientes Order By Id_Paciente"
                Call Variables.Llenar_Listas(Lv_Listado, CONSULTA, "PACIENTES", RS_CONSULTA)
                If Lv_Listado.Items.Count > 0 Then
                    Lbl_Contador.Text = "Registros: " & Lv_Listado.Items.Count.ToString
                Else : Lbl_Contador.Text = "Registros: 0"
                End If

            Case 2 'Listado de Doctores
                'Configuracion de las opciones
                Opt_1.Visible = True
                Opt_2.Visible = True

                Opt_1.Text = "Id_Doctor"
                Opt_2.Text = "Nombre del Doctor: "

                Opt_1.Checked = True
                Opt_2.Checked = False

                Txt_Filtro.Text = ""
                Lbl_Titulo.Text = "Lista de Doctores:"

                CONSULTA = "SELECT Id_Doctor,Doctor,No_Cedula,Direccion,No_Telefono,Especialidad,Fotos,Activo From Doctores Order By Id_Doctor"
                Call Variables.Llenar_Listas(Lv_Listado, CONSULTA, "DOCTORES", RS_CONSULTA)
                If Lv_Listado.Items.Count > 0 Then
                    Lbl_Contador.Text = "Registros: " & Lv_Listado.Items.Count.ToString
                Else : Lbl_Contador.Text = "Registros: 0"
                End If
        End Select

    End Sub
    Private Sub Txt_Filtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Filtro.KeyPress
        'Busqueda de Datos
        On Error GoTo HORROR

        Select Case Val_Band
            Case 1
                If (e.KeyChar = Chr(Keys.Enter)) Then
                    If (Txt_Filtro.ReadOnly = True) Then
                        e.Handled = True
                        Exit Sub
                    End If

                    Lv_Listado.Clear()
                    If Txt_Filtro.Text = "" Then
                        CONSULTA = "SELECT Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,Direccion,No_Telefono,Activo From Pacientes Order By Id_Paciente"
                    Else
                        If Opt_1.Checked = True Then
                            CONSULTA = "SELECT Id_Paciente,No_Expediente,Paciente,No_Cedula,Edad,Direccion,No_Telefono,Activo From Pacientes WHERE (No_Expediente LIKE '" & Trim(Txt_Filtro.Text) & "%') ORDER BY Id_Paciente"
                        ElseIf Opt_2.Checked = True Then
                            CONSULTA = "SELECT Id_Pciente,No_Expediente,Paciente,No_Cedula,Edad,Direccion,No_Telefono,Activo From Pacientes WHERE (Paciente LIKE '" & Trim(Txt_Filtro.Text) & "%') ORDER BY Id_Paciente"
                        End If
                    End If

                    Call Variables.Llenar_Listas(Lv_Listado, CONSULTA, "PACIENTES", RS_CONSULTA)
                    If Lv_Listado.Items.Count > 0 Then
                        Lv_Listado.Focus()
                        Lv_Listado.Items(0).Selected = True
                        Lbl_Contador.Text = "Registros: " & Lv_Listado.Items.Count.ToString
                    End If
                ElseIf (e.KeyChar <> Chr(Keys.Back)) Then
                    UCase(e.KeyChar)
                End If

            Case 2
                If (e.KeyChar = Chr(Keys.Enter)) Then
                    If (Txt_Filtro.ReadOnly = True) Then
                        e.Handled = True
                        Exit Sub
                    End If

                    Lv_Listado.Clear()
                    If Txt_Filtro.Text = "" Then
                        CONSULTA = "SELECT Id_Doctor,Doctor,No_Cedula,Direccion,No_Telefono,Especialidad,Fotos,Activo From Doctores Order By Id_Doctor"
                    Else
                        If Opt_1.Checked = True Then
                            CONSULTA = "SELECT Id_Doctor,Doctor,No_Cedula,Direccion,No_Telefono,Especialidad,Fotos,Activo From Doctores WHERE (Id_Doctor LIKE '" & Trim(Txt_Filtro.Text) & "%') ORDER BY Id_Doctor"
                        ElseIf Opt_2.Checked = True Then
                            CONSULTA = "SELECT Id_Doctor,Doctor,No_Cedula,Direccion,No_Telefono,Especialidad,Fotos,Activo From Doctores WHERE (Doctor LIKE '" & Trim(Txt_Filtro.Text) & "%') ORDER BY Id_Doctor"
                        End If
                    End If

                    Call Variables.Llenar_Listas(Lv_Listado, CONSULTA, "DOCTORES", RS_CONSULTA)
                    If Lv_Listado.Items.Count > 0 Then
                        Lv_Listado.Focus()
                        Lv_Listado.Items(0).Selected = True
                        Lbl_Contador.Text = "Registros: " & Lv_Listado.Items.Count.ToString
                    End If
                ElseIf (e.KeyChar <> Chr(Keys.Back)) Then
                    UCase(e.KeyChar)
                End If

        End Select
        Exit Sub
HORROR:
        MessageBox.Show("Error: " & Err.Description, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
    Private Sub Opt_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_1.Click
        'Ubica cursor
        Txt_Filtro.Text = ""
        Txt_Filtro.Focus()

    End Sub

    Private Sub Opt_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_2.Click
        'Ubica cursor
        Txt_Filtro.Text = ""
        Txt_Filtro.Focus()

    End Sub

    Private Sub Lv_Listado_Click(sender As Object, e As EventArgs) Handles Lv_Listado.Click
        'Seleccionando un Registro
        Select Case Val_Band
            Case 1
                If Lv_Listado.Items.Count > 0 Then
                    Dbl_Cod_Lista = CDbl(Lv_Listado.SelectedItems.Item(0).SubItems(0).Text)
                    Frm_Consultas.Txt_IdPaciente.Text = Lv_Listado.SelectedItems.Item(0).SubItems(0).Text
                    Frm_Consultas.Txt_Expediente.Text = Lv_Listado.SelectedItems.Item(0).SubItems(1).Text
                    Frm_Consultas.Txt_Paciente.Text = Lv_Listado.SelectedItems.Item(0).SubItems(2).Text
                End If
                Me.Close()

            Case 2
                If Lv_Listado.Items.Count > 0 Then
                    Dbl_Cod_Lista = CDbl(Lv_Listado.SelectedItems.Item(0).SubItems(0).Text)
                    Frm_Consultas.Txt_IdDoctor.Text = Lv_Listado.SelectedItems.Item(0).SubItems(0).Text
                    Frm_Consultas.Txt_Medico.Text = Lv_Listado.SelectedItems.Item(0).SubItems(1).Text
                    Frm_Consultas.Cbo_Asegurado.Focus()
                End If
                Me.Close()

        End Select
    End Sub

    Private Sub Listado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Lv_Listado.KeyPress
        'Seleccionando un Registro
        Call Lv_Listado_Click(sender, e)

    End Sub
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando el Formulario de los Usuarios
        Respuesta = MessageBox.Show("¿Desea cerrar el Formulario?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            'Cerrando el Formulario
            Me.Close()
        End If

    End Sub
End Class