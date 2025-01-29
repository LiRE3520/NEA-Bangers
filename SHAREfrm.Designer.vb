<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHAREfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SHAREfrm))
        Me.Sharebtn = New System.Windows.Forms.Button()
        Me.EntNamlbl = New System.Windows.Forms.Label()
        Me.Nametxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Sharebtn
        '
        Me.Sharebtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.Sharebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sharebtn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sharebtn.ForeColor = System.Drawing.Color.White
        Me.Sharebtn.Location = New System.Drawing.Point(90, 140)
        Me.Sharebtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Sharebtn.Name = "Sharebtn"
        Me.Sharebtn.Size = New System.Drawing.Size(160, 79)
        Me.Sharebtn.TabIndex = 7
        Me.Sharebtn.Text = "SHARE"
        Me.Sharebtn.UseVisualStyleBackColor = False
        '
        'EntNamlbl
        '
        Me.EntNamlbl.AutoSize = True
        Me.EntNamlbl.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntNamlbl.ForeColor = System.Drawing.Color.White
        Me.EntNamlbl.Location = New System.Drawing.Point(34, 28)
        Me.EntNamlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EntNamlbl.Name = "EntNamlbl"
        Me.EntNamlbl.Size = New System.Drawing.Size(300, 35)
        Me.EntNamlbl.TabIndex = 6
        Me.EntNamlbl.Text = "ENTER USERNAME:"
        '
        'Nametxt
        '
        Me.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nametxt.Font = New System.Drawing.Font("OCR A Extended", 15.0!)
        Me.Nametxt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Nametxt.Location = New System.Drawing.Point(40, 64)
        Me.Nametxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(266, 21)
        Me.Nametxt.TabIndex = 5
        '
        'SHAREfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(346, 257)
        Me.Controls.Add(Me.Sharebtn)
        Me.Controls.Add(Me.EntNamlbl)
        Me.Controls.Add(Me.Nametxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SHAREfrm"
        Me.Text = "SHARE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sharebtn As Button
    Friend WithEvents EntNamlbl As Label
    Friend WithEvents Nametxt As TextBox
End Class
