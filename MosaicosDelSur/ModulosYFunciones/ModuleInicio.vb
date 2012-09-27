Imports System.Data.SqlClient

Module ModuleInicio
    Public Sub Main()
        If My.Forms.xfrmLogin.ShowDialog = DialogResult.OK Then
            DevExpress.UserSkins.OfficeSkins.Register()
            'Application.SetCompatibleTextRenderingDefault(False)
            System.Windows.Forms.Application.EnableVisualStyles()
            Application.DoEvents()
            Application.Run(New RFrmPrincipal)
        End If
    End Sub

    Public Structure Usuario
        Public IdUsuario As Integer
        Public Username As String
        Public Password As String
        Public EsAdmin As Boolean
        Public Estado As Boolean
        Public Nombre As String
        Public Apellido As String
        Public IdEmpleado As Integer
    End Structure

    Public Structure Empresa
        Public IdEmpresa As Integer
        Public NombreEmpresa As String
    End Structure

    Public UsuarioActivo As Usuario
    Public EmpresaActiva As Empresa

    Public Sub AddAction(ByVal IdUser As Integer, ByVal fecha As DateTime, ByVal accion As String, ByVal descripcion As String)
        Using TaLog As New dsSeguridadTableAdapters.LogTableAdapter
            TaLog.Insert(IdUser, fecha, accion, descripcion)
        End Using
    End Sub

    Public Sub Arqueo(ByVal NumCompra As String, _
                      ByVal Cliente As String, _
                      ByVal Mosaicos As Double, _
                      ByVal Terrazos As Double, _
                      ByVal CementoGris As Double, _
                      ByVal CementoBlanco As Double, _
                      ByVal Bloques As Double, _
                      ByVal Solidex As Double, _
                      ByVal Varios As Double, _
                      ByVal TotalIngresos As Double, _
                      ByVal NoIngresos As Double, _
                      ByVal Recibos As Double)

        Using CNN As New SqlConnection(My.Settings.MosaicosDelSurDBConnectionString)
            Using DA As New SqlDataAdapter() With {.InsertCommand = New SqlCommand("INSERT INTO Arqueo (Fecha, NumCompra, Cliente, Mosaicos, Terrazos, CementoGris, CementoBlanco, Bloques, Solidex, Varios, TotalIngresos, NoIngresos, Recibos) VALUES (@Fecha, @NumCompra, @Cliente, @Mosaicos, @Terrazos, @CementoGris, @CementoBlanco, @Bloques, @Solidex, @Varios, @TotalIngresos, @NoIngresos, @Recibos)", CNN)}
                DA.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Now
                DA.InsertCommand.Parameters.Add("@NumCompra", SqlDbType.NVarChar).Value = NumCompra
                DA.InsertCommand.Parameters.Add("@Cliente", SqlDbType.NVarChar).Value = Cliente
                DA.InsertCommand.Parameters.Add("@Mosaicos", SqlDbType.Money).Value = Mosaicos
                DA.InsertCommand.Parameters.Add("@Terrazos", SqlDbType.Money).Value = Terrazos
                DA.InsertCommand.Parameters.Add("@CementoGris", SqlDbType.Money).Value = CementoGris
                DA.InsertCommand.Parameters.Add("@CementoBlanco", SqlDbType.Money).Value = CementoBlanco
                DA.InsertCommand.Parameters.Add("@Bloques", SqlDbType.Money).Value = Bloques
                DA.InsertCommand.Parameters.Add("@Solidex", SqlDbType.Money).Value = Solidex
                DA.InsertCommand.Parameters.Add("@Varios", SqlDbType.Money).Value = Varios
                DA.InsertCommand.Parameters.Add("@TotalIngresos", SqlDbType.Money).Value = TotalIngresos
                DA.InsertCommand.Parameters.Add("@NoIngresos", SqlDbType.Money).Value = NoIngresos
                DA.InsertCommand.Parameters.Add("@Recibos", SqlDbType.Money).Value = Recibos

                CNN.Open()
                DA.InsertCommand.ExecuteNonQuery()
                CNN.Close()
            End Using
        End Using
    End Sub
End Module
