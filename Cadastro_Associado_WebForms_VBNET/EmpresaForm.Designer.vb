<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresaForm
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
        lbEmpresa = New Label()
        lblNome = New Label()
        lblCNPJ = New Label()
        txtIdEmpresa = New TextBox()
        txtNome = New TextBox()
        txtCNPJ = New TextBox()
        btnIncluir = New Button()
        btnAlterar = New Button()
        btnExcluir = New Button()
        SuspendLayout()
        ' 
        ' lbEmpresa
        ' 
        lbEmpresa.AutoSize = True
        lbEmpresa.Location = New Point(33, 39)
        lbEmpresa.Name = "lbEmpresa"
        lbEmpresa.Size = New Size(86, 20)
        lbEmpresa.TabIndex = 0
        lbEmpresa.Text = "Id Empresa:"
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(32, 94)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(53, 20)
        lblNome.TabIndex = 1
        lblNome.Text = "Nome:"
        ' 
        ' lblCNPJ
        ' 
        lblCNPJ.AutoSize = True
        lblCNPJ.Location = New Point(32, 158)
        lblCNPJ.Name = "lblCNPJ"
        lblCNPJ.Size = New Size(44, 20)
        lblCNPJ.TabIndex = 2
        lblCNPJ.Text = "CNPJ:"
        ' 
        ' txtIdEmpresa
        ' 
        txtIdEmpresa.Location = New Point(33, 62)
        txtIdEmpresa.Name = "txtIdEmpresa"
        txtIdEmpresa.Size = New Size(125, 27)
        txtIdEmpresa.TabIndex = 3
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(32, 117)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(125, 27)
        txtNome.TabIndex = 4
        ' 
        ' txtCNPJ
        ' 
        txtCNPJ.Location = New Point(32, 181)
        txtCNPJ.Name = "txtCNPJ"
        txtCNPJ.Size = New Size(125, 27)
        txtCNPJ.TabIndex = 5
        ' 
        ' btnIncluir
        ' 
        btnIncluir.Location = New Point(168, 305)
        btnIncluir.Name = "btnIncluir"
        btnIncluir.Size = New Size(94, 29)
        btnIncluir.TabIndex = 6
        btnIncluir.Text = "Incluir"
        btnIncluir.UseVisualStyleBackColor = True
        ' 
        ' btnAlterar
        ' 
        btnAlterar.Location = New Point(326, 305)
        btnAlterar.Name = "btnAlterar"
        btnAlterar.Size = New Size(94, 29)
        btnAlterar.TabIndex = 7
        btnAlterar.Text = "Alterar"
        btnAlterar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(510, 305)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(94, 29)
        btnExcluir.TabIndex = 8
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' EmpresaForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExcluir)
        Controls.Add(btnAlterar)
        Controls.Add(btnIncluir)
        Controls.Add(txtCNPJ)
        Controls.Add(txtNome)
        Controls.Add(txtIdEmpresa)
        Controls.Add(lblCNPJ)
        Controls.Add(lblNome)
        Controls.Add(lbEmpresa)
        Name = "EmpresaForm"
        Text = "EmpresaForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbEmpresa As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCNPJ As Label
    Friend WithEvents txtIdEmpresa As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCNPJ As TextBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
End Class
