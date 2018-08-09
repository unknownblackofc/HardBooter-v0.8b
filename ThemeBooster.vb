﻿Imports System, System.IO, System.Collections.Generic
Imports System.Drawing, System.Drawing.Drawing2D
Imports System.ComponentModel, System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterTheme
    Inherits ThemeContainer154
    Sub New()
        TransparencyKey = Color.Fuchsia
        BackColor = Color.FromArgb(51, 51, 51)
        Header = 25
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(51, 51, 51))
        DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(65, 65, 65), 0, 28, Width, (Height \ 2) - 10)
        DrawGradient(Color.FromArgb(87, 87, 87), Color.FromArgb(49, 49, 49), 0, 0, Width, 25)
        G.DrawLine(Pens.Black, 0, 25, Width, 25)

        G.DrawLine(New Pen(Color.FromArgb(192, 74, 74)), 0, 26, Width, 26)
        G.FillRectangle(New SolidBrush(Color.FromArgb(169, 0, 0)), 0, 27, Width, 27)
        G.FillRectangle(New SolidBrush(Color.FromArgb(45, Color.White)), 0, 27, Width, 13)

        G.DrawLine(New Pen(Color.FromArgb(38, 38, 38)), 0, Height - 25, Width, Height - 25)
        G.DrawLine(New Pen(Color.FromArgb(64, 64, 64)), 0, Height - 24, Width, Height - 24)

        DrawBorders(Pens.Black)
        DrawBorders(New Pen(Color.FromArgb(92, 92, 92)), 1)

        DrawCorners(Color.Fuchsia)
        DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 1)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterTopButton
    Inherits ThemeControl154
    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()

        DrawGradient(Color.FromArgb(141, 141, 141), Color.FromArgb(23, 23, 23), 0, 0, Width, Height, 45)
        DrawBorders(New Pen(Color.FromArgb(41, 41, 41)), 0)
        DrawBorders(New Pen(Color.FromArgb(41, 41, 41)), 1)
        DrawBorders(Pens.Black, 2)
        G.DrawLine(New Pen(Color.FromArgb(100, 100, 100)), 0, Height - 1, Width, Height - 1)
        DrawGradient(Color.FromArgb(41, 41, 41), Color.FromArgb(100, 100, 100), 0, 0, 1, Height)
        DrawGradient(Color.FromArgb(41, 41, 41), Color.FromArgb(100, 100, 100), Width - 1, 0, Width, Height)
        DrawCorners(BackColor)
        DrawCorners(Color.FromArgb(41, 41, 41), 2)

        If State = MouseState.Over Then
            DrawGradient(Color.FromArgb(255, 255, 255), Color.FromArgb(23, 23, 23), 0, 0, Width, Height, 45)
            DrawBorders(New Pen(Color.FromArgb(41, 41, 41)), 0)
            DrawBorders(New Pen(Color.FromArgb(41, 41, 41)), 1)
            DrawBorders(Pens.Black, 2)
            G.DrawLine(New Pen(Color.FromArgb(100, 100, 100)), 0, Height - 1, Width, Height - 1)
            DrawGradient(Color.FromArgb(41, 41, 41), Color.FromArgb(100, 100, 100), 0, 0, 1, Height)
            DrawGradient(Color.FromArgb(41, 41, 41), Color.FromArgb(100, 100, 100), Width - 1, 0, Width, Height)
            DrawCorners(BackColor)
            DrawCorners(Color.FromArgb(41, 41, 41), 2)
        ElseIf State = MouseState.Down Then
            DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(23, 23, 23), 0, 0, Width, Height, 45)
            DrawBorders(New Pen(Color.FromArgb(41, 41, 41)), 0)
            DrawBorders(New Pen(Color.FromArgb(41, 41, 41)), 1)
            DrawBorders(Pens.Black, 2)
            G.DrawLine(New Pen(Color.FromArgb(100, 100, 100)), 0, Height - 1, Width, Height - 1)
            DrawGradient(Color.FromArgb(41, 41, 41), Color.FromArgb(100, 100, 100), 0, 0, 1, Height)
            DrawGradient(Color.FromArgb(41, 41, 41), Color.FromArgb(100, 100, 100), Width - 1, 0, Width, Height)
            DrawCorners(BackColor)
            DrawCorners(Color.FromArgb(41, 41, 41), 2)
        Else
        End If
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterButton
    Inherits ThemeControl154
    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub

    Property ArrowColour As Color

    Property BorderColour As Color

    Property HoverColour As Color

    Property PressedColour As Color

    Property ArrowBorderColour As Color

    Property ArcColour As Color

    Property NormalColour As Color

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()

        DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(95, 0, 0), 0, 2, Width \ 2, Height \ 2, 45)
        DrawGradient(Color.FromArgb(95, 0, 0), Color.FromArgb(0, 0, 0), Width \ 2, 2, Width - 15, Height \ 2, -45)
        DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(95, 0, 0), 0, Height \ 2, Width \ 2, Height, 45)
        DrawGradient(Color.FromArgb(95, 0, 0), Color.FromArgb(0, 0, 0), Width \ 2, Height \ 2, Width, Height \ 2, 315)


        DrawBorders(Pens.Black, 0)
        DrawBorders(Pens.Black, 1)
        DrawBorders(New Pen(Color.FromArgb(95, 0, 0)), 3)
        G.DrawLine(New Pen(Color.FromArgb(93, 93, 93)), 3, 3, Width - 5, 3)
        G.DrawLine(New Pen(Color.FromArgb(73, 73, 73)), 0, Height - 1, Width, Height - 1)
        DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(73, 73, 73), 0, 0, 1, Height)
        DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(73, 73, 73), Width - 1, 0, 1, Height)

        If State = MouseState.Over Then
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(95, 0, 0), 0, 2, Width \ 2, Height \ 2, 45)
            DrawGradient(Color.FromArgb(95, 0, 0), Color.FromArgb(0, 0, 0), Width \ 2, 2, Width - 15, Height \ 2, -45)
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(95, 0, 0), 0, Height \ 2, Width \ 2, Height, 45)
            DrawGradient(Color.FromArgb(95, 0, 0), Color.FromArgb(0, 0, 0), Width \ 2, Height \ 2, Width, Height \ 2, 315)
            G.FillRectangle(New SolidBrush(Color.FromArgb(13, Color.White)), 0, 0, Width, (Height \ 2) - 7)
            DrawBorders(Pens.Black, 0)
            DrawBorders(Pens.Black, 1)
            DrawBorders(New Pen(Color.FromArgb(95, 0, 0)), 3)
            G.DrawLine(New Pen(Color.FromArgb(93, 93, 93)), 3, 3, Width - 5, 3)
            G.DrawLine(New Pen(Color.FromArgb(73, 73, 73)), 0, Height - 1, Width, Height - 1)
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(73, 73, 73), 0, 0, 1, Height)
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(73, 73, 73), Width - 1, 0, 1, Height)
        ElseIf State = MouseState.Down Then
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(95, 0, 0), 0, 2, Width \ 2, Height \ 2, 45)
            DrawGradient(Color.FromArgb(95, 0, 0), Color.FromArgb(0, 0, 0), Width \ 2, 2, Width - 15, Height \ 2, -45)
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(95, 0, 0), 0, Height \ 2, Width \ 2, Height, 45)
            DrawGradient(Color.FromArgb(95, 0, 0), Color.FromArgb(0, 0, 0), Width \ 2, Height \ 2, Width, Height \ 2, 315)
            G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), 0, 0, Width, (Height \ 2) - 7)
            DrawBorders(Pens.Black, 0)
            DrawBorders(Pens.Black, 1)
            DrawBorders(New Pen(Color.FromArgb(95, 0, 0)), 3)
            G.DrawLine(New Pen(Color.FromArgb(93, 93, 93)), 3, 3, Width - 5, 3)
            G.DrawLine(New Pen(Color.FromArgb(73, 73, 73)), 0, Height - 1, Width, Height - 1)
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(73, 73, 73), 0, 0, 1, Height)
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(73, 73, 73), Width - 1, 0, 1, Height)
        Else
        End If

        DrawCorners(BackColor)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)

    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterRedButton
    Inherits ThemeControl154
    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        DrawGradient(Color.FromArgb(175, 26, 26), Color.FromArgb(124, 0, 0), 0, 0, Width, Height)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
        G.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.White)), 0, 0, Width, Height \ 2)
        DrawBorders(New Pen(Color.FromArgb(105, 0, 0)), 0)
        DrawBorders(New Pen(Color.FromArgb(199, 26, 26)), 1)


        If State = MouseState.Over Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.White)), 0, 0, Width, Height)
        ElseIf State = MouseState.Down Then
            DrawGradient(Color.FromArgb(45, 45, 45), Color.FromArgb(0, 0, 0), 0, 0, Width, Height)
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
            G.FillRectangle(New SolidBrush(Color.FromArgb(15, Color.White)), 0, 0, Width, Height \ 2)
            DrawBorders(Pens.Black)
            DrawBorders(New Pen(Color.FromArgb(73, 73, 73)), 1)
        Else
        End If


        DrawCorners(BackColor)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BossterMixedButton
    Inherits ThemeControl154
    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        DrawGradient(Color.FromArgb(59, 59, 59), Color.FromArgb(24, 24, 24), 0, 0, Width, Height)
        DrawGradient(Color.FromArgb(204, 37, 37), Color.FromArgb(104, 2, 2), 0, 0, (Width \ 5) + 8, Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), 0, 0, Width, Height \ 2)

        DrawBorders(New Pen(Color.FromArgb(216, 70, 70)), 1)
        G.DrawLine(New Pen(Color.FromArgb(151, 36, 36)), (Width \ 5) + 7, 1, (Width \ 5) + 7, Height - 1)
        G.DrawLine(New Pen(Color.FromArgb(64, 64, 64)), (Width \ 5) + 8, 1, (Width \ 5) + 8, Height - 1)
        G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), (Width \ 5) + 8, 1, Width, 1)
        G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), Width - 2, 1, Width - 2, Height - 1)
        G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), (Width \ 5) + 8, Height - 2, Width, Height - 2)
        DrawBorders(Pens.Black)
        DrawCorners(BackColor)

        If State = MouseState.Over Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.White)), (Width \ 5) + 8, 0, Width, Height)
            DrawBorders(New Pen(Color.FromArgb(216, 70, 70)), 1)
            G.DrawLine(New Pen(Color.FromArgb(151, 36, 36)), (Width \ 5) + 7, 1, (Width \ 5) + 7, Height - 1)
            G.DrawLine(New Pen(Color.FromArgb(64, 64, 64)), (Width \ 5) + 8, 1, (Width \ 5) + 8, Height - 1)
            G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), (Width \ 5) + 8, 1, Width, 1)
            G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), Width - 2, 1, Width - 2, Height - 1)
            G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), (Width \ 5) + 8, Height - 2, Width, Height - 2)
            DrawBorders(Pens.Black)
        ElseIf State = MouseState.Down Then
            DrawGradient(Color.FromArgb(45, 45, 45), Color.FromArgb(0, 0, 0), (Width \ 5) + 8, 0, Width, Height)
            G.FillRectangle(New SolidBrush(Color.FromArgb(15, Color.White)), (Width \ 5) + 8, 0, Width, Height \ 2)
            DrawBorders(New Pen(Color.FromArgb(216, 70, 70)), 1)
            G.DrawLine(New Pen(Color.FromArgb(151, 36, 36)), (Width \ 5) + 7, 1, (Width \ 5) + 7, Height - 1)
            G.DrawLine(New Pen(Color.FromArgb(64, 64, 64)), (Width \ 5) + 8, 1, (Width \ 5) + 8, Height - 1)
            G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), (Width \ 5) + 8, 1, Width, 1)
            G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), Width - 2, 1, Width - 2, Height - 1)
            G.DrawLine(New Pen(Color.FromArgb(87, 87, 87)), (Width \ 5) + 8, Height - 2, Width, Height - 2)
            DrawBorders(Pens.Black)
        Else
        End If

        DrawText(Brushes.White, HorizontalAlignment.Center, 8, 0)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterProgressbar
    Inherits ThemeControl154

    Private _Value As Integer
    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            If value > _Maximum Then value = _Maximum
            If value < 0 Then value = 0

            _Value = value
            Invalidate()
        End Set
    End Property

    Private _Maximum As Integer = 100
    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then value = 1
            If _Value > value Then _Value = value

            _Maximum = value
            Invalidate()
        End Set
    End Property

    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BackColor)

        DrawGradient(Color.FromArgb(226, 226, 226), Color.FromArgb(168, 168, 168), 0, 0, CInt((_Value / _Maximum) * Width - 1), Height)
        G.DrawLine(Pens.White, 0, 2, CInt((_Value / _Maximum) * Width - 2), 2)

        CreateRound(0, 0, Width, Height, 5)
        DrawBorders(Pens.Black)
        DrawBorders(New Pen(Color.FromArgb(92, 92, 92)), 1)
        DrawCorners(BackColor)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterGreyProgressbar
    Inherits ThemeControl154

    Private _Value As Integer
    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            If value > _Maximum Then value = _Maximum
            If value < 0 Then value = 0

            _Value = value
            Invalidate()
        End Set
    End Property

    Private _Maximum As Integer = 100
    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then value = 1
            If _Value > value Then _Value = value

            _Maximum = value
            Invalidate()
        End Set
    End Property

    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BackColor)

        DrawGradient(Color.FromArgb(129, 129, 129), Color.FromArgb(75, 75, 75), 0, 0, CInt((_Value / _Maximum) * Width - 1), Height)
        G.DrawLine(New Pen(Color.FromArgb(182, 182, 182)), 0, 2, CInt((_Value / _Maximum) * Width - 2), 2)

        CreateRound(0, 0, Width, Height, 5)
        DrawBorders(Pens.Black)
        DrawBorders(New Pen(Color.FromArgb(91, 91, 91)), 1)
        DrawCorners(BackColor)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterRedProgressbar
    Inherits ThemeControl154

    Private _Value As Integer
    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            If value > _Maximum Then value = _Maximum
            If value < 0 Then value = 0

            _Value = value
            Invalidate()
        End Set
    End Property

    Private _Maximum As Integer = 100
    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then value = 1
            If _Value > value Then _Value = value

            _Maximum = value
            Invalidate()
        End Set
    End Property

    Sub New()
        Transparent = True
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(66, 0, 0))

        G.FillRectangle(New SolidBrush(Color.FromArgb(204, 0, 0)), 0, 0, CInt((_Value / _Maximum) * Width - 1), Height)

        CreateRound(0, 0, Width, Height, 5)
        G.DrawLine(New Pen(Color.FromArgb(32, 32, 32)), 0, 1, Width, 1)
        DrawBorders(New Pen(Color.FromArgb(70, 70, 70)), 0)
        G.DrawLine(New Pen(Color.FromArgb(138, 139, 138)), 0, Height - 1, Width, Height - 1)
        DrawGradient(Color.FromArgb(70, 70, 70), Color.FromArgb(138, 139, 138), 0, 0, 1, Height)
        DrawGradient(Color.FromArgb(70, 70, 70), Color.FromArgb(138, 139, 138), Width - 1, 0, Width, Height)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
