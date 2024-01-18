Public Class PrincipalForm
    Private Sub btnAbrirFormAssociado_Click(sender As Object, e As EventArgs) Handles btnAbrirFormAssociado.Click
        Dim associadoForm As New AssociadoForm()
        associadoForm.ShowDialog()
    End Sub

    Private Sub btnAbrirFormEmpresa_Click(sender As Object, e As EventArgs) Handles btnAbrirFormEmpresa.Click
        Dim empresaForm As New EmpresaForm()
        empresaForm.ShowDialog()
    End Sub
End Class