<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnIrPara = New System.Windows.Forms.Button()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.pgbar1 = New System.Windows.Forms.ProgressBar()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnAvançar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 73)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(673, 417)
        Me.WebBrowser1.TabIndex = 0
        '
        'btnIrPara
        '
        Me.btnIrPara.Location = New System.Drawing.Point(610, 16)
        Me.btnIrPara.Name = "btnIrPara"
        Me.btnIrPara.Size = New System.Drawing.Size(75, 23)
        Me.btnIrPara.TabIndex = 1
        Me.btnIrPara.Text = "Ir Para"
        Me.btnIrPara.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(12, 18)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(592, 20)
        Me.txtUrl.TabIndex = 2
        '
        'pgbar1
        '
        Me.pgbar1.Location = New System.Drawing.Point(417, 43)
        Me.pgbar1.Name = "pgbar1"
        Me.pgbar1.Size = New System.Drawing.Size(268, 23)
        Me.pgbar1.Step = 5
        Me.pgbar1.TabIndex = 3
        Me.pgbar1.Visible = False
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(12, 43)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "< Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnAvançar
        '
        Me.btnAvançar.Location = New System.Drawing.Point(93, 43)
        Me.btnAvançar.Name = "btnAvançar"
        Me.btnAvançar.Size = New System.Drawing.Size(75, 23)
        Me.btnAvançar.TabIndex = 1
        Me.btnAvançar.Text = "Avançar >"
        Me.btnAvançar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(174, 43)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 1
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(255, 43)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 1
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(336, 43)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(697, 502)
        Me.Controls.Add(Me.pgbar1)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnAvançar)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnIrPara)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "Navegador VB .NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnIrPara As System.Windows.Forms.Button
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents pgbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnAvançar As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button

End Class
