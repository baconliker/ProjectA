﻿Public Class MainForm

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        MessageBox.Show("Test completed (concurrent - remote).", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class
