Imports System.Data.SqlClient

Public Class AssociadoRepository
    Private connectionString As String = "sua_string_de_conexao"

    Public Function ConsultarAssociados() As List(Of Associado)
        Dim associados As New List(Of Associado)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM Associados"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim associado As New Associado() With {
                            .Id = CInt(reader("Id")),
                            .Nome = CStr(reader("Nome")),
                            .Cpf = CStr(reader("Cpf")),
                            .DataNascimento = If(reader("DataNascimento") IsNot DBNull.Value, CDate(reader("DataNascimento")), Nothing)
                        }
                        associados.Add(associado)
                    End While
                End Using
            End Using
        End Using

        Return associados
    End Function

    Public Function ConsultarAssociadoPorId(id As Integer) As Associado
        Dim associado As New Associado()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM Associados WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", id)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        associado.Id = CInt(reader("Id"))
                        associado.Nome = CStr(reader("Nome"))
                        associado.Cpf = CStr(reader("Cpf"))
                        associado.DataNascimento = If(reader("DataNascimento") IsNot DBNull.Value, CDate(reader("DataNascimento")), Nothing)
                    End If
                End Using
            End Using
        End Using

        Return associado
    End Function

    Public Sub IncluirAssociado(associado As Associado)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Associados (Nome, Cpf, DataNascimento) VALUES (@Nome, @Cpf, @DataNascimento)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nome", associado.Nome)
                command.Parameters.AddWithValue("@Cpf", associado.Cpf)
                command.Parameters.AddWithValue("@DataNascimento", If(associado.DataNascimento IsNot Nothing, CType(associado.DataNascimento, Object), DBNull.Value))

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AlterarAssociado(associado As Associado)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE Associados SET Nome = @Nome, Cpf = @Cpf, DataNascimento = @DataNascimento WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", associado.Id)
                command.Parameters.AddWithValue("@Nome", associado.Nome)
                command.Parameters.AddWithValue("@Cpf", associado.Cpf)
                command.Parameters.AddWithValue("@DataNascimento", If(associado.DataNascimento IsNot Nothing, CType(associado.DataNascimento, Object), DBNull.Value))

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ExcluirAssociado(id As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Antes de excluir o associado, você também pode precisar remover quaisquer relacionamentos com empresas

            Dim query As String = "DELETE FROM Associados WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class

