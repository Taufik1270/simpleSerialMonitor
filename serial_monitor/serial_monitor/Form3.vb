Public Class Form3
    Private Sub btn_cmdsend_Click(sender As Object, e As EventArgs) Handles btn_cmdsend.Click
        If Form1.MyCOMPort.IsOpen = True Then
            Form1.MyCOMPort.Write(txt_cmdout.Text)
        End If
    End Sub
End Class