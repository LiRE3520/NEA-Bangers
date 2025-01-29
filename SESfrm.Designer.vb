<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SESfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SESfrm))
        Me.Endlbl = New System.Windows.Forms.Label()
        Me.Startlbl = New System.Windows.Forms.Label()
        Me.Endupdown = New System.Windows.Forms.NumericUpDown()
        Me.Startupdown = New System.Windows.Forms.NumericUpDown()
        Me.Graphbtn = New System.Windows.Forms.Button()
        Me.Tableitbtn = New System.Windows.Forms.Button()
        Me.stepupdown = New System.Windows.Forms.NumericUpDown()
        Me.steplbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Endupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Startupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stepupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Endlbl
        '
        Me.Endlbl.AutoSize = True
        Me.Endlbl.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endlbl.ForeColor = System.Drawing.Color.White
        Me.Endlbl.Location = New System.Drawing.Point(307, 31)
        Me.Endlbl.Name = "Endlbl"
        Me.Endlbl.Size = New System.Drawing.Size(140, 32)
        Me.Endlbl.TabIndex = 56
        Me.Endlbl.Text = "End(x):"
        '
        'Startlbl
        '
        Me.Startlbl.AutoSize = True
        Me.Startlbl.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startlbl.ForeColor = System.Drawing.Color.White
        Me.Startlbl.Location = New System.Drawing.Point(41, 31)
        Me.Startlbl.Name = "Startlbl"
        Me.Startlbl.Size = New System.Drawing.Size(176, 32)
        Me.Startlbl.TabIndex = 55
        Me.Startlbl.Text = "Start(x):"
        '
        'Endupdown
        '
        Me.Endupdown.BackColor = System.Drawing.Color.RoyalBlue
        Me.Endupdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Endupdown.DecimalPlaces = 3
        Me.Endupdown.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endupdown.ForeColor = System.Drawing.Color.White
        Me.Endupdown.Location = New System.Drawing.Point(313, 80)
        Me.Endupdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Endupdown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.Endupdown.Name = "Endupdown"
        Me.Endupdown.Size = New System.Drawing.Size(189, 35)
        Me.Endupdown.TabIndex = 53
        '
        'Startupdown
        '
        Me.Startupdown.BackColor = System.Drawing.Color.RoyalBlue
        Me.Startupdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Startupdown.DecimalPlaces = 3
        Me.Startupdown.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startupdown.ForeColor = System.Drawing.Color.White
        Me.Startupdown.Location = New System.Drawing.Point(48, 80)
        Me.Startupdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Startupdown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.Startupdown.Name = "Startupdown"
        Me.Startupdown.Size = New System.Drawing.Size(189, 35)
        Me.Startupdown.TabIndex = 52
        '
        'Graphbtn
        '
        Me.Graphbtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.Graphbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Graphbtn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graphbtn.ForeColor = System.Drawing.Color.White
        Me.Graphbtn.Location = New System.Drawing.Point(47, 214)
        Me.Graphbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Graphbtn.Name = "Graphbtn"
        Me.Graphbtn.Size = New System.Drawing.Size(716, 76)
        Me.Graphbtn.TabIndex = 58
        Me.Graphbtn.Text = "GRAPH IT"
        Me.Graphbtn.UseVisualStyleBackColor = False
        '
        'Tableitbtn
        '
        Me.Tableitbtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.Tableitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tableitbtn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tableitbtn.ForeColor = System.Drawing.Color.White
        Me.Tableitbtn.Location = New System.Drawing.Point(47, 318)
        Me.Tableitbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tableitbtn.Name = "Tableitbtn"
        Me.Tableitbtn.Size = New System.Drawing.Size(716, 76)
        Me.Tableitbtn.TabIndex = 59
        Me.Tableitbtn.Text = "TABLE IT"
        Me.Tableitbtn.UseVisualStyleBackColor = False
        '
        'stepupdown
        '
        Me.stepupdown.BackColor = System.Drawing.Color.RoyalBlue
        Me.stepupdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stepupdown.DecimalPlaces = 2
        Me.stepupdown.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stepupdown.ForeColor = System.Drawing.Color.White
        Me.stepupdown.Location = New System.Drawing.Point(574, 80)
        Me.stepupdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.stepupdown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.stepupdown.Name = "stepupdown"
        Me.stepupdown.Size = New System.Drawing.Size(189, 35)
        Me.stepupdown.TabIndex = 60
        '
        'steplbl
        '
        Me.steplbl.AutoSize = True
        Me.steplbl.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steplbl.ForeColor = System.Drawing.Color.White
        Me.steplbl.Location = New System.Drawing.Point(568, 31)
        Me.steplbl.Name = "steplbl"
        Me.steplbl.Size = New System.Drawing.Size(158, 32)
        Me.steplbl.TabIndex = 61
        Me.steplbl.Text = "Step(x):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(734, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Step value is not necessary for a graph."
        '
        'SESfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(816, 440)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.steplbl)
        Me.Controls.Add(Me.stepupdown)
        Me.Controls.Add(Me.Tableitbtn)
        Me.Controls.Add(Me.Graphbtn)
        Me.Controls.Add(Me.Endlbl)
        Me.Controls.Add(Me.Startlbl)
        Me.Controls.Add(Me.Endupdown)
        Me.Controls.Add(Me.Startupdown)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SESfrm"
        Me.Text = "Start/End"
        CType(Me.Endupdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Startupdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stepupdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Endlbl As Label
    Friend WithEvents Startlbl As Label
    Private WithEvents Endupdown As NumericUpDown
    Private WithEvents Startupdown As NumericUpDown
    Friend WithEvents Graphbtn As Button
    Friend WithEvents Tableitbtn As Button
    Private WithEvents stepupdown As NumericUpDown
    Friend WithEvents steplbl As Label
    Friend WithEvents Label1 As Label
End Class
