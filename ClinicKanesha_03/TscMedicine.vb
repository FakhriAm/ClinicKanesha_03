Imports System.Data.Odbc
Public Class TscMedicine
    Sub InitFormTsc()
        labelPtnName.Text = ""
        labelPtnAddress.Text = ""
        labelDate.Text = Today
        labelAdmin.Text = FormMain.labelUname.Text
        chengeIn.Text = ""
        idPatient.Text = ""
        idPatient.Items.Clear()
        medName.Items.Clear()
        DataGridView1.Columns.Clear()
        labelQty.Text = ""
        labelMedPrice.Text = ""
        labelMedId.Text = ""
        totalIn.Text = ""
        cashIn.Text = ""
        Call generateCodeTsc()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTime.Text = TimeOfDay
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub



    Private Sub TscMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitFormTsc()
        Call getPatientData()
        Call generateCodeTsc()
        Call AddingColumn()
        Call getMedicineData()
        totalIn.Text = ""

    End Sub

    Sub getPatientData()
        Call Connect_DB()
        Cmd = New OdbcCommand("Select * From list_patient", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            idPatient.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Sub getMedicineData()
        Call Connect_DB()
        Cmd = New OdbcCommand("Select * From list_medicine", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            medName.Items.Add(Rd.Item(2))
        Loop
    End Sub

    Private Sub idPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idPatient.SelectedIndexChanged
        Call Connect_DB()
        Cmd = New OdbcCommand("Select * From list_patient where patient_id = '" & idPatient.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            labelPtnName.Text = Rd!patient_name
            labelPtnAddress.Text = Rd!patient_address
        End If
    End Sub

    Private Sub medName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles medName.SelectedIndexChanged
        Call Connect_DB()
        Cmd = New OdbcCommand("Select * From list_medicine where med_name = '" & medName.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            labelMedId.Text = Rd!med_id
            labelMedPrice.Text = Rd!med_Price
        End If
    End Sub

    Sub generateCodeTsc()
        Call Connect_DB()
        Cmd = New OdbcCommand("SELECT * FROM list_transaction WHERE tsc_code IN (Select MAX(tsc_code) From list_transaction)", Conn)
        Dim codeTsc As String
        Dim genCode As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            codeTsc = "T" + Format(Now, "yyMMdd") + "001"
        Else
            genCode = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            codeTsc = "T" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("003" & genCode, 3)
        End If

        LabelCodeTsc.Text = codeTsc
    End Sub

    Sub AddingColumn()
        DataGridView1.Columns.Add("Code", "Code")
        DataGridView1.Columns.Add("Name", "Medicine Name")
        DataGridView1.Columns.Add("Price", "Price")
        DataGridView1.Columns.Add("Qty", "Qty")
        DataGridView1.Columns.Add("SubTotal", "SubTotal")
    End Sub

    Private Sub ButtonInsertMed_Click(sender As Object, e As EventArgs) Handles ButtonInsertMed.Click

        If idPatient.Text = "" Then
            MsgBox("Please Select Patient Id Before Insert!")
            idPatient.Focus()
        ElseIf medName.Text = "" Then
            MsgBox("Please Select Item Before Insert!")
            medName.Focus()
        ElseIf medQty.Text = "" Then
            MsgBox("Fill Qty!")
            medQty.Focus()
        Else
            DataGridView1.Rows.Add(New String() {labelMedId.Text, medName.Text, labelMedPrice.Text, Val(medQty.Text), Val(medQty.Text) * labelMedPrice.Text})
            Call getTotal()
            Call getTotalQty()
            medName.Text = ""
            medQty.Text = ""
        End If

    End Sub

    Sub getTotal()
        Dim total As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            total = total + DataGridView1.Rows(i).Cells(4).Value
            totalIn.Text = total
        Next
    End Sub

    Sub getTotalQty()
        Dim Counter As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Counter = Counter + DataGridView1.Rows(i).Cells(3).Value
        Next
        labelQty.Text = Counter
    End Sub



    Private Sub cashIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cashIn.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(cashIn.Text) < Val(totalIn.Text) Then
                MsgBox("Insuficient Cash Amount!")
            ElseIf Val(cashIn.Text) = Val(totalIn.Text) Then
                chengeIn.Text = 0
            ElseIf Val(cashIn.Text) > Val(totalIn.Text) Then
                chengeIn.Text = Val(cashIn.Text) - Val(totalIn.Text)
            End If
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If Val(cashIn.Text) < Val(totalIn.Text) Then
            MsgBox("Insuficient Cash Amount!")
        ElseIf Val(cashIn.Text) = Val(totalIn.Text) Then
            chengeIn.Text = 0
        ElseIf Val(cashIn.Text) > Val(totalIn.Text) Then
            chengeIn.Text = Val(cashIn.Text) - Val(totalIn.Text)
        End If

        If idPatient.Text = "" Or labelPtnName.Text = "" Or chengeIn.Text = "" Or cashIn.Text = "" Then
            MsgBox("Please Fill All the data form before save!")
        Else
            Dim dateFormatSql As String
            dateFormatSql = Format(Today, "yyyy-MM-dd")
            Dim saveDataTsc As String = "insert into list_transaction (tsc_code,tsc_patient_id,tsc_user_id,tsc_date,tsc_time,tsc_total_item,tsc_cash_in,tsc_change_in) values ('" & LabelCodeTsc.Text & "','" & idPatient.Text & "','" & FormMain.labelUid.Text & "','" & dateFormatSql & "','" & labelTime.Text & "','" & labelQty.Text & "','" & cashIn.Text & "','" & chengeIn.Text & "')"
            Cmd = New OdbcCommand(saveDataTsc, Conn)
            Cmd.ExecuteNonQuery()

            For rowData As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim saveDataDtl = "Insert into list_detail_transaction (tsc_code,med_id,med_name,tsc_qty,tsc_sub_total) values ('" & LabelCodeTsc.Text & "','" & DataGridView1.Rows(rowData).Cells(0).Value & "','" & DataGridView1.Rows(rowData).Cells(1).Value & "','" & DataGridView1.Rows(rowData).Cells(3).Value & "','" & DataGridView1.Rows(rowData).Cells(4).Value & "')"
                Cmd = New OdbcCommand(saveDataDtl, Conn)
                Cmd.ExecuteNonQuery()
            Next

            MsgBox("Data Saved !")
            Call InitFormTsc()
        End If
    End Sub
End Class