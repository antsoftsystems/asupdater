Public Class frmUpdateDesc

    Private Sub RtfDescUpdate_LinkClicked(sender As Object, e As Windows.Forms.LinkClickedEventArgs)
        Process.Start(e.LinkText)
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim frm As New frmUpdater
        Dispose()
        frm.ShowDialog()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dispose()
    End Sub



    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Dim frm As New FrmAbout
        frm.ShowDialog(Me)
    End Sub
End Class