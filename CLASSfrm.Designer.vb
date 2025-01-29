<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CLASSfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CLASSfrm))
        Me.Sharelbl = New System.Windows.Forms.Label()
        Me.Resultslbl = New System.Windows.Forms.Label()
        Me.NewClasslbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Sharelbl
        '
        Me.Sharelbl.AutoSize = True
        Me.Sharelbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sharelbl.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sharelbl.ForeColor = System.Drawing.Color.White
        Me.Sharelbl.Location = New System.Drawing.Point(28, 24)
        Me.Sharelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sharelbl.Name = "Sharelbl"
        Me.Sharelbl.Size = New System.Drawing.Size(338, 35)
        Me.Sharelbl.TabIndex = 0
        Me.Sharelbl.Text = "SHARE YOUR ANSWER"
        '
        'Resultslbl
        '
        Me.Resultslbl.AutoSize = True
        Me.Resultslbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Resultslbl.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultslbl.ForeColor = System.Drawing.Color.White
        Me.Resultslbl.Location = New System.Drawing.Point(418, 24)
        Me.Resultslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Resultslbl.Name = "Resultslbl"
        Me.Resultslbl.Size = New System.Drawing.Size(262, 35)
        Me.Resultslbl.TabIndex = 1
        Me.Resultslbl.Text = "CLASS RESULTS"
        '
        'NewClasslbl
        '
        Me.NewClasslbl.AutoSize = True
        Me.NewClasslbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewClasslbl.Font = New System.Drawing.Font("OCR A Extended", 15.0!)
        Me.NewClasslbl.ForeColor = System.Drawing.Color.White
        Me.NewClasslbl.Location = New System.Drawing.Point(245, 150)
        Me.NewClasslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NewClasslbl.Name = "NewClasslbl"
        Me.NewClasslbl.Size = New System.Drawing.Size(238, 23)
        Me.NewClasslbl.TabIndex = 5
        Me.NewClasslbl.Text = "CLICK FOR NEW CLASS"
        '
        'CLASSfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(702, 210)
        Me.Controls.Add(Me.NewClasslbl)
        Me.Controls.Add(Me.Resultslbl)
        Me.Controls.Add(Me.Sharelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CLASSfrm"
        Me.Text = "CLASS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sharelbl As Label
    Friend WithEvents Resultslbl As Label
    Friend WithEvents NewClasslbl As Label
End Class
