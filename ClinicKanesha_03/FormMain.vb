Public Class FormMain
    Sub Initial_close()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False

        MasterToolStripMenuItem.Enabled = False
        AdminToolStripMenuItem.Enabled = False
        PatientToolStripMenuItem.Enabled = False
        MedicineToolStripMenuItem.Enabled = False

        TransactionToolStripMenuItem.Enabled = False
        ConsultationToolStripMenuItem.Enabled = False
        PrescriptionMedToolStripMenuItem.Enabled = False

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initial_close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form_Login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Initial_close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub
End Class
