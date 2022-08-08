Public Class MasterPatient
    Sub FormPtnInit()
        patientId.Text = ""
        patientName.Text = ""
        patientAddress.Text = ""
        patientAge.Text = ""
        patientStatus.Text = ""
        patientStatus.Items.Clear()


        patientId.Enabled = False
        patientName.Enabled = False
        patientAddress.Enabled = False
        patientAge.Enabled = False
        patientStatus.Enabled = False

        Button_save.Enabled = True
        Button_edit.Enabled = True
        Button_delete.Enabled = True
        Button_clear.Enabled = True

        Button_save.Text = "Input"
        Button_edit.Text = "Edit"
        Button_delete.Text = "Delete"
        Button_clear.Text = "Close"

        Call Connect_DB()
        Da = New Odbc.OdbcDataAdapter("Select patient_id as 'ID', patient_name as 'Patient Name', patient_address as 'Address', patient_age as 'Age' ,patient_status as 'Status', created as 'Created' from list_patient", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "list_patient")
        DataGridView1.DataSource = Ds.Tables("list_patient")
        DataGridView1.ReadOnly = True
    End Sub

    Sub FormPtnReady()
        patientId.Enabled = True
        patientName.Enabled = True
        patientAge.Enabled = True
        patientAddress.Enabled = True
        patientStatus.Enabled = True
        patientStatus.Items.Clear()
        patientStatus.Items.Add("New")
        patientStatus.Items.Add("Old")

    End Sub

    Private Sub MasterPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormPtnInit()
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        If Button_clear.Text = "Close" Then
            Me.Close()
        Else
            Call FormPtnInit()
        End If
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        If Button_save.Text = "Input" Then
            Button_save.Text = "Save"
            Button_edit.Enabled = False
            Button_delete.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormPtnReady()
            Call generateCodePtn()
            patientId.Enabled = False
            patientName.Focus()
        Else
            If patientId.Text = "" Or patientName.Text = "" Or patientAddress.Text = "" Or patientAge.Text = "" Or patientStatus.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim InputData As String = "Insert into list_patient (patient_id,patient_name,patient_address,patient_age,patient_status) values('" & patientId.Text & "','" & patientName.Text & "', '" & patientAddress.Text & "' ,'" & patientAge.Text & "','" & patientStatus.Text & "')"
                Dim Cmd = New Odbc.OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Success!")
                Call FormPtnInit()
            End If
        End If
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If Button_edit.Text = "Edit" Then
            Button_edit.Text = "Save"
            Button_save.Enabled = False
            Button_delete.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormPtnReady()
        Else
            If patientId.Text = "" Or patientName.Text = "" Or patientAddress.Text = "" Or patientAge.Text = "" Or patientStatus.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim UpdateData As String = "Update list_patient set patient_name ='" & patientName.Text & "',patient_address='" & patientAddress.Text & "',patient_age='" & patientAge.Text & "',patient_status='" & patientStatus.Text & "' where patient_id='" & patientId.Text & "'"
                Dim Cmd = New Odbc.OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Success!")
                Call FormPtnInit()
            End If
        End If
    End Sub

    Private Sub patientId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles patientId.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connect_DB()
            Cmd = New Odbc.OdbcCommand("select * from list_patient where patient_id='" & patientId.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Patient Id not Found!")
            Else
                patientId.Text = Rd.Item("patient_id")
                patientName.Text = Rd.Item("patient_name")
                patientAddress.Text = Rd.Item("patient_address")
                patientAge.Text = Rd.Item("patient_age")
                patientStatus.Text = Rd.Item("patient_status")
            End If
        End If
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        If Button_delete.Text = "Delete" Then
            Button_delete.Text = "Confirm"
            Button_save.Enabled = False
            Button_edit.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormPtnReady()
        Else
            If patientId.Text = "" Or patientName.Text = "" Or patientAddress.Text = "" Or patientAge.Text = "" Or patientStatus.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim DeleteData As String = "Delete from list_patient where patient_id='" & patientId.Text & "'"
                Dim Cmd = New Odbc.OdbcCommand(DeleteData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Data Success!")
                Call FormPtnInit()
            End If
        End If
    End Sub

    Sub generateCodePtn()
        Call Connect_DB()
        Cmd = New Odbc.OdbcCommand("SELECT * FROM list_patient WHERE patient_id IN (Select MAX(patient_id) From list_patient)", Conn)
        Dim codePtn As String
        Dim genCode As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            codePtn = "PTN" + "001"
        Else
            genCode = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            codePtn = "PTN" + Microsoft.VisualBasic.Right("000" & genCode, 3)
        End If

        patientId.Text = codePtn
    End Sub
End Class