Public Class cls_Gestor
    'Atributos
    Private myUsuario As New Cls_Usuario
    Private myBitacora As New cls_Bitacora
    Private myMiembro As New cls_Miembro
    Private myDatos As New Cls_Datos
    Private myFoto As New Cls_Foto
    Private myOrganizacion As New Cls_organizacion


    'Constructor vacio
    Public Sub New()
    End Sub


#Region "Usuario"

    'Funcion insertar
    Public Function InsertarUsuario(ByVal iid_Usuario As Integer, ByVal iUsername As String, ByVal iContraseña As String, ByVal iTipo_Usuario As String) As Boolean
        'Crea un objeto con todos los atributos
        myUsuario = New Cls_Usuario(iid_Usuario, iUsername, iContraseña, iTipo_Usuario)

        If myUsuario.Consultar() Is Nothing Then
            Return myUsuario.insertar()
        Else
            Return False
        End If

    End Function
    Public Function ModificarUsuario(ByVal iid_Usuario As Integer, ByVal iUsername As String, ByVal iContraseña As String, ByVal iTipo_Usuario As String) As Boolean
        'Crea un objeto con todos los atributos
        myUsuario = New Cls_Usuario(iid_Usuario, iUsername, iContraseña, iTipo_Usuario)


        If myUsuario.Consultar() IsNot Nothing Then
            Return myUsuario.modificar()
        Else
            Return False
        End If

    End Function
    Public Function EliminarUsuario(ByVal iid_Usuario As Integer, ByVal iUsername As String, ByVal iContraseña As String, ByVal iTipo_Usuario As String) As Boolean
        'Crea un objeto con todos los atributos
        myUsuario = New Cls_Usuario(iid_Usuario, iUsername, iContraseña, iTipo_Usuario)
        If myUsuario.Consultar() IsNot Nothing Then
            Return myUsuario.eliminar()
        Else
            Return False
        End If

    End Function
    Public Function ConsultarUsuario(ByVal iid_Usuario As String) As Cls_Usuario
        myUsuario = New Cls_Usuario(iid_Usuario)
        Return myUsuario.Consultar

    End Function

    Public Function ConsultasUsuario(Optional ByVal iUsername As String = "") As Cls_Usuario()
        myUsuario = New Cls_Usuario(iUsername)
        If myUsuario.Consultas() IsNot Nothing Then
            Return myUsuario.Consultas()
        Else

            myUsuario = New Cls_Usuario("")
            Return myUsuario.Consultas()
        End If

    End Function

    Public Function ConsecutivoUsuario() As String
        myUsuario = New Cls_Usuario()
        Return myUsuario.Consecutivo() + 1
    End Function

    Public Function ValidarUsuarios(Optional ByVal iid_usuario As String = "Nada", Optional ByVal iclave As String = "Nada") As Boolean
        myUsuario = New Cls_Usuario(iid_usuario, iclave)
        If myUsuario.Login() IsNot Nothing Then
            Return True
        Else


            Return False
        End If


    End Function


#End Region

#Region "Miembro"

    'Funcion insertar
    Public Function InsertarMiembro(ByVal iid_Miembro As Integer, ByVal iNum_miembro As String, ByVal iLocalizacion_Foto As String, ByVal iId_Organizacion As String, ByVal iNombre As String, ByVal iDirreccion As String, ByVal iTelefono As String, ByVal iGenero As String, ByVal iFecha_nac As Date) As Boolean
        'Crea un objeto con todos los atributos
        myMiembro = New cls_Miembro(iid_Miembro, iNum_miembro, iLocalizacion_Foto, iId_Organizacion, iNombre, iDirreccion, iTelefono, iGenero, iFecha_nac)

        If myMiembro.Consultar() Is Nothing Then
            Return myMiembro.insertar()
        Else
            Return False
        End If

    End Function
    Public Function ModificarMiembro(ByVal iid_Miembro As Integer, ByVal iNum_miembro As String, ByVal iLocalizacion_Foto As String, ByVal iId_Organizacion As String, ByVal iNombre As String, ByVal iDirreccion As String, ByVal iTelefono As String, ByVal iGenero As String, ByVal iFecha_nac As Date) As Boolean
        'Crea un objeto con todos los atributos
        myMiembro = New cls_Miembro(iid_Miembro, iNum_miembro, iLocalizacion_Foto, iId_Organizacion, iNombre, iDirreccion, iTelefono, iGenero, iFecha_nac)


        If myMiembro.Consultar() IsNot Nothing Then
            Return myMiembro.modificar()
        Else
            Return False
        End If

    End Function
    Public Function EliminarMiembro(ByVal iid_Miembro As Integer) As Boolean
        'Crea un objeto con todos los atributos
        myMiembro = New cls_Miembro(iid_Miembro)

        If myMiembro.Consultar() IsNot Nothing Then
            Return myMiembro.eliminar()
        Else
            Return False
        End If

    End Function
    Public Function ConsultarMiembro(ByVal iid_Miembro As String) As cls_Miembro
        myMiembro = New cls_Miembro(iid_Miembro)
        Return myMiembro.Consultar

    End Function

    Public Function ConsultasMiembro(Optional ByVal iNum_miembro As String = "vacio", Optional ByVal iNombre As String = "vacio") As cls_Miembro()
        myMiembro = New cls_Miembro(iNum_miembro, iNombre)
        Return myMiembro.Consultas()


    End Function

    Public Function ConsecutivoMiembro() As String
        myMiembro = New cls_Miembro()
        Return myMiembro.Consecutivo() + 1
    End Function

  


