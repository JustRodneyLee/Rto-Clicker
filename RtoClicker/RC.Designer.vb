﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxFreq = New System.Windows.Forms.TextBox()
        Me.TextBoxNum = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Prep = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox_Inf = New System.Windows.Forms.CheckBox()
        Me.startButtonRight = New System.Windows.Forms.Button()
        Me.CheckBox_Hold = New System.Windows.Forms.CheckBox()
        Me.CheckBox_P = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'startButtonLeft
        '
        Me.startButtonLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.startButtonLeft.Location = New System.Drawing.Point(12, 95)
        Me.startButtonLeft.Name = "startButtonLeft"
        Me.startButtonLeft.Size = New System.Drawing.Size(107, 65)
        Me.startButtonLeft.TabIndex = 0
        Me.startButtonLeft.Text = "Start Auto-Clicking! （Left)"
        Me.startButtonLeft.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Frequency (times/s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Clicks"
        '
        'TextBoxFreq
        '
        Me.TextBoxFreq.Location = New System.Drawing.Point(14, 24)
        Me.TextBoxFreq.Name = "TextBoxFreq"
        Me.TextBoxFreq.Size = New System.Drawing.Size(105, 21)
        Me.TextBoxFreq.TabIndex = 3
        '
        'TextBoxNum
        '
        Me.TextBoxNum.Location = New System.Drawing.Point(14, 63)
        Me.TextBoxNum.Name = "TextBoxNum"
        Me.TextBoxNum.Size = New System.Drawing.Size(105, 21)
        Me.TextBoxNum.TabIndex = 4
        '
        'Timer
        '
        '
        'Timer_Prep
        '
        Me.Timer_Prep.Interval = 5000
        '
        'CheckBox_Inf
        '
        Me.CheckBox_Inf.AutoSize = True
        Me.CheckBox_Inf.Location = New System.Drawing.Point(125, 47)
        Me.CheckBox_Inf.Name = "CheckBox_Inf"
        Me.CheckBox_Inf.Size = New System.Drawing.Size(102, 16)
        Me.CheckBox_Inf.TabIndex = 5
        Me.CheckBox_Inf.Text = "Infinite Time"
        Me.CheckBox_Inf.UseVisualStyleBackColor = True
        '
        'startButtonRight
        '
        Me.startButtonRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startButtonRight.Location = New System.Drawing.Point(125, 95)
        Me.startButtonRight.Name = "startButtonRight"
        Me.startButtonRight.Size = New System.Drawing.Size(103, 65)
        Me.startButtonRight.TabIndex = 6
        Me.startButtonRight.Text = "Start Auto-Clicking! （Right)"
        Me.startButtonRight.UseVisualStyleBackColor = True
        '
        'CheckBox_Hold
        '
        Me.CheckBox_Hold.AutoSize = True
        Me.CheckBox_Hold.Location = New System.Drawing.Point(125, 26)
        Me.CheckBox_Hold.Name = "CheckBox_Hold"
        Me.CheckBox_Hold.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox_Hold.TabIndex = 7
        Me.CheckBox_Hold.Text = "Mouse Hold"
        Me.CheckBox_Hold.UseVisualStyleBackColor = True
        '
        'CheckBox_P
        '
        Me.CheckBox_P.AutoSize = True
        Me.CheckBox_P.Checked = True
        Me.CheckBox_P.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_P.Location = New System.Drawing.Point(125, 68)
        Me.CheckBox_P.Name = "CheckBox_P"
        Me.CheckBox_P.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox_P.TabIndex = 8
        Me.CheckBox_P.Text = "[P] as Pause"
        Me.CheckBox_P.UseVisualStyleBackColor = True
        '
        'RC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 172)
        Me.Controls.Add(Me.CheckBox_P)
        Me.Controls.Add(Me.CheckBox_Hold)
        Me.Controls.Add(Me.startButtonRight)
        Me.Controls.Add(Me.CheckBox_Inf)
        Me.Controls.Add(Me.TextBoxNum)
        Me.Controls.Add(Me.TextBoxFreq)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startButtonLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RC"
        Me.Text = "Rto Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startButtonLeft As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxFreq As TextBox
    Friend WithEvents TextBoxNum As TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Timer_Prep As Timer
    Friend WithEvents CheckBox_Inf As CheckBox
    Friend WithEvents startButtonRight As Button
    Friend WithEvents CheckBox_Hold As CheckBox
    Friend WithEvents CheckBox_P As CheckBox
End Class