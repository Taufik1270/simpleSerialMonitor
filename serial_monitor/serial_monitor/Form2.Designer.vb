<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_stopbits = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_databits = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_parity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_baudrate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_port = New System.Windows.Forms.ComboBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_openDir = New System.Windows.Forms.Button()
        Me.lbl_dir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(55, 238)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(76, 23)
        Me.btn_save.TabIndex = 22
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Stop Bits"
        '
        'cb_stopbits
        '
        Me.cb_stopbits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_stopbits.FormattingEnabled = True
        Me.cb_stopbits.Location = New System.Drawing.Point(124, 148)
        Me.cb_stopbits.Name = "cb_stopbits"
        Me.cb_stopbits.Size = New System.Drawing.Size(121, 28)
        Me.cb_stopbits.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Data Bits"
        '
        'cb_databits
        '
        Me.cb_databits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_databits.FormattingEnabled = True
        Me.cb_databits.Location = New System.Drawing.Point(124, 114)
        Me.cb_databits.Name = "cb_databits"
        Me.cb_databits.Size = New System.Drawing.Size(121, 28)
        Me.cb_databits.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Parity"
        '
        'cb_parity
        '
        Me.cb_parity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_parity.FormattingEnabled = True
        Me.cb_parity.Location = New System.Drawing.Point(124, 80)
        Me.cb_parity.Name = "cb_parity"
        Me.cb_parity.Size = New System.Drawing.Size(121, 28)
        Me.cb_parity.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Baudrate"
        '
        'cb_baudrate
        '
        Me.cb_baudrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_baudrate.FormattingEnabled = True
        Me.cb_baudrate.Location = New System.Drawing.Point(124, 46)
        Me.cb_baudrate.Name = "cb_baudrate"
        Me.cb_baudrate.Size = New System.Drawing.Size(121, 28)
        Me.cb_baudrate.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Port"
        '
        'cb_port
        '
        Me.cb_port.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_port.FormattingEnabled = True
        Me.cb_port.Location = New System.Drawing.Point(124, 12)
        Me.cb_port.Name = "cb_port"
        Me.cb_port.Size = New System.Drawing.Size(121, 28)
        Me.cb_port.TabIndex = 12
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(137, 238)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 23)
        Me.btn_cancel.TabIndex = 23
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_openDir
        '
        Me.btn_openDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openDir.Location = New System.Drawing.Point(124, 182)
        Me.btn_openDir.Name = "btn_openDir"
        Me.btn_openDir.Size = New System.Drawing.Size(35, 31)
        Me.btn_openDir.TabIndex = 24
        Me.btn_openDir.Text = "..."
        Me.btn_openDir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_openDir.UseVisualStyleBackColor = True
        '
        'lbl_dir
        '
        Me.lbl_dir.AutoSize = True
        Me.lbl_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dir.Location = New System.Drawing.Point(21, 189)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(85, 24)
        Me.lbl_dir.TabIndex = 25
        Me.lbl_dir.Text = "Log To : "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 283)
        Me.Controls.Add(Me.lbl_dir)
        Me.Controls.Add(Me.btn_openDir)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_stopbits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_databits)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_parity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_baudrate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_port)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_stopbits As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_databits As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_parity As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_baudrate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_port As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_openDir As Button
    Friend WithEvents lbl_dir As Label
End Class