#End Region

#Region "Datos"

    'Funcion insertar
    Public Function InsertarDatos(ByVal iNum_miembro As String, ByVal ifecha_Baut As Date, ByVal ifecha_Conf As Date, ByVal ifecha_Sell As Date, ByVal ifecha_Inv As Date, ByVal iLLamamiento_Act As String, ByVal iComentarios As String) As Boolean
        'Crea un objeto con todos los atributos
        myDatos = New Cls_Datos(iNum_miembro, ifecha_Baut, ifecha_Conf, ifecha_Sell, ifecha_Inv, iLLamamiento_Act, iComentarios)

        If myDatos.Consultar() Is Nothing Then
            Return myDatos.insertar()
        Else
            Return False
        End If

    End Function
    Public Function ModificarDatos(ByVal iNum_miembro As String, ByVal ifecha_Baut As Date, ByVal ifecha_Conf As Date, ByVal ifecha_Sell As Date, ByVal ifecha_Inv As Date, ByVal iLLamamiento_Act As String, ByVal iComentarios As String) As Boolean
        'Crea un objeto con todos los atributos
        myDatos = New Cls_Datos(iNum_miembro, ifecha_Baut, ifecha_Conf, ifecha_Sell, ifecha_Inv, iLLamamiento_Act, iComentarios)


        If myDatos.Consultar() IsNot Nothing Then
            Return myDatos.modificar()
        Else
            Return False
        End If

    End Function
    Public Function EliminarDatos(ByVal iNum_miembro As String, ByVal ifecha_Baut As Date, ByVal ifecha_Conf As Date, ByVal ifecha_Sell As Date, ByVal ifecha_Inv As Date, ByVal iLLamamiento_Act As String, ByVal iComentarios As String) As Boolean
        'Crea un objeto con todos los atributos
        myDatos = New Cls_Datos(iNum_Miembro, ifecha_Baut, ifecha_Conf, ifecha_Sell, ifecha_Inv, iLLamamiento_Act, iComentarios)
        If myDatos.Consultar() IsNot Nothing Then
            Return myDatos.eliminar()
        Else
            Return False
        End If

    End Function
    Public Function ConsultarDatos(ByVal iNum_Miembro As String) As Cls_Datos
        myDatos = New Cls_Datos(iNum_Miembro)
        Return myDatos.Consultar

    End Function

    Public Function ConsultasDatos(Optional ByVal iNum_miembro As String = "") As Cls_Datos()
        myDatos = New Cls_Datos(iNum_miembro)
        If myDatos.Consultas() IsNot Nothing Then
            Return myDatos.Consultas()
        Else

            myDatos = New Cls_Datos("")
            Return myDatos.Consultas()
        End If

    End Function
#End Region

