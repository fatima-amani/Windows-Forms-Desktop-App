<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        lbHeader = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tbName = New TextBox()
        tbEmail = New TextBox()
        tbPhone = New TextBox()
        tbGithub = New TextBox()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        lbStopwatchTime = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' lbHeader
        ' 
        lbHeader.AutoSize = True
        lbHeader.Font = New Font("Segoe UI", 14F)
        lbHeader.Location = New Point(12, 25)
        lbHeader.Name = "lbHeader"
        lbHeader.Size = New Size(534, 32)
        lbHeader.TabIndex = 0
        lbHeader.Text = "Fatima Amani, Slidely Task 2 - Create Submission"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(26, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(31, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 28)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(31, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 28)
        Label3.TabIndex = 3
        Label3.Text = "Phone"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(-4, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 76)
        Label4.TabIndex = 4
        Label4.Text = "Github Link For Task 2"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(130, 91)
        tbName.Name = "tbName"
        tbName.Size = New Size(416, 27)
        tbName.TabIndex = 5
        ' 
        ' tbEmail
        ' 
        tbEmail.Location = New Point(130, 136)
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(416, 27)
        tbEmail.TabIndex = 6
        ' 
        ' tbPhone
        ' 
        tbPhone.Location = New Point(130, 187)
        tbPhone.Name = "tbPhone"
        tbPhone.Size = New Size(416, 27)
        tbPhone.TabIndex = 7
        ' 
        ' tbGithub
        ' 
        tbGithub.Location = New Point(130, 240)
        tbGithub.Name = "tbGithub"
        tbGithub.Size = New Size(416, 27)
        tbGithub.TabIndex = 8
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSubmit.Font = New Font("Segoe UI", 12F)
        btnSubmit.Location = New Point(26, 405)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(520, 44)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.AutoSize = True
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnToggleStopwatch.Font = New Font("Segoe UI", 12F)
        btnToggleStopwatch.Location = New Point(12, 322)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(320, 42)
        btnToggleStopwatch.TabIndex = 11
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lbStopwatchTime
        ' 
        lbStopwatchTime.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        lbStopwatchTime.Font = New Font("Segoe UI", 12F)
        lbStopwatchTime.Location = New Point(354, 322)
        lbStopwatchTime.Name = "lbStopwatchTime"
        lbStopwatchTime.Size = New Size(183, 42)
        lbStopwatchTime.TabIndex = 12
        lbStopwatchTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(573, 479)
        Controls.Add(lbStopwatchTime)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(tbGithub)
        Controls.Add(tbPhone)
        Controls.Add(tbEmail)
        Controls.Add(tbName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbHeader)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents tbGithub As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lbStopwatchTime As Label
    Friend WithEvents Timer1 As Timer
End Class
