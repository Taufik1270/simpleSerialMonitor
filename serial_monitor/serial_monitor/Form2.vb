Imports System.IO
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.MyCOMPort.Close()

        cb_baudrate.Items.Add(600)
        cb_baudrate.Items.Add(1200)
        cb_baudrate.Items.Add(2400)
        cb_baudrate.Items.Add(4800)
        cb_baudrate.Items.Add(9600)
        cb_baudrate.Items.Add(19800)
        cb_baudrate.Items.Add(57600)
        cb_baudrate.Items.Add(115200)
        cb_databits.Items.Add(8)
        cb_databits.Items.Add(7)
        cb_databits.Items.Add(6)
        cb_databits.Items.Add(5)
        cb_stopbits.Items.Add(1)
        cb_stopbits.Items.Add(1.5)
        cb_stopbits.Items.Add(2)
        cb_parity.Items.Add("NONE")
        cb_parity.Items.Add("ODD")
        cb_parity.Items.Add("EVEN")

        scanPort()
        Try
            cb_port.SelectedItem = cb_port.Items(0)
        Catch
            cb_port.Items.Add("NO PORT")
        End Try
        cb_parity.SelectedItem = cb_parity.Items(0)
        cb_baudrate.SelectedItem = cb_baudrate.Items(0)
        cb_databits.SelectedItem = cb_databits.Items(0)
        cb_stopbits.SelectedItem = cb_stopbits.Items(0)


        'cb_port.Enabled = False
        'cb_baudrate.Enabled = False
        'cb_stopbits.Enabled = False
        'cb_parity.Enabled = False
        'cb_databits.Enabled = False
    End Sub

    Public Sub scanPort()
        Try
            For Each sp As String In My.Computer.Ports.SerialPortNames
                If (cb_port.Items.Contains(sp) = False) Then
                    cb_port.Items.Add(sp)
                End If
            Next
        Catch
            cb_port.Items.Add("NO PORT")
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Form1.Timer1.Stop()
        Form1.MyCOMPort.Close()
        Form1.MyCOMPort.PortName = cb_port.Text
        Form1.MyCOMPort.BaudRate = cb_baudrate.Text
        Form1.MyCOMPort.Parity = Form1.parityDict(cb_parity.Text)
        Form1.setup_ok = 1
        Form1.Timer1.Start()
        Form1.lbl_conStatus.Text = "Disconnected"
        Form1.lbl_conStatus.ForeColor = Color.Red
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Form1.setup_ok = 1 Then
            Form1.btn_connect.Enabled = True
        End If
    End Sub

    Private Sub btn_openDir_Click(sender As Object, e As EventArgs) Handles btn_openDir.Click
        Dim txtFileFinder As OpenFileDialog = New OpenFileDialog()
        If (txtFileFinder.ShowDialog() = DialogResult.OK) Then
            Form1.logDir = txtFileFinder.FileName
        End If
    End Sub
End Class