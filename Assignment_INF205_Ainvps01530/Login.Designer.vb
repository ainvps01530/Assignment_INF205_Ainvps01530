<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnketnoi = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(38, 43)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(81, 13)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Tên Tài Khoản:"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(63, 72)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(56, 13)
        Me.lblpass.TabIndex = 1
        Me.lblpass.Text = "Mật Khẩu:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(144, 40)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(187, 20)
        Me.txtid.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(144, 69)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(187, 20)
        Me.txtpass.TabIndex = 4
        Me.txtpass.UseSystemPasswordChar = True
        '
        'btnketnoi
        '
        Me.btnketnoi.Location = New System.Drawing.Point(144, 112)
        Me.btnketnoi.Name = "btnketnoi"
        Me.btnketnoi.Size = New System.Drawing.Size(75, 23)
        Me.btnketnoi.TabIndex = 5
        Me.btnketnoi.Text = "Kết Nối"
        Me.btnketnoi.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(256, 112)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 6
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 181)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnketnoi)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblid)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btnketnoi As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button

End Class
