<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdater
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdater))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ilst16 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvwUpdate = New System.Windows.Forms.ListView()
        Me.ch1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.picUpdate = New System.Windows.Forms.PictureBox()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        CType(Me.picUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(630, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 62)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Fechar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(630, 25)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 62)
        Me.btnStart.TabIndex = 12
        Me.btnStart.Text = "Iniciar"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(177, 308)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(447, 21)
        Me.pBar.Step = 1
        Me.pBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pBar.TabIndex = 11
        Me.pBar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Andamento da atualização:"
        '
        'ilst16
        '
        Me.ilst16.ImageStream = CType(resources.GetObject("ilst16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilst16.TransparentColor = System.Drawing.Color.Transparent
        Me.ilst16.Images.SetKeyName(0, "dives_downoad_16.png")
        Me.ilst16.Images.SetKeyName(1, "exclamation.png")
        Me.ilst16.Images.SetKeyName(2, "accept.png")
        Me.ilst16.Images.SetKeyName(3, "world_go.png")
        Me.ilst16.Images.SetKeyName(4, "tick.png")
        Me.ilst16.Images.SetKeyName(5, "Ruby.png")
        Me.ilst16.Images.SetKeyName(6, "Vote-Yes-32.png")
        '
        'lvwUpdate
        '
        Me.lvwUpdate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch1})
        Me.lvwUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUpdate.FullRowSelect = True
        Me.lvwUpdate.GridLines = True
        Me.lvwUpdate.HideSelection = False
        Me.lvwUpdate.Location = New System.Drawing.Point(177, 25)
        Me.lvwUpdate.MultiSelect = False
        Me.lvwUpdate.Name = "lvwUpdate"
        Me.lvwUpdate.Size = New System.Drawing.Size(447, 277)
        Me.lvwUpdate.SmallImageList = Me.ilst16
        Me.lvwUpdate.TabIndex = 15
        Me.lvwUpdate.UseCompatibleStateImageBehavior = False
        Me.lvwUpdate.View = System.Windows.Forms.View.Details
        '
        'ch1
        '
        Me.ch1.Text = "Processo de atualização"
        Me.ch1.Width = 410
        '
        'picUpdate
        '
        Me.picUpdate.Location = New System.Drawing.Point(10, 9)
        Me.picUpdate.Name = "picUpdate"
        Me.picUpdate.Size = New System.Drawing.Size(161, 322)
        Me.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpdate.TabIndex = 14
        Me.picUpdate.TabStop = False
        '
        'btnSetup
        '
        Me.btnSetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetup.Enabled = False
        Me.btnSetup.Image = CType(resources.GetObject("btnSetup.Image"), System.Drawing.Image)
        Me.btnSetup.Location = New System.Drawing.Point(630, 87)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 62)
        Me.btnSetup.TabIndex = 17
        Me.btnSetup.Text = "Instalar"
        Me.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.Location = New System.Drawing.Point(630, 211)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 62)
        Me.btnAbout.TabIndex = 18
        Me.btnAbout.Text = "Sobre..."
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'frmUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 341)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwUpdate)
        Me.Controls.Add(Me.picUpdate)
        Me.Controls.Add(Me.btnSetup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AntSoft Software Updater"
        CType(Me.picUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ilst16 As System.Windows.Forms.ImageList
    Friend WithEvents lvwUpdate As System.Windows.Forms.ListView
    Friend WithEvents ch1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents picUpdate As System.Windows.Forms.PictureBox
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
End Class
