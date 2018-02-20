<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridMarkersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintoutScalingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TxtBoxTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMeasOD = New System.Windows.Forms.Label()
        Me.TxtBoxMeasOD = New System.Windows.Forms.TextBox()
        Me.LblPCD = New System.Windows.Forms.Label()
        Me.PlotGraph = New System.Windows.Forms.GroupBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.TxtBoxScale = New System.Windows.Forms.TextBox()
        Me.LblScale = New System.Windows.Forms.Label()
        Me.LblODTheo = New System.Windows.Forms.Label()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.LblCircThick = New System.Windows.Forms.Label()
        Me.LblTeethNo = New System.Windows.Forms.Label()
        Me.LblPA = New System.Windows.Forms.Label()
        Me.LblDp = New System.Windows.Forms.Label()
        Me.RButtonTooth = New System.Windows.Forms.RadioButton()
        Me.RButtonSpace = New System.Windows.Forms.RadioButton()
        Me.TxtBoxToothNo = New System.Windows.Forms.TextBox()
        Me.TxtBoxPA = New System.Windows.Forms.TextBox()
        Me.TxtBoxDepth = New System.Windows.Forms.TextBox()
        Me.TxtBoxCircThick = New System.Windows.Forms.TextBox()
        Me.TxtBoxODTheo = New System.Windows.Forms.TextBox()
        Me.TxtBoxPCD = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawGrid, Me.GridMarkersToolStripMenuItem, Me.PrintoutScalingToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'DrawGrid
        '
        Me.DrawGrid.Name = "DrawGrid"
        Me.DrawGrid.Size = New System.Drawing.Size(158, 22)
        Me.DrawGrid.Text = "Draw Grid"
        '
        'GridMarkersToolStripMenuItem
        '
        Me.GridMarkersToolStripMenuItem.Name = "GridMarkersToolStripMenuItem"
        Me.GridMarkersToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GridMarkersToolStripMenuItem.Text = "Grid Markers"
        '
        'PrintoutScalingToolStripMenuItem
        '
        Me.PrintoutScalingToolStripMenuItem.Name = "PrintoutScalingToolStripMenuItem"
        Me.PrintoutScalingToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.PrintoutScalingToolStripMenuItem.Text = "Printout Scaling"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.PrintToolStripMenuItem1.Text = "Print"
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Printer Setup"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSetupToolStripMenuItem, Me.PrintToolStripMenuItem1, Me.PageSetupToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'PrintDocument1
        '
        '
        'TxtBoxTitle
        '
        Me.TxtBoxTitle.Location = New System.Drawing.Point(167, 276)
        Me.TxtBoxTitle.Name = "TxtBoxTitle"
        Me.TxtBoxTitle.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxTitle.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Name or Reference Number"
        '
        'lblMeasOD
        '
        Me.lblMeasOD.AutoSize = True
        Me.lblMeasOD.Location = New System.Drawing.Point(89, 224)
        Me.lblMeasOD.Name = "lblMeasOD"
        Me.lblMeasOD.Size = New System.Drawing.Size(73, 13)
        Me.lblMeasOD.TabIndex = 80
        Me.lblMeasOD.Text = "Measured OD"
        '
        'TxtBoxMeasOD
        '
        Me.TxtBoxMeasOD.Location = New System.Drawing.Point(168, 221)
        Me.TxtBoxMeasOD.Name = "TxtBoxMeasOD"
        Me.TxtBoxMeasOD.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxMeasOD.TabIndex = 6
        '
        'LblPCD
        '
        Me.LblPCD.AutoSize = True
        Me.LblPCD.Location = New System.Drawing.Point(129, 96)
        Me.LblPCD.Name = "LblPCD"
        Me.LblPCD.Size = New System.Drawing.Size(29, 13)
        Me.LblPCD.TabIndex = 78
        Me.LblPCD.Text = "PCD"
        '
        'PlotGraph
        '
        Me.PlotGraph.Location = New System.Drawing.Point(380, 23)
        Me.PlotGraph.Name = "PlotGraph"
        Me.PlotGraph.Size = New System.Drawing.Size(513, 522)
        Me.PlotGraph.TabIndex = 76
        Me.PlotGraph.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(167, 316)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 23)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "CALCULATE"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'TxtBoxScale
        '
        Me.TxtBoxScale.Location = New System.Drawing.Point(168, 247)
        Me.TxtBoxScale.Name = "TxtBoxScale"
        Me.TxtBoxScale.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxScale.TabIndex = 8
        '
        'LblScale
        '
        Me.LblScale.AutoSize = True
        Me.LblScale.Location = New System.Drawing.Point(129, 250)
        Me.LblScale.Name = "LblScale"
        Me.LblScale.Size = New System.Drawing.Size(34, 13)
        Me.LblScale.TabIndex = 74
        Me.LblScale.Text = "Scale"
        '
        'LblODTheo
        '
        Me.LblODTheo.AutoSize = True
        Me.LblODTheo.Location = New System.Drawing.Point(112, 200)
        Me.LblODTheo.Name = "LblODTheo"
        Me.LblODTheo.Size = New System.Drawing.Size(51, 13)
        Me.LblODTheo.TabIndex = 72
        Me.LblODTheo.Text = "OD Theo"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HowToRunToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HowToRunToolStripMenuItem
        '
        Me.HowToRunToolStripMenuItem.Name = "HowToRunToolStripMenuItem"
        Me.HowToRunToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HowToRunToolStripMenuItem.Text = "How to Run"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(42, 381)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(318, 134)
        Me.ListBox1.TabIndex = 77
        Me.ListBox1.Visible = False
        '
        'lblDepth
        '
        Me.lblDepth.AutoSize = True
        Me.lblDepth.Location = New System.Drawing.Point(126, 174)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(36, 13)
        Me.lblDepth.TabIndex = 71
        Me.lblDepth.Text = "Depth"
        '
        'LblCircThick
        '
        Me.LblCircThick.AutoSize = True
        Me.LblCircThick.Location = New System.Drawing.Point(64, 148)
        Me.LblCircThick.Name = "LblCircThick"
        Me.LblCircThick.Size = New System.Drawing.Size(94, 13)
        Me.LblCircThick.TabIndex = 70
        Me.LblCircThick.Text = "Circular Thickness"
        '
        'LblTeethNo
        '
        Me.LblTeethNo.AutoSize = True
        Me.LblTeethNo.Location = New System.Drawing.Point(75, 70)
        Me.LblTeethNo.Name = "LblTeethNo"
        Me.LblTeethNo.Size = New System.Drawing.Size(83, 13)
        Me.LblTeethNo.TabIndex = 69
        Me.LblTeethNo.Text = "Number of teeth"
        '
        'LblPA
        '
        Me.LblPA.AutoSize = True
        Me.LblPA.Location = New System.Drawing.Point(41, 122)
        Me.LblPA.Name = "LblPA"
        Me.LblPA.Size = New System.Drawing.Size(121, 13)
        Me.LblPA.TabIndex = 68
        Me.LblPA.Text = "Pressure Angle at P.C.D"
        '
        'LblDp
        '
        Me.LblDp.AutoSize = True
        Me.LblDp.Location = New System.Drawing.Point(47, 427)
        Me.LblDp.Name = "LblDp"
        Me.LblDp.Size = New System.Drawing.Size(78, 13)
        Me.LblDp.TabIndex = 67
        Me.LblDp.Text = "Diametric Pitch"
        Me.LblDp.Visible = False
        '
        'RButtonTooth
        '
        Me.RButtonTooth.AutoSize = True
        Me.RButtonTooth.Checked = True
        Me.RButtonTooth.Location = New System.Drawing.Point(87, 44)
        Me.RButtonTooth.Name = "RButtonTooth"
        Me.RButtonTooth.Size = New System.Drawing.Size(87, 17)
        Me.RButtonTooth.TabIndex = 11
        Me.RButtonTooth.TabStop = True
        Me.RButtonTooth.Text = "Tooth Shape"
        Me.RButtonTooth.UseVisualStyleBackColor = True
        '
        'RButtonSpace
        '
        Me.RButtonSpace.AutoSize = True
        Me.RButtonSpace.Location = New System.Drawing.Point(178, 44)
        Me.RButtonSpace.Name = "RButtonSpace"
        Me.RButtonSpace.Size = New System.Drawing.Size(90, 17)
        Me.RButtonSpace.TabIndex = 12
        Me.RButtonSpace.Text = "Space Shape"
        Me.RButtonSpace.UseVisualStyleBackColor = True
        '
        'TxtBoxToothNo
        '
        Me.TxtBoxToothNo.Location = New System.Drawing.Point(168, 67)
        Me.TxtBoxToothNo.Name = "TxtBoxToothNo"
        Me.TxtBoxToothNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxToothNo.TabIndex = 0
        '
        'TxtBoxPA
        '
        Me.TxtBoxPA.Location = New System.Drawing.Point(168, 119)
        Me.TxtBoxPA.Name = "TxtBoxPA"
        Me.TxtBoxPA.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxPA.TabIndex = 2
        '
        'TxtBoxDepth
        '
        Me.TxtBoxDepth.Location = New System.Drawing.Point(168, 171)
        Me.TxtBoxDepth.Name = "TxtBoxDepth"
        Me.TxtBoxDepth.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxDepth.TabIndex = 4
        '
        'TxtBoxCircThick
        '
        Me.TxtBoxCircThick.Location = New System.Drawing.Point(167, 145)
        Me.TxtBoxCircThick.Name = "TxtBoxCircThick"
        Me.TxtBoxCircThick.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxCircThick.TabIndex = 3
        '
        'TxtBoxODTheo
        '
        Me.TxtBoxODTheo.Location = New System.Drawing.Point(168, 197)
        Me.TxtBoxODTheo.Name = "TxtBoxODTheo"
        Me.TxtBoxODTheo.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxODTheo.TabIndex = 5
        '
        'TxtBoxPCD
        '
        Me.TxtBoxPCD.Location = New System.Drawing.Point(168, 93)
        Me.TxtBoxPCD.Name = "TxtBoxPCD"
        Me.TxtBoxPCD.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxPCD.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.InchesToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1202, 24)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InchesToolStripMenuItem
        '
        Me.InchesToolStripMenuItem.Name = "InchesToolStripMenuItem"
        Me.InchesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.InchesToolStripMenuItem.Text = "Inches"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 639)
        Me.Controls.Add(Me.TxtBoxTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMeasOD)
        Me.Controls.Add(Me.TxtBoxMeasOD)
        Me.Controls.Add(Me.LblPCD)
        Me.Controls.Add(Me.PlotGraph)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.TxtBoxScale)
        Me.Controls.Add(Me.LblScale)
        Me.Controls.Add(Me.LblODTheo)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblDepth)
        Me.Controls.Add(Me.LblCircThick)
        Me.Controls.Add(Me.LblTeethNo)
        Me.Controls.Add(Me.LblPA)
        Me.Controls.Add(Me.LblDp)
        Me.Controls.Add(Me.RButtonTooth)
        Me.Controls.Add(Me.RButtonSpace)
        Me.Controls.Add(Me.TxtBoxToothNo)
        Me.Controls.Add(Me.TxtBoxPA)
        Me.Controls.Add(Me.TxtBoxDepth)
        Me.Controls.Add(Me.TxtBoxCircThick)
        Me.Controls.Add(Me.TxtBoxODTheo)
        Me.Controls.Add(Me.TxtBoxPCD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Involute Inspection"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawGrid As ToolStripMenuItem
    Friend WithEvents GridMarkersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrintSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TxtBoxTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMeasOD As Label
    Friend WithEvents TxtBoxMeasOD As TextBox
    Friend WithEvents LblPCD As Label
    Friend WithEvents PlotGraph As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents TxtBoxScale As TextBox
    Friend WithEvents LblScale As Label
    Friend WithEvents LblODTheo As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToRunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblDepth As Label
    Friend WithEvents LblCircThick As Label
    Friend WithEvents LblTeethNo As Label
    Friend WithEvents LblPA As Label
    Friend WithEvents LblDp As Label
    Friend WithEvents RButtonTooth As RadioButton
    Friend WithEvents RButtonSpace As RadioButton
    Friend WithEvents TxtBoxToothNo As TextBox
    Friend WithEvents TxtBoxPA As TextBox
    Friend WithEvents TxtBoxDepth As TextBox
    Friend WithEvents TxtBoxCircThick As TextBox
    Friend WithEvents TxtBoxODTheo As TextBox
    Friend WithEvents TxtBoxPCD As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InchesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintoutScalingToolStripMenuItem As ToolStripMenuItem
End Class
