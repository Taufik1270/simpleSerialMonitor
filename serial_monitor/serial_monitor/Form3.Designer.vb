<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txt_cmdout = New System.Windows.Forms.TextBox()
        Me.btn_cmdsend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_cmdout
        '
        Me.txt_cmdout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cmdout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cmdout.Location = New System.Drawing.Point(12, 12)
        Me.txt_cmdout.Multiline = True
        Me.txt_cmdout.Name = "txt_cmdout"
        Me.txt_cmdout.Size = New System.Drawing.Size(611, 65)
        Me.txt_cmdout.TabIndex = 0
        '
        'btn_cmdsend
        '
        Me.btn_cmdsend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cmdsend.Location = New System.Drawing.Point(12, 93)
        Me.btn_cmdsend.Name = "btn_cmdsend"
        Me.btn_cmdsend.Size = New System.Drawing.Size(610, 32)
        Me.btn_cmdsend.TabIndex = 1
        Me.btn_cmdsend.Text = "SEND"
        Me.btn_cmdsend.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 147)
        Me.Controls.Add(Me.btn_cmdsend)
        Me.Controls.Add(Me.txt_cmdout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Send String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cmdout As TextBox
    Friend WithEvents btn_cmdsend As Button
End Class
