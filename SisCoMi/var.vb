Imports System.Configuration
Module var

    Public id_user As Integer
    Public permit As String
    Public ConexionString = ConfigurationManager.ConnectionStrings("SisCoMi.My.MySettings.MyConexion").ConnectionString

End Module
