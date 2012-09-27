Imports System.Data.SqlClient
Imports VB = Microsoft.VisualBasic

Module ModuleFunciones
    Public Function SHA1(ByVal strToHash As String) As String
        Using sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider()
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
            bytesToHash = sha1Obj.ComputeHash(bytesToHash)
            Dim strResult As String = ""
            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next
            Return strResult
        End Using
    End Function

    Public Function DameCodigoSiguiente(ByVal Columnallave As String, ByVal Tabla As String, ByVal CadenaConexion As String) As Integer
        Dim sqlconsulta As String = String.Format("Select max({0})+1 from {1}", Columnallave, Tabla)
        Dim midr As DataRow
        Dim _segCNN As SqlConnection = New SqlConnection(CadenaConexion)
        Using _segCNN
            Using _DT As New DataTable()
                _segCNN.Open()
                Using _adapter As New SqlDataAdapter(sqlconsulta, _segCNN)
                    _adapter.Fill(_DT)
                End Using
                If _DT.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Try
                        midr = _DT.Rows(0)
                        Return CInt(midr(0))
                    Catch
                        Return 1
                    End Try
                End If
            End Using
        End Using
    End Function

    Public Function DameUltimoCodigo(ByVal Columnallave As String, ByVal Tabla As String, ByVal CadenaConexion As String) As Integer
        Dim sqlconsulta As String = String.Format("Select max({0}) from {1}", Columnallave, Tabla)
        Dim midr As DataRow
        Dim _segCNN As SqlConnection = New SqlConnection(CadenaConexion)
        Using _segCNN
            Using _DT As New DataTable()
                _segCNN.Open()
                Using _adapter As New SqlDataAdapter(sqlconsulta, _segCNN)
                    _adapter.Fill(_DT)
                End Using
                If _DT.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Try
                        midr = _DT.Rows(0)
                        Return CInt(midr(0))
                    Catch
                        Return 1
                    End Try
                End If
            End Using
        End Using
    End Function

    Public Function DameFacturaSinOrden(ByVal CadenaConexion As String) As Integer
        Dim midr As DataRow
        Dim _segCNN As SqlConnection = New SqlConnection(CadenaConexion)
        Using _segCNN
            Using _DT As New DataTable()
                _segCNN.Open()
                Using _adapter As New SqlDataAdapter("Select max(IdFactura) from Facturas WHERE IdOrdenTrabajo IS NULL", _segCNN)
                    _adapter.Fill(_DT)
                End Using
                If _DT.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Try
                        midr = _DT.Rows(0)
                        Return CInt(midr(0))
                    Catch
                        Return 1
                    End Try
                End If
            End Using
        End Using
    End Function

    Public Function GenerarNumero(ByVal numero As Integer) As String
        Return VB.Right("00000" + Trim(Str(numero)), 6)
    End Function
End Module
