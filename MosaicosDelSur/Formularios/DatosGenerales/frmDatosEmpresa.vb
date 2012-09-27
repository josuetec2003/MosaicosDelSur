Public Class frmDatosEmpresa 
    Private EsNuevo As Boolean
    Dim NuevaLocalidad As Boolean

    Private Sub frmDatosEmpresa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarLocaciones()

        If EsNuevo Then
            DatosGeneralesBindingSource.AddNew()
            btnGuardarEmpresa.Text = "Guardar información"
            DesbloquearLocaciones(False)
        Else
            DatosGeneralesTableAdapter.FillByIdInfo(DsCatalogos.DatosGenerales, EmpresaActiva.IdEmpresa)
            btnGuardarEmpresa.Text = "Actualizar"
            btnGuardarLocacion.Enabled = False
            btnCancelar.Enabled = False
        End If
    End Sub

    Sub CargarLocaciones()
        LocacionesTableAdapter.Fill(DsCatalogos.Locaciones)
    End Sub

    Private Function ValidarFormEmpresa() As Boolean
        If NombreEmpresaTextEdit.EditValue Is DBNull.Value Then
            NombreEmpresaTextEdit.Focus()
            Return False
        End If

        If RTNTextEdit.EditValue Is DBNull.Value Then
            RTNTextEdit.Focus()
            Return False
        End If

        If IndustriaTextEdit.EditValue Is DBNull.Value Then
            IndustriaTextEdit.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ValidarFormLocacion() As Boolean
        If LocalidadTextEdit.Text.Trim = "" Then
            LocalidadTextEdit.Focus()
            Return False
        End If

        If TelefonosTextEdit.Text.Trim = "" Then
            TelefonosTextEdit.Focus()
            Return False
        End If

        If DireccionMemoEdit.Text.Trim = "" Then
            DireccionMemoEdit.Focus()
            Return False
        End If

        Return True
    End Function

    Public Property EsNuevo1() As Boolean
        Get
            Return EsNuevo
        End Get
        Set(value As Boolean)
            EsNuevo = Value
        End Set
    End Property

    Sub DesbloquearLocaciones(ByVal TS As Boolean)
        LocalidadTextEdit.Enabled = TS
        TelefonosTextEdit.Enabled = TS
        DireccionMemoEdit.Enabled = TS
        LocacionesGridControl.Enabled = TS
        btnGuardarLocacion.Enabled = TS
        btnNuevo.Enabled = TS
        btnCancelar.Enabled = TS
    End Sub


    Private Sub btnGuardarEmpresa_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarEmpresa.Click
        If Not ValidarFormEmpresa() Then
            Exit Sub
        End If

        If EsNuevo Then
            Validate()
            DatosGeneralesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsCatalogos)
            MsgBox(String.Format("La información de la empresa ha sido registrada. {0} Comienza agregando las localidades.", Chr(13)), MsgBoxStyle.Information, "Datos generales")
            DesbloquearLocaciones(True)
            btnGuardarLocacion.Enabled = False
            btnCancelar.Enabled = False
            EsNuevo = False
            EmpresaActiva.IdEmpresa = DameUltimoCodigo("IdInformacion", "DatosGenerales", My.Settings.MosaicosDelSurDBConnectionString)
        Else
            Validate()
            DatosGeneralesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsCatalogos)
            MsgBox("Información actualizada", MsgBoxStyle.Information, "Datos generales")
        End If
    End Sub

    Private Sub btnGuardarLocacion_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarLocacion.Click
        If Not ValidarFormLocacion() Then
            Exit Sub
        End If

        If NuevaLocalidad Then
            LocacionesTableAdapter.Insert(LocalidadTextEdit.EditValue, DireccionMemoEdit.EditValue, TelefonosTextEdit.EditValue, EmpresaActiva.IdEmpresa)
            btnNuevo.Enabled = True
            btnGuardarLocacion.Enabled = False
            LimpiarLocalidades()
            CargarLocaciones()
        Else
            Dim id As Integer = DameLoc()
            LocacionesTableAdapter.UpdateLocacion(LocalidadTextEdit.EditValue, DireccionMemoEdit.EditValue, TelefonosTextEdit.EditValue, id)
            btnNuevo.Enabled = True
            btnGuardarLocacion.Enabled = False
            btnCancelar.Enabled = False
            CargarLocaciones()
        End If
    End Sub

    Private Function DameLoc() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdLocacion")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardarLocacion.Enabled = True
        btnCancelar.Enabled = True
        NuevaLocalidad = True
        LimpiarLocalidades()
        LocalidadTextEdit.Focus()
    End Sub

    Private Sub LocacionesGridControl_Click(sender As System.Object, e As System.EventArgs) Handles LocacionesGridControl.Click
        NuevaLocalidad = False
        btnNuevo.Enabled = False
        btnGuardarLocacion.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        LocacionesBindingSource.EndEdit()
        CargarLocaciones()
        btnCancelar.Enabled = False
        btnGuardarLocacion.Enabled = False
        btnNuevo.Enabled = True
        'LimpiarLocalidades()
    End Sub

    Sub LimpiarLocalidades()
        LocalidadTextEdit.EditValue = Nothing
        TelefonosTextEdit.EditValue = Nothing
        DireccionMemoEdit.EditValue = Nothing
    End Sub

    Private Sub EliminarLocalidadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarLocalidadToolStripMenuItem.Click
        If MsgBox("¿Eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
            Dim id As Integer = DameLoc()
            LocacionesTableAdapter.DeleteLocacion(id)
            CargarLocaciones()
        End If
    End Sub
End Class