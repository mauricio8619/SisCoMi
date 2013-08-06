
Public Class cls_Bitacora
#Region "ATRIBUTOS"

    Private id_bitacora As Integer
    Private accion As String
    Private fecha As Date
    Private id_usuario As Cls_Usuario

#End Region

#Region "CONSTRUCTORES"

    Public Sub New(ByVal pid_bitacora As String, ByVal pid_usuario As Cls_Usuario, ByVal pfecha As Date, ByVal paccion As String)
        Me.newid_bitacora = pid_bitacora
        Me.newaccion = paccion
        Me.newfecha = pfecha
        Me.newid_usuario = pid_usuario

    End Sub
    Public Sub New(Optional ByVal pid_bitacora As Integer = 0, Optional ByVal pfecha As Date = Nothing)
        Me.newid_bitacora = pid_bitacora
        Me.newfecha = pfecha

    End Sub


#End Region

#Region "PROPIEDADES DE LOS ATRIBUTOS"

    Public Property newid_bitacora() As Integer
        Get
            Return id_bitacora
        End Get
        Set(ByVal nwid_bitacora As Integer)
            id_bitacora = nwid_bitacora
        End Set
    End Property
    Public Property newaccion() As String
        Get
            Return accion
        End Get
        Set(ByVal nwaccion As String)
            accion = nwaccion
        End Set
    End Property

    Public Property newfecha() As Date
        Get
            Return fecha
        End Get
        Set(ByVal nwfecha As Date)
            fecha = nwfecha
        End Set
    End Property
    Public Property newid_usuario() As Cls_Usuario
        Get
            Return id_usuario
        End Get
        Set(ByVal nwid_usuario As Cls_Usuario)
            id_usuario = nwid_usuario
        End Set
    End Property

#End Region

#Region "METODOS"
    'METODOS
    Public Function agregar() As Boolean

        Dim miConexion As New Cls_Conexion

        Dim SQL As String

        SQL = "INSERT INTO TB_BITACORA VALUES ( '" & Me.newid_bitacora & "','" & Me.newid_usuario.newUsername & "',getdate(),'" & Me.newaccion & "')"

        Return miConexion.modificadorDatos(SQL)

    End Function

    Public Function Consultar() As cls_Bitacora

        Dim miConexion As New Cls_Conexion
        Dim SQL As String
        Dim myDataset As DataSet
        Dim mibitacora As New cls_Bitacora
        Dim bandera As Boolean = False
        Dim i As Integer
        Try

       
            SQL = "SELECT ID_CAMBIO  FROM TB_BITACORA WHERE ID_CAMBIO='" & newid_bitacora & "' ORDER BY FECHA_CAMBIO"

            myDataset = miConexion.accesoDatos(SQL)
            For i = 0 To myDataset.Tables(0).Rows.Count - 1
                bandera = True


                Dim miusuario As New Cls_Usuario(myDataset.Tables(0).Rows(i).Item(1))

                mibitacora = New cls_Bitacora(myDataset.Tables(0).Rows(i).Item(0), miusuario, myDataset.Tables(0).Rows(i).Item(2), myDataset.Tables(0).Rows(i).Item(3))

            Next
            If (bandera = False) Then
                mibitacora = Nothing

            End If
            Return mibitacora
        Catch ex As Exception
            Return mibitacora
        End Try
    End Function
    Public Function Consultas() As cls_Bitacora()

        Dim bandera As Boolean = True
        Dim pWhere As Boolean = False

        Dim conecta As New Cls_Conexion
        Dim myDataset As New DataSet
        Dim SQL As String
        Dim row As Integer
        Dim i As Integer

        SQL = "SELECT count(ID_CAMBIO) from TB_BITACORA"

        myDataset = conecta.accesoDatos(SQL)
        For i = 0 To myDataset.Tables(0).Rows.Count - 1
            row = myDataset.Tables(0).Rows(i).Item(0)
        Next

        Dim mibitacora(row) As cls_Bitacora

        SQL = "SELECT * FROM TB_BITACORA"

        If (newid_bitacora <> 0) Then
            pWhere = True
            SQL &= " Where ID_USUARIO like '%" & newid_bitacora & "%' "

        End If
        If (newfecha <> Nothing) Then
            If (pWhere) Then
                SQL &= " OR FECHA_CAMBIO LIKE '%" & newfecha & "%' "
            Else
                Dim fecha1 As Date = newfecha.AddDays(1.0)

                SQL &= " WHERE FECHA_CAMBIO BETWEEN  '" & newfecha & "'and '" & fecha1 & "' "
            End If
        End If


        myDataset = conecta.accesoDatos(SQL)
        Dim c As Integer
        For c = 0 To myDataset.Tables(0).Rows.Count - 1
            bandera = False

            Dim us As Integer
            us = myDataset.Tables(0).Rows(c).Item(1)
            Dim miusuario = New Cls_Usuario(us)


            mibitacora(c) = New cls_Bitacora(myDataset.Tables(0).Rows(c).Item(0), miusuario, myDataset.Tables(0).Rows(c).Item(2), myDataset.Tables(0).Rows(c).Item(3))
        Next
        If (bandera) Then
            mibitacora = Nothing

        End If
        Return mibitacora

    End Function

    'Funcion Consecutivo
    Public Function Consecutivo() As String
        Dim Conecta As New Cls_Conexion
        Dim SQL As String = "SELECT count(ID_CAMBIO) from TB_BITACORA "
        Return Conecta.consecutivo(SQL)
    End Function

#End Region

End Class
