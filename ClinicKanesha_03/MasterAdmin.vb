Public Class MasterAdmin
    Sub FormAdmInit()
        userId.Text = ""
        userName.Text = ""
        userPass.Text = ""
        userAuth.Text = ""
        userAuth.Items.Clear()

        userId.Enabled = False
        userName.Enabled = False
        userPass.Enabled = False
        userAuth.Enabled = False

        Button_save.Enabled = True
        Button_edit.Enabled = True
        Button_delete.Enabled = True
        Button_clear.Enabled = True

        Button_save.Text = "Input"
        Button_edit.Text = "Edit"
        Button_delete.Text = "Delete"
        Button_clear.Text = "Close"

        Call Connect_DB()
        Da = New Odbc.OdbcDataAdapter("Select user_id as 'ID', user_name as 'User Name',user_auth as 'Level', created as 'Created' from users", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "users")
        DataGridView1.DataSource = Ds.Tables("users")
        DataGridView1.ReadOnly = True
    End Sub

    Sub FormAdmReady()
        userId.Enabled = True
        userName.Enabled = True
        userPass.Enabled = True
        userAuth.Enabled = True
        userAuth.Items.Clear()
        userAuth.Items.Add("admin")
        userAuth.Items.Add("user")

    End Sub

    Private Sub MasterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormAdmInit()
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        If Button_clear.Text = "Close" Then
            Me.Close()
        Else
            Call FormAdmInit()
        End If
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        If Button_save.Text = "Input" Then
            Button_save.Text = "Save"
            Button_edit.Enabled = False
            Button_delete.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormAdmReady()
            Call generateCodeUid()
            userId.Enabled = False
            userName.Focus()
        Else
            If userName.Text = "" Or userPass.Text = "" Or userId.Text = "" Or userAuth.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim InputData As String = "Insert into users (user_id,user_name,user_pass,user_auth) values('" & userId.Text & "','" & userName.Text & "','" & userPass.Text & "','" & userAuth.Text & "')"
                Dim Cmd = New Odbc.OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Success!")
                Call FormAdmInit()
            End If
        End If
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If Button_edit.Text = "Edit" Then
            Button_edit.Text = "Save"
            Button_save.Enabled = False
            Button_delete.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormAdmReady()
        Else
            If userName.Text = "" Or userPass.Text = "" Or userId.Text = "" Or userAuth.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim UpdateData As String = "Update users set user_name ='" & userName.Text & "',user_pass='" & userPass.Text & "',user_auth='" & userAuth.Text & "' where user_id='" & userId.Text & "'"
                Dim Cmd = New Odbc.OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Success!")
                Call FormAdmInit()
            End If
        End If
    End Sub


    Private Sub userId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles userId.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connect_DB()
            Cmd = New Odbc.OdbcCommand("select * from users where user_id='" & userId.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("User Id not Found!")
            Else
                userId.Text = Rd.Item("user_id")
                userName.Text = Rd.Item("user_name")
                userPass.Text = Rd.Item("user_pass")
                userAuth.Text = Rd.Item("user_auth")
            End If
        End If
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        If Button_delete.Text = "Delete" Then
            Button_delete.Text = "Confirm"
            Button_save.Enabled = False
            Button_edit.Enabled = False
            Button_clear.Text = "Cancel"
            Call FormAdmReady()
        Else
            If userName.Text = "" Or userPass.Text = "" Or userId.Text = "" Or userAuth.Text = "" Then
                MsgBox("Please complete the field before save!")
            Else
                Call Connect_DB()
                Dim DeleteData As String = "Delete from users where user_id='" & userId.Text & "'"
                Dim Cmd = New Odbc.OdbcCommand(DeleteData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Data Success!")
                Call FormAdmInit()
            End If
        End If
    End Sub

    Sub generateCodeUid()
        Call Connect_DB()
        Cmd = New Odbc.OdbcCommand("SELECT * FROM users WHERE user_id IN (Select MAX(user_id) From users)", Conn)
        Dim codeUid As String
        Dim genCode As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            codeUid = "UID" + "001"
        Else
            genCode = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            codeUid = "UID" + Microsoft.VisualBasic.Right("000" & genCode, 3)
        End If

        userId.Text = codeUid
    End Sub
End Class