<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label7 = New Label()
        Label2 = New Label()
        user = New TextBox()
        pass = New TextBox()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkSlateGray
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Image = My.Resources.Resources.monitor
        Label1.Location = New Point(90, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 127)
        Label1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(121, 146)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.Yes
        Label7.Size = New Size(102, 19)
        Label7.TabIndex = 13
        Label7.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(120, 208)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.Yes
        Label2.Size = New Size(103, 19)
        Label2.TabIndex = 14
        Label2.Text = "PASSWORD"
        ' 
        ' user
        ' 
        user.Location = New Point(90, 168)
        user.Name = "user"
        user.Size = New Size(162, 23)
        user.TabIndex = 15
        ' 
        ' pass
        ' 
        pass.Location = New Point(90, 230)
        pass.Name = "pass"
        pass.PasswordChar = "*"c
        pass.Size = New Size(162, 23)
        pass.TabIndex = 16
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.Green
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(156, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 30)
        Button2.TabIndex = 18
        Button2.Text = "Log In"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(101, 282)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(49, 15)
        LinkLabel1.TabIndex = 19
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(363, 371)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(pass)
        Controls.Add(user)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
