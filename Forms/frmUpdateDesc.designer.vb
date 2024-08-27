<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateDesc))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.wbDescription = New System.Windows.Forms.WebBrowser()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(426, 95)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 61)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Fechar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(427, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 61)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "&Baixar"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Nova Versão Disponível"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.wbDescription)
        Me.Panel1.Location = New System.Drawing.Point(15, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 342)
        Me.Panel1.TabIndex = 15
        '
        'wbDescription
        '
        Me.wbDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbDescription.IsWebBrowserContextMenuEnabled = False
        Me.wbDescription.Location = New System.Drawing.Point(0, 0)
        Me.wbDescription.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbDescription.Name = "wbDescription"
        Me.wbDescription.ScriptErrorsSuppressed = True
        Me.wbDescription.Size = New System.Drawing.Size(404, 340)
        Me.wbDescription.TabIndex = 0
        Me.wbDescription.WebBrowserShortcutsEnabled = False
        '
        'BtnAbout
        '
        Me.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbout.Image = CType(resources.GetObject("BtnAbout.Image"), System.Drawing.Image)
        Me.BtnAbout.Location = New System.Drawing.Point(427, 162)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(75, 61)
        Me.BtnAbout.TabIndex = 19
        Me.BtnAbout.Text = "Sobre..."
        Me.BtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'frmUpdateDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 382)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateDesc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualização Disponível"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents wbDescription As System.Windows.Forms.WebBrowser
    Friend WithEvents BtnAbout As Windows.Forms.Button
End Class
