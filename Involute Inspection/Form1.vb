Option Strict Off

Imports System
Imports System.IO
Imports System.Math
Imports System.Text
Imports System.Collections
Imports System.Ncalc
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Graphics

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim ShapeType, newprintname As String
    Dim NewDia, Difference, Increment, Ht, x1d, y1d, x2d, y2d, Mm, DrawScale, Convert2 As Double
    Dim NewThickness, NewAng, CordThick As Double
    Dim PCD, PCR, BCD, CircPitch, SpaceThick, DiaDiv, Formula1, Formula2, Formula3, Formula4, Formula5, Formula6, Formula7, New_Pa, New_PaR, ConvertImpMet, ConvertRad, ConvertDeg As Double
    Dim CoordQuant, mark, mark2, ArrayIndex, CC, Gridvis As Integer
    Dim dX, dY As Single
    Dim GridX1, GridX2, GridY1, GridY2 As Single
    Dim DotCounter As Integer
    Dim BoxWidth, BoxHeight As Single
    Dim MyGraphics, xCoord(25), yCoord(25) As Object
    Dim inputTitle As Object
    Dim titleFont As New Font("Calibri", 26, FontStyle.Underline)
    Dim depth As Double
    Dim drawFont As New Font("Arial", 10)
    Dim skyBluePen As New Pen(Brushes.DeepSkyBlue, 1)
    Dim bigPen As New Pen(Brushes.Red)
    Dim ps As New PaperSize("A3", 1169, 1654)
    Dim ds As New PaperSize("A4", 584.5, 1169)
    Dim gridPen As New Pen(Brushes.Black, 1 / 96)
    Dim blackPen As New Pen(Brushes.Black, 0.5)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim drawBrush2 As New SolidBrush(Color.Red)
    Dim x1, y1, x2, y2, gpxleng, gpxhei As Single
    Public Shared Pen1 As New Pen(Color.Black, 1 / 96)
    Dim dg, gm As String
    Dim InputDp, InputPa, InputTeethNo, InputToothThick, InputPaR, MajorDia, MinorDia, MajorRad, MinorRad, Yy, Yy1, Ho, ScaleSize, Dpm, Dpi, PrintAdjX, PrintAdjY As Double
    Dim orientation As Integer
    Dim pageSize As PaperSize
    Dim ODTheo, MeasOD, CircThick, NewThickness2, PA, DP As Double
    Dim lines() As String = {"First line", "Second line", "Third line"}
    ' Set a variable to the My Documents path.
    Dim mydocpath As String = "C:\Users\tom.stanger\source\repos\Involute Inspection\Involute Inspection\bin\Debug\"
    Dim prompt As String = String.Empty
    Dim title As String = String.Empty
    Dim defaultResponse As String = String.Empty


    ' Write the string array to a new file named "WriteLines.txt".
    Private Sub OutputIn8000()

        ' MsgBox("Triggered subroutine 8000")
        My.Computer.FileSystem.DeleteFile("PrintScaling8000.txt")
        My.Computer.FileSystem.WriteAllText("PrintScaling8000.txt", PrintAdjX, True)
        My.Computer.FileSystem.WriteAllText("PrintScaling8000.txt", "
", True)

        My.Computer.FileSystem.WriteAllText("PrintScaling8000.txt", PrintAdjY, True)
        '    Next
        'End Using
    End Sub

    Private Sub OutputIn2050()

        'MsgBox("Triggered subroutine 2050")
        My.Computer.FileSystem.DeleteFile("PrintScaling2050.txt")
        My.Computer.FileSystem.WriteAllText("PrintScaling2050.txt", PrintAdjX, True)
        My.Computer.FileSystem.WriteAllText("PrintScaling2050.txt", "
", True)

        My.Computer.FileSystem.WriteAllText("PrintScaling2050.txt", PrintAdjY, True)
        '    Next
        'End Using
    End Sub


    Private Sub OutputInNEW()

        ' MsgBox("Triggered subroutine NEW")
        My.Computer.FileSystem.DeleteFile("PrintScalingNEW.txt")
        My.Computer.FileSystem.WriteAllText("PrintScalingNEW.txt", PrintAdjX, True)
        My.Computer.FileSystem.WriteAllText("PrintScalingNEW.txt", "
", True)

        My.Computer.FileSystem.WriteAllText("PrintScalingNEW.txt", PrintAdjY, True)
        '    Next
        'End Using
    End Sub


    Private Sub PrintoutScalingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintoutScalingToolStripMenuItem.Click
        PrintAdjX = InputBox("The current value is " & PrintAdjX & ". What do you want to change the X value to?", "Printout Scaling", PrintAdjX)
        PrintAdjY = InputBox("The current value is " & PrintAdjY & ". What do you want to change the Y value to?", "Printout Scaling", PrintAdjY)
        If PrintDocument1.PrinterSettings.PrinterName = "HP LaserJet 8000 Series PCL6" Then
            OutputIn8000()
        ElseIf PrintDocument1.PrinterSettings.PrinterName = "HP LaserJet 2050 Series PCL6" Then
            OutputIn2050()
        Else newprintname = InputBox("The default printer is not currently defined yet. Please input the new printer name")
            OutputInNEW()
        End If

    End Sub
    Private Sub HowToRunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToRunToolStripMenuItem.Click
        MsgBox("To run this program, fill In all Of the input boxes With the exact details. Once finished, Click run. You can choose whether you want to add a grid And CM interval markers onto the paper before printing.")
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This program Is used to draw the tooth Or space shape of an involute form. It can draw this onto A4 / A3 paper for easy use.")
    End Sub

    Private Sub TxtBoxPCD_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPCD.TextChanged
        PCD = TxtBoxPCD.Text
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem1.Click

        If PageSetupDialog1.PageSettings.Landscape = True Then
            PrintDocument1.DefaultPageSettings.Landscape = True
            orientation = 1
        Else
            PrintDocument1.DefaultPageSettings.Landscape = False
            orientation = 0
        End If

        ' Access of shared member, constant member, enum member or nested type through an instance
        '        If PageSetupDialog1.PageSettings.PaperSize.Kind.A3 Then
        '#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        '            MsgBox("A3 was selected")
        '            ' PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("A3 tom", 3508, 4961)
        '            PrintDocument1.DefaultPageSettings.PaperSize = PageSetupDialog1.PageSettings.PaperSize
        '        End If

        'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 8

        'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 8
        'PrintDocument1.DefaultPageSettings.PaperSize = PageSetupDialog1.PageSettings.PaperSize
        'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = PaperKind.A3
        'PageSetupDialog1.PageSettings.PaperSize.RawKind = PaperKind.A3

        'PrintDocument1.DefaultPageSettings.PaperSize = PageSetupDialog1.PageSettings.PaperSize

        'PrintDocument1.DefaultPageSettings.PaperSource.RawKind = 3
        PrintDocument1.Print()
    End Sub

    Public Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Draw a translation taking into account dimensions of the paper
        e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Dim paperwidth, paperheight As Single


        paperwidth = PrintDocument1.DefaultPageSettings.PaperSize.Width
        paperwidth = paperwidth / 100 * 25.4
        paperheight = PrintDocument1.DefaultPageSettings.PaperSize.Height
        paperheight = paperheight / 100 * 25.4
        Debug.WriteLine(paperwidth)
        Debug.WriteLine(paperheight)
        Dpi = e.Graphics.DpiX
        Dpm = Dpi / Mm



        If orientation = 1 Then

            e.Graphics.TranslateTransform(paperheight / 2, paperwidth / 2)
            e.Graphics.DrawString(inputTitle, titleFont, drawBrush, -paperheight / 2, -paperwidth / 2 + 5)
            e.Graphics.DrawString("Scale = ", drawFont, drawBrush, -paperheight / 2, paperwidth / 2 - 15)
            e.Graphics.DrawString(ScaleSize & " times", drawFont, drawBrush, -paperheight / 2 + 15, paperwidth / 2 - 15)
            e.Graphics.DrawString("Major Diameter Is " & MajorDia, drawFont, drawBrush, -paperheight / 2, paperwidth / 2 - 25)
            e.Graphics.DrawString("Minor Diameter Is " & MinorDia, drawFont, drawBrush, -paperheight / 2, paperwidth / 2 - 20)
        Else

            e.Graphics.TranslateTransform(paperwidth / 2, paperheight / 2)
            e.Graphics.DrawString(inputTitle, titleFont, drawBrush, -paperwidth / 2, -paperheight / 2)
            e.Graphics.DrawString("Scale = ", drawFont, drawBrush, -paperwidth / 2, paperheight / 2 - 15)
            e.Graphics.DrawString(ScaleSize & " times", drawFont, drawBrush, -paperwidth / 2 + 15, paperheight / 2 - 15)
            e.Graphics.DrawString("Major Diameter Is " & MajorDia, drawFont, drawBrush, -paperwidth / 2, paperheight / 2 - 25)
            e.Graphics.DrawString("Minor Diameter Is " & MinorDia, drawFont, drawBrush, -paperwidth / 2, paperheight / 2 - 20)
        End If

        PlaceGrid(e.Graphics)
        GridMarkers(e.Graphics)
        'e.Graphics.TranslateTransform(-BoxWidth / Dpm / 2, -BoxHeight / Dpm / 2)

        e.Graphics.TranslateTransform(0, (MajorDia * Mm / 2 + MinorDia * Mm / 2) / 2 * ScaleSize)
        '' e.Graphics.ScaleTransform(sx:=ScaleSize, sy:=ScaleSize)
        DrawScale = ScaleSize
        PlotGraphics(e.Graphics)
        PrintCheck()
        'e.Graphics.TranslateTransform(-BoxWidth / Dpm / 2, -(BoxHeight / Dpm / 2 + (MajorDia * Mm / 2 + MinorDia * Mm / 2) / 2 * DrawScale))


    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click

        'PageSetupDialog1.PageSettings =
        ' New System.Drawing.Printing.PageSettings
        ' PageSetupDialog1.ShowDialog()

        PageSetupDialog1.PrinterSettings =
            New System.Drawing.Printing.PrinterSettings
        PageSetupDialog1.ShowNetwork = False
        PageSetupDialog1.PrinterSettings.DefaultPageSettings.Landscape = True

        Dim result As DialogResult = PageSetupDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            Dim results() As Object = New Object() _
                {PageSetupDialog1.PageSettings.Margins,
                 PageSetupDialog1.PageSettings.PaperSize,
                 PageSetupDialog1.PageSettings.Landscape,
            PageSetupDialog1.PrinterSettings.PrinterName,
                 PageSetupDialog1.PrinterSettings.PrintRange}
            ListBox1.Items.AddRange(results)
        End If

    End Sub


    Private Sub InchesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InchesToolStripMenuItem.Click

        'Swapped MM to inches around and vice versa
        If Convert2 = 25.4 Then
            InchesToolStripMenuItem.Text = "Inches"
            TxtBoxCircThick.Text = Val(TxtBoxCircThick.Text) / Convert2
            TxtBoxODTheo.Text = Val(TxtBoxODTheo.Text) / Convert2
            TxtBoxDepth.Text = Val(TxtBoxDepth.Text) / Convert2

            Convert2 = 1

        Else
            InchesToolStripMenuItem.Text = "MM"
            Convert2 = 25.4
            ' MsgBox(mmininch)
            TxtBoxCircThick.Text = Val(TxtBoxCircThick.Text) * Convert2
            TxtBoxODTheo.Text = Val(TxtBoxODTheo.Text) * Convert2
            TxtBoxDepth.Text = Val(TxtBoxDepth.Text) * Convert2
        End If
    End Sub

    Private Sub PrintSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSetupToolStripMenuItem.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub TxtBoxCircThick_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxCircThick.LostFocus
        CircThick = Val(TxtBoxCircThick.Text)
    End Sub
    Private Sub TxtBoxTitle_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxTitle.TextChanged
        inputTitle = TxtBoxTitle.Text
    End Sub

    Public Sub FormPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim PrintGraphics As Graphics = Me.CreateGraphics
    End Sub
    Private Sub TxtBoxDepth_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxDepth.TextChanged
        depth = Val(TxtBoxDepth.Text)
    End Sub
    Public Shared Function Inv(ByVal Ang As Double) As Double
        Inv = Tan(Ang) - Ang
        Return Inv
    End Function

    Private Sub TxtBoxMinorDia_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxODTheo.LostFocus
        ODTheo = Val(TxtBoxODTheo.Text)
        ' MinorRad = MinorDia / 2
    End Sub

    Private Sub RButtonSpace_CheckedChanged(sender As Object, e As EventArgs) Handles RButtonSpace.CheckedChanged
        ShapeType = "Space"
    End Sub

    Private Sub RButtonTooth_CheckedChanged(sender As Object, e As EventArgs) Handles RButtonTooth.CheckedChanged
        ShapeType = "Tooth"
    End Sub

    Private Sub TxtBoxPA_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxPA.LostFocus
        InputPa = Val(TxtBoxPA.Text)
        InputPaR = InputPa * PI / 180
    End Sub
    Private Sub LostFocus(sender As Object, e As EventArgs) Handles TxtBoxMeasOD.LostFocus
        MeasOD = Val(TxtBoxMeasOD.Text)
    End Sub
    Private Sub TxtBoxToothNo_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxToothNo.LostFocus
        InputTeethNo = Val(TxtBoxToothNo.Text)
    End Sub

    Private Sub TxtBoxCoordNo_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxCoordNo.LostFocus
        CoordQuant = Val(TxtBoxCoordNo.Text)
    End Sub

    Private Sub TxtBoxScale_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxScale.LostFocus
        ScaleSize = Val(TxtBoxScale.Text)
        'MsgBox(ScaleSize)
    End Sub
    Private Sub DrawGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawGrid.Click

        If dg = "NO" Then
            DrawGrid.Text = "Remove Grid"
            dg = "YES"
            PlotGraph.Invalidate()
        ElseIf dg = "YES" Then
            dg = "NO"
            DrawGrid.Text = "Draw Grid"
            PlotGraph.Invalidate()
        End If

    End Sub
    Private Sub GridMarkersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridMarkersToolStripMenuItem.Click
        If gm = "NO" Then
            GridMarkersToolStripMenuItem.Text = "Remove Markers"
            gm = "YES"
            PlotGraph.Invalidate()
        ElseIf gm = "YES" Then
            gm = "NO"
            GridMarkersToolStripMenuItem.Text = "Grid Markers"
            PlotGraph.Invalidate()
        End If

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        InputDp = InputTeethNo / PCD
        InputToothThick = CircThick + Tan(InputPaR) * (MeasOD - ODTheo)
        MajorDia = MeasOD
        MinorDia = MeasOD - 2 * depth



        'PCD = InputTeethNo / InputDp
        PCR = PCD / 2
        BCD = PCD * Cos(InputPaR)
        Debug.WriteLine("There")
        CircPitch = PI / InputDp
        SpaceThick = CircPitch - InputToothThick
        DiaDiv = (PCD - MinorDia)

        'Mm = 25.4
        If MinorDia > BCD Then
            NewDia = MinorDia
        Else
            NewDia = BCD
        End If
        Difference = MajorDia - NewDia
        Increment = Difference / (CoordQuant - 1)
        For CC = 1 To CoordQuant

            New_PaR = Acos(PCD / 2 * Cos(InputPaR) / (NewDia / 2))
            If RButtonTooth.Checked Then
                NewThickness = NewDia * (InputToothThick / PCD + Inv(InputPaR) - Inv(New_PaR))
            Else
                NewThickness = PI / (InputTeethNo / NewDia) - NewDia * (InputToothThick / PCD + Inv(InputPaR) - Inv(New_PaR))
            End If
            NewAng = NewThickness / (NewDia / 2)
            CordThick = NewDia / 2 * Sin(NewAng / 2)
            Ht = NewDia / 2 * Cos(NewAng / 2)
            'xCoord(Cc).Add(CordThick)
            xCoord(CC) = Val(CordThick)
            yCoord(CC) = Val(Ht)
            Debug.WriteLine(CC)
            Debug.WriteLine(xCoord(CC))
            Debug.WriteLine(yCoord(CC))
            'Debug.WriteLine(Ht)
            'Debug.WriteLine(CordThick)
            Debug.WriteLine(NewDia)
            'Debug.WriteLine(New_PaR * 180 / PI)
            NewDia = NewDia + Increment

        Next
        PlotGraph.Invalidate()
    End Sub


    ' Private Sub btnDraw_Click(sender As Object, ByVal e As System.EventArgs) Handles btnDraw.Click
    Private Sub PlotGraph_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PlotGraph.Paint
        Dim PlotGraphGraphics As Graphics = PlotGraph.CreateGraphics
        PlotGraphGraphics.PageUnit = GraphicsUnit.Millimeter
        BoxWidth = PlotGraph.Width
        BoxHeight = PlotGraph.Height
        Dpi = PlotGraphGraphics.DpiX
        Dpm = Dpi / Mm
        SetPlotScale(BoxWidth / Dpm, BoxHeight / Dpm)

        PlotGraphGraphics.TranslateTransform(BoxWidth / Dpm / 2, BoxHeight / Dpm / 2)

        PlaceGrid(PlotGraphGraphics)
        GridMarkers(PlotGraphGraphics)
        PlotGraphGraphics.TranslateTransform(-BoxWidth / Dpm / 2, -BoxHeight / Dpm / 2)
        PlotGraphGraphics.TranslateTransform(BoxWidth / Dpm / 2, BoxHeight / Dpm / 2 + (MajorDia * Mm / 2 + MinorDia * Mm / 2) / 2 * DrawScale)
        PlotGraphics(PlotGraphGraphics)
        PlotGraphGraphics.TranslateTransform(-BoxWidth / Dpm / 2, -(BoxHeight / Dpm / 2 + (MajorDia * Mm / 2 + MinorDia * Mm / 2) / 2 * DrawScale))

    End Sub

    Sub PlotGraphics(ByVal MyGraphics As Graphics)
        Dim newC As Integer
        Dim MajorDiaX, MajorDiaY, MinorDiaX, MinorDiaY As Single
        MajorDiaX = MajorDia * Mm * DrawScale * PrintAdjX
        MinorDiaX = MinorDia * Mm * DrawScale * PrintAdjX
        MajorDiaY = MajorDia * Mm * DrawScale * PrintAdjY
        MinorDiaY = MinorDia * Mm * DrawScale * PrintAdjY
        If CC = CoordQuant + 1 Then
            Debug.WriteLine("It's found the coords")

        Dim X1, Y1, X2, Y2 As Single
            newC = 1

            For newC = 1 To CoordQuant + 1
                If newC = CoordQuant Then
                    ' MsgBox("Its finished")
                ElseIf newC <> CoordQuant + 1 Then
                    '*Val(ScaleSize)
                    X1 = xCoord(newC) * Mm * DrawScale * PrintAdjX
                    Y1 = yCoord(newC) * Mm * DrawScale * PrintAdjY
                    X2 = xCoord(newC + 1) * Mm * DrawScale * PrintAdjX
                    Y2 = yCoord(newC + 1) * Mm * DrawScale * PrintAdjY
                    MyGraphics.DrawLine(Pen1, -X1, -Y1, -X2, -Y2)
                    MyGraphics.DrawLine(Pen1, +X1, -Y1, +X2, -Y2)
                    MyGraphics.DrawArc(Pen1, -MajorDiaX / 2, -MajorDiaY / 2, MajorDiaX, MajorDiaY, 180, 180)
                    MyGraphics.DrawArc(Pen1, -MinorDiaX / 2, -MinorDiaY / 2, MinorDiaX, MinorDiaY, 180, 180)
                    'Debug.WriteLine(newC)
                    'Debug.WriteLine(X1)
                    'Debug.WriteLine(X2)
                    'Debug.WriteLine(Y1)
                    'Debug.WriteLine(Y2)

                End If
            Next
        Else

        End If

    End Sub

    Sub PlaceGrid(ByVal MyGraphics As Graphics)

        GridX1 = 0
        GridX2 = PlotGraph.Width / Dpm * PrintAdjX
        GridY1 = 0
        GridY2 = PlotGraph.Height / Dpm * PrintAdjY
        'if dg = yes then draw grid and for each 10 mm in gridx2 drawstring
        If dg = "YES" Then
            MyGraphics.DrawLine(gridPen, -500, 0, 500, 0)
            MyGraphics.DrawLine(gridPen, 0, 500, 0, -500)
            'PlotGraphGraphics.DrawRectangle(gridPen, 0, 0, 1, 1)
            'PlotGraphGraphics.DrawRectangle(gridPen, 0, 0, -1, -1)
            gpxleng = GridX2
            gpxhei = GridY2

        End If
    End Sub


    Sub GridMarkers(ByVal MyGraphics As Graphics)
        ' Dim PlotGraphGraphics As Graphics = PlotGraph.CreateGraphics
        MyGraphics.PageUnit = GraphicsUnit.Millimeter
        SetPlotScale(BoxWidth / Dpm, BoxHeight / Dpm)
        ' PlotGraphGraphics.TranslateTransform(BoxWidth / Dpm / 2, BoxHeight / Dpm / 2)
        If gm = "YES" Then
            Dim MarkArray As Object
            Dim markArray2 As Object
            Dim Sfw, Fts As Single
            MarkArray = gpxleng
            markArray2 = gpxhei

            For MarkArray = -GridX2 To GridX2
                MyGraphics.DrawLine(gridPen, Sfw, -3, Sfw, 3)
                MyGraphics.DrawLine(gridPen, -Sfw, -3, -Sfw, 3)
                Sfw = Sfw + 10 * PrintAdjX
            Next

            For markArray2 = -GridY2 To GridY2
                MyGraphics.DrawLine(gridPen, -3, Fts, 3, Fts)
                MyGraphics.DrawLine(gridPen, -3, -Fts, 3, -Fts)
                Fts = Fts + 10 * PrintAdjY
            Next
        End If

    End Sub

    Sub SetPlotScale(ScaleWidth As Single, ScaleHeight As Single)
        Dim Yscale, Xscale As Double
        Xscale = ScaleWidth * 0.9 / (xCoord(1) * Mm * 2)
        Yscale = ScaleHeight * 0.9 / (MajorDia * Mm / 2 - MinorDia * Mm / 2)
        DrawScale = Min(Xscale, Yscale)
        'DrawScale = 1
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(PrintDocument1.PrinterSettings.PrinterName)
        ' PageSetupDialog1.PageSettings.PaperSize = ps
        Convert2 = 1
        Mm = 25.4
        Gridvis = 1
        dg = "NO"
        gm = "NO"
        mark = 0
        mark2 = 0
        'PrintAdjX = 0.995
        'PrintAdjY = 1.0015
        PrintDocument1.DefaultPageSettings.Landscape = True
        ' PrintDocument1.DefaultPageSettings.PaperSize = PageSetupDialog1.PageSettings.PaperSize
        PrintDocument1.DefaultPageSettings.PaperSize = PageSetupDialog1.PageSettings.PaperSize

        If PrintDocument1.PrinterSettings.PrinterName = "HP LaserJet 8000 Series PCL6" Then
            Using outputFile As New StreamReader(mydocpath & Convert.ToString("PrintScaling8000.txt"))
                Dim readX As String = outputFile.ReadLine
                Dim readY As String = outputFile.ReadLine

                PrintAdjX = readX
                PrintAdjY = readY
            End Using
        ElseIf PrintDocument1.PrinterSettings.PrinterName = "HP LaserJet 2050 Series PCL6" Then
            Using outputFile As New StreamReader(mydocpath & Convert.ToString("PrintScaling2050.txt"))
                Dim readX As String = outputFile.ReadLine
                Dim readY As String = outputFile.ReadLine

                PrintAdjX = readX
                PrintAdjY = readY
            End Using
        Else PrintDocument1.PrinterSettings.PrinterName = newprintname
            OutputInNEW()
            Using outputFile As New StreamReader(mydocpath & Convert.ToString("PrintScalingNEW.txt"))
                Dim readX As String = outputFile.ReadLine
                Dim readY As String = outputFile.ReadLine

                PrintAdjX = readX
                PrintAdjY = readY
            End Using

        End If
        'PrintAdjY = readPrintAdjY
        'Dim fileReader, fileReader2 As String
        '        fileReader = My.Computer.FileSystem.ReadAllText("PrintScaling.txt")
        'Dim readPrintAdjX As String = fileReader.Substring(0, 5)
        'Dim readPrintAdjY As String = fileReader.Substring(fileReader.Length - 7, 7)
        'PrintAdjX = readPrintAdjX
        'PrintAdjY = readPrintAdjY
        'MsgBox(readPrintAdjX)
        'MsgBox(readPrintAdjY)
        ' MsgBox(fileReader)

    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd
        Dim FormWidth, FormHeight As Integer
        FormWidth = Me.Width
        FormHeight = Me.Height
        PlotGraph.Width = FormWidth - 500
        PlotGraph.Height = FormHeight - 200
        Me.Invalidate()
    End Sub

    Sub PrintCheck()
        'ADD ADJX & ADJY AS NECESSARY
        If PrintDocument1.PrinterSettings.PrinterName = "HP LaserJet 8000 Series PCL6" Then
            PageSetupDialog1.PageSettings.PaperSize = ps
            PrintDocument1.DefaultPageSettings.PaperSize = ps
            ' MsgBox("Its found 8000 as default")

        Else
            PageSetupDialog1.PageSettings.PaperSize = ds
            PrintDocument1.DefaultPageSettings.PaperSize = ds
        End If
    End Sub


End Class
