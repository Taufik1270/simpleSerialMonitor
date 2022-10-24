<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_logfile = New System.Windows.Forms.Button()
        Me.btn_sendstring = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_conStatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 65)
        Me.TextBox1.MaxLength = 255
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(742, 345)
        Me.TextBox1.TabIndex = 0
        '
        'Timer1
        '
        '
        'btn_clear
        '
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.Location = New System.Drawing.Point(41, 23)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(29, 29)
        Me.btn_clear.TabIndex = 12
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_connect
        '
        Me.btn_connect.BackgroundImage = CType(resources.GetObject("btn_connect.BackgroundImage"), System.Drawing.Image)
        Me.btn_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_connect.Location = New System.Drawing.Point(19, 23)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(29, 29)
        Me.btn_connect.TabIndex = 13
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_scan
        '
        Me.btn_scan.BackgroundImage = CType(resources.GetObject("btn_scan.BackgroundImage"), System.Drawing.Image)
        Me.btn_scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_scan.Location = New System.Drawing.Point(15, 27)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(29, 29)
        Me.btn_scan.TabIndex = 14
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'btn_logfile
        '
        Me.btn_logfile.BackgroundImage = CType(resources.GetObject("btn_logfile.BackgroundImage"), System.Drawing.Image)
        Me.btn_logfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logfile.Location = New System.Drawing.Point(6, 23)
        Me.btn_logfile.Name = "btn_logfile"
        Me.btn_logfile.Size = New System.Drawing.Size(29, 29)
        Me.btn_logfile.TabIndex = 15
        Me.btn_logfile.UseVisualStyleBackColor = True
        '
        'btn_sendstring
        '
        Me.btn_sendstring.BackgroundImage = CType(resources.GetObject("btn_sendstring.BackgroundImage"), System.Drawing.Image)
        Me.btn_sendstring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sendstring.Location = New System.Drawing.Point(54, 23)
        Me.btn_sendstring.Name = "btn_sendstring"
        Me.btn_sendstring.Size = New System.Drawing.Size(29, 29)
        Me.btn_sendstring.TabIndex = 16
        Me.btn_sendstring.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_sendstring)
        Me.GroupBox1.Controls.Add(Me.btn_connect)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(133, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 58)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connectivity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_logfile)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(50, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(77, 58)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'lbl_conStatus
        '
        Me.lbl_conStatus.AutoSize = True
        Me.lbl_conStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conStatus.Location = New System.Drawing.Point(267, 24)
        Me.lbl_conStatus.Name = "lbl_conStatus"
        Me.lbl_conStatus.Size = New System.Drawing.Size(138, 24)
        Me.lbl_conStatus.TabIndex = 17
        Me.lbl_conStatus.Text = "Disconnected"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 422)
        Me.Controls.Add(Me.lbl_conStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Monitor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_scan As Button
    Friend WithEvents btn_logfile As Button
    Friend WithEvents btn_sendstring As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbl_conStatus As Label
End Class
