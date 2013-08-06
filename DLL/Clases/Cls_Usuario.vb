Imports System.Security.Cryptography
Public Class Cls_Usuario
#Region "Atributos"
    Private id_Usuario As Integer
    Private Username As String
    Private Contraseña As String
    Private Tipo_usuario As String



#End Region

#Region "Propiedades"

    Public Property newid_Usuario() As Integer
        Get
            Return id_Usuario
        End Get
        Set(ByVal nwid_Usuario As Integer)
            id_Usuario = nwid_Usuario
        End Set
    End Property



    Public Property newUsername() As String
        Get
            Return Username
        End Get
        Set(ByVal nwUsername As String)
            Username = nwUsername
        End Set
    End Property

    Public Property newContraseña() As String
        Get
            Return Contraseña
        End Get
        Set(ByVal nwContraseña As String)
            Contraseña = nwContraseña
        End Set
    End Property


    Public Property newTipo_usuario() As String
        Get
            Return Tipo_usuario
        End Get
        Set(ByVal nwTipo_usuario As String)
            Tipo_usuario = nwTipo_usuario
        End Set
    End Property






#End Region

#Region "Constructores"
    'constructor con todos los atributos
    Public Sub New(ByVal pId_Usuario As Integer, _
                   ByVal pUsername As String, _
                   ByVal pContraseña As String, _
                   ByVal pTipo_Usuario As String)
        Me.newid_Usuario = pId_Usuario
        Me.newUsername = pUsername
        Me.newContraseña = pContraseña
        Me.newTipo_usuario = pTipo_Usuario




    End Sub



    Public Sub New(ByVal pUsername As String, ByVal pContraseña As String)
        Me.newUsername = pUsername
        Me.newContraseña = pContraseña

    End Sub

    Public Sub New(ByVal pUsername As String)
        Me.newUsername = pUsername
        'Me.newid_Usuario = pUsername

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
        SQL = "INSERT INTO TB_USUARIO VALUES ( '" & Me.newid_Usuario & "','" & Me.newUsername & "','" & MD5EncryptPass(Me.newContraseña) & "','" & Me.newTipo_usuario & "')"

        Return myConexion.modificadorDatos(SQL)
    End Function

    ' Funcion Modificar

    Public Function modificar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        If Me.newContraseña <> "" Then
            SQL = "UPDATE TB_USUARIO SET USERNAME= '" & Me.newUsername _
       & "',CONTRASENA = '" & MD5EncryptPass(Me.newContraseña) _
       & "',TIPO = '" & Me.newTipo_usuario _
               & "'WHERE ID_USUARIO = '" & Me.newid_Usuario & "'"
        Else
            SQL = "UPDATE TB_USUARIO SET USERNAME= '" & Me.newUsername _
                & "',TIPO = '" & Me.newTipo_usuario _
                & "'WHERE ID_USUARIO = '" & Me.newid_Usuario & "'"
        End If
        

        Return myConexion.modificadorDatos(SQL)

    End Function

    ' Funcion Eliminar

    Public Function eliminar() As Boolean
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        'Sentencia
        SQL = "UPDATE TB_USUARIO SET Activo = 0 WHERE ID_USUARIO = '" & Me.newid_Usuario & "'"

        Return myConexion.modificadorDatos(SQL)
    End Function
    'Funcion Consultar
    Public Function Consultar() As Cls_Usuario
        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim myUsuario As New Cls_Usuario
        Dim bandera As Boolean = False
        Dim i As Integer
        'Sentensia
        SQL = "SELECT * FROM TB_USUARIO WHERE ID_USUARIO ='" & newid_Usuario & "' ORDER BY ID_USUARIO"

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = True

            myUsuario = New Cls_Usuario(myDataset.Tables(0).Rows(i).Item(0), myDataset.Tables(0).Rows(i).Item(1), myDataset.Tables(0).Rows(i).Item(2), myDataset.Tables(0).Rows(i).Item(3))

        Next
        If (bandera = False) Then
            myUsuario = Nothing

        End If
        Return myUsuario

    End Function
    'Funcion Consultas
    Public Function Consultas() As Cls_Usuario()
        'Declaracion
        Dim bandera As Boolean = True
        Dim pWhere As Boolean = False
        Dim conecta As New Cls_Conexion
        Dim myDataset As New DataSet
        Dim SQL As String
        Dim row As Integer
        Dim i As Integer
        'Sentencia
        SQL = "SELECT count(ID_USUARIO) from TB_USUARIO "

        myDataset = conecta.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            row = myDataset.Tables(0).Rows(i).Item(0)
        Next

        Dim myUsuario(row) As Cls_Usuario

        SQL = "SELECT * FROM TB_USUARIO"

        If (newUsername = "") Then
            pWhere = True
            SQL &= " ORDER BY USERNAME"
        End If



        If (newUsername <> "") Then
            If (pWhere) Then
                SQL &= " OR Username LIKE '%" & newUsername & "%'"
            Else
                SQL &= " WHERE USERNAME LIKE '%" & newUsername & "%'"
            End If
        End If



        myDataset = conecta.accesoDatos(SQL)
        Dim c As Integer
        For c = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = False


            myUsuario(c) = New Cls_Usuario(myDataset.Tables(0).Rows(c).Item(0), myDataset.Tables(0).Rows(c).Item(1), myDataset.Tables(0).Rows(c).Item(2), myDataset.Tables(0).Rows(c).Item(3))



        Next
        If (bandera) Then
            myUsuario = Nothing

        End If
        Return myUsuario


    End Function

    'Funcion Consecutivo
    Public Function Consecutivo() As String
        Dim Conecta As New Cls_Conexion
        Dim SQL As String = "SELECT count(ID_USUARIO) from TB_USUARIO "
        Return Conecta.consecutivo(SQL)
    End Function


    Public Function Login() As Cls_Usuario

        'Declaracion
        Dim myConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim myUsuario As New Cls_Usuario
        Dim bandera As Boolean = False
        Dim i As Integer
        'Sentensia
        SQL = "SELECT * FROM TB_USUARIO WHERE USERNAME ='" & newUsername & "'and Contrasena ='" & MD5EncryptPass(newContraseña) & "' "

        myDataset = myConexion.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = True

            myUsuario = New Cls_Usuario(myDataset.Tables(0).Rows(i).Item(0), myDataset.Tables(0).Rows(i).Item(1))

        Next
        If (bandera = False) Then
            myUsuario = Nothing

        End If
        Return myUsuario

    End Function

    Private Function MD5EncryptPass(ByVal StrPass As String) As String
        Dim PasConMd5 As String = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return PasConMd5

    End Function

#End Region

End Class
