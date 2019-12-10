<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RC))
        Me.startButtonLeft = New System.Windows.Forms.Button()
        Me.LabelFreq = New System.Windows.Forms.Label()
        Me.LabelNoClicks = New System.Windows.Forms.Label()
        Me.TextBoxFreq = New System.Windows.Forms.TextBox()
        Me.TextBoxNum = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Prep = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox_Inf = New System.Windows.Forms.CheckBox()
        Me.startButtonRight = New System.Windows.Forms.Button()
        Me.CheckBox_Hold = New System.Windows.Forms.CheckBox()
        Me.CheckBox_P = New System.Windows.Forms.CheckBox()
        Me.LabelFocus = New System.Windows.Forms.Label()
        Me.Button_MB = New System.Windows.Forms.Button()
        Me.GroupBox_AC = New System.Windows.Forms.GroupBox()
        Me.GroupBox_MB = New System.Windows.Forms.GroupBox()
        Me.Button_MB2 = New System.Windows.Forms.Button()
        Me.GroupBox_Info = New System.Windows.Forms.GroupBox()
        Me.Label_JRL = New System.Windows.Forms.Label()
        Me.Label_WrittenBy = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Timer_MB = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_MB2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_AC.SuspendLayout()
        Me.GroupBox_MB.SuspendLayout()
        Me.GroupBox_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'startButtonLeft
        '
        Me.startButtonLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.startButtonLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButtonLeft.Location = New System.Drawing.Point(6, 107)
        Me.startButtonLeft.Name = "startButtonLeft"
        Me.startButtonLeft.Size = New System.Drawing.Size(107, 65)
        Me.startButtonLeft.TabIndex = 0
        Me.startButtonLeft.Text = "Start Auto-Clicking! (Left)"
        Me.startButtonLeft.UseVisualStyleBackColor = True
        '
        'LabelFreq
        '
        Me.LabelFreq.AutoSize = True
        Me.LabelFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFreq.Location = New System.Drawing.Point(5, 22)
        Me.LabelFreq.Name = "LabelFreq"
        Me.LabelFreq.Size = New System.Drawing.Size(114, 15)
        Me.LabelFreq.TabIndex = 1
        Me.LabelFreq.Text = "Frequency (times/s)"
        '
        'LabelNoClicks
        '
        Me.LabelNoClicks.AutoSize = True
        Me.LabelNoClicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNoClicks.Location = New System.Drawing.Point(5, 61)
        Me.LabelNoClicks.Name = "LabelNoClicks"
        Me.LabelNoClicks.Size = New System.Drawing.Size(100, 15)
        Me.LabelNoClicks.TabIndex = 2
        Me.LabelNoClicks.Text = "Number of Clicks"
        '
        'TextBoxFreq
        '
        Me.TextBoxFreq.Location = New System.Drawing.Point(7, 37)
        Me.TextBoxFreq.Name = "TextBoxFreq"
        Me.TextBoxFreq.Size = New System.Drawing.Size(105, 21)
        Me.TextBoxFreq.TabIndex = 3
        '
        'TextBoxNum
        '
        Me.TextBoxNum.Location = New System.Drawing.Point(7, 76)
        Me.TextBoxNum.Name = "TextBoxNum"
        Me.TextBoxNum.Size = New System.Drawing.Size(105, 21)
        Me.TextBoxNum.TabIndex = 4
        '
        'Timer
        '
        '
        'Timer_Prep
        '
        Me.Timer_Prep.Interval = 1000
        '
        'CheckBox_Inf
        '
        Me.CheckBox_Inf.AutoSize = True
        Me.CheckBox_Inf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Inf.Location = New System.Drawing.Point(118, 60)
        Me.CheckBox_Inf.Name = "CheckBox_Inf"
        Me.CheckBox_Inf.Size = New System.Drawing.Size(93, 19)
        Me.CheckBox_Inf.TabIndex = 5
        Me.CheckBox_Inf.Text = "Infinite Time"
        Me.CheckBox_Inf.UseVisualStyleBackColor = True
        '
        'startButtonRight
        '
        Me.startButtonRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startButtonRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButtonRight.Location = New System.Drawing.Point(118, 107)
        Me.startButtonRight.Name = "startButtonRight"
        Me.startButtonRight.Size = New System.Drawing.Size(103, 65)
        Me.startButtonRight.TabIndex = 6
        Me.startButtonRight.Text = "Start Auto-Clicking! (Right)"
        Me.startButtonRight.UseVisualStyleBackColor = True
        '
        'CheckBox_Hold
        '
        Me.CheckBox_Hold.AutoSize = True
        Me.CheckBox_Hold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Hold.Location = New System.Drawing.Point(118, 39)
        Me.CheckBox_Hold.Name = "CheckBox_Hold"
        Me.CheckBox_Hold.Size = New System.Drawing.Size(93, 19)
        Me.CheckBox_Hold.TabIndex = 7
        Me.CheckBox_Hold.Text = "Mouse Hold"
        Me.CheckBox_Hold.UseVisualStyleBackColor = True
        '
        'CheckBox_P
        '
        Me.CheckBox_P.AutoSize = True
        Me.CheckBox_P.Checked = True
        Me.CheckBox_P.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_P.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_P.Location = New System.Drawing.Point(118, 81)
        Me.CheckBox_P.Name = "CheckBox_P"
        Me.CheckBox_P.Size = New System.Drawing.Size(94, 19)
        Me.CheckBox_P.TabIndex = 8
        Me.CheckBox_P.Text = "[P] as Pause"
        Me.CheckBox_P.UseVisualStyleBackColor = True
        '
        'LabelFocus
        '
        Me.LabelFocus.AutoSize = True
        Me.LabelFocus.Location = New System.Drawing.Point(180, 22)
        Me.LabelFocus.Name = "LabelFocus"
        Me.LabelFocus.Size = New System.Drawing.Size(0, 15)
        Me.LabelFocus.TabIndex = 9
        '
        'Button_MB
        '
        Me.Button_MB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MB.Location = New System.Drawing.Point(8, 22)
        Me.Button_MB.Name = "Button_MB"
        Me.Button_MB.Size = New System.Drawing.Size(124, 59)
        Me.Button_MB.TabIndex = 10
        Me.Button_MB.Text = "Reaction Test"
        Me.Button_MB.UseVisualStyleBackColor = True
        '
        'GroupBox_AC
        '
        Me.GroupBox_AC.Controls.Add(Me.startButtonLeft)
        Me.GroupBox_AC.Controls.Add(Me.LabelFreq)
        Me.GroupBox_AC.Controls.Add(Me.LabelFocus)
        Me.GroupBox_AC.Controls.Add(Me.LabelNoClicks)
        Me.GroupBox_AC.Controls.Add(Me.CheckBox_P)
        Me.GroupBox_AC.Controls.Add(Me.TextBoxFreq)
        Me.GroupBox_AC.Controls.Add(Me.CheckBox_Hold)
        Me.GroupBox_AC.Controls.Add(Me.TextBoxNum)
        Me.GroupBox_AC.Controls.Add(Me.startButtonRight)
        Me.GroupBox_AC.Controls.Add(Me.CheckBox_Inf)
        Me.GroupBox_AC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_AC.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_AC.Name = "GroupBox_AC"
        Me.GroupBox_AC.Size = New System.Drawing.Size(227, 178)
        Me.GroupBox_AC.TabIndex = 11
        Me.GroupBox_AC.TabStop = False
        Me.GroupBox_AC.Text = "Auto Clicking"
        '
        'GroupBox_MB
        '
        Me.GroupBox_MB.Controls.Add(Me.Button_MB2)
        Me.GroupBox_MB.Controls.Add(Me.Button_MB)
        Me.GroupBox_MB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_MB.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox_MB.Name = "GroupBox_MB"
        Me.GroupBox_MB.Size = New System.Drawing.Size(138, 87)
        Me.GroupBox_MB.TabIndex = 12
        Me.GroupBox_MB.TabStop = False
        Me.GroupBox_MB.Text = "Machine Benchmark"
        '
        'Button_MB2
        '
        Me.Button_MB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MB2.Location = New System.Drawing.Point(8, 52)
        Me.Button_MB2.Name = "Button_MB2"
        Me.Button_MB2.Size = New System.Drawing.Size(124, 24)
        Me.Button_MB2.TabIndex = 11
        Me.Button_MB2.Text = "Visual Memory Test"
        Me.Button_MB2.UseVisualStyleBackColor = True
        Me.Button_MB2.Visible = False
        '
        'GroupBox_Info
        '
        Me.GroupBox_Info.Controls.Add(Me.Label_JRL)
        Me.GroupBox_Info.Controls.Add(Me.Label_WrittenBy)
        Me.GroupBox_Info.Controls.Add(Me.Label_Version)
        Me.GroupBox_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Info.Location = New System.Drawing.Point(245, 105)
        Me.GroupBox_Info.Name = "GroupBox_Info"
        Me.GroupBox_Info.Size = New System.Drawing.Size(138, 85)
        Me.GroupBox_Info.TabIndex = 13
        Me.GroupBox_Info.TabStop = False
        Me.GroupBox_Info.Text = "Application Info"
        '
        'Label_JRL
        '
        Me.Label_JRL.AutoSize = True
        Me.Label_JRL.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_JRL.Location = New System.Drawing.Point(2, 59)
        Me.Label_JRL.Name = "Label_JRL"
        Me.Label_JRL.Size = New System.Drawing.Size(133, 20)
        Me.Label_JRL.TabIndex = 2
        Me.Label_JRL.Text = """Just"" Rodney Lee"
        '
        'Label_WrittenBy
        '
        Me.Label_WrittenBy.AutoSize = True
        Me.Label_WrittenBy.Location = New System.Drawing.Point(3, 39)
        Me.Label_WrittenBy.Name = "Label_WrittenBy"
        Me.Label_WrittenBy.Size = New System.Drawing.Size(60, 15)
        Me.Label_WrittenBy.TabIndex = 1
        Me.Label_WrittenBy.Text = "Written by"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Version.Location = New System.Drawing.Point(3, 17)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(68, 15)
        Me.Label_Version.TabIndex = 0
        Me.Label_Version.Text = "Version 1.2"
        '
        'Timer_MB
        '
        Me.Timer_MB.Interval = 1
        '
        'Timer_MB2
        '
        '
        'RC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 198)
        Me.Controls.Add(Me.GroupBox_Info)
        Me.Controls.Add(Me.GroupBox_MB)
        Me.Controls.Add(Me.GroupBox_AC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RC"
        Me.Text = "Rto Clicker"
        Me.GroupBox_AC.ResumeLayout(False)
        Me.GroupBox_AC.PerformLayout()
        Me.GroupBox_MB.ResumeLayout(False)
        Me.GroupBox_Info.ResumeLayout(False)
        Me.GroupBox_Info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents startButtonLeft As Button
    Friend WithEvents LabelFreq As Label
    Friend WithEvents LabelNoClicks As Label
    Friend WithEvents TextBoxFreq As TextBox
    Friend WithEvents TextBoxNum As TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Timer_Prep As Timer
    Friend WithEvents CheckBox_Inf As CheckBox
    Friend WithEvents startButtonRight As Button
    Friend WithEvents CheckBox_Hold As CheckBox
    Friend WithEvents CheckBox_P As CheckBox
    Friend WithEvents LabelFocus As Label
    Friend WithEvents Button_MB As Button
    Friend WithEvents GroupBox_AC As GroupBox
    Friend WithEvents GroupBox_MB As GroupBox
    Friend WithEvents Button_MB2 As Button
    Friend WithEvents GroupBox_Info As GroupBox
    Friend WithEvents Label_JRL As Label
    Friend WithEvents Label_WrittenBy As Label
    Friend WithEvents Label_Version As Label
    Friend WithEvents Timer_MB As Timer
    Friend WithEvents Timer_MB2 As Timer
End Class
