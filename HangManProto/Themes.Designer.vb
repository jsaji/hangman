<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Themes
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
        Me.Normal = New System.Windows.Forms.Button()
        Me.HarryPotter = New System.Windows.Forms.Button()
        Me.Christmas = New System.Windows.Forms.Button()
        Me.Halloween = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Normal
        '
        Me.Normal.BackColor = System.Drawing.Color.LightCyan
        Me.Normal.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Normal.ForeColor = System.Drawing.Color.DarkBlue
        Me.Normal.Location = New System.Drawing.Point(0, 0)
        Me.Normal.Margin = New System.Windows.Forms.Padding(5)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(632, 350)
        Me.Normal.TabIndex = 61
        Me.Normal.Text = "Normal"
        Me.Normal.UseVisualStyleBackColor = False
        '
        'HarryPotter
        '
        Me.HarryPotter.BackColor = System.Drawing.Color.DarkMagenta
        Me.HarryPotter.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HarryPotter.ForeColor = System.Drawing.Color.Gold
        Me.HarryPotter.Location = New System.Drawing.Point(631, 0)
        Me.HarryPotter.Margin = New System.Windows.Forms.Padding(5)
        Me.HarryPotter.Name = "HarryPotter"
        Me.HarryPotter.Size = New System.Drawing.Size(632, 350)
        Me.HarryPotter.TabIndex = 62
        Me.HarryPotter.Text = "Harry Potter"
        Me.HarryPotter.UseVisualStyleBackColor = False
        '
        'Christmas
        '
        Me.Christmas.BackColor = System.Drawing.Color.LimeGreen
        Me.Christmas.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Christmas.ForeColor = System.Drawing.Color.Crimson
        Me.Christmas.Location = New System.Drawing.Point(0, 348)
        Me.Christmas.Margin = New System.Windows.Forms.Padding(5)
        Me.Christmas.Name = "Christmas"
        Me.Christmas.Size = New System.Drawing.Size(632, 332)
        Me.Christmas.TabIndex = 64
        Me.Christmas.Text = "Christmas"
        Me.Christmas.UseVisualStyleBackColor = False
        '
        'Halloween
        '
        Me.Halloween.BackColor = System.Drawing.Color.DimGray
        Me.Halloween.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Halloween.ForeColor = System.Drawing.Color.DarkOrange
        Me.Halloween.Location = New System.Drawing.Point(631, 348)
        Me.Halloween.Margin = New System.Windows.Forms.Padding(5)
        Me.Halloween.Name = "Halloween"
        Me.Halloween.Size = New System.Drawing.Size(632, 332)
        Me.Halloween.TabIndex = 65
        Me.Halloween.Text = "Halloween"
        Me.Halloween.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(551, 310)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(5)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(162, 60)
        Me.HomeButton.TabIndex = 66
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Themes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Halloween)
        Me.Controls.Add(Me.Christmas)
        Me.Controls.Add(Me.HarryPotter)
        Me.Controls.Add(Me.Normal)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Themes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Themes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Normal As Button
    Friend WithEvents HarryPotter As Button
    Friend WithEvents Christmas As Button
    Friend WithEvents Halloween As Button
    Friend WithEvents HomeButton As Button
End Class
