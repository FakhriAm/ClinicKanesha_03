<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterMedicine
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
        Dim Unit As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_clear = New System.Windows.Forms.Button()
        Me.Button_delete = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.medStock = New System.Windows.Forms.TextBox()
        Me.medPrice = New System.Windows.Forms.TextBox()
        Me.medName = New System.Windows.Forms.TextBox()
        Me.medId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.medUnit = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Unit = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Unit
        '
        Unit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Unit.Location = New System.Drawing.Point(39, 135)
        Unit.Name = "Unit"
        Unit.Size = New System.Drawing.Size(99, 25)
        Unit.TabIndex = 37
        Unit.Text = "Unit"
        Unit.UseMnemonic = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(626, 227)
        Me.DataGridView1.TabIndex = 36
        '
        'Button_clear
        '
        Me.Button_clear.Location = New System.Drawing.Point(590, 113)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_clear.TabIndex = 30
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'Button_delete
        '
        Me.Button_delete.Location = New System.Drawing.Point(590, 84)
        Me.Button_delete.Name = "Button_delete"
        Me.Button_delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_delete.TabIndex = 29
        Me.Button_delete.Text = "Delete"
        Me.Button_delete.UseVisualStyleBackColor = True
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(590, 56)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 28
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'Button_save
        '
        Me.Button_save.Location = New System.Drawing.Point(590, 29)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(75, 23)
        Me.Button_save.TabIndex = 27
        Me.Button_save.Text = "Save"
        Me.Button_save.UseVisualStyleBackColor = True
        '
        'medStock
        '
        Me.medStock.Location = New System.Drawing.Point(144, 113)
        Me.medStock.Name = "medStock"
        Me.medStock.Size = New System.Drawing.Size(122, 20)
        Me.medStock.TabIndex = 25
        '
        'medPrice
        '
        Me.medPrice.BackColor = System.Drawing.SystemColors.Window
        Me.medPrice.Location = New System.Drawing.Point(144, 87)
        Me.medPrice.Name = "medPrice"
        Me.medPrice.Size = New System.Drawing.Size(125, 20)
        Me.medPrice.TabIndex = 24
        '
        'medName
        '
        Me.medName.Location = New System.Drawing.Point(144, 61)
        Me.medName.Name = "medName"
        Me.medName.Size = New System.Drawing.Size(263, 20)
        Me.medName.TabIndex = 23
        '
        'medId
        '
        Me.medId.Location = New System.Drawing.Point(145, 36)
        Me.medId.Name = "medId"
        Me.medId.Size = New System.Drawing.Size(124, 20)
        Me.medId.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(39, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Stock"
        Me.Label5.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(39, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Medicine Name"
        Me.Label2.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(40, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Price"
        Me.Label3.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Medicine Id"
        Me.Label1.UseMnemonic = False
        '
        'medUnit
        '
        Me.medUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.medUnit.FormattingEnabled = True
        Me.medUnit.Location = New System.Drawing.Point(145, 138)
        Me.medUnit.Name = "medUnit"
        Me.medUnit.Size = New System.Drawing.Size(121, 21)
        Me.medUnit.TabIndex = 38
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(707, 84)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(280, 335)
        Me.DataGridView2.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(707, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Stock Monitoring"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(707, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 23)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Stock < 30 | Please Re-Order Imidietly"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MasterMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 452)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.medUnit)
        Me.Controls.Add(Unit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Button_delete)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.medStock)
        Me.Controls.Add(Me.medPrice)
        Me.Controls.Add(Me.medName)
        Me.Controls.Add(Me.medId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterMedicine"
        Me.Text = "MasterMedicine"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_clear As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_edit As Button
    Friend WithEvents Button_save As Button
    Friend WithEvents medStock As TextBox
    Friend WithEvents medPrice As TextBox
    Friend WithEvents medName As TextBox
    Friend WithEvents medId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents medUnit As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
