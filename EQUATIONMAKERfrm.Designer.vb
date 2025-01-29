<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EQUATIONMAKERfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EQUATIONMAKERfrm))
        Me.Tanlbl = New System.Windows.Forms.Label()
        Me.Coslbl = New System.Windows.Forms.Label()
        Me.Sinlbl = New System.Windows.Forms.Label()
        Me.GraphTableExpressionlbl = New System.Windows.Forms.Label()
        Me.Cursorlbl = New System.Windows.Forms.Label()
        Me.xlbl = New System.Windows.Forms.Label()
        Me.fxlbl = New System.Windows.Forms.Label()
        Me.Solvebtn = New System.Windows.Forms.Button()
        Me.Equalslbl = New System.Windows.Forms.Label()
        Me.SolverCheck = New System.Windows.Forms.CheckBox()
        Me.LHSlbl = New System.Windows.Forms.Label()
        Me.RHSlbl = New System.Windows.Forms.Label()
        Me.GraphTablebtn = New System.Windows.Forms.Button()
        Me.LHSbtn = New System.Windows.Forms.Label()
        Me.RHSbtn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tanlbl
        '
        Me.Tanlbl.AllowDrop = True
        Me.Tanlbl.AutoSize = True
        Me.Tanlbl.BackColor = System.Drawing.Color.RoyalBlue
        Me.Tanlbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tanlbl.Font = New System.Drawing.Font("OCR A Extended", 72.0!)
        Me.Tanlbl.ForeColor = System.Drawing.Color.White
        Me.Tanlbl.Location = New System.Drawing.Point(596, 316)
        Me.Tanlbl.Name = "Tanlbl"
        Me.Tanlbl.Size = New System.Drawing.Size(268, 123)
        Me.Tanlbl.TabIndex = 77
        Me.Tanlbl.Text = "tan"
        '
        'Coslbl
        '
        Me.Coslbl.AllowDrop = True
        Me.Coslbl.AutoSize = True
        Me.Coslbl.BackColor = System.Drawing.Color.RoyalBlue
        Me.Coslbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Coslbl.Font = New System.Drawing.Font("OCR A Extended", 72.0!)
        Me.Coslbl.ForeColor = System.Drawing.Color.White
        Me.Coslbl.Location = New System.Drawing.Point(322, 316)
        Me.Coslbl.Name = "Coslbl"
        Me.Coslbl.Size = New System.Drawing.Size(268, 123)
        Me.Coslbl.TabIndex = 76
        Me.Coslbl.Text = "cos"
        '
        'Sinlbl
        '
        Me.Sinlbl.AllowDrop = True
        Me.Sinlbl.AutoSize = True
        Me.Sinlbl.BackColor = System.Drawing.Color.RoyalBlue
        Me.Sinlbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sinlbl.Font = New System.Drawing.Font("OCR A Extended", 72.0!)
        Me.Sinlbl.ForeColor = System.Drawing.Color.White
        Me.Sinlbl.Location = New System.Drawing.Point(48, 316)
        Me.Sinlbl.Name = "Sinlbl"
        Me.Sinlbl.Size = New System.Drawing.Size(268, 123)
        Me.Sinlbl.TabIndex = 75
        Me.Sinlbl.Text = "sin"
        '
        'GraphTableExpressionlbl
        '
        Me.GraphTableExpressionlbl.AutoSize = True
        Me.GraphTableExpressionlbl.BackColor = System.Drawing.Color.Transparent
        Me.GraphTableExpressionlbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GraphTableExpressionlbl.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphTableExpressionlbl.ForeColor = System.Drawing.Color.White
        Me.GraphTableExpressionlbl.Location = New System.Drawing.Point(229, 60)
        Me.GraphTableExpressionlbl.Name = "GraphTableExpressionlbl"
        Me.GraphTableExpressionlbl.Size = New System.Drawing.Size(0, 73)
        Me.GraphTableExpressionlbl.TabIndex = 73
        '
        'Cursorlbl
        '
        Me.Cursorlbl.AutoSize = True
        Me.Cursorlbl.BackColor = System.Drawing.Color.Transparent
        Me.Cursorlbl.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cursorlbl.ForeColor = System.Drawing.Color.White
        Me.Cursorlbl.Location = New System.Drawing.Point(181, 23)
        Me.Cursorlbl.Name = "Cursorlbl"
        Me.Cursorlbl.Size = New System.Drawing.Size(29, 35)
        Me.Cursorlbl.TabIndex = 82
        Me.Cursorlbl.Text = "<"
        '
        'xlbl
        '
        Me.xlbl.AllowDrop = True
        Me.xlbl.AutoSize = True
        Me.xlbl.BackColor = System.Drawing.Color.RoyalBlue
        Me.xlbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xlbl.Font = New System.Drawing.Font("OCR A Extended", 72.0!)
        Me.xlbl.ForeColor = System.Drawing.Color.White
        Me.xlbl.Location = New System.Drawing.Point(870, 316)
        Me.xlbl.Name = "xlbl"
        Me.xlbl.Size = New System.Drawing.Size(100, 123)
        Me.xlbl.TabIndex = 85
        Me.xlbl.Text = "𝑥"
        '
        'fxlbl
        '
        Me.fxlbl.AutoSize = True
        Me.fxlbl.BackColor = System.Drawing.Color.Transparent
        Me.fxlbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fxlbl.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fxlbl.ForeColor = System.Drawing.Color.White
        Me.fxlbl.Location = New System.Drawing.Point(51, 58)
        Me.fxlbl.Name = "fxlbl"
        Me.fxlbl.Size = New System.Drawing.Size(172, 73)
        Me.fxlbl.TabIndex = 86
        Me.fxlbl.Text = "f(𝑥) = "
        '
        'Solvebtn
        '
        Me.Solvebtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.Solvebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Solvebtn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Solvebtn.ForeColor = System.Drawing.Color.White
        Me.Solvebtn.Location = New System.Drawing.Point(69, 537)
        Me.Solvebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Solvebtn.Name = "Solvebtn"
        Me.Solvebtn.Size = New System.Drawing.Size(901, 67)
        Me.Solvebtn.TabIndex = 88
        Me.Solvebtn.Text = "SOLVE"
        Me.Solvebtn.UseVisualStyleBackColor = False
        '
        'Equalslbl
        '
        Me.Equalslbl.AutoSize = True
        Me.Equalslbl.BackColor = System.Drawing.Color.Transparent
        Me.Equalslbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Equalslbl.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equalslbl.ForeColor = System.Drawing.Color.White
        Me.Equalslbl.Location = New System.Drawing.Point(485, 176)
        Me.Equalslbl.Name = "Equalslbl"
        Me.Equalslbl.Size = New System.Drawing.Size(62, 73)
        Me.Equalslbl.TabIndex = 89
        Me.Equalslbl.Text = "="
        '
        'SolverCheck
        '
        Me.SolverCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.SolverCheck.AutoSize = True
        Me.SolverCheck.Font = New System.Drawing.Font("OCR A Extended", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolverCheck.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SolverCheck.Location = New System.Drawing.Point(845, 23)
        Me.SolverCheck.Name = "SolverCheck"
        Me.SolverCheck.Size = New System.Drawing.Size(159, 49)
        Me.SolverCheck.TabIndex = 90
        Me.SolverCheck.Text = "SOLVER"
        Me.SolverCheck.UseVisualStyleBackColor = True
        '
        'LHSlbl
        '
        Me.LHSlbl.AutoSize = True
        Me.LHSlbl.BackColor = System.Drawing.Color.Transparent
        Me.LHSlbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LHSlbl.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHSlbl.ForeColor = System.Drawing.Color.White
        Me.LHSlbl.Location = New System.Drawing.Point(78, 176)
        Me.LHSlbl.Name = "LHSlbl"
        Me.LHSlbl.Size = New System.Drawing.Size(0, 73)
        Me.LHSlbl.TabIndex = 91
        '
        'RHSlbl
        '
        Me.RHSlbl.AutoSize = True
        Me.RHSlbl.BackColor = System.Drawing.Color.Transparent
        Me.RHSlbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RHSlbl.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RHSlbl.ForeColor = System.Drawing.Color.White
        Me.RHSlbl.Location = New System.Drawing.Point(578, 176)
        Me.RHSlbl.Name = "RHSlbl"
        Me.RHSlbl.Size = New System.Drawing.Size(0, 73)
        Me.RHSlbl.TabIndex = 92
        '
        'GraphTablebtn
        '
        Me.GraphTablebtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.GraphTablebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GraphTablebtn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphTablebtn.ForeColor = System.Drawing.Color.White
        Me.GraphTablebtn.Location = New System.Drawing.Point(69, 453)
        Me.GraphTablebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GraphTablebtn.Name = "GraphTablebtn"
        Me.GraphTablebtn.Size = New System.Drawing.Size(901, 65)
        Me.GraphTablebtn.TabIndex = 87
        Me.GraphTablebtn.Text = "GRAPH/TABLE"
        Me.GraphTablebtn.UseVisualStyleBackColor = False
        '
        'LHSbtn
        '
        Me.LHSbtn.AutoSize = True
        Me.LHSbtn.BackColor = System.Drawing.Color.Transparent
        Me.LHSbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LHSbtn.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHSbtn.ForeColor = System.Drawing.Color.White
        Me.LHSbtn.Location = New System.Drawing.Point(330, 243)
        Me.LHSbtn.Name = "LHSbtn"
        Me.LHSbtn.Size = New System.Drawing.Size(135, 63)
        Me.LHSbtn.TabIndex = 93
        Me.LHSbtn.Text = "LHS"
        '
        'RHSbtn
        '
        Me.RHSbtn.AutoSize = True
        Me.RHSbtn.BackColor = System.Drawing.Color.Transparent
        Me.RHSbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RHSbtn.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RHSbtn.ForeColor = System.Drawing.Color.White
        Me.RHSbtn.Location = New System.Drawing.Point(578, 243)
        Me.RHSbtn.Name = "RHSbtn"
        Me.RHSbtn.Size = New System.Drawing.Size(135, 63)
        Me.RHSbtn.TabIndex = 94
        Me.RHSbtn.Text = "RHS"
        '
        'EQUATIONMAKERfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1064, 680)
        Me.Controls.Add(Me.RHSbtn)
        Me.Controls.Add(Me.LHSbtn)
        Me.Controls.Add(Me.RHSlbl)
        Me.Controls.Add(Me.LHSlbl)
        Me.Controls.Add(Me.SolverCheck)
        Me.Controls.Add(Me.Equalslbl)
        Me.Controls.Add(Me.Solvebtn)
        Me.Controls.Add(Me.GraphTablebtn)
        Me.Controls.Add(Me.fxlbl)
        Me.Controls.Add(Me.xlbl)
        Me.Controls.Add(Me.Tanlbl)
        Me.Controls.Add(Me.Coslbl)
        Me.Controls.Add(Me.Sinlbl)
        Me.Controls.Add(Me.GraphTableExpressionlbl)
        Me.Controls.Add(Me.Cursorlbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EQUATIONMAKERfrm"
        Me.Text = "EQUATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tanlbl As Label
    Friend WithEvents Coslbl As Label
    Friend WithEvents Sinlbl As Label
    Friend WithEvents GraphTableExpressionlbl As Label
    Friend WithEvents Cursorlbl As Label
    Friend WithEvents xlbl As Label
    Friend WithEvents fxlbl As Label
    Friend WithEvents Solvebtn As Button
    Friend WithEvents Equalslbl As Label
    Friend WithEvents SolverCheck As CheckBox
    Friend WithEvents LHSlbl As Label
    Friend WithEvents RHSlbl As Label
    Friend WithEvents GraphTablebtn As Button
    Friend WithEvents LHSbtn As Label
    Friend WithEvents RHSbtn As Label
End Class
