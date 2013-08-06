Public Class Cls_Datos



#Region "Atributos"

    Private Num_Miembro As String
    Private Fecha_Baut As Date
    Private Fecha_Conf As Date
    Private Fecha_Sell As Date
    Private Fecha_Inv As Date
    Private Llamamiento_Act As String
    Private Comentarios As String
  

#End Region

#Region "Propiedades"

    Public Property newNum_Miembro() As String
        Get
            Return Num_Miembro
        End Get
        Set(ByVal nwNum_Miembro As String)
            Num_Miembro = nwNum_Miembro
        End Set
    End Property
    Public Property newFecha_Baut() As Date
        Get
            Return Fecha_Baut
        End Get
        Set(ByVal nwFecha_Baut As Date)
            Fecha_Baut = nwFecha_Baut
        End Set
    End Property

    Public Property newFecha_Conf() As Date
        Get
            Return Fecha_Conf
        End Get
        Set(ByVal nwFecha_Conf As Date)
            Fecha_Conf = nwFecha_Conf
        End Set
    End Property

    Public Property newFecha_Sell() As Date
        Get
            Return Fecha_Sell
        End Get
        Set(ByVal nwFecha_Sell As Date)
            Fecha_Sell = nwFecha_Sell
        End Set
    End Property

    Public Property newFecha_Inv() As Date
        Get
            Return Fecha_Inv
        End Get
        Set(ByVal nwFecha_Inv As Date)
            Fecha_Inv = nwFecha_Inv
        End Set
    End Property


    Public Property newLlamamiento_Act() As String
        Get
            Return Llamamiento_Act
        End Get
        Set(ByVal nwLlamamiento_Act As String)
            Llamamiento_Act = nwLlamamiento_Act
        End Set
    End Property


    Public Property newComentarios() As String
        Get
            Return Comentarios
        End Get
        Set(ByVal nwComentarios As String)
            Comentarios = nwComentarios
        End Set
    End Property

   


#End Region

