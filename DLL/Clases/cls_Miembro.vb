Public Class cls_Miembro

#Region "Atributos"
    Private Id_Miembro As Integer
    Private Num_Miembro As String
    Private Localizacion_Foto As String
    Private Id_Organizacion As String
    Private Nombre As String
    Private Direccion As String
    Private Telefono As String
    Private Genero As String
    Private Fecha_Nac As Date


#End Region

#Region "Propiedades"

    Public Property newId_Miembro() As Integer
        Get
            Return Id_Miembro
        End Get
        Set(ByVal nwId_Miembro As Integer)
            Id_Miembro = nwId_Miembro
        End Set
    End Property
    Public Property newNum_Miembro() As String
        Get
            Return Num_Miembro
        End Get
        Set(ByVal nwNum_Miembro As String)
            Num_Miembro = nwNum_Miembro
        End Set
    End Property
    Public Property newLocalizacion_Foto() As String
        Get
            Return Localizacion_Foto
        End Get
        Set(ByVal nwLocalizacion_Foto As String)
            Localizacion_Foto = nwLocalizacion_Foto
        End Set
    End Property
    Public Property newid_Organizacion() As String
        Get
            Return Id_Organizacion
        End Get
        Set(ByVal nwid_Organizacion As String)
            Id_Organizacion = nwid_Organizacion
        End Set
    End Property

    Public Property newNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal nwNombre As String)
            Nombre = nwNombre
        End Set
    End Property

    Public Property newDireccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal nwDireccion As String)
            Direccion = nwDireccion
        End Set
    End Property


    Public Property newGenero() As String
        Get
            Return Genero
        End Get
        Set(ByVal nwGenero As String)
            Genero = nwGenero
        End Set
    End Property


    Public Property newTelefono() As String
        Get
            Return Telefono
        End Get
        Set(ByVal nwTelefono As String)
            Telefono = nwTelefono
        End Set
    End Property

    Public Property newFecha_Nac() As Date
        Get
            Return Fecha_Nac
        End Get
        Set(ByVal nwFecha_Nac As Date)
            Fecha_Nac = nwFecha_Nac
        End Set
    End Property


#End Region

#Region "Constructores"
    'constructor con todos los atributos
    Public Sub New(ByVal pid_Miembro As Integer, _
                    ByVal pNum_Miembro As String, _
                    ByVal pLocalizacion_Foto As String, _
                    ByVal pid_Organizacion As Integer, _
                   ByVal pNombre As String, _
                   ByVal pDireccion As String, _
                   ByVal pTelefono As String, _
       ByVal pGenero As String, _
       ByVal pFecha_Nac As Date)

        Me.newId_Miembro = pid_Miembro
        Me.newNum_Miembro = pNum_Miembro
        Me.newLocalizacion_Foto = pLocalizacion_Foto
        Me.newid_Organizacion = pid_Organizacion
        Me.newNombre = pNombre
        Me.newDireccion = pDireccion
        Me.newTelefono = pTelefono
        Me.newGenero = pGenero
        Me.newFecha_Nac = pFecha_Nac


    End Sub
    'Constructor con un atributo
    Public Sub New(ByVal pid_Miembro As Integer)
        Me.newId_Miembro = pid_Miembro

    End Sub

    Public Sub New(ByVal pid_Organizacion As Integer, ByVal val As Integer)
        Me.newid_Organizacion = pid_Organizacion
    End Sub

    Public Sub New(ByVal pNum_miembro As String, ByVal pNombre As String)
        Me.newNum_Miembro = pNum_miembro
        Me.newNombre = pNombre
    End Sub


    'Constructor con un atributo
    Public Sub New(ByVal pNum_Miembro As String)
        Me.newNum_Miembro = pNum_Miembro

    End Sub

   
    'Constructor vacio
    Public Sub New()

    End Sub
#End Region