Class BoosterControlpanel
    Inherits ThemeContainer154

    Sub New()
        ControlMode = True
        Transparent = True
        BackColor = Color.Transparent
        Header = 20
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(51, 51, 51))
        DrawGradient(Color.FromArgb(51, 51, 51), Color.FromArgb(0, 0, 0), 0, 0, Width, 20)

        G.DrawLine(New Pen(Color.FromArgb(92, 92, 92)), 0, 21, Width, 21)
        G.DrawLine(Pens.Black, 0, 20, Width, 20)
        DrawBorders(Pens.Black)

        DrawText(Brushes.White, HorizontalAlignment.Center, 8, 3)

        DrawBorders(New Pen(Color.FromArgb(92, 92, 92)), 1)
    End Sub
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
<DefaultEvent("CheckedChanged")> _
Class BoosterCheckBox
    Inherits ThemeControl154

    Sub New()
        Transparent = True
        BackColor = Color.Transparent
        LockHeight = 15
    End Sub

    Property BorderColour As Color

    Property BackgroundColour As Color

    Property MaxLength As Integer

    Property TextAlign As HorizontalAlignment

    Property TextColour As Color

    Property UseSystemPasswordChar As Boolean

    Property [ReadOnly] As Boolean

    Property Multiline As Boolean

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        Dim CheckRectangle As New Rectangle(1, 1, Height - 2, Height - 2)

        G.Clear(BackColor)




        Select Case _Checked
            Case True
                G.FillRectangle(New SolidBrush(Color.FromArgb(129, 10, 10)), CheckRectangle)
                G.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.White)), 1, 1, Height - 2, Height \ 2)
            Case False
                G.FillRectangle(New SolidBrush(Color.FromArgb(51, 28, 28)), CheckRectangle)
        End Select

        G.DrawRectangle(New Pen(Color.FromArgb(92, 92, 92)), 2, 2, Height - 4, Height - 4)
        G.DrawRectangle(Pens.Black, CheckRectangle)

        DrawText(Brushes.White, HorizontalAlignment.Left, 18, 1)
    End Sub


    Private Property _Checked As Boolean = False
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal v As Boolean)
            _Checked = v
        End Set
    End Property
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub
    Event CheckedChanged(ByVal sender As Object)
