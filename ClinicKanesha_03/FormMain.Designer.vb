<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrescriptionMedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SLabel_uid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelUid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel_uname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelUname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel_auth = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelAuth = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel_Time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel_Date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.PatientToolStripMenuItem, Me.MedicineToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'MedicineToolStripMenuItem
        '
        Me.MedicineToolStripMenuItem.Name = "MedicineToolStripMenuItem"
        Me.MedicineToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.MedicineToolStripMenuItem.Text = "Medicine"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultationToolStripMenuItem, Me.PrescriptionMedToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'ConsultationToolStripMenuItem
        '
        Me.ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        Me.ConsultationToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ConsultationToolStripMenuItem.Text = "Consultation"
        '
        'PrescriptionMedToolStripMenuItem
        '
        Me.PrescriptionMedToolStripMenuItem.Name = "PrescriptionMedToolStripMenuItem"
        Me.PrescriptionMedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PrescriptionMedToolStripMenuItem.Text = "Prescription Med"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SLabel_uid, Me.labelUid, Me.SLabel_uname, Me.labelUname, Me.SLabel_auth, Me.labelAuth, Me.SLabel_Time, Me.labelTime, Me.SLabel_Date, Me.labelDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SLabel_uid
        '
        Me.SLabel_uid.Name = "SLabel_uid"
        Me.SLabel_uid.Size = New System.Drawing.Size(34, 17)
        Me.SLabel_uid.Text = "Uid : "
        '
        'labelUid
        '
        Me.labelUid.Name = "labelUid"
        Me.labelUid.Size = New System.Drawing.Size(0, 17)
        '
        'SLabel_uname
        '
        Me.SLabel_uname.Name = "SLabel_uname"
        Me.SLabel_uname.Size = New System.Drawing.Size(48, 17)
        Me.SLabel_uname.Text = "Name : "
        '
        'labelUname
        '
        Me.labelUname.Name = "labelUname"
        Me.labelUname.Size = New System.Drawing.Size(0, 17)
        '
        'SLabel_auth
        '
        Me.SLabel_auth.Name = "SLabel_auth"
        Me.SLabel_auth.Size = New System.Drawing.Size(42, 17)
        Me.SLabel_auth.Text = "Auth : "
        '
        'labelAuth
        '
        Me.labelAuth.Name = "labelAuth"
        Me.labelAuth.Size = New System.Drawing.Size(0, 17)
        '
        'SLabel_Time
        '
        Me.SLabel_Time.Name = "SLabel_Time"
        Me.SLabel_Time.Size = New System.Drawing.Size(42, 17)
        Me.SLabel_Time.Text = "Time : "
        '
        'labelTime
        '
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(0, 17)
        '
        'SLabel_Date
        '
        Me.SLabel_Date.Name = "SLabel_Date"
        Me.SLabel_Date.Size = New System.Drawing.Size(40, 17)
        Me.SLabel_Date.Text = "Date : "
        '
        'labelDate
        '
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu Cinic Kanesha"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrescriptionMedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SLabel_uid As ToolStripStatusLabel
    Friend WithEvents labelUid As ToolStripStatusLabel
    Friend WithEvents SLabel_uname As ToolStripStatusLabel
    Friend WithEvents labelUname As ToolStripStatusLabel
    Friend WithEvents SLabel_auth As ToolStripStatusLabel
    Friend WithEvents labelAuth As ToolStripStatusLabel
    Friend WithEvents SLabel_Time As ToolStripStatusLabel
    Friend WithEvents labelTime As ToolStripStatusLabel
    Friend WithEvents SLabel_Date As ToolStripStatusLabel
    Friend WithEvents labelDate As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
