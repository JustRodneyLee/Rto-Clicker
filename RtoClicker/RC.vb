Public Class RC

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Private WithEvents kbHook As New KeyboardHook

    Dim lastNum, num As Integer
    Dim lastFreq, freq As Integer
    Dim clicking, infinite, p2pause As Boolean
    Dim mRight As Boolean

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
            End If
        Else
            If mRight Then
                Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Else
                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            End If
        End If
    End Sub

    Sub Initialize()
        Timer.Stop()
        clicking = False
        num = lastNum
        TextBoxNum.Text = num.ToString()
        TextBoxNum.Enabled = True
        TextBoxFreq.Enabled = True
        startButtonLeft.Text = "Start Auto-Clicking! (Left)"
        startButtonLeft.Enabled = True
        startButtonRight.Text = "Start Auto-Clicking! (Right)"
        startButtonRight.Enabled = True
    End Sub

    Sub InitiateClicking()
        clicking = True
        startButtonLeft.Enabled = True
        startButtonLeft.Text = "Stop Auto-Clicking!"
        startButtonRight.Enabled = True
        startButtonRight.Text = "Stop Auto-Clicking!"
        TextBoxNum.Enabled = False
        TextBoxFreq.Enabled = False
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

    Private Sub TextBoxFreq_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFreq.TextChanged
        If IsNumeric(TextBoxFreq.Text) Then
            If freq <= 1000 Then
                freq = Convert.ToInt16(TextBoxFreq.Text)
                lastFreq = freq
                Timer.Interval = 1000 \ freq
            Else
                MessageBox.Show("Frequency cannot be larger than 1000!")
            End If
        Else
            TextBoxFreq.Text = lastFreq.ToString()
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
                lastNum = num
            Else
                TextBoxNum.Text = lastNum.ToString()
            End If
        End If
    End Sub

    Private Sub Timer_Prep_Tick(sender As Object, e As EventArgs) Handles Timer_Prep.Tick
        InitiateClicking()
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If Key.ToString() = "P" Then
            If p2pause Then
                If infinite Then
                    If Timer.Enabled Then
                        Timer.Stop()
                        TextBoxFreq.Enabled = True
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
