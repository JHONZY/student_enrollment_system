<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label2 = New Label()
        Label3 = New Label()
        username = New TextBox()
        password = New TextBox()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(49, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 67)
        Label1.TabIndex = 0
        Label1.Text = "REGISTER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(49, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.ImageAlign = ContentAlignment.MiddleLeft
        Label3.Location = New Point(53, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' username
        ' 
        username.Location = New Point(139, 101)
        username.Name = "username"
        username.Size = New Size(165, 23)
        username.TabIndex = 3
        ' 
        ' password
        ' 
        password.Location = New Point(139, 138)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(165, 23)
        password.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.Cyan
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.Green
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(139, 180)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 31)
        Button2.TabIndex = 19
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.ForeColor = SystemColors.ButtonHighlight
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(253, 186)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(51, 20)
        LinkLabel1.TabIndex = 20
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log In"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(375, 241)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Cursor = Cursors.Hand
        ForeColor = SystemColors.ButtonHighlight
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
