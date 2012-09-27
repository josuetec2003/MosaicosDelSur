Public Class frmTamanios 

    Private Sub frmTamanios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)
        TamanioTextEdit.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If btnOK.Text = "Agregar" Then
            TamaniosBindingSource.AddNew()
            btnOK.Text = "Guardar"
            btnActualizar.Text = "Cancelar"
            TamanioTextEdit.Enabled = True
            TamanioTextEdit.Focus()
        ElseIf btnOK.Text = "Guardar" Then
            btnOK.Text = "Agregar"
            btnActualizar.Text = "Editar"
            TamanioTextEdit.Enabled = False
            Validate()
            TamaniosBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsCatalogos)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        If btnActualizar.Text = "Editar" Then
            btnActualizar.Text = "Actualizar"
            TamanioTextEdit.Enabled = True
        ElseIf btnActualizar.Text = "Actualizar" Then
            Validate()
            TamaniosBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsCatalogos)
            TamanioTextEdit.Enabled = False
            btnActualizar.Text = "Editar"
        ElseIf btnActualizar.Text = "Cancelar" Then
            TamaniosBindingSource.CancelEdit()
            btnOK.Text = "Agregar"
            TamanioTextEdit.Enabled = False
            btnActualizar.Text = "Editar"
        End If
    End Sub
End Class