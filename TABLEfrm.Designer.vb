<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TABLEfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TABLEfrm))
        Me.Contentslbl = New System.Windows.Forms.Label()
        Me.xlistbox = New System.Windows.Forms.ListBox()
        Me.xlbl = New System.Windows.Forms.Label()
        Me.fxlbl = New System.Windows.Forms.Label()
        Me.Sortlbl = New System.Windows.Forms.Label()
        Me.AscArrlbl = New System.Windows.Forms.Label()
        Me.DescArrlbl = New System.Windows.Forms.Label()
        Me.Originallbl = New System.Windows.Forms.Label()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Searchtxt = New System.Windows.Forms.TextBox()
        Me.SFlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Contentslbl
        '
        Me.Contentslbl.AutoSize = True
        Me.Contentslbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contentslbl.ForeColor = System.Drawing.Color.White
        Me.Contentslbl.Location = New System.Drawing.Point(446, 117)
        Me.Contentslbl.Name = "Contentslbl"
        Me.Contentslbl.Size = New System.Drawing.Size(127, 35)
        Me.Contentslbl.TabIndex = 3
        Me.Contentslbl.Text = "5454545"
        Me.Contentslbl.UseCompatibleTextRendering = True
        '
        'xlistbox
        '
        Me.xlistbox.BackColor = System.Drawing.Color.RoyalBlue
        Me.xlistbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xlistbox.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xlistbox.ForeColor = System.Drawing.Color.White
        Me.xlistbox.FormattingEnabled = True
        Me.xlistbox.ItemHeight = 29
        Me.xlistbox.Location = New System.Drawing.Point(80, 117)
        Me.xlistbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.xlistbox.Name = "xlistbox"
        Me.xlistbox.Size = New System.Drawing.Size(227, 348)
        Me.xlistbox.TabIndex = 4
        '
        'xlbl
        '
        Me.xlbl.AutoSize = True
        Me.xlbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xlbl.ForeColor = System.Drawing.Color.White
        Me.xlbl.Location = New System.Drawing.Point(77, 71)
        Me.xlbl.Name = "xlbl"
        Me.xlbl.Size = New System.Drawing.Size(26, 35)
        Me.xlbl.TabIndex = 5
        Me.xlbl.Text = "x"
        Me.xlbl.UseCompatibleTextRendering = True
        '
        'fxlbl
        '
        Me.fxlbl.AutoSize = True
        Me.fxlbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fxlbl.ForeColor = System.Drawing.Color.White
        Me.fxlbl.Location = New System.Drawing.Point(446, 71)
        Me.fxlbl.Name = "fxlbl"
        Me.fxlbl.Size = New System.Drawing.Size(77, 35)
        Me.fxlbl.TabIndex = 6
        Me.fxlbl.Text = "f(x)"
        Me.fxlbl.UseCompatibleTextRendering = True
        '
        'Sortlbl
        '
        Me.Sortlbl.AutoSize = True
        Me.Sortlbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sortlbl.ForeColor = System.Drawing.Color.White
        Me.Sortlbl.Location = New System.Drawing.Point(332, 22)
        Me.Sortlbl.Name = "Sortlbl"
        Me.Sortlbl.Size = New System.Drawing.Size(93, 35)
        Me.Sortlbl.TabIndex = 7
        Me.Sortlbl.Text = "Sort:"
        Me.Sortlbl.UseCompatibleTextRendering = True
        '
        'AscArrlbl
        '
        Me.AscArrlbl.AutoSize = True
        Me.AscArrlbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AscArrlbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AscArrlbl.ForeColor = System.Drawing.Color.White
        Me.AscArrlbl.Location = New System.Drawing.Point(446, 22)
        Me.AscArrlbl.Name = "AscArrlbl"
        Me.AscArrlbl.Size = New System.Drawing.Size(23, 35)
        Me.AscArrlbl.TabIndex = 8
        Me.AscArrlbl.Text = "↓"
        Me.AscArrlbl.UseCompatibleTextRendering = True
        '
        'DescArrlbl
        '
        Me.DescArrlbl.AutoSize = True
        Me.DescArrlbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DescArrlbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescArrlbl.ForeColor = System.Drawing.Color.White
        Me.DescArrlbl.Location = New System.Drawing.Point(500, 22)
        Me.DescArrlbl.Name = "DescArrlbl"
        Me.DescArrlbl.Size = New System.Drawing.Size(23, 35)
        Me.DescArrlbl.TabIndex = 9
        Me.DescArrlbl.Text = "↑"
        Me.DescArrlbl.UseCompatibleTextRendering = True
        '
        'Originallbl
        '
        Me.Originallbl.AutoSize = True
        Me.Originallbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Originallbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Originallbl.ForeColor = System.Drawing.Color.White
        Me.Originallbl.Location = New System.Drawing.Point(562, 22)
        Me.Originallbl.Name = "Originallbl"
        Me.Originallbl.Size = New System.Drawing.Size(144, 35)
        Me.Originallbl.TabIndex = 10
        Me.Originallbl.Text = "ORIGINAL"
        Me.Originallbl.UseCompatibleTextRendering = True
        '
        'Searchbtn
        '
        Me.Searchbtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Font = New System.Drawing.Font("OCR A Extended", 16.2!)
        Me.Searchbtn.ForeColor = System.Drawing.Color.White
        Me.Searchbtn.Location = New System.Drawing.Point(562, 463)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(144, 41)
        Me.Searchbtn.TabIndex = 11
        Me.Searchbtn.Text = "SEARCH"
        Me.Searchbtn.UseVisualStyleBackColor = False
        '
        'Searchtxt
        '
        Me.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Searchtxt.Font = New System.Drawing.Font("OCR A Extended", 16.2!)
        Me.Searchtxt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Searchtxt.Location = New System.Drawing.Point(80, 469)
        Me.Searchtxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(460, 28)
        Me.Searchtxt.TabIndex = 12
        '
        'SFlbl
        '
        Me.SFlbl.AutoSize = True
        Me.SFlbl.Font = New System.Drawing.Font("OCR A Extended", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SFlbl.ForeColor = System.Drawing.Color.White
        Me.SFlbl.Location = New System.Drawing.Point(77, 508)
        Me.SFlbl.Name = "SFlbl"
        Me.SFlbl.Size = New System.Drawing.Size(463, 35)
        Me.SFlbl.TabIndex = 13
        Me.SFlbl.Text = "Use the standard form: xE+y"
        Me.SFlbl.UseCompatibleTextRendering = True
        '
        'TABLEfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(839, 561)
        Me.Controls.Add(Me.SFlbl)
        Me.Controls.Add(Me.Searchtxt)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Originallbl)
        Me.Controls.Add(Me.DescArrlbl)
        Me.Controls.Add(Me.AscArrlbl)
        Me.Controls.Add(Me.Sortlbl)
        Me.Controls.Add(Me.fxlbl)
        Me.Controls.Add(Me.xlbl)
        Me.Controls.Add(Me.xlistbox)
        Me.Controls.Add(Me.Contentslbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TABLEfrm"
        Me.Text = "TABLE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Contentslbl As Label
    Friend WithEvents xlistbox As ListBox
    Friend WithEvents xlbl As Label
    Friend WithEvents fxlbl As Label
    Friend WithEvents Sortlbl As Label
    Friend WithEvents AscArrlbl As Label
    Friend WithEvents DescArrlbl As Label
    Friend WithEvents Originallbl As Label
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Searchtxt As TextBox
    Friend WithEvents SFlbl As Label
End Class
