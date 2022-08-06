Imports System.Data.Odbc
Public Class Form_Login

    Sub Init_open()
        FormMain.LoginToolStripMenuItem.Enabled = False
        FormMain.LogoutToolStripMenuItem.Enabled = True
        FormMain.ChangePasswordToolStripMenuItem.Enabled = True

        FormMain.MasterToolStripMenuItem.Enabled = True
        FormMain.AdminToolStripMenuItem.Enabled = True
        FormMain.PatientToolStripMenuItem.Enabled = True
        FormMain.MedicineToolStripMenuItem.Enabled = True

        FormMain.TransactionToolStripMenuItem.Enabled = True
        FormMain.ConsultationToolStripMenuItem.Enabled = True
        FormMain.PrescriptionMedToolStripMenuItem.Enabled = True
    End Sub

    Sub Clear_login()
        userName.Text = ""
        userPass.Text = ""
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If userName.Text = "" Or userPass.Text = "" Then
            MsgBox("Plaese fill Username & Password!")
        Else
            Call Connect_DB()
            Cmd = New Odbc.OdbcCommand("Select * from users where user_name='" & userName.Text & "' and user_pass='" & userPass.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Init_open()
            Else
                MsgBox("Username or Password Incorrect!")
            End If
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Clear_login()
    End Sub

End Class