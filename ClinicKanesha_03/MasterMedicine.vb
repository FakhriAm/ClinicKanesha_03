Public Class MasterMedicine
    Sub FormMedInit()
        medId.Text = ""
        medName.Text = ""
        medPrice.Text = ""
        medStock.Text = ""
        medUnit.Items.Clear()



        medId.Enabled = False
        medName.Enabled = False
        medPrice.Enabled = False
        medStock.Enabled = False
        medUnit.Enabled = False

        Button_save.Enabled = True
        Button_edit.Enabled = True
        Button_delete.Enabled = True
        Button_clear.Enabled = True

        Button_save.Text = "Input"
        Button_edit.Text = "Edit"
        Button_delete.Text = "Delete"
        Button_clear.Text = "Close"

        Call Connect_DB()
        Da = New Odbc.OdbcDataAdapter("Select med_id as 'ID', med_name as 'Medicine Name', med_stock as 'Stock' , med_unit as 'Unit', med_price as 'Price', med_status as 'Status', med_date_in as 'Date In',med_date_ex as 'Expired Date' from list_medicine", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "list_medicine")
        DataGridView1.DataSource = Ds.Tables("list_medicine")
        DataGridView1.ReadOnly = True
        Call stockAlarm()

    End Sub

    Sub stockAlarm()
        Call Connect_DB()
        Da = New Odbc.OdbcDataAdapter("select med_name as 'Medicine Name', med_stock as 'Stock' , med_unit as 'Unit' from list_medicine where med_stock <= 30 and med_status = 'Good' ", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "list_medicine")
        DataGridView2.DataSource = Ds.Tables("list_medicine")
        DataGridView2.ReadOnly = True
    End Sub

    Sub FormMedReady()
        medId.Enabled = True
        medName.Enabled = True
        medPrice.Enabled = True
        medStock.Enabled = True
        medUnit.Enabled = True

        medUnit.Items.Clear()
        medUnit.Items.Add("Syrup")
        medUnit.Items.Add("Capsule")
        medUnit.Items.Add("Tablet")
        medUnit.Items.Add("Suplement")

    End Sub

    Sub fillUnit()
        Call Connect_DB()
        Cmd = New Odbc.OdbcCommand("Select distinct med_unit from list_medicine", Conn)
        Rd = Cmd.ExecuteReader()
        medUnit.Items.Clear()
        Do While Rd.Read
            medUnit.Items.Add(Rd.Item("med_unit"))
        Loop

    End Sub


    Private Sub MasterMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMedInit()
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        If Button_clear.Text = "Close" Then
            Me.Close()
        Else
            Call FormMedInit()
        End If
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        If Button_save.Text = "Input" Then
            Button_save.Text = "Save"
            Button_edit.Enabled = False
            Button_delete.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormMedReady()
            Call generateCodeMed()
            medId.Enabled = False
            medName.Focus()
        Else
            If medId.Text = "" Or medName.Text = "" Or medPrice.Text = "" Or medStock.Text = "" Or medUnit.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim InputData As String = "Insert into list_medicine (med_id,med_name,med_stock,med_price,med_unit) values('" & medId.Text & "','" & medName.Text & "','" & medStock.Text & "', '" & medPrice.Text & "' ,'" & medUnit.Text & "')"
                Dim Cmd = New Odbc.OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Success!")
                Call FormMedInit()
            End If
        End If
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If Button_edit.Text = "Edit" Then
            Button_edit.Text = "Save"
            Button_save.Enabled = False
            Button_delete.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormMedReady()
        Else
            If medId.Text = "" Or medName.Text = "" Or medPrice.Text = "" Or medStock.Text = "" Or medUnit.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim UpdateData As String = "Update list_medicine set med_name='" & medName.Text & "', med_stock = ' " & medStock.Text & " ', med_unit = '" & medUnit.Text & "', med_price= '" & medPrice.Text & "' where med_id = '" & medId.Text & "'"
                Dim Cmd = New Odbc.OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Success!")
                Call FormMedInit()
            End If
        End If
    End Sub



    Private Sub medId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles medId.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connect_DB()
            Cmd = New Odbc.OdbcCommand("select * from list_medicine where med_id='" & medId.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Patient Id not Found!")
            Else
                medId.Text = Rd.Item("med_id")
                medName.Text = Rd.Item("med_name")
                medUnit.Text = Rd.Item("med_unit")
                medStock.Text = Rd.Item("med_stock")
                medPrice.Text = Rd.Item("med_price")
            End If
        End If
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        If Button_delete.Text = "Delete" Then
            Button_delete.Text = "Confirm"
            Button_save.Enabled = False
            Button_edit.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormMedReady()
        Else
            If medId.Text = "" Or medName.Text = "" Or medPrice.Text = "" Or medStock.Text = "" Or medUnit.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim DeleteData As String = "Delete from list_medicine where med_id='" & medId.Text & "'"
                Dim Cmd = New Odbc.OdbcCommand(DeleteData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Data Success!")
                Call FormMedInit()
            End If
        End If
    End Sub


    Private Sub medPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles medPrice.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub


    Private Sub medStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles medStock.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Sub generateCodeMed()
        Call Connect_DB()
        Cmd = New Odbc.OdbcCommand("SELECT * FROM list_medicine WHERE med_id IN (Select MAX(med_id) From list_medicine)", Conn)
        Dim codeMed As String
        Dim genCode As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            codeMed = "MED" + "001"
        Else
            genCode = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            codeMed = "MED" + Microsoft.VisualBasic.Right("000" & genCode, 3)
        End If

        medId.Text = codeMed
    End Sub

End Class