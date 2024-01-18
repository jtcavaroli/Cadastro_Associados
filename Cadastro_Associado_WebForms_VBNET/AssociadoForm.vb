Public Class AssociadoForm
    Dim associadoRepo As New AssociadoRepository()

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim novoAssociado As New Associado() With {
            .Nome = txtNome.Text,
            .Cpf = txtCpf.Text,
            .DataNascimento = dtDataNascimento.Value
        }

        associadoRepo.IncluirAssociado(novoAssociado)

        ' Limpar os campos após a inclusão
        LimparCampos()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        ' Recuperar o associado existente do banco de dados por ID
        Dim idAssociado As Integer = ObterIdAssociado()
        Dim associadoExistente As Associado = associadoRepo.ConsultarAssociadoPorId(idAssociado)

        ' Atualizar os dados do associado existente
        associadoExistente.Nome = txtNome.Text
        associadoExistente.Cpf = txtCpf.Text
        associadoExistente.DataNascimento = dtDataNascimento.Value

        ' Implementar a lógica de alteração de associado
        associadoRepo.AlterarAssociado(associadoExistente)

        ' Limpar os campos após a alteração
        LimparCampos()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ' Obter o ID do associado a ser excluído
        Dim idAssociado As Integer = ObterIdAssociado()

        ' Implementar a lógica de exclusão de associado
        associadoRepo.ExcluirAssociado(idAssociado)

        ' Limpar os campos após a exclusão
        LimparCampos()
    End Sub

    ' Função para limpar os campos do formulário
    Private Sub LimparCampos()
        txtNome.Clear()
        txtCpf.Clear()
        dtDataNascimento.Value = DateTime.Now
    End Sub

    Private Function ObterIdAssociado() As Integer
        Dim idAssociado As Integer

        If Integer.TryParse(txtIdAssociado.Text, idAssociado) Then
            Return idAssociado
        Else
            ' Exiba uma mensagem de erro ou tome outra ação apropriada
            MessageBox.Show("ID do associado inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If
    End Function

End Class