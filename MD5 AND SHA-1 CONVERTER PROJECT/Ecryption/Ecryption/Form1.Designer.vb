<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MD5btn = New System.Windows.Forms.Button()
        Me.stringtxt = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsha1 = New System.Windows.Forms.Label()
        Me.resulttxt = New System.Windows.Forms.Label()
        Me.lblmd5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sha1box = New System.Windows.Forms.TextBox()
        Me.md5box = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MD5btn
        '
        Me.MD5btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MD5btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MD5btn.FlatAppearance.BorderSize = 0
        Me.MD5btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MD5btn.Font = New System.Drawing.Font("AR DESTINE", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MD5btn.ForeColor = System.Drawing.SystemColors.Info
        Me.MD5btn.Location = New System.Drawing.Point(275, 222)
        Me.MD5btn.Name = "MD5btn"
        Me.MD5btn.Size = New System.Drawing.Size(246, 32)
        Me.MD5btn.TabIndex = 0
        Me.MD5btn.Tag = ""
        Me.MD5btn.Text = "Convert"
        Me.MD5btn.UseVisualStyleBackColor = False
        '
        'stringtxt
        '
        Me.stringtxt.AccessibleDescription = ""
        Me.stringtxt.AccessibleName = ""
        Me.stringtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stringtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stringtxt.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stringtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.stringtxt.Location = New System.Drawing.Point(102, 91)
        Me.stringtxt.Name = "stringtxt"
        Me.stringtxt.Size = New System.Drawing.Size(509, 29)
        Me.stringtxt.TabIndex = 2
        Me.stringtxt.Tag = ""
        Me.stringtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DigifaceWide", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(182, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DATA ENCRYPTION"
        '
        'lblsha1
        '
        Me.lblsha1.AutoSize = True
        Me.lblsha1.Font = New System.Drawing.Font("AR DESTINE", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsha1.ForeColor = System.Drawing.Color.Green
        Me.lblsha1.Location = New System.Drawing.Point(98, 143)
        Me.lblsha1.Name = "lblsha1"
        Me.lblsha1.Size = New System.Drawing.Size(170, 23)
        Me.lblsha1.TabIndex = 5
        Me.lblsha1.Text = "SHA-1 Encryption:"
        '
        'resulttxt
        '
        Me.resulttxt.AutoSize = True
        Me.resulttxt.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resulttxt.ForeColor = System.Drawing.Color.Green
        Me.resulttxt.Location = New System.Drawing.Point(98, 166)
        Me.resulttxt.Name = "resulttxt"
        Me.resulttxt.Size = New System.Drawing.Size(0, 24)
        Me.resulttxt.TabIndex = 6
        Me.resulttxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblmd5
        '
        Me.lblmd5.AutoSize = True
        Me.lblmd5.Font = New System.Drawing.Font("AR DESTINE", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmd5.ForeColor = System.Drawing.Color.Green
        Me.lblmd5.Location = New System.Drawing.Point(98, 180)
        Me.lblmd5.Name = "lblmd5"
        Me.lblmd5.Size = New System.Drawing.Size(158, 23)
        Me.lblmd5.TabIndex = 7
        Me.lblmd5.Text = "MD5 Encryption:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AR DESTINE", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(98, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter text:"
        '
        'sha1box
        '
        Me.sha1box.Enabled = False
        Me.sha1box.Location = New System.Drawing.Point(275, 145)
        Me.sha1box.Name = "sha1box"
        Me.sha1box.Size = New System.Drawing.Size(336, 20)
        Me.sha1box.TabIndex = 9
        '
        'md5box
        '
        Me.md5box.Enabled = False
        Me.md5box.Location = New System.Drawing.Point(275, 183)
        Me.md5box.Name = "md5box"
        Me.md5box.Size = New System.Drawing.Size(336, 20)
        Me.md5box.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("AR DESTINE", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(538, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Tag = ""
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(769, 304)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.md5box)
        Me.Controls.Add(Me.sha1box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblmd5)
        Me.Controls.Add(Me.resulttxt)
        Me.Controls.Add(Me.lblsha1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stringtxt)
        Me.Controls.Add(Me.MD5btn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(774, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Encryption"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MD5btn As Button
    Friend WithEvents stringtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsha1 As Label
    Friend WithEvents resulttxt As Label
    Friend WithEvents lblmd5 As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents Table1BindingSource As BindingSource

    Friend WithEvents FirstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents sha1box As TextBox
    Friend WithEvents md5box As TextBox
    Friend WithEvents Button1 As Button
End Class