#Region "Foto"

    'Funcion insertar
    Public Function InsertarFoto(ByVal iId_foto As Integer, ByVal iLocalizacion As String) As Boolean
        'Crea un objeto con todos los atributos
        myFoto = New Cls_Foto(iId_foto, iLocalizacion)

        If myFoto.Consultar() Is Nothing Then
            Return myFoto.insertar()
        Else
            Return False
        End If

    End Function
    Public Function ModificarFoto(ByVal iId_foto As Integer, ByVal iLocalizacion As String) As Boolean      'Crea un objeto con todos los atributos
        myFoto = New Cls_Foto(iId_foto, iLocalizacion)

        If myFoto.Consultar() IsNot Nothing Then
            Return myFoto.modificar()
        Else
            Return False
        End If

    End Function
    Public Function EliminarFoto(ByVal iId_foto As Integer) As Boolean
        'Crea un objeto con todos los atributos
        myFoto = New Cls_Foto(iId_foto)
        If myFoto.Consultar() IsNot Nothing Then
            Return myFoto.eliminar()
        Else
            Return False
        End If

    End Function
    Public Function ConsultarFoto(ByVal iId_foto As Integer) As Cls_Datos
        myFoto = New Cls_Foto(iId_foto)
        Return myDatos.Consultar

    End Function

    Public Function Consultasfoto(Optional ByVal iId_miembro As Integer = 0) As Cls_Foto()
        myFoto = New Cls_Foto(iId_miembro)
        If myFoto.Consultas() IsNot Nothing Then
            Return myFoto.Consultas()
        Else

            myFoto = New Cls_Foto("")
            Return myFoto.Consultas()
        End If

    End Function
#End Region




#Region "bitacora"
    Public Function agregarbitacora(ByVal iid_bitacora As Integer, ByVal iusuario As Integer, ByVal ifecha As Date, ByVal iaccion As String) As Boolean

        myUsuario = New Cls_Usuario(iusuario)


        MyBitacora = New cls_Bitacora(iid_bitacora, myUsuario, ifecha, iaccion)

        If MyBitacora.Consultar() Is Nothing Then
            Return MyBitacora.agregar()

        Else
            Return False
        End If

    End Function

    Public Function Consultarbitacora(ByVal iid_bitacora As Integer) As cls_Bitacora
        MyBitacora = New cls_Bitacora(iid_bitacora)
        Return MyBitacora.Consultar()
    End Function
    Public Function Consultasbitacoras(Optional ByVal icodigo As Integer = 0, Optional ByVal ifecha As Date = Nothing) As cls_Bitacora()


        MyBitacora = New cls_Bitacora(icodigo, ifecha)
        Return myBitacora.Consultas()

    End Function

    Public Function ConsecutivoBitacora() As String
        MyBitacora = New cls_Bitacora()
        Return myBitacora.Consecutivo() + 1
    End Function

#End Region

#Region "Organizacion"

    'Funcion insertar
    Public Function InsertarOrganizacion(ByVal iId_Organizacion As Integer, ByVal iNombre As String, ByVal iImagen As String) As Boolean
        'Crea un objeto con todos los atributos
        myOrganizacion = New Cls_organizacion(iId_Organizacion, iNombre, iImagen)

        If myOrganizacion.Consultar() Is Nothing Then
            Return myOrganizacion.insertar()
        Else
            Return False
        End If

    End Function
    Public Function ModificarOrganizacion(ByVal iId_Organizacion As Integer, ByVal iNombre As String, ByVal iImagen As String) As Boolean
        myOrganizacion = New Cls_organizacion(iId_Organizacion, iNombre, iImagen)

        If myOrganizacion.Consultar() IsNot Nothing Then
            Return myOrganizacion.modificar()
        Else
            Return False
        End If

    End Function
    Public Function EliminarOrganizacion(ByVal iId_Organizacion As Integer) As Boolean
        'Crea un objeto con todos los atributos
        myOrganizacion = New Cls_organizacion(iId_Organizacion)
        If myOrganizacion.Consultar() IsNot Nothing Then
            Return myOrganizacion.eliminar()
        Else
            Return False
        End If

    End Function
    Public Function ConsultarOrganizacion(ByVal iId_Organizacion As Integer) As Cls_organizacion
        myOrganizacion = New Cls_organizacion(iId_Organizacion)
        Return myOrganizacion.Consultar

    End Function

    Public Function ConsultasOrganizacion(ByVal iId_Organizacion As Integer, Optional ByVal val As Integer = 0) As cls_Miembro()
        myMiembro = New cls_Miembro(iId_Organizacion, val)
        Return myMiembro.Consultas()


    End Function

    Public Function ConsultasImagen(ByVal iId_Organizacion As Integer) As Cls_organizacion()
        myOrganizacion = New Cls_organizacion(iId_Organizacion)
        Return myOrganizacion.consultaImagen()

    End Function

    Public Function ConsecutivoOrganizacion() As String
        myOrganizacion = New Cls_organizacion()
        Return myOrganizacion.Consecutivo() + 1
    End Function




#End Region

End Class
