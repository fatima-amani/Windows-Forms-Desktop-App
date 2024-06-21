<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        lbTitle = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnViewSubmissions.Font = New Font("Segoe UI", 12F)
        btnViewSubmissions.Location = New Point(12, 102)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(757, 41)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnCreateSubmission.Font = New Font("Segoe UI", 12F)
        btnCreateSubmission.Location = New Point(12, 162)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(757, 39)
        btnCreateSubmission.TabIndex = 2
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL+N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' lbTitle
        ' 
        lbTitle.AutoSize = True
        lbTitle.Font = New Font("Segoe UI", 15F)
        lbTitle.Location = New Point(12, 45)
        lbTitle.Name = "lbTitle"
        lbTitle.Size = New Size(535, 35)
        lbTitle.TabIndex = 3
        lbTitle.Text = "Fatima Amani, Slidely Task 2 - Slidely Form App"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbTitle)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTitle As TextBox
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents lbTitle As Label

End Class
