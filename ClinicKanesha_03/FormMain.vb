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

        labelUid.Text = ""
        labelUname.Text = ""
        labelAuth.Text = ""


    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initial_close()
        labelDate.Text = Today
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

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        MasterAdmin.ShowDialog()
    End Sub

    Private Sub PatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientToolStripMenuItem.Click
        MasterPatient.ShowDialog()
    End Sub

    Private Sub MedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicineToolStripMenuItem.Click
        MasterMedicine.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTime.Text = TimeOfDay

    End Sub

    Private Sub PrescriptionMedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrescriptionMedToolStripMenuItem.Click
        TscMedicine.ShowDialog()
    End Sub
End Class
