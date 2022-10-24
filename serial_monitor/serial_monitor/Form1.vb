Imports System          'To Access Console.WriteLine()
Imports System.IO.Ports 'To Access the SerialPort
Imports System.IO


Public Class Form1
    Public logDir As String = ""
    Public DataReceived As String
    Public AvailablePorts() As String = SerialPort.GetPortNames()
    Public MyCOMPort As SerialPort
    Public timerCounter As Int64
    Public _baudrate As Int32 = 9600
    Public parityDict As New Dictionary(Of String, Integer)()
    Public windowIsResize As Byte = 0
    Public windowIsclosed As Byte = 0
    Public wakeup As Byte = 0
    Public setup_ok As Byte = 0
    Public setup_changed As Byte = 0

    Public Sub setSerialProp(cfg_port As String, cfg_baud As Int32, cfg_parity As String, databits As Byte, stopbits As Byte)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataReceived = ""
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM0"   'Assign the port name to the MyCOMPort object
        MyCOMPort.BaudRate = 115200      'Assign the Baudrate to the MyCOMPort object
        MyCOMPort.Parity = Parity.None   'Parity bits = none  
        MyCOMPort.DataBits = 8             'No of Data bits = 8
        MyCOMPort.StopBits = StopBits.One  'No of Stop bits = 1

        parityDict.Add("NONE", 0)
        parityDict.Add("ODD", 1)
        parityDict.Add("EVEN", 2)



        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim buf As String
        buf = ""
        If MyCOMPort.IsOpen Then
            buf = MyCOMPort.ReadExisting()
        End If

        If (buf.Length() > 0) Then
            DataReceived += buf ' Waiting for Data to be send 
        End If

        timerCounter += 1

        If timerCounter > 5 And DataReceived.Length() Then
            If windowIsclosed = 0 Then
                If wakeup = 0 Then
                    TextBox1.AppendText(DataReceived)
                    timerCounter = 0
                    DataReceived = ""
                Else
                    TextBox1.Text = DataReceived
                    timerCounter = 0
                    DataReceived = ""
                    wakeup = 0
                End If
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MyCOMPort.Close()
        MyCOMPort.Close()
        MyCOMPort.Close()
        Timer1.Stop()
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        While MyCOMPort.IsOpen = True
            MyCOMPort.Close()
        End While
        Form2.Show()
    End Sub


    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_scan.Click, btn_connect.Click
        If setup_ok <> 0 Then
            Try
                MyCOMPort.Open()
                lbl_conStatus.Text = "Connected"
                lbl_conStatus.ForeColor = Color.LimeGreen
            Catch
            End Try

        Else
            TextBox1.AppendText("Serial Port Not Configured " & vbNewLine)
        End If
    End Sub



    Private Sub Form1_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        windowIsResize = 1
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        windowIsResize = 0
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs)
        'windowIsclosed = 0
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If (WindowState = FormWindowState.Minimized) Then
            windowIsclosed = 1
        Else
            windowIsclosed = 0
            wakeup = 1
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub btn_sendstring_Click(sender As Object, e As EventArgs) Handles btn_sendstring.Click
        Form3.Show()
    End Sub

    Private Sub btn_logfile_Click(sender As Object, e As EventArgs) Handles btn_logfile.Click
        Try
            File.WriteAllText(logDir, TextBox1.Text)
        Catch ex As Exception
            TextBox1.AppendText(ex.Message)
        End Try
    End Sub

    Private Sub btn_scan_MouseHover(sender As Object, e As EventArgs) Handles btn_scan.MouseHover
        ToolTip1.Show("Settings", btn_scan)
    End Sub

    Private Sub btn_logfile_MouseHover(sender As Object, e As EventArgs) Handles btn_logfile.MouseHover
        ToolTip1.Show("Log Data", btn_logfile)
    End Sub

    Private Sub btn_clear_MouseHover(sender As Object, e As EventArgs) Handles btn_clear.MouseHover
        ToolTip1.Show("Clear Data", btn_clear)
    End Sub

    Private Sub btn_connect_MouseHover(sender As Object, e As EventArgs) Handles btn_connect.MouseHover
        ToolTip1.Show("Connect", btn_connect)
    End Sub

    Private Sub btn_sendstring_MouseHover(sender As Object, e As EventArgs) Handles btn_sendstring.MouseHover
        ToolTip1.Show("Send String", btn_sendstring)
    End Sub
End Class
