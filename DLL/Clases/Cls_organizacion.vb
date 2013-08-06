Public Class Cls_organizacion

#Region "Atributos"

    Private Id_Org As Integer
    Private Nombre_org As String
    Private Imagen As String




#End Region

#Region "Propiedades"

    Public Property newId_Org() As Integer
        Get
            Return Id_Org
        End Get
        Set(ByVal nwId_Org As Integer)
            Id_Org = nwId_Org
        End Set
    End Property




    Public Property newNombre_org() As String
        Get
            Return Nombre_org
        End Get
        Set(ByVal nwNombre_org As String)
            Nombre_org = nwNombre_org
        End Set
    End Property

    Public Property newImagen() As String
        Get
            Return Imagen
        End Get
        Set(ByVal nwImagen As String)
            Imagen = nwImagen
        End Set
    End Property




#End Region

#Region "Constructores"
    'constructor con todos los atributos
    Public Sub New(ByVal pid_org As Integer, ByVal pNombre_org As String, ByVal pImagen As String)


        Me.newId_Org = pid_org
        Me.newNombre_org = pNombre_org
        Me.newImagen = pImagen



    End Sub

    'Constructor con un atributo
    Public Sub New(ByVal pid_org As Integer)
        Me.newId_Org = pid_org

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
        SQL = "INSERT INTO TB_ORGANIZACION VALUES ('" & Me.newId_Org _
        & "','" & Me.newNombre_org & "','" & Me.newImagen & "')"

        Return myConexion.modificadorDatos(SQL)
    End Function

    ' Funcion Modificar

    Public Function modificar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "UPDATE TB_ORGANIZACION SET NOMBRE_ORGANIZACION = '" _
        & Me.newNombre_org & "'WHERE ID_ORGANIZACION = '" & Me.newId_Org & " '"

        Return myConexion.modificadorDatos(SQL)

    End Function

    ' Funcion Eliminar

    Public Function eliminar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "DELETE TB_ORGANIZACION WHERE ID_ORGANIZACION = '" & Me.newId_Org & "'"

        Return myConexion.modificadorDatos(SQL)
    End Function
    'Funcion Consultar
    Public Function Consultar() As Cls_organizacion
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim myOrganizacion As New Cls_organizacion
        Dim bandera As Boolean = False
        Dim i As Integer
        'Sentensia
        SQL = "SELECT * FROM TB_ORGANIZACION WHERE ID_ORGANIZACION ='" & newId_Org & "' ORDER BY ID_ORGANIZACION"

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = True

            myOrganizacion = New Cls_organizacion(myDataset.Tables(0).Rows(i).Item(0), myDataset.Tables(0).Rows(i).Item(1), myDataset.Tables(0).Rows(i).Item(2))

        Next
        If (bandera = False) Then
            myOrganizacion = Nothing

        End If
        Return myOrganizacion

    End Function
    Public Function consultaImagen() As Cls_organizacion()
        Dim myConexion As New Cls_Conexion
        Dim myDataset As DataSet
        Dim SQL As String = "SELECT * From TB_ORGANIZACION WHERE ID_ORGANIZACION = '" & newId_Org & "' ORDER BY ID_ORGANIZACION"
        Dim row As Integer
        Dim i As Integer

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            row = myDataset.Tables(0).Rows(i).Item(0)
        Next

        Dim myorganizacion(row) As Cls_organizacion


        myDataset = myConexion.accesoDatos(SQL)
        Dim c As Integer
        For c = 0 To myDataset.Tables(0).Rows.Count - 1

            myorganizacion(c) = New Cls_organizacion(myDataset.Tables(0).Rows(c).Item(0), myDataset.Tables(0).Rows(c).Item(1), myDataset.Tables(0).Rows(c).Item(2))

        Next
        Return myorganizacion
    End Function

    Public Function Consecutivo() As String
        Dim Conecta As New Cls_Conexion
        Dim SQL As String = "SELECT TOP 1 * from TB_ORGANIZACION  order by ID_ORGANIZACION desc"
        Return Conecta.consecutivo(SQL)
    End Function


#End Region
End Class



