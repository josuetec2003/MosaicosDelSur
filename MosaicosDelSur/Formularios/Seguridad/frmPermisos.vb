Public Class frmPermisos

    Private Sub frmPermisos_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmPermisos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        UsuariosTableAdapter.Fill(DsSeguridad.Usuarios)
        ModulosTableAdapter.Fill(DsSeguridad.Modulos)
        EmpleadosNombreCompletoTableAdapter.Fill(DsCatalogos.EmpleadosNombreCompleto)
    End Sub

    Sub CargarModulosAsigandosDisponibles(ByVal IDUSER As Integer)
        ModulosDisponiblesTableAdapter.Fill(DsSeguridad.ModulosDisponibles, IDUSER)
        ModulosAsignadosTableAdapter.Fill(DsSeguridad.ModulosAsignados, IDUSER)
    End Sub

    Private Function DameUsuario() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function DameNombreEmpleado() As String
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Username")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function DameModuloDisponible() As Integer
        Try
            Return GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "IdModulo")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function DameModuloAsignado() As Integer
        Try
            Return GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "IdModulo")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim ID As Integer = DameUsuario()
        GridView1.GroupPanelText = String.Format("Usuario seleccionado: {0}", DameNombreEmpleado)
        CargarModulosAsigandosDisponibles(ID)
    End Sub

    Private Sub GridControl2_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl2.DoubleClick
        Dim IdUser As Integer = DameUsuario()

        Using TaUsuarioModulos As New dsSeguridadTableAdapters.DetalleUsuarioModulosTableAdapter
            TaUsuarioModulos.Insert(IdUser, DameModuloDisponible)
            CargarModulosAsigandosDisponibles(IdUser)
        End Using
    End Sub

    Private Sub GridControl3_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl3.DoubleClick
        Dim IdUser As Integer = DameUsuario()
        Using TaUsuarioModulo As New dsSeguridadTableAdapters.DetalleUsuarioModulosTableAdapter
            TaUsuarioModulo.Delete(IdUser, DameModuloAsignado)
            CargarModulosAsigandosDisponibles(IdUser)
        End Using
    End Sub
End Class