End Class

'------------------
'Creator: dlwhdrlf
'Created: 19/12/2011
'Version: 1.0.0
'------------------
<DefaultEvent("CheckedChanged")> _
Class BoosterRadioButton
    Inherits ThemeControl154

    Sub New()
        Transparent = True
        BackColor = Color.Transparent
        LockHeight = 15
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BackColor)




        Select Case _Checked
            Case True
                G.FillEllipse(New SolidBrush(Color.FromArgb(129, 10, 10)), 2, 2, Height - 3, Height - 3)
                G.FillEllipse(New SolidBrush(Color.FromArgb(30, Color.White)), 2, 2, Height - 3, Height \ 2)
            Case False
                G.FillEllipse(New SolidBrush(Color.FromArgb(51, 28, 28)), 2, 2, Height - 3, Height - 3)
        End Select

        G.DrawEllipse(New Pen(Color.FromArgb(92, 92, 92)), 2, 2, Height - 3, Height - 3)
        G.DrawEllipse(Pens.Black, 1, 1, Height - 1, Height - 1)

        DrawText(Brushes.White, HorizontalAlignment.Left, 18, 1)
    End Sub


    Private Property _Checked As Boolean = False
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal v As Boolean)
            _Checked = v
        End Set
    End Property
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub
    Event CheckedChanged(ByVal sender As Object)
End Class