<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterPatient
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_clear = New System.Windows.Forms.Button()
        Me.Button_delete = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.patientStatus = New System.Windows.Forms.ComboBox()
        Me.patientName = New System.Windows.Forms.TextBox()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.patientAge = New System.Windows.Forms.TextBox()
        Me.patientAddress = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 227)
        Me.DataGridView1.TabIndex = 21
        '
        'Button_clear
        '
        Me.Button_clear.Location = New System.Drawing.Point(445, 116)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_clear.TabIndex = 9
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'Button_delete
        '
        Me.Button_delete.Location = New System.Drawing.Point(445, 87)
        Me.Button_delete.Name = "Button_delete"
        Me.Button_delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_delete.TabIndex = 8
        Me.Button_delete.Text = "Delete"
        Me.Button_delete.UseVisualStyleBackColor = True
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(445, 60)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 7
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'Button_save
        '
        Me.Button_save.Location = New System.Drawing.Point(445, 34)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(75, 23)
        Me.Button_save.TabIndex = 6
        Me.Button_save.Text = "Input"
        Me.Button_save.UseVisualStyleBackColor = True
        '
        'patientStatus
        '
        Me.patientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.patientStatus.FormattingEnabled = True
        Me.patientStatus.Location = New System.Drawing.Point(144, 139)
        Me.patientStatus.Name = "patientStatus"
        Me.patientStatus.Size = New System.Drawing.Size(121, 21)
        Me.patientStatus.TabIndex = 5
        '
        'patientName
        '
        Me.patientName.Location = New System.Drawing.Point(144, 60)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(263, 20)
        Me.patientName.TabIndex = 1
        '
        'patientId
        '
        Me.patientId.Location = New System.Drawing.Point(145, 35)
        Me.patientId.Name = "patientId"
        Me.patientId.Size = New System.Drawing.Size(124, 20)
        Me.patientId.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(39, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Status"
        Me.Label4.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(39, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patient Name"
        Me.Label2.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(40, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Address"
        Me.Label3.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(39, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Patient Id"
        Me.Label1.UseMnemonic = False
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(39, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Age"
        Me.Label5.UseMnemonic = False
        '
        'patientAge
        '
        Me.patientAge.Location = New System.Drawing.Point(144, 112)
        Me.patientAge.Name = "patientAge"
        Me.patientAge.Size = New System.Drawing.Size(122, 20)
        Me.patientAge.TabIndex = 4
        '
        'patientAddress
        '
        Me.patientAddress.BackColor = System.Drawing.SystemColors.Window
        Me.patientAddress.Location = New System.Drawing.Point(144, 86)
        Me.patientAddress.Name = "patientAddress"
        Me.patientAddress.Size = New System.Drawing.Size(262, 20)
        Me.patientAddress.TabIndex = 3
        '
        'MasterPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 446)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Button_delete)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.patientStatus)
        Me.Controls.Add(Me.patientAge)
        Me.Controls.Add(Me.patientAddress)
        Me.Controls.Add(Me.patientName)
        Me.Controls.Add(Me.patientId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterPatient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_clear As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_edit As Button
    Friend WithEvents Button_save As Button
    Friend WithEvents patientStatus As ComboBox
    Friend WithEvents patientName As TextBox
    Friend WithEvents patientId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents patientAge As TextBox
    Friend WithEvents patientAddress As TextBox
End Class
