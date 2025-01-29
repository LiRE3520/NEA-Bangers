<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GRAPHINGfrm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GRAPHINGfrm))
        Me.Graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Tangentbtn = New System.Windows.Forms.Button()
        Me.Tangentupdown = New System.Windows.Forms.NumericUpDown()
        Me.Tangentxlbl = New System.Windows.Forms.Label()
        CType(Me.Graph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tangentupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Graph
        '
        ChartArea1.AxisY.ScaleBreakStyle.Spacing = 1.0R
        ChartArea1.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes
        ChartArea1.Name = "ChartArea1"
        Me.Graph.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Graph.Legends.Add(Legend1)
        Me.Graph.Location = New System.Drawing.Point(52, 41)
        Me.Graph.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Graph.Name = "Graph"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.LabelForeColor = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.Enabled = False
        Me.Graph.Series.Add(Series1)
        Me.Graph.Size = New System.Drawing.Size(779, 666)
        Me.Graph.TabIndex = 0
        Me.Graph.Text = "Chart1"
        '
        'Tangentbtn
        '
        Me.Tangentbtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.Tangentbtn.Font = New System.Drawing.Font("OCR A Extended", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tangentbtn.ForeColor = System.Drawing.Color.White
        Me.Tangentbtn.Location = New System.Drawing.Point(429, 720)
        Me.Tangentbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tangentbtn.Name = "Tangentbtn"
        Me.Tangentbtn.Size = New System.Drawing.Size(403, 96)
        Me.Tangentbtn.TabIndex = 1
        Me.Tangentbtn.Text = "DRAW TANGENT"
        Me.Tangentbtn.UseVisualStyleBackColor = False
        '
        'Tangentupdown
        '
        Me.Tangentupdown.BackColor = System.Drawing.Color.RoyalBlue
        Me.Tangentupdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tangentupdown.DecimalPlaces = 3
        Me.Tangentupdown.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tangentupdown.ForeColor = System.Drawing.Color.White
        Me.Tangentupdown.Location = New System.Drawing.Point(52, 767)
        Me.Tangentupdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tangentupdown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.Tangentupdown.Name = "Tangentupdown"
        Me.Tangentupdown.Size = New System.Drawing.Size(332, 49)
        Me.Tangentupdown.TabIndex = 54
        '
        'Tangentxlbl
        '
        Me.Tangentxlbl.AutoSize = True
        Me.Tangentxlbl.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tangentxlbl.ForeColor = System.Drawing.Color.White
        Me.Tangentxlbl.Location = New System.Drawing.Point(45, 720)
        Me.Tangentxlbl.Name = "Tangentxlbl"
        Me.Tangentxlbl.Size = New System.Drawing.Size(338, 32)
        Me.Tangentxlbl.TabIndex = 57
        Me.Tangentxlbl.Text = "Tangent (x) value:"
        '
        'GRAPHINGfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(891, 857)
        Me.Controls.Add(Me.Tangentxlbl)
        Me.Controls.Add(Me.Tangentupdown)
        Me.Controls.Add(Me.Tangentbtn)
        Me.Controls.Add(Me.Graph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GRAPHINGfrm"
        Me.Text = "GRAPH"
        CType(Me.Graph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tangentupdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Graph As DataVisualization.Charting.Chart
    Friend WithEvents Tangentbtn As Button
    Private WithEvents Tangentupdown As NumericUpDown
    Friend WithEvents Tangentxlbl As Label
End Class
