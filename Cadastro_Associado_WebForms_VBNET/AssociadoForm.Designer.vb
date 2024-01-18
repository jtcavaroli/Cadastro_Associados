<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssociadoForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnIncluir = New Button()
        btnAlterar = New Button()
        btnExcluir = New Button()
        txtNome = New TextBox()
        txtCpf = New TextBox()
        lblNome = New Label()
        lblCpf = New Label()
        lblDataNascimento = New Label()
        dtDataNascimento = New DateTimePicker()
        Label1 = New Label()
        txtIdAssociado = New TextBox()
        SuspendLayout()
        ' 
        ' btnIncluir
        ' 
        btnIncluir.Location = New Point(179, 370)
        btnIncluir.Name = "btnIncluir"
        btnIncluir.Size = New Size(94, 29)
        btnIncluir.TabIndex = 0
        btnIncluir.Text = "Incluir"
        btnIncluir.UseVisualStyleBackColor = True
        ' 
        ' btnAlterar
        ' 
        btnAlterar.Location = New Point(338, 370)
        btnAlterar.Name = "btnAlterar"
        btnAlterar.Size = New Size(94, 29)
        btnAlterar.TabIndex = 1
        btnAlterar.Text = "Alterar"
        btnAlterar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(500, 370)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(94, 29)
        btnExcluir.TabIndex = 2
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(39, 67)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(125, 27)
        txtNome.TabIndex = 3
        ' 
        ' txtCpf
        ' 
        txtCpf.Location = New Point(39, 131)
        txtCpf.Name = "txtCpf"
        txtCpf.Size = New Size(125, 27)
        txtCpf.TabIndex = 4
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(39, 44)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(53, 20)
        lblNome.TabIndex = 6
        lblNome.Text = "Nome:"
        ' 
        ' lblCpf
        ' 
        lblCpf.AutoSize = True
        lblCpf.Location = New Point(39, 108)
        lblCpf.Name = "lblCpf"
        lblCpf.Size = New Size(36, 20)
        lblCpf.TabIndex = 7
        lblCpf.Text = "CPF:"
        ' 
        ' lblDataNascimento
        ' 
        lblDataNascimento.AutoSize = True
        lblDataNascimento.Location = New Point(39, 175)
        lblDataNascimento.Name = "lblDataNascimento"
        lblDataNascimento.Size = New Size(127, 20)
        lblDataNascimento.TabIndex = 8
        lblDataNascimento.Text = "Data Nascimento:"
        ' 
        ' dtDataNascimento
        ' 
        dtDataNascimento.Location = New Point(39, 213)
        dtDataNascimento.Name = "dtDataNascimento"
        dtDataNascimento.Size = New Size(250, 27)
        dtDataNascimento.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(536, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 10
        Label1.Text = "Id Associado:"
        ' 
        ' txtIdAssociado
        ' 
        txtIdAssociado.Location = New Point(536, 67)
        txtIdAssociado.Name = "txtIdAssociado"
        txtIdAssociado.Size = New Size(125, 27)
        txtIdAssociado.TabIndex = 11
        ' 
        ' AssociadoForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtIdAssociado)
        Controls.Add(Label1)
        Controls.Add(dtDataNascimento)
        Controls.Add(lblDataNascimento)
        Controls.Add(lblCpf)
        Controls.Add(lblNome)
        Controls.Add(txtCpf)
        Controls.Add(txtNome)
        Controls.Add(btnExcluir)
        Controls.Add(btnAlterar)
        Controls.Add(btnIncluir)
        Name = "AssociadoForm"
        Text = "AssociadoForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents dtDataNascimento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdAssociado As TextBox
End Class
