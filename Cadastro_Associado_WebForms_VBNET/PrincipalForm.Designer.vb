<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalForm
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
        Label1 = New Label()
        Label2 = New Label()
        btnAbrirFormAssociado = New Button()
        btnAbrirFormEmpresa = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 0
        Label1.Text = "Form Associado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(438, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Form Empresa"
        ' 
        ' btnAbrirFormAssociado
        ' 
        btnAbrirFormAssociado.Location = New Point(126, 164)
        btnAbrirFormAssociado.Name = "btnAbrirFormAssociado"
        btnAbrirFormAssociado.Size = New Size(94, 29)
        btnAbrirFormAssociado.TabIndex = 2
        btnAbrirFormAssociado.Text = "Abrir"
        btnAbrirFormAssociado.UseVisualStyleBackColor = True
        ' 
        ' btnAbrirFormEmpresa
        ' 
        btnAbrirFormEmpresa.Location = New Point(448, 164)
        btnAbrirFormEmpresa.Name = "btnAbrirFormEmpresa"
        btnAbrirFormEmpresa.Size = New Size(94, 29)
        btnAbrirFormEmpresa.TabIndex = 3
        btnAbrirFormEmpresa.Text = "Abrir"
        btnAbrirFormEmpresa.UseVisualStyleBackColor = True
        ' 
        ' PrincipalForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAbrirFormEmpresa)
        Controls.Add(btnAbrirFormAssociado)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PrincipalForm"
        Text = "PrincipalForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAbrirFormAssociado As Button
    Friend WithEvents btnAbrirFormEmpresa As Button
End Class
