Module Variables
    'Declaracion de las Variables
    Public Respuesta As Integer
    Public Si_Agrego As Boolean
    Public xCod As Integer
    Public I As Integer, Val_Band As Integer, Int_Informe As Integer
    Public LOGIN_USER As String, NOMBRE_USER As String, TIPO_USER As String, TURNO_USER As String, IMAGEN_FOTO As String
    Public Const SISTEMA As String = "CLINICA SU MEDICO"

    'Variable de Conexion y Mnejo de Datos
    Public CONEXION As Odbc.OdbcConnection 'El Objeto Conecio ADO.NET Conectado
    Public COMANDO As Odbc.OdbcCommand 'El Objeto Para Consultas (Insert,Delete,Update)
    Public RS_CONSULTA As Odbc.OdbcDataReader 'Objeto para almacenamiento de datos (Select)
    Public CAD_CONEXION As String
    Public CONSULTA As String

    'Variables del listview
    Public Columna As ColumnHeader
    Public Fila_View As ListViewItem

    'Abre y Ejecuta la Conexion con la Cadena de Conexion de Tipo y ODBC
    Public Function Consulta_Segura(ByVal SQL As String, ByVal RS As Odbc.OdbcDataReader) As Odbc.OdbcDataReader
        Dim Seleccionar As Integer

        'Estableciendo la Conexion
        CAD_CONEXION = "PROVIDER=MSDASQL;DSN=BD_CLINICA;UID=;PWD=;"

        'Abre la Conexion
        CONEXION = New Odbc.OdbcConnection(CAD_CONEXION)
        CONEXION.Open()

        'Ejecutamos la Consulta
        COMANDO = New Odbc.OdbcCommand(SQL, CONEXION)
        COMANDO.Connection = CONEXION

        Seleccionar = InStrRev(SQL, "SELECT", , CompareMethod.Text)
        If (Seleccionar > 0) Then
            'Llenamos en Memoria los Registros Devueltos
            RS = COMANDO.ExecuteReader()
            Consulta_Segura = RS
        Else
            'Ejecutamos la Consulta sin Devolverl Resultados
            COMANDO.ExecuteNonQuery()
            Call Cierra_Conexion()
            Consulta_Segura = Nothing
        End If
    End Function

    'Cierra la Conexion y Vacia el Contenido de los Objetos
    Public Sub Cierra_Conexion()
        'Cierra la Conexion
        COMANDO = Nothing
        CONEXION.Close()
    End Sub

    Public Function Consecutivo(ByVal Tabla As String, ByVal Campo As String, ByVal RS As Odbc.OdbcDataReader) As Double
        'Consecutivo de una Tabla
        Dim Dbl_Resultado As Double

        CONSULTA = "SELECT MAX(" & Campo & ") FROM " & Tabla
        RS = Variables.Consulta_Segura(CONSULTA, RS)
        If RS.HasRows = True Then
            RS.Read()
            If IsDBNull(RS.Item(0)) = True Then
                Dbl_Resultado = 1
            Else : Dbl_Resultado = CDbl(RS.Item(0).ToString) + 1 'El ultimo registro mas 1
            End If
        Else : Dbl_Resultado = 1
        End If
        Call Variables.Cierra_Conexion()
        Consecutivo = Dbl_Resultado
    End Function

    '-- Procedimiento para llenar un Listview
    Public Sub Llenar_Listas(ByVal Contenedor As ListView, ByVal Query As String, ByVal Str_Tipo As String, ByVal RS As Odbc.OdbcDataReader)
        'Definiendo y Llenando un Listview
        Contenedor.Clear()
        If Str_Tipo = "USUARIOS" Then
            Columna = New ColumnHeader
            Columna.Text = "Id_Usuario"
            Contenedor.Columns.Add(Columna.Text, 70)
            Columna.Text = "Usuario"
            Contenedor.Columns.Add(Columna.Text, 300, HorizontalAlignment.Left)
            Columna.Text = "Clave"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Nombre de Usuario"
            Contenedor.Columns.Add(Columna.Text, 400, HorizontalAlignment.Left)
            Columna.Text = "Tipo de Usuario"
            Contenedor.Columns.Add(Columna.Text, 160, HorizontalAlignment.Left)
            Columna.Text = "Activo"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Center)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Usuario
                    Col_2 = RS.Item(1).ToString  'Usuario
                    Col_3 = RS.Item(2).ToString  'Contraseña
                    Col_4 = RS.Item(3).ToString  'Nombre Completo
                    Col_5 = RS.Item(4).ToString  'Tipo de Usuario
                    Col_6 = IIf(CInt(RS.Item(5).ToString) = 1, "SI", "NO").ToString 'Activo

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Str_Tipo = "DOCTORES" Then
            Columna = New ColumnHeader
            Columna.Text = "Id_Doctor"
            Contenedor.Columns.Add(Columna.Text, 70)
            Columna.Text = "Doctor"
            Contenedor.Columns.Add(Columna.Text, 200, HorizontalAlignment.Left)
            Columna.Text = "No. Cedula"
            Contenedor.Columns.Add(Columna.Text, 90, HorizontalAlignment.Left)
            Columna.Text = "Direccion"
            Contenedor.Columns.Add(Columna.Text, 400, HorizontalAlignment.Left)
            Columna.Text = "Telefono"
            Contenedor.Columns.Add(Columna.Text, 80, HorizontalAlignment.Left)
            Columna.Text = "Especialidad"
            Contenedor.Columns.Add(Columna.Text, 150, HorizontalAlignment.Left)
            Columna.Text = "Fotos"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Activo"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Center)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String, Col_7 As String, Col_8 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Doctor
                    Col_2 = RS.Item(1).ToString  'Nombre del Doctor
                    Col_3 = RS.Item(2).ToString  'No. Cedula
                    Col_4 = RS.Item(3).ToString  'Dirección
                    Col_5 = RS.Item(4).ToString  'Teléfono
                    Col_6 = RS.Item(5).ToString  'Especialidad
                    Col_7 = RS.Item(6).ToString  'Fotos
                    Col_8 = IIf(CInt(RS.Item(7).ToString) = 1, "SI", "NO").ToString 'Activo

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Fila_View.SubItems.Add(Col_7)
                    Fila_View.SubItems.Add(Col_8)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Str_Tipo = "ENFERMERAS" Then
            Columna = New ColumnHeader
            Columna.Text = "Id. Enefermera"
            Contenedor.Columns.Add(Columna.Text, 70)
            Columna.Text = "Enfermera"
            Contenedor.Columns.Add(Columna.Text, 200, HorizontalAlignment.Left)
            Columna.Text = "No. Cedula"
            Contenedor.Columns.Add(Columna.Text, 90, HorizontalAlignment.Left)
            Columna.Text = "Direccion"
            Contenedor.Columns.Add(Columna.Text, 400, HorizontalAlignment.Left)
            Columna.Text = "Telefono"
            Contenedor.Columns.Add(Columna.Text, 80, HorizontalAlignment.Left)
            Columna.Text = "Titulada(o)"
            Contenedor.Columns.Add(Columna.Text, 150, HorizontalAlignment.Left)
            Columna.Text = "Fotos"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Activo"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Center)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String, Col_7 As String, Col_8 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Enfermera
                    Col_2 = RS.Item(1).ToString  'Nombre Enfermera(o)
                    Col_3 = RS.Item(2).ToString  'No. Cedula
                    Col_4 = RS.Item(3).ToString  'Dirección
                    Col_5 = RS.Item(4).ToString  'Teléfono
                    Col_6 = RS.Item(5).ToString  'Titulo
                    Col_7 = RS.Item(6).ToString  'Fotos
                    Col_8 = IIf(CInt(RS.Item(7).ToString) = 1, "SI", "NO").ToString 'Activo

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Fila_View.SubItems.Add(Col_7)
                    Fila_View.SubItems.Add(Col_8)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Str_Tipo = "EMPLEADOS" Then
            Columna = New ColumnHeader
            Columna.Text = "Id. Empleado"
            Contenedor.Columns.Add(Columna.Text, 70)
            Columna.Text = "Empleado"
            Contenedor.Columns.Add(Columna.Text, 200, HorizontalAlignment.Left)
            Columna.Text = "No. Cedula"
            Contenedor.Columns.Add(Columna.Text, 90, HorizontalAlignment.Left)
            Columna.Text = "Direccion"
            Contenedor.Columns.Add(Columna.Text, 400, HorizontalAlignment.Left)
            Columna.Text = "Telefono"
            Contenedor.Columns.Add(Columna.Text, 80, HorizontalAlignment.Left)
            Columna.Text = "Cargo"
            Contenedor.Columns.Add(Columna.Text, 150, HorizontalAlignment.Left)
            Columna.Text = "Departamento"
            Contenedor.Columns.Add(Columna.Text, 150, HorizontalAlignment.Left)
            Columna.Text = "Fotos"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Activo"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Center)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String, Col_7 As String, Col_8 As String, Col_9 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Empleado
                    Col_2 = RS.Item(1).ToString  'Nombre del Empleado
                    Col_3 = RS.Item(2).ToString  'No. Cedula
                    Col_4 = RS.Item(3).ToString  'Dirección
                    Col_5 = RS.Item(4).ToString  'Teléfono
                    Col_6 = RS.Item(5).ToString  'Cargo
                    Col_7 = RS.Item(6).ToString  'Departamento
                    Col_8 = RS.Item(7).ToString  'Fotos
                    Col_9 = IIf(CInt(RS.Item(8).ToString) = 1, "SI", "NO").ToString 'Activo

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Fila_View.SubItems.Add(Col_7)
                    Fila_View.SubItems.Add(Col_8)
                    Fila_View.SubItems.Add(Col_9)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Str_Tipo = "PACIENTES" Then
            Columna = New ColumnHeader
            Columna.Text = "Id_Paciente"
            Contenedor.Columns.Add(Columna.Text, 80)
            Columna.Text = "No. Expediente"
            Contenedor.Columns.Add(Columna.Text, 110, HorizontalAlignment.Left)
            Columna.Text = "Paciente"
            Contenedor.Columns.Add(Columna.Text, 220, HorizontalAlignment.Left)
            Columna.Text = "No. Cedula"
            Contenedor.Columns.Add(Columna.Text, 120, HorizontalAlignment.Left)
            Columna.Text = "Edad"
            Contenedor.Columns.Add(Columna.Text, 80, HorizontalAlignment.Left)
            Columna.Text = "No. Teléfono"
            Contenedor.Columns.Add(Columna.Text, 98, HorizontalAlignment.Left)
            Columna.Text = "Direccion"
            Contenedor.Columns.Add(Columna.Text, 240, HorizontalAlignment.Left)
            Columna.Text = "Activo"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Center)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String, Col_7 As String, Col_8 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Paciente
                    Col_2 = RS.Item(1).ToString  'No. Expediente
                    Col_3 = RS.Item(2).ToString  'Nombre del Paciente
                    Col_4 = RS.Item(3).ToString  'No. Cedula
                    Col_5 = RS.Item(4).ToString  'Edad del Paciente
                    Col_6 = RS.Item(5).ToString  'Teléfono
                    Col_7 = RS.Item(6).ToString  'Dirección
                    Col_8 = IIf(CInt(RS.Item(7).ToString) = 1, "SI", "NO").ToString 'Activo

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Fila_View.SubItems.Add(Col_7)
                    Fila_View.SubItems.Add(Col_8)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Str_Tipo = "CONSULTAS" Then
            Columna = New ColumnHeader
            Columna.Text = "Id. Consulta"
            Contenedor.Columns.Add(Columna.Text, 0)
            Columna.Text = "Id. Paciente"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Expediente"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Left)
            Columna.Text = "Paciente"
            Contenedor.Columns.Add(Columna.Text, 225, HorizontalAlignment.Left)
            Columna.Text = "Id. Doctor"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Medico"
            Contenedor.Columns.Add(Columna.Text, 200, HorizontalAlignment.Left)
            Columna.Text = "Fecha"
            Contenedor.Columns.Add(Columna.Text, 68, HorizontalAlignment.Left)
            Columna.Text = "Asegurado"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Left)
            Columna.Text = "Diagnostico"
            Contenedor.Columns.Add(Columna.Text, 300, HorizontalAlignment.Left)
            Columna.Text = "Anulada"
            Contenedor.Columns.Add(Columna.Text, 70, HorizontalAlignment.Center)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String, Col_7 As String, Col_8 As String, Col_9 As String, Col_10 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Consulta
                    Col_2 = RS.Item(1).ToString  'Id Paciente
                    Col_3 = RS.Item(2).ToString  'Numero de Expediente
                    Col_4 = RS.Item(3).ToString  'Nombre del Paciente
                    Col_5 = RS.Item(4).ToString  'Id. Doctor
                    Col_6 = RS.Item(5).ToString  'Nombre del Medico
                    Col_7 = RS.Item(6).ToString  'Fecha de la Consulta
                    Col_8 = RS.Item(7).ToString  'Asegurado Si/No
                    Col_9 = RS.Item(8).ToString  'Diagnostico
                    Col_10 = IIf(CInt(RS.Item(9).ToString) = 1, "SI", "NO").ToString 'Anulada

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Fila_View.SubItems.Add(Col_7)
                    Fila_View.SubItems.Add(Col_8)
                    Fila_View.SubItems.Add(Col_9)
                    Fila_View.SubItems.Add(Col_10)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Str_Tipo = "DETALLE_CONSULTA" Then
            Columna = New ColumnHeader
            Columna.Text = "Id. Detalle"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Id. Paciente"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Id. Consulta"
            Contenedor.Columns.Add(Columna.Text, 0, HorizontalAlignment.Left)
            Columna.Text = "Fecha"
            Contenedor.Columns.Add(Columna.Text, 80, HorizontalAlignment.Left)
            Columna.Text = "Asegurado"
            Contenedor.Columns.Add(Columna.Text, 80, HorizontalAlignment.Left)
            Columna.Text = "Diagnostico"
            Contenedor.Columns.Add(Columna.Text, 444, HorizontalAlignment.Left)

            Dim Col_1 As String, Col_2 As String, Col_3 As String, Col_4 As String, Col_5 As String, Col_6 As String
            RS = Variables.Consulta_Segura(Query, RS)
            If (RS.HasRows = True) Then
                Do While (RS.Read = True)
                    Col_1 = RS.Item(0).ToString  'Id Detalle
                    Col_2 = RS.Item(1).ToString  'Id_Paciente
                    Col_3 = RS.Item(2).ToString  'Id_consulta
                    Col_4 = RS.Item(3).ToString  'Fecha
                    Col_5 = RS.Item(4).ToString  'Asegurado
                    Col_6 = RS.Item(5).ToString  'Diagnostico

                    Fila_View = New ListViewItem(Col_1, 0)
                    Fila_View.SubItems.Add(Col_2)
                    Fila_View.SubItems.Add(Col_3)
                    Fila_View.SubItems.Add(Col_4)
                    Fila_View.SubItems.Add(Col_5)
                    Fila_View.SubItems.Add(Col_6)
                    Contenedor.Items.Add(Fila_View)
                Loop
                Call Variables.Cierra_Conexion()
                RS.Close()
            End If
        End If

        If Contenedor.Items.Count > 0 Then
            Contenedor.Items(0).Selected = True
        End If
    End Sub

End Module
