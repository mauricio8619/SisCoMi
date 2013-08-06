Public Class Cls_Foto
#Region "Atributos"

    Private Id_foto As Integer
    Private Localizacion As String




#End Region

#Region "Propiedades"

    Public Property newId_foto() As Integer
        Get
            Return Id_foto
        End Get
        Set(ByVal nwId_foto As Integer)
            Id_foto = nwId_foto
        End Set
    End Property
 



    Public Property newLocalizacion() As String
        Get
            Return Localizacion
        End Get
        Set(ByVal nwLocalizacion As String)
            Localizacion = nwLocalizacion
        End Set
    End Property




#End Region

#Region "Constructores"
    'constructor con todos los atributos
    Public Sub New(ByVal pid_foto As Integer, _
                    ByVal pLocalizacion As String)


        Me.newId_foto = pid_foto
        Me.newLocalizacion = pLocalizacion
       


    End Sub

    'Constructor con un atributo
    Public Sub New(ByVal pid_foto As Integer)
        Me.newId_foto = pid_foto

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
        SQL = "INSERT INTO TB_FOTO VALUES ('" & Me.newId_foto _
        & "','" & Me.newLocalizacion & "')"

        Return myConexion.modificadorDatos(SQL)
    End Function

    ' Funcion Modificar

    Public Function modificar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "UPDATE TB_FOTO SET LOCALIZACION = '" _
        & Me.newLocalizacion & "'WHERE ID_FOTO = '" & Me.newId_foto & " '"

        Return myConexion.modificadorDatos(SQL)

    End Function

    ' Funcion Eliminar

    Public Function eliminar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "DELETE TB_FOTO WHERE ID_FOTO = " & Me.newId_foto & ""

        Return myConexion.modificadorDatos(SQL)
    End Function
    'Funcion Consultar
    Public Function Consultar() As Cls_Foto
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim myFoto As New Cls_Foto
        Dim bandera As Boolean = False
        Dim i As Integer
        'Sentensia
        SQL = "SELECT * FROM TB_FOTO WHERE ID_FOTO =" & newId_foto & " ORDER BY ID_FOTO"

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = True

            myFoto = New Cls_Foto(myDataset.Tables(0).Rows(i).Item(0), myDataset.Tables(0).Rows(i).Item(1))

        Next
        If (bandera = False) Then
            myFoto = Nothing

        End If
        Return myFoto

    End Function
  

#End Region

    'Funcion Consultas
    Public Function Consultas() As Cls_Foto()
        'Declaracion
        Dim bandera As Boolean = True
        Dim pWhere As Boolean = False
        Dim conecta As New Cls_Conexion
        Dim myDataset As New DataSet
        Dim SQL As String
        Dim row As Integer
        Dim i As Integer
        'Sentencia
        SQL = "SELECT count(ID_FOTO) from TB_FOTO "

        myDataset = conecta.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            row = myDataset.Tables(0).Rows(i).Item(0)
        Next

        Dim myfotos(row) As Cls_Foto

        SQL = "SELECT * FROM TB_FOTO "

        If (newId_foto = 0) Then
            pWhere = True
            SQL &= " ORDER BY ID_FOTO "
        End If





        If (newId_foto <> Nothing) Then
            If (pWhere) Then
                SQL &= " OR ID_FOTO LIKE '%" & newId_foto & "%'"
            Else
                SQL = " SELECT * FROM TB_FOTO WHERE  ID_FOTO = " & newId_foto & " "
            End If
        End If




        myDataset = conecta.accesoDatos(SQL)
        Dim c As Integer
        For c = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = False


            myfotos(c) = New Cls_Foto(myDataset.Tables(0).Rows(c).Item(0), myDataset.Tables(0).Rows(c).Item(1))

        Next
        If (bandera) Then
            myfotos = Nothing

        End If
        Return myfotos

    End Function
End Class
