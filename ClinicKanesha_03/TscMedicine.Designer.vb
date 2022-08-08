<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TscMedicine
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelCodeTsc = New System.Windows.Forms.Label()
        Me.labelPtnName = New System.Windows.Forms.Label()
        Me.labelPtnAddress = New System.Windows.Forms.Label()
        Me.idPatient = New System.Windows.Forms.ComboBox()
        Me.Date_ = New System.Windows.Forms.Label()
        Me.Admin_ = New System.Windows.Forms.Label()
        Me.Time_ = New System.Windows.Forms.Label()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.labelAdmin = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalIn = New System.Windows.Forms.Label()
        Me.chengeIn = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.cashIn = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.medName = New System.Windows.Forms.ComboBox()
        Me.labelMedPrice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labelMedId = New System.Windows.Forms.Label()
        Me.medQty = New System.Windows.Forms.TextBox()
        Me.ButtonInsertMed = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labelQty = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(46, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code Transaction"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(46, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Patient"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(46, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Patient Name"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(46, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Patient Address"
        '
        'LabelCodeTsc
        '
        Me.LabelCodeTsc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelCodeTsc.Location = New System.Drawing.Point(196, 38)
        Me.LabelCodeTsc.Name = "LabelCodeTsc"
        Me.LabelCodeTsc.Size = New System.Drawing.Size(144, 22)
        Me.LabelCodeTsc.TabIndex = 0
        Me.LabelCodeTsc.Text = "labelCode"
        '
        'labelPtnName
        '
        Me.labelPtnName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelPtnName.Location = New System.Drawing.Point(196, 88)
        Me.labelPtnName.Name = "labelPtnName"
        Me.labelPtnName.Size = New System.Drawing.Size(257, 22)
        Me.labelPtnName.TabIndex = 0
        Me.labelPtnName.Text = "labelPtnName"
        '
        'labelPtnAddress
        '
        Me.labelPtnAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelPtnAddress.Location = New System.Drawing.Point(196, 111)
        Me.labelPtnAddress.Name = "labelPtnAddress"
        Me.labelPtnAddress.Size = New System.Drawing.Size(257, 22)
        Me.labelPtnAddress.TabIndex = 0
        Me.labelPtnAddress.Text = "labelPtnAddress"
        '
        'idPatient
        '
        Me.idPatient.FormattingEnabled = True
        Me.idPatient.Location = New System.Drawing.Point(196, 64)
        Me.idPatient.Name = "idPatient"
        Me.idPatient.Size = New System.Drawing.Size(144, 21)
        Me.idPatient.TabIndex = 1
        '
        'Date_
        '
        Me.Date_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Date_.Location = New System.Drawing.Point(513, 85)
        Me.Date_.Name = "Date_"
        Me.Date_.Size = New System.Drawing.Size(52, 22)
        Me.Date_.TabIndex = 0
        Me.Date_.Text = "Date"
        '
        'Admin_
        '
        Me.Admin_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Admin_.Location = New System.Drawing.Point(513, 111)
        Me.Admin_.Name = "Admin_"
        Me.Admin_.Size = New System.Drawing.Size(52, 22)
        Me.Admin_.TabIndex = 0
        Me.Admin_.Text = "Admin"
        '
        'Time_
        '
        Me.Time_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Time_.Location = New System.Drawing.Point(513, 59)
        Me.Time_.Name = "Time_"
        Me.Time_.Size = New System.Drawing.Size(52, 22)
        Me.Time_.TabIndex = 0
        Me.Time_.Text = "Time"
        '
        'labelTime
        '
        Me.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelTime.Location = New System.Drawing.Point(573, 59)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(104, 22)
        Me.labelTime.TabIndex = 0
        Me.labelTime.Text = "labelTime"
        '
        'labelDate
        '
        Me.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelDate.Location = New System.Drawing.Point(573, 84)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(104, 22)
        Me.labelDate.TabIndex = 0
        Me.labelDate.Text = "labelDate"
        '
        'labelAdmin
        '
        Me.labelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelAdmin.Location = New System.Drawing.Point(573, 109)
        Me.labelAdmin.Name = "labelAdmin"
        Me.labelAdmin.Size = New System.Drawing.Size(104, 22)
        Me.labelAdmin.TabIndex = 0
        Me.labelAdmin.Text = "labelAdmin"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(631, 194)
        Me.DataGridView1.TabIndex = 3
        '
        'Total
        '
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(245, 467)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(155, 50)
        Me.Total.TabIndex = 0
        Me.Total.Text = "Total Rp."
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(46, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cash"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(46, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Change"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalIn
        '
        Me.totalIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalIn.Location = New System.Drawing.Point(406, 467)
        Me.totalIn.Name = "totalIn"
        Me.totalIn.Size = New System.Drawing.Size(159, 50)
        Me.totalIn.TabIndex = 0
        Me.totalIn.Text = "0"
        Me.totalIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chengeIn
        '
        Me.chengeIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.chengeIn.Location = New System.Drawing.Point(138, 467)
        Me.chengeIn.Name = "chengeIn"
        Me.chengeIn.Size = New System.Drawing.Size(101, 22)
        Me.chengeIn.TabIndex = 0
        Me.chengeIn.Text = "Change"
        Me.chengeIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(573, 495)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(100, 22)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(571, 467)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 22)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(571, 438)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(102, 23)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'cashIn
        '
        Me.cashIn.Location = New System.Drawing.Point(134, 439)
        Me.cashIn.Name = "cashIn"
        Me.cashIn.Size = New System.Drawing.Size(105, 20)
        Me.cashIn.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(110, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Medicine"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(357, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Price"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'medName
        '
        Me.medName.FormattingEnabled = True
        Me.medName.Location = New System.Drawing.Point(172, 155)
        Me.medName.Name = "medName"
        Me.medName.Size = New System.Drawing.Size(179, 21)
        Me.medName.TabIndex = 6
        '
        'labelMedPrice
        '
        Me.labelMedPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelMedPrice.Location = New System.Drawing.Point(406, 155)
        Me.labelMedPrice.Name = "labelMedPrice"
        Me.labelMedPrice.Size = New System.Drawing.Size(87, 22)
        Me.labelMedPrice.TabIndex = 0
        Me.labelMedPrice.Text = "Rp.0000"
        Me.labelMedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(499, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Qty"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelMedId
        '
        Me.labelMedId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelMedId.Location = New System.Drawing.Point(46, 154)
        Me.labelMedId.Name = "labelMedId"
        Me.labelMedId.Size = New System.Drawing.Size(58, 22)
        Me.labelMedId.TabIndex = 0
        Me.labelMedId.Text = "MED000"
        Me.labelMedId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'medQty
        '
        Me.medQty.Location = New System.Drawing.Point(535, 155)
        Me.medQty.Name = "medQty"
        Me.medQty.Size = New System.Drawing.Size(43, 20)
        Me.medQty.TabIndex = 7
        '
        'ButtonInsertMed
        '
        Me.ButtonInsertMed.Location = New System.Drawing.Point(584, 153)
        Me.ButtonInsertMed.Name = "ButtonInsertMed"
        Me.ButtonInsertMed.Size = New System.Drawing.Size(93, 24)
        Me.ButtonInsertMed.TabIndex = 8
        Me.ButtonInsertMed.Text = "Insert Data"
        Me.ButtonInsertMed.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(46, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Qty"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelQty
        '
        Me.labelQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelQty.Location = New System.Drawing.Point(138, 495)
        Me.labelQty.Name = "labelQty"
        Me.labelQty.Size = New System.Drawing.Size(101, 22)
        Me.labelQty.TabIndex = 0
        Me.labelQty.Text = "labelQty"
        Me.labelQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TscMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 555)
        Me.Controls.Add(Me.ButtonInsertMed)
        Me.Controls.Add(Me.medQty)
        Me.Controls.Add(Me.medName)
        Me.Controls.Add(Me.cashIn)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.idPatient)
        Me.Controls.Add(Me.labelPtnAddress)
        Me.Controls.Add(Me.labelPtnName)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.Time_)
        Me.Controls.Add(Me.labelAdmin)
        Me.Controls.Add(Me.totalIn)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.labelQty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chengeIn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Admin_)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.Date_)
        Me.Controls.Add(Me.LabelCodeTsc)
        Me.Controls.Add(Me.labelMedPrice)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.labelMedId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TscMedicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription Administration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelCodeTsc As Label
    Friend WithEvents labelPtnName As Label
    Friend WithEvents labelPtnAddress As Label
    Friend WithEvents idPatient As ComboBox
    Friend WithEvents Date_ As Label
    Friend WithEvents Admin_ As Label
    Friend WithEvents Time_ As Label
    Friend WithEvents labelTime As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents labelAdmin As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents totalIn As Label
    Friend WithEvents chengeIn As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents cashIn As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents medName As ComboBox
    Friend WithEvents labelMedPrice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents labelMedId As Label
    Friend WithEvents medQty As TextBox
    Friend WithEvents ButtonInsertMed As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents labelQty As Label
End Class