#Region "Constructores"
    'constructor con todos los atributos
    Public Sub New(ByVal pNum_Miembro As String, _
                    ByVal pFecha_Baut As Date, _
                    ByVal pFecha_Conf As Date, _
                    ByVal pFecha_Sell As Date, _
                    ByVal pFecha_Inv As Date, _
                    ByVal pLlamamiento_Act As String, _
                    ByVal pComentario As String)


        Me.newNum_Miembro = pNum_Miembro
        Me.newFecha_Baut = pFecha_Baut
        Me.newFecha_Conf = pFecha_Conf
        Me.newFecha_Sell = pFecha_Sell
        Me.newFecha_Inv = pFecha_Inv
        Me.newLlamamiento_Act = pLlamamiento_Act
        Me.newComentarios = pComentario


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
        SQL = "INSERT INTO TB_DATOS VALUES ('" & Me.newNum_Miembro _
        & "','" & Me.newFecha_Baut & "','" & Me.newFecha_Conf _
        & "','" & Me.newFecha_Sell & "','" & Me.newFecha_Inv & "','" & Me.newLlamamiento_Act & "','" & Me.newComentarios & "')"

        Return myConexion.modificadorDatos(SQL)
    End Function

    ' Funcion Modificar

    Public Function modificar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "UPDATE TB_DATOS SET FECHA_BAUT = '" _
        & Me.newFecha_Baut & "',FECHA_CONF = '" _
        & Me.newFecha_Conf & "',FECHA_SELL = '" & Me.newFecha_Sell _
        & "',FECHA_INV = '" & Me.newFecha_Inv _
        & "',LLAMAMIENTO_ACT = '" & Me.newLlamamiento_Act _
        & "',COMENTARIOS = '" & Me.newComentarios _
        & "'WHERE NUM_MIEMBRO = '" & Me.newNum_Miembro & " '"

        Return myConexion.modificadorDatos(SQL)

    End Function

    ' Funcion Eliminar

    Public Function eliminar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "DELETE TB_DATOS WHERE NUM_MIEMBRO = '" & Me.newNum_Miembro & "'"

        Return myConexion.modificadorDatos(SQL)
    End Function
    'Funcion Consultar
    Public Function Consultar() As Cls_Datos
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim myDatos As New Cls_Datos
        Dim bandera As Boolean = False
        Dim i As Integer
        'Sentensia
        SQL = "SELECT * FROM TB_DATOS WHERE NUM_MIEMBRO ='" & newNum_Miembro & "' ORDER BY FECHA_BAUT"

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = True

            myDatos = New Cls_Datos(myDataset.Tables(0).Rows(i).Item(0), myDataset.Tables(0).Rows(i).Item(1), myDataset.Tables(0).Rows(i).Item(2), myDataset.Tables(0).Rows(i).Item(3), myDataset.Tables(0).Rows(i).Item(4), myDataset.Tables(0).Rows(i).Item(5), myDataset.Tables(0).Rows(i).Item(6))

        Next
        If (bandera = False) Then
            myDatos = Nothing

        End If
        Return myDatos

    End Function
    'Funcion Consultas
    Public Function Consultas() As Cls_Datos()
        'Declaracion
        Dim bandera As Boolean = True
        Dim pWhere As Boolean = False
        Dim conecta As New Cls_Conexion
        Dim myDataset As New DataSet
        Dim SQL As String
        Dim row As Integer
        Dim i As Integer
        'Sentencia
        SQL = "SELECT count(NUM_MIEMBRO) from TB_DATOS "

        myDataset = conecta.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            row = myDataset.Tables(0).Rows(i).Item(0)
        Next

        Dim myDatos(row) As Cls_Datos

        SQL = "SELECT * FROM TB_DATOS "

        If (newNum_Miembro = "Nada") Then
            pWhere = True
            SQL &= " ORDER BY NUM_MIEMBRO "
        End If



        

        If (newNum_Miembro <> Nothing) Then
            If (pWhere) Then
                SQL &= " OR NUM_MIEMBRO LIKE '%" & newNum_Miembro & "%'"
            Else
                SQL = " SELECT * FROM TB_Datos WHERE  NUM_MIEMBRO = '" & newNum_Miembro & "' "
            End If
        End If




        myDataset = conecta.accesoDatos(SQL)
        Dim c As Integer
        For c = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = False


            myDatos(c) = New Cls_Datos(myDataset.Tables(0).Rows(c).Item(0), myDataset.Tables(0).Rows(c).Item(1), myDataset.Tables(0).Rows(c).Item(2), myDataset.Tables(0).Rows(c).Item(3), myDataset.Tables(0).Rows(c).Item(4), myDataset.Tables(0).Rows(c).Item(5), myDataset.Tables(0).Rows(c).Item(6))

        Next
        If (bandera) Then
            myDatos = Nothing

        End If
        Return myDatos

    End Function

    'Public Function Consultas1() As Cls_Cliente()
    '    'Declaracion
    '    Dim bandera As Boolean = True
    '    Dim pWhere As Boolean = False
    '    Dim conecta As New Cls_Conexion
    '    Dim myDataset As New DataSet
    '    Dim SQL As String
    '    Dim row As Integer
    '    Dim i As Integer
    '    'Sentencia
    '    SQL = "SELECT count(ID_CLIENTE) from TB_CLIENTE "

    '    myDataset = conecta.accesoDatos(SQL)
    '    For i = 0 To myDataset.Tables(0).Rows.Count - 1
    '        row = myDataset.Tables(0).Rows(i).Item(0)
    '    Next

    '    Dim myCliente(row) As Cls_Cliente

    '    SQL = "SELECT * FROM TB_CLIENTE "

    '    If (newNombre = "Nada") Then
    '        pWhere = True
    '        SQL &= " ORDER BY ID_CLIENTE"
    '    End If




    '    If (newNombre <> "Nada") Then
    '        If (pWhere) Then
    '            SQL &= " OR ID_CLIENTE LIKE '%" & newNombre & "%'"
    '        Else
    '            SQL &= " WHERE  ID_CLIENTE LIKE '%" & newNombre & "%'"
    '        End If
    '    End If




    '    myDataset = conecta.accesoDatos(SQL)
    '    Dim c As Integer
    '    For c = 0 To myDataset.Tables(0).Rows.Count - 1
    '        bandera = False

    '        myCliente(c) = New Cls_Cliente(myDataset.Tables(0).Rows(c).Item(0), myDataset.Tables(0).Rows(c).Item(1), myDataset.Tables(0).Rows(c).Item(2), myDataset.Tables(0).Rows(c).Item(3), myDataset.Tables(0).Rows(c).Item(4), myDataset.Tables(0).Rows(c).Item(5))

    '    Next
    '    If (bandera) Then
    '        myCliente = Nothing

    '    End If
    '    Return myCliente

    'End Function

    'Funcion Consecutivo
   
#End Region

End Class
