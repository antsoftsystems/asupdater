<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.PicAbout = New System.Windows.Forms.PictureBox()
        Me.wbDescription = New System.Windows.Forms.WebBrowser()
        CType(Me.PicAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicAbout
        '
        Me.PicAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicAbout.Location = New System.Drawing.Point(0, 0)
        Me.PicAbout.Name = "PicAbout"
        Me.PicAbout.Size = New System.Drawing.Size(442, 112)
        Me.PicAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicAbout.TabIndex = 0
        Me.PicAbout.TabStop = False
        Me.PicAbout.WaitOnLoad = True
        '
        'wbDescription
        '
        Me.wbDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbDescription.IsWebBrowserContextMenuEnabled = False
        Me.wbDescription.Location = New System.Drawing.Point(0, 112)
        Me.wbDescription.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbDescription.Name = "wbDescription"
        Me.wbDescription.ScriptErrorsSuppressed = True
        Me.wbDescription.Size = New System.Drawing.Size(442, 215)
        Me.wbDescription.TabIndex = 1
        Me.wbDescription.WebBrowserShortcutsEnabled = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(442, 327)
        Me.Controls.Add(Me.wbDescription)
        Me.Controls.Add(Me.PicAbout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre..."
        CType(Me.PicAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicAbout As System.Windows.Forms.PictureBox
    Friend WithEvents wbDescription As System.Windows.Forms.WebBrowser
End Class
