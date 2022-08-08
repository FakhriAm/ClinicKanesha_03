<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterAdmin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.userId = New System.Windows.Forms.TextBox()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.userPass = New System.Windows.Forms.TextBox()
        Me.userAuth = New System.Windows.Forms.ComboBox()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_delete = New System.Windows.Forms.Button()
        Me.Button_clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(36, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        Me.Label2.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Id"
        Me.Label1.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(36, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        Me.Label3.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(36, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Authority"
        Me.Label4.UseMnemonic = False
        '
        'userId
        '
        Me.userId.Location = New System.Drawing.Point(141, 33)
        Me.userId.Name = "userId"
        Me.userId.Size = New System.Drawing.Size(124, 20)
        Me.userId.TabIndex = 0
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(140, 59)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(263, 20)
        Me.userName.TabIndex = 1
        '
        'userPass
        '
        Me.userPass.Location = New System.Drawing.Point(141, 84)
        Me.userPass.Name = "userPass"
        Me.userPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPass.Size = New System.Drawing.Size(262, 20)
        Me.userPass.TabIndex = 2
        '
        'userAuth
        '
        Me.userAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userAuth.FormattingEnabled = True
        Me.userAuth.Location = New System.Drawing.Point(142, 108)
        Me.userAuth.Name = "userAuth"
        Me.userAuth.Size = New System.Drawing.Size(121, 21)
        Me.userAuth.TabIndex = 3
        '
        'Button_save
        '
        Me.Button_save.Location = New System.Drawing.Point(442, 26)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(75, 23)
        Me.Button_save.TabIndex = 4
        Me.Button_save.Text = "Save"
        Me.Button_save.UseVisualStyleBackColor = True
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(442, 51)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 5
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'Button_delete
        '
        Me.Button_delete.Location = New System.Drawing.Point(442, 79)
        Me.Button_delete.Name = "Button_delete"
        Me.Button_delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_delete.TabIndex = 6
        Me.Button_delete.Text = "Delete"
        Me.Button_delete.UseVisualStyleBackColor = True
        '
        'Button_clear
        '
        Me.Button_clear.Location = New System.Drawing.Point(442, 108)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_clear.TabIndex = 7
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 227)
        Me.DataGridView1.TabIndex = 8
        '
        'MasterAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 413)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Button_delete)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.userAuth)
        Me.Controls.Add(Me.userPass)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.userId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents userId As TextBox
    Friend WithEvents userName As TextBox
    Friend WithEvents userPass As TextBox
    Friend WithEvents userAuth As ComboBox
    Friend WithEvents Button_save As Button
    Friend WithEvents Button_edit As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_clear As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
