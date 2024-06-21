<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionForm
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
        Label1 = New Label()
        lbUserName = New Label()
        lbUserEmail = New Label()
        lbUserPhone = New Label()
        lbUserGithub = New Label()
        lbUserStopwatch = New Label()
        tbUserName = New TextBox()
        tbUserEmail = New TextBox()
        tbUserPhone = New TextBox()
        tbUserGithub = New TextBox()
        tbUserStopwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F)
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(474, 30)
        Label1.TabIndex = 0
        Label1.Text = "Fatima Amani, Slidely Task 2 - View Submissions"
        ' 
        ' lbUserName
        ' 
        lbUserName.AutoSize = True
        lbUserName.Font = New Font("Segoe UI", 12F)
        lbUserName.Location = New Point(38, 96)
        lbUserName.Name = "lbUserName"
        lbUserName.Size = New Size(64, 28)
        lbUserName.TabIndex = 1
        lbUserName.Text = "Name"
        lbUserName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbUserEmail
        ' 
        lbUserEmail.AutoSize = True
        lbUserEmail.Font = New Font("Segoe UI", 12F)
        lbUserEmail.Location = New Point(38, 132)
        lbUserEmail.Name = "lbUserEmail"
        lbUserEmail.Size = New Size(59, 28)
        lbUserEmail.TabIndex = 2
        lbUserEmail.Text = "Email"
        lbUserEmail.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbUserPhone
        ' 
        lbUserPhone.AutoSize = True
        lbUserPhone.Font = New Font("Segoe UI", 12F)
        lbUserPhone.Location = New Point(12, 177)
        lbUserPhone.Name = "lbUserPhone"
        lbUserPhone.Size = New Size(115, 28)
        lbUserPhone.TabIndex = 3
        lbUserPhone.Text = "Phone Num"
        lbUserPhone.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbUserGithub
        ' 
        lbUserGithub.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbUserGithub.Font = New Font("Segoe UI", 12F)
        lbUserGithub.Location = New Point(12, 227)
        lbUserGithub.Name = "lbUserGithub"
        lbUserGithub.Size = New Size(115, 122)
        lbUserGithub.TabIndex = 4
        lbUserGithub.Text = "GitHub Link for Task 2"
        lbUserGithub.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbUserStopwatch
        ' 
        lbUserStopwatch.Font = New Font("Segoe UI", 12F)
        lbUserStopwatch.Location = New Point(12, 311)
        lbUserStopwatch.Name = "lbUserStopwatch"
        lbUserStopwatch.Size = New Size(131, 70)
        lbUserStopwatch.TabIndex = 5
        lbUserStopwatch.Text = "Stopwatch time"
        lbUserStopwatch.TextAlign = ContentAlignment.TopCenter
        ' 
        ' tbUserName
        ' 
        tbUserName.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        tbUserName.Location = New Point(141, 97)
        tbUserName.Name = "tbUserName"
        tbUserName.ReadOnly = True
        tbUserName.Size = New Size(375, 27)
        tbUserName.TabIndex = 6
        tbUserName.TabStop = False
        tbUserName.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbUserEmail
        ' 
        tbUserEmail.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        tbUserEmail.Location = New Point(139, 136)
        tbUserEmail.Name = "tbUserEmail"
        tbUserEmail.ReadOnly = True
        tbUserEmail.Size = New Size(377, 27)
        tbUserEmail.TabIndex = 7
        tbUserEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbUserPhone
        ' 
        tbUserPhone.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        tbUserPhone.Location = New Point(141, 181)
        tbUserPhone.Name = "tbUserPhone"
        tbUserPhone.ReadOnly = True
        tbUserPhone.Size = New Size(375, 27)
        tbUserPhone.TabIndex = 8
        tbUserPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbUserGithub
        ' 
        tbUserGithub.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        tbUserGithub.Location = New Point(141, 227)
        tbUserGithub.Name = "tbUserGithub"
        tbUserGithub.ReadOnly = True
        tbUserGithub.Size = New Size(375, 27)
        tbUserGithub.TabIndex = 9
        tbUserGithub.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbUserStopwatch
        ' 
        tbUserStopwatch.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        tbUserStopwatch.Location = New Point(139, 311)
        tbUserStopwatch.Name = "tbUserStopwatch"
        tbUserStopwatch.ReadOnly = True
        tbUserStopwatch.Size = New Size(377, 27)
        tbUserStopwatch.TabIndex = 10
        tbUserStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnPrevious.Location = New Point(22, 384)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(227, 41)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNext.Location = New Point(289, 384)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(227, 41)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.Black
        btnDelete.Location = New Point(171, 445)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(182, 36)
        btnDelete.TabIndex = 13
        btnDelete.Text = "DELETE (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 521)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(tbUserStopwatch)
        Controls.Add(tbUserGithub)
        Controls.Add(tbUserPhone)
        Controls.Add(tbUserEmail)
        Controls.Add(tbUserName)
        Controls.Add(lbUserStopwatch)
        Controls.Add(lbUserGithub)
        Controls.Add(lbUserPhone)
        Controls.Add(lbUserEmail)
        Controls.Add(lbUserName)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents lbUserEmail As Label
    Friend WithEvents lbUserPhone As Label
    Friend WithEvents lbUserGithub As Label
    Friend WithEvents lbUserStopwatch As Label
    Friend WithEvents tbUserName As TextBox
    Friend WithEvents tbUserEmail As TextBox
    Friend WithEvents tbUserPhone As TextBox
    Friend WithEvents tbUserGithub As TextBox
    Friend WithEvents tbUserStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
End Class
