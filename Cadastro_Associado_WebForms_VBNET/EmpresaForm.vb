Imports System.Windows.Forms

Public Class EmpresaForm
    Dim empresaRepo As New EmpresaRepository()

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        ' Criar uma nova empresa com os dados do formulário
        Dim novaEmpresa As New Empresa() With {
            .Nome = txtNome.Text,
            .Cnpj = txtCNPJ.Text
        }

        ' Implementar a lógica de inclusão de empresa
        empresaRepo.IncluirEmpresa(novaEmpresa)

        ' Limpar os campos após a inclusão
        LimparCampos()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        ' Obter o ID da empresa a ser alterada
        Dim idEmpresa As Integer = ObterIdEmpresa()

        ' Verificar se o ID é válido
        If idEmpresa > 0 Then
            ' Recuperar a empresa existente do banco de dados por ID
            Dim empresaExistente As Empresa = empresaRepo.ConsultarEmpresaPorId(idEmpresa)

            ' Verificar se a empresa existe
            If empresaExistente IsNot Nothing Then
                ' Atualizar os dados da empresa existente com os do formulário
                empresaExistente.Nome = txtNome.Text
                empresaExistente.Cnpj = txtCNPJ.Text

                ' Implementar a lógica de alteração de empresa
                empresaRepo.AlterarEmpresa(empresaExistente)

                ' Limpar os campos após a alteração
                LimparCampos()
            Else
                MessageBox.Show("Empresa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ' Obter o ID da empresa a ser excluída
        Dim idEmpresa As Integer = ObterIdEmpresa()

        ' Verificar se o ID é válido
        If idEmpresa > 0 Then
            ' Implementar a lógica de exclusão de empresa
            empresaRepo.ExcluirEmpresa(idEmpresa)

            ' Limpar os campos após a exclusão
            LimparCampos()
        End If
    End Sub

    ' Função para obter o ID da empresa a partir do TextBox
    Private Function ObterIdEmpresa() As Integer
        Dim idEmpresa As Integer

        If Integer.TryParse(txtIdEmpresa.Text, idEmpresa) Then
            Return idEmpresa
        Else
            ' Exiba uma mensagem de erro ou tome outra ação apropriada
            MessageBox.Show("ID da empresa inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If
    End Function

    ' Função para limpar os campos do formulário
    Private Sub LimparCampos()
        txtNome.Clear()
        txtCNPJ.Clear()
        txtIdEmpresa.Clear()
    End Sub
End Class
