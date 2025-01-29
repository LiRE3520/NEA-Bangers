<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RESULTSfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RESULTSfrm))
        Me.NamesListbox = New System.Windows.Forms.ListBox()
        Me.VScrollBar = New System.Windows.Forms.VScrollBar()
        Me.Calculationslbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NamesListbox
        '
        Me.NamesListbox.BackColor = System.Drawing.Color.RoyalBlue
        Me.NamesListbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NamesListbox.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamesListbox.ForeColor = System.Drawing.Color.White
        Me.NamesListbox.FormattingEnabled = True
        Me.NamesListbox.ItemHeight = 24
        Me.NamesListbox.Location = New System.Drawing.Point(22, 20)
        Me.NamesListbox.Margin = New System.Windows.Forms.Padding(2)
        Me.NamesListbox.Name = "NamesListbox"
        Me.NamesListbox.Size = New System.Drawing.Size(170, 288)
        Me.NamesListbox.TabIndex = 0
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(551, 20)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(39, 324)
        Me.VScrollBar.TabIndex = 1
        '
        'Calculationslbl
        '
        Me.Calculationslbl.AutoSize = True
        Me.Calculationslbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculationslbl.ForeColor = System.Drawing.Color.White
        Me.Calculationslbl.Location = New System.Drawing.Point(196, 20)
        Me.Calculationslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Calculationslbl.Name = "Calculationslbl"
        Me.Calculationslbl.Size = New System.Drawing.Size(0, 27)
        Me.Calculationslbl.TabIndex = 2
        Me.Calculationslbl.UseCompatibleTextRendering = True
        '
        'RESULTSfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Calculationslbl)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.NamesListbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RESULTSfrm"
        Me.Text = "RESULTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NamesListbox As ListBox
    Friend WithEvents VScrollBar As VScrollBar
    Friend WithEvents Calculationslbl As Label
End Class
