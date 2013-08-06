'importar librerias de sql
Imports System.Data.SqlClient
Imports System.Data
'declaracion de la clase
Public Class Cls_Conexion
    'ConexionString //no se como llamar de modulo var que es global
    Dim pathConexion As String = "Data source = MAURICIO-LAPTOP\SQLEXPRESS; " _
                                          & "Initial Catalog=SisCoMi; " _
                                          & "Integrated Security=true; " _
                                          & "User=sa; password=darling22"

    Friend BD As New OleDb.OleDbConnection
    Dim cnSQL As New SqlConnection
    Dim path As String
    Dim cmSQL As SqlCommand

    'creacion de la conexion

    Public Sub New()
        path = String.Format(pathConexion)


    End Sub
    'funcion para manipular datos
    Public Function modificadorDatos(ByVal pStr As String) As Boolean
        Dim bandera As Boolean = False

        Try
            cnSQL.ConnectionString = path

            cmSQL = New SqlCommand(pStr, cnSQL)

            If (cnSQL.State = ConnectionState.Closed) Then
                cnSQL.Open()
            End If
            cmSQL.ExecuteNonQuery()
            cnSQL.Close()
            bandera = True

        Catch ex As Exception
            bandera = False

            MsgBox("Error de SQL " + ex.Message)

        End Try
        Return bandera

    End Function



    'funcion para accesar a datos

    Public Function accesoDatos(ByVal pStr As String) As DataSet

        Try
            cnSQL.ConnectionString = path
            If (cnSQL.State = ConnectionState.Closed) Then
                cnSQL.Open()
            End If

            cmSQL = New SqlCommand(pStr, cnSQL)
            Dim myAdapter As New SqlDataAdapter
            myAdapter.SelectCommand = cmSQL

            Dim myDataset As New DataSet
            myAdapter.Fill(myDataset)

            cmSQL.ExecuteNonQuery()
            cmSQL.Dispose()
            cnSQL.Dispose()

            Return myDataset



        Catch ex As Exception

            Return Nothing

        End Try


    End Function


    'funcion con el string de conexion
    Public Function cadena() As String
        Return String.Format(pathConexion)
    End Function

    Public Function consecutivo(ByVal Proc As String) As Integer
        Try
            Dim cnSQL As New SqlConnection
            Dim cmSQL As New SqlCommand
            Dim SQL As String

            SQL = Proc
            cmSQL.CommandType = CommandType.StoredProcedure
            cnSQL.ConnectionString = Me.cadena
            cmSQL = New SqlCommand(SQL, cnSQL)

            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = cmSQL
            Dim myDataset As DataSet = New DataSet
            myAdapter.Fill(myDataset)
            If myDataset.Tables(0).Rows.Count > 0 Then
                Return myDataset.Tables(0).Rows(0).Item(0)
            Else
                Return Nothing
            End If

        Catch er As SqlException
            Return Nothing
        End Try
    End Function

    Public Function Vistas(ByVal Vista As String) As Integer
        Try
            Dim cnSQL As New SqlConnection
            Dim cmSQL As New SqlCommand
            Dim SQL As String

            SQL = Vista
            cmSQL.CommandType = CommandType.StoredProcedure
            cnSQL.ConnectionString = Me.cadena
            cmSQL = New SqlCommand(SQL, cnSQL)

            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = cmSQL
            Dim myDataset As DataSet = New DataSet
            myAdapter.Fill(myDataset)
            If myDataset.Tables(0).Rows.Count > 0 Then
                Return myDataset.Tables(0).Rows(0).Item(0)
            Else
                Return Nothing
            End If

        Catch er As SqlException
            Return Nothing
        End Try
    End Function
End Class



