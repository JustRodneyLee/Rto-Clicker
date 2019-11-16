Public Class RC

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Private WithEvents kbHook As New KeyboardHook

    Dim lastNum, num As Integer
    Dim lastFreq, freq As Decimal
    Dim clicking, infinite, p2pause As Boolean
    Dim mRight As Boolean
    Dim countDown As Integer

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
        p2pause = True
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
        startButtonRight.Text = "Initiating in 3 seconds..."
        startButtonLeft.Enabled = False
        startButtonLeft.Text = "Initiating in 3 seconds..."
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
        countDown = 0
        clicking = False
        num = lastNum
        TextBoxNum.Text = num.ToString()
        TextBoxNum.Enabled = True
        TextBoxFreq.Enabled = True
        startButtonLeft.Text = "Start Auto-Clicking! (Left)"
        startButtonLeft.Enabled = True
        startButtonRight.Text = "Start Auto-Clicking! (Right)"
        startButtonRight.Enabled = True
        Me.Text = "Rto Clicker"
    End Sub

    Sub InitiateClicking()
        clicking = True
        startButtonLeft.Enabled = True
        startButtonLeft.Text = "Stop Auto-Clicking!"
        startButtonRight.Enabled = True
        startButtonRight.Text = "Stop Auto-Clicking!"
        TextBoxNum.Enabled = False
        TextBoxFreq.Enabled = False
        Me.Text = "Rto Clicker - Auto-Clicking..."
        Timer.Start()
        Timer_Prep.Stop()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If num = 0 Then
            Initialize()
        Else
            MClick()
            If infinite Then
                TextBoxNum.Text = "∞"
            Else
                num -= 1
                TextBoxNum.Text = num.ToString()
            End If
        End If
    End Sub

    Private Sub CheckBox_Inf_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Inf.CheckedChanged
        If CheckBox_Inf.Checked Then
            infinite = True
            CheckBox_P.Checked = True
            p2pause = True
            TextBoxNum.Enabled = False
        Else
            infinite = False
            TextBoxNum.Enabled = True
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
            startButtonLeft.Text = "Stop Auto-Clicking!"
        Else
            ma = MouseAction.Click
            startButtonLeft.Text = "Stop Auto-Clicking!"
        End If
    End Sub

    Private Sub TextBoxFreq_Leave(sender As Object, e As EventArgs) Handles TextBoxFreq.Leave
        If IsNumeric(TextBoxFreq.Text) Then
            freq = Convert.ToDecimal(TextBoxFreq.Text)
            'MsgBox(freq)
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

    Private Sub CheckBox_P_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_P.CheckedChanged
        If CheckBox_P.Checked Then
            p2pause = True
        Else
            p2pause = False
        End If
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
        If countDown = 3 Then
            InitiateClicking()
            Me.Text = "Rto Clicker - Auto-Clicking..."
        Else
            countDown += 1
            Me.Text = "Rto Clicker - Clicking in " + (3 - countDown).ToString() + "s..."
        End If
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If Key.ToString() = "P" Then
            If p2pause Then
                If infinite Then
                    If Timer.Enabled Then
                        Timer.Stop()
                        TextBoxFreq.Enabled = True
                        If mRight Then
                            startButtonRight.Text = "Continue Auto-Clicking! (Right)"
                            startButtonRight.Enabled = True
                        Else
                            startButtonLeft.Text = "Continue Auto-Clicking! (Left)"
                            startButtonLeft.Enabled = True
                        End If
                    Else
                        InitiateClicking()
                    End If
                Else
                    Initialize()
                End If
            End If
        End If
    End Sub
End Class
