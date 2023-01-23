Imports System.Runtime.InteropServices

Public Class RC

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Private WithEvents kbHook As New KeyboardHook

    Dim lastNum, num As Integer
    Dim lastFreq, freq As Decimal
    Dim clicking, infinite As Boolean
    Dim mRight As Boolean
    Dim countDown As Integer
    Dim Bmp As New Bitmap(1, 1)
    Dim G As Graphics = Graphics.FromImage(Bmp)

    Enum MouseAction
        Click
        Hold
    End Enum

    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    Dim ma As MouseAction

    Private Sub RC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lastNum = 1000
        num = lastNum
        lastFreq = 1
        freq = lastFreq
        Timer.Interval = 1000 / freq
        mRight = False
        ma = MouseAction.Click
        infinite = False
        Initialize()
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButtonLeft.Click
        If clicking = False Then
            countDown = 0
            clicking = True
            mRight = False
            DisableControls()
            Timer_Prep.Start()
        Else
            Initialize()
        End If
    End Sub

    Sub DisableControls()
        startButtonRight.Enabled = False
        startButtonRight.Text = "Initiating in 3s..."
        startButtonLeft.Enabled = False
        startButtonLeft.Text = "Initiating in 3s..."
        CheckBox_Hold.Enabled = False
        CheckBox_Inf.Enabled = False
    End Sub

    Sub MClick()
        If ma = MouseAction.Click Then
            If mRight Then
                Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Else
                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            End If
        Else
            If mRight Then
                Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
            Else
                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            End If
        End If
    End Sub

    Sub Initialize()
        Timer.Stop()
        Timer_MB.Stop()
        Timer_MB2.Stop()
        countDown = 0
        clicking = False
        num = lastNum
        TextBoxNum.Text = num.ToString()
        startButtonLeft.Text = "Start Auto-Clicking (Left)"
        startButtonLeft.Enabled = True
        startButtonRight.Text = "Start Auto-Clicking (Right)"
        startButtonRight.Enabled = True
        Button_MB.Text = "Reaction Test"
        GroupBox_AC.Enabled = True
        Button_MB.Enabled = True
        GroupBox_MB.Enabled = True
        CheckBox_Hold.Enabled = True
        CheckBox_Inf.Enabled = True
        If CheckBox_Inf.Checked Then
            TextBoxNum.Enabled = False
        Else
            TextBoxNum.Enabled = True
        End If
        If CheckBox_Hold.Checked Then
            TextBoxFreq.Enabled = False
        Else
            TextBoxFreq.Enabled = True
        End If
        Text = "Rto Clicker"
    End Sub

    Sub InitiateClicking()
        clicking = True
        startButtonLeft.Enabled = True
        startButtonLeft.Text = "Press P to Pause"
        startButtonRight.Enabled = True
        startButtonRight.Text = "Press P to Pause"
        TextBoxNum.Enabled = False
        TextBoxFreq.Enabled = False
        GroupBox_MB.Enabled = False
        Text = "Rto Clicker - Auto-Clicking..."
        Timer.Start()
        Timer_Prep.Stop()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If num = 0 Then
            Initialize()
        Else
            MClick()
            If Not infinite Then
                num -= 1
                TextBoxNum.Text = num.ToString()
            End If
        End If
    End Sub

    Private Sub CheckBox_Inf_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Inf.CheckedChanged
        If CheckBox_Inf.Checked Then
            infinite = True
            TextBoxNum.Enabled = False
            TextBoxNum.Text = "∞"
        Else
            infinite = False
            TextBoxNum.Enabled = True
            TextBoxNum.Text = ToString(lastNum)
        End If
    End Sub

    Private Sub startButtonRight_Click(sender As Object, e As EventArgs) Handles startButtonRight.Click
        If clicking = False Then
            countDown = 0
            clicking = True
            mRight = True
            DisableControls()
            Timer_Prep.Start()
        Else
            Initialize()
        End If
    End Sub

    Private Sub CheckBox_Hold_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Hold.CheckedChanged
        If CheckBox_Hold.Checked = True Then
            ma = MouseAction.Hold
            freq = 1
            TextBoxFreq.Enabled = False
            TextBoxNum.Enabled = False
        Else
            ma = MouseAction.Click
            freq = lastFreq
            TextBoxFreq.Enabled = True
            If Not infinite Then
                TextBoxNum.Enabled = True
            End If
            LabelNoClicks.Text = "Time to Hold(s)"
        End If
    End Sub

    Private Sub TextBoxFreq_Leave(sender As Object, e As EventArgs) Handles TextBoxFreq.Leave
        If IsNumeric(TextBoxFreq.Text) Then
            freq = Convert.ToDecimal(TextBoxFreq.Text)
            If freq <= 1000 Then
                If freq > 0 Then
                    lastFreq = freq
                    Timer.Interval = Convert.ToInt16(1000 / freq)
                Else
                    freq = -1
                End If
            Else
                MsgBox("Frequency cannot be larger than 1000!", MsgBoxStyle.OkOnly, "Rto Clicker - Error")
                TextBoxFreq.Text = lastFreq.ToString()
            End If
        Else
            TextBoxFreq.Text = lastFreq.ToString()
            TextBoxFreq.Select()
        End If
        If freq = -1 Then
            MsgBox("Invalid Frequency Input!", MsgBoxStyle.OkOnly, "Rto Clicker - Error")
            freq = lastFreq
            TextBoxFreq.Text = lastFreq.ToString()
            TextBoxFreq.Select()
        End If
    End Sub

    Private Sub RC_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        LabelFocus.Select()
    End Sub

    Private Sub Button_MB_Click(sender As Object, e As EventArgs) Handles Button_MB.Click
        If Timer_MB.Enabled Then
            Initialize()
        Else
            GroupBox_AC.Enabled = False
            Me.Text = "Rto Clicker - Human Benchmark Reaction Test"
            MsgBox("Follow this link for magic to happen: https://humanbenchmark.com/tests/reactiontime.")
            MsgBox("Please keep your webpage at the front and position your pointer on the area to be clicked.")
            Button_MB.Text = "Stop Test"
            Timer_MB.Start()
        End If
    End Sub

    Private Sub Button_MB2_Click(sender As Object, e As EventArgs)
        If Timer_MB2.Enabled Then
            Initialize()
        Else
            GroupBox_AC.Enabled = False
            Button_MB.Enabled = False
            MsgBox("Follow this link for magic to happen: https://humanbenchmark.com/tests/memory.")
            MsgBox("Please keep your webpage at the front.")
            Me.Text = "Rto Clicker - Human Benchmark Visual Memory Test"
            Timer_MB2.Start()
        End If
    End Sub

    Private Sub Timer_MB_Tick(sender As Object, e As EventArgs) Handles Timer_MB.Tick
        G.CopyFromScreen(Cursor.Position, Point.Empty, Bmp.Size)
        If Bmp.GetPixel(0, 0) = Color.FromArgb(75, 219, 106) Then
            MClick()
        End If
    End Sub

    Private Sub Timer_MB2_Tick(sender As Object, e As EventArgs) Handles Timer_MB2.Tick
        G.CopyFromScreen(Cursor.Position, Point.Empty, Bmp.Size)
    End Sub

    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged
        If infinite = False Then
            If IsNumeric(TextBoxNum.Text) Then
                num = Convert.ToInt16(TextBoxNum.Text)
                If num <= 0 Then
                    MsgBox("Invalid Number of Clicks!", MsgBoxStyle.OkOnly, "Rto Clicker - Error")
                    num = lastNum
                    TextBoxNum.Text = lastNum.ToString()
                Else
                    lastNum = num
                End If
            Else
                TextBoxNum.Text = lastNum.ToString()
            End If
        End If
    End Sub

    Private Sub Timer_Prep_Tick(sender As Object, e As EventArgs) Handles Timer_Prep.Tick
        If countDown = 2 Then
            InitiateClicking()
            Me.Text = "Rto Clicker - Auto-Clicking..."
        Else
            countDown += 1
            Me.Text = "Rto Clicker - Clicking in " + (3 - countDown).ToString() + "s..."
            startButtonLeft.Text = "Initiating in " + (3 - countDown).ToString() + "s..."
            startButtonRight.Text = "Initiating in " + (3 - countDown).ToString() + "s..."
        End If
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If Key.ToString() = "P" Or Key.ToString() = "p" Then
            If Timer.Enabled Then
                Timer.Stop()
                If ma = MouseAction.Click Then
                    TextBoxFreq.Enabled = True
                End If
                If Not infinite Then
                    TextBoxNum.Enabled = True
                End If
                startButtonRight.Text = "Press to Stop"
                startButtonLeft.Text = "Press to Stop"
            Else
                InitiateClicking()
            End If
        End If
    End Sub
End Class