#Region "Metodos"
    'Funcion Insertar

    Public Function insertar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentensia
        SQL = "INSERT INTO TB_Miembro VALUES ( '" & _
        Me.newId_Miembro & "','" & Me.newNum_Miembro _
        & "','" & Me.newLocalizacion_Foto & "','" & Me.newid_Organizacion _
        & "','" & Me.newNombre & "','" & Me.newDireccion & "','" & Me.newTelefono & "','" & Me.newGenero & "','" & Me.newFecha_Nac & "')"

        Return myConexion.modificadorDatos(SQL)
    End Function

    ' Funcion Modificar

    Public Function modificar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "UPDATE TB_Miembro SET NUM_MIEMBRO = '" _
        & Me.newNum_Miembro & "',ID_FOTO = '" _
        & Me.newLocalizacion_Foto & "',ID_ORGANIZACION = '" & Me.newid_Organizacion _
        & "',NOMBRE = '" & Me.newNombre _
        & "',DIRRECION = '" & Me.newDireccion _
        & "',TELEFONO = '" & Me.newTelefono _
        & "',GENERO = '" & Me.newGenero _
        & "',FECHA_NAC = '" & Me.newFecha_Nac _
        & "'WHERE ID_MIEMBRO = '" & Me.newId_Miembro & "'"

        Return myConexion.modificadorDatos(SQL)

    End Function

    ' Funcion Eliminar

    Public Function eliminar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "DELETE TB_MIEMBRO WHERE ID_MIEMBRO = " & Me.newId_Miembro & ""

        Return myConexion.modificadorDatos(SQL)
    End Function
    'Funcion Consultar
    Public Function Consultar() As cls_Miembro
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim myMiembro As New cls_Miembro
        Dim bandera As Boolean = False
        Dim i As Integer
        'Sentensia
        SQL = "SELECT * FROM TB_MIEMBRO WHERE ID_MIEMBRO =" & newId_Miembro & " ORDER BY NOMBRE"

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = True

            myMiembro = New cls_Miembro(myDataset.Tables(0).Rows(i).Item(0), myDataset.Tables(0).Rows(i).Item(1), myDataset.Tables(0).Rows(i).Item(2), myDataset.Tables(0).Rows(i).Item(3), myDataset.Tables(0).Rows(i).Item(4), myDataset.Tables(0).Rows(i).Item(5), myDataset.Tables(0).Rows(i).Item(6), myDataset.Tables(0).Rows(i).Item(7), myDataset.Tables(0).Rows(i).Item(8))

        Next
        If (bandera = False) Then
            myMiembro = Nothing

        End If
        Return myMiembro

    End Function
    'Funcion Consultas
    Public Function Consultas() As cls_Miembro()
        'Declaracion
        Dim bandera As Boolean = True
        Dim pWhere As Boolean = False
        Dim conecta As New Cls_Conexion
        Dim myDataset As New DataSet
        Dim SQL As String
        Dim row As Integer
        Dim i As Integer
        'Sentencia
        SQL = "SELECT count(ID_MIEMBRO) from TB_MIEMBRO "

        myDataset = conecta.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            row = myDataset.Tables(0).Rows(i).Item(0)
        Next

        Dim myMiembro(row) As cls_Miembro

        SQL = "SELECT * FROM TB_MIEMBRO "

        If (newNombre = "Nada") Then
            pWhere = True
            SQL &= " ORDER BY ID_MIEMBRO"
        End If



        If (newNombre <> "vacio") Then
            If (pWhere) Then
                SQL &= " OR NOMBRE LIKE '%" & newNombre & "%'"
            Else
                SQL &= " WHERE NOMBRE LIKE '%" & newNombre & "%'"
            End If
        End If

        If (newNum_Miembro <> Nothing) Then
            If (pWhere) Then
                SQL &= " OR NUM_MIEMBRO LIKE '%" & newNum_Miembro & "%'"
            Else
                SQL = " SELECT * FROM TB_MIEMBRO WHERE  NUM_MIEMBRO LIKE '%" & newNum_Miembro & "%'"
            End If
        End If

        If (newid_Organizacion <> Nothing) Then
            If (pWhere) Then
                SQL &= " OR ID_ORGANIZACION LIKE '%" & newid_Organizacion & "%'"
            Else
                SQL = " SELECT * FROM TB_MIEMBRO WHERE  ID_ORGANIZACION = " & newid_Organizacion & ""
            End If
        End If




        myDataset = conecta.accesoDatos(SQL)
        Dim c As Integer
        For c = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = False


            myMiembro(c) = New cls_Miembro(myDataset.Tables(0).Rows(c).Item(0), myDataset.Tables(0).Rows(c).Item(1), myDataset.Tables(0).Rows(c).Item(2), myDataset.Tables(0).Rows(c).Item(3), myDataset.Tables(0).Rows(c).Item(4), myDataset.Tables(0).Rows(c).Item(5), myDataset.Tables(0).Rows(c).Item(6), myDataset.Tables(0).Rows(c).Item(7), myDataset.Tables(0).Rows(c).Item(8))

        Next
        If (bandera) Then
            myMiembro = Nothing

        End If
        Return myMiembro

    End Function

    Public Function Consecutivo() As String
        Dim Conecta As New Cls_Conexion
        Dim SQL As String = "SELECT TOP 1 * from TB_MIEMBRO  order by ID_MIEMBRO desc"
        Return Conecta.consecutivo(SQL)
    End Function
#End Region


End Class
