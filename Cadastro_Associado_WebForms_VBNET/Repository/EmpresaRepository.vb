Imports System.Data.SqlClient

Public Class EmpresaRepository
    Private connectionString As String = "sua_string_de_conexao"

    Public Function ConsultarEmpresas() As List(Of Empresa)
        Dim empresas As New List(Of Empresa)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM Empresas"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim empresa As New Empresa() With {
                            .Id = CInt(reader("Id")),
                            .Nome = CStr(reader("Nome")),
                            .Cnpj = CStr(reader("Cnpj"))
                        }
                        empresas.Add(empresa)
                    End While
                End Using
            End Using
        End Using

        Return empresas
    End Function

    Public Function ConsultarEmpresaPorId(id As Integer) As Empresa
        Dim empresa As New Empresa()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM Empresas WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", id)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        empresa.Id = CInt(reader("Id"))
                        empresa.Nome = CStr(reader("Nome"))
                        empresa.Cnpj = CStr(reader("Cnpj"))
                    End If
                End Using
            End Using
        End Using

        Return empresa
    End Function

    Public Sub IncluirEmpresa(empresa As Empresa)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Empresas (Nome, Cnpj) VALUES (@Nome, @Cnpj)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nome", empresa.Nome)
                command.Parameters.AddWithValue("@Cnpj", empresa.Cnpj)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AlterarEmpresa(empresa As Empresa)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE Empresas SET Nome = @Nome, Cnpj = @Cnpj WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", empresa.Id)
                command.Parameters.AddWithValue("@Nome", empresa.Nome)
                command.Parameters.AddWithValue("@Cnpj", empresa.Cnpj)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ExcluirEmpresa(id As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Antes de excluir a empresa, você também pode precisar remover quaisquer relacionamentos com associados

            Dim query As String = "DELETE FROM Empresas WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
