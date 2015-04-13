<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlysanpham
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
        Me.lblmasanpham = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtgiasp = New System.Windows.Forms.TextBox()
        Me.txtsoluongsp = New System.Windows.Forms.TextBox()
        Me.txtchitietsp = New System.Windows.Forms.TextBox()
        Me.dtgquanly = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cbbloaisp = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dtgquanly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmasanpham
        '
        Me.lblmasanpham.AutoSize = True
        Me.lblmasanpham.Location = New System.Drawing.Point(44, 40)
        Me.lblmasanpham.Name = "lblmasanpham"
        Me.lblmasanpham.Size = New System.Drawing.Size(77, 13)
        Me.lblmasanpham.TabIndex = 0
        Me.lblmasanpham.Text = "Mã Sản Phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên Sản Phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Giá Sản Phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Số Lượng Sản Phẩm:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Chi Tiết Sản Phẩm:"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(127, 37)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(370, 20)
        Me.txtmasp.TabIndex = 5
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(127, 64)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(370, 20)
        Me.txttensp.TabIndex = 6
        '
        'txtgiasp
        '
        Me.txtgiasp.Location = New System.Drawing.Point(127, 92)
        Me.txtgiasp.Name = "txtgiasp"
        Me.txtgiasp.Size = New System.Drawing.Size(370, 20)
        Me.txtgiasp.TabIndex = 7
        Me.txtgiasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsoluongsp
        '
        Me.txtsoluongsp.Location = New System.Drawing.Point(127, 118)
        Me.txtsoluongsp.Name = "txtsoluongsp"
        Me.txtsoluongsp.Size = New System.Drawing.Size(370, 20)
        Me.txtsoluongsp.TabIndex = 8
        Me.txtsoluongsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtchitietsp
        '
        Me.txtchitietsp.Location = New System.Drawing.Point(127, 145)
        Me.txtchitietsp.Name = "txtchitietsp"
        Me.txtchitietsp.Size = New System.Drawing.Size(370, 20)
        Me.txtchitietsp.TabIndex = 9
        '
        'dtgquanly
        '
        Me.dtgquanly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgquanly.Location = New System.Drawing.Point(12, 236)
        Me.dtgquanly.Name = "dtgquanly"
        Me.dtgquanly.Size = New System.Drawing.Size(723, 246)
        Me.dtgquanly.TabIndex = 10
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(519, 134)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(91, 57)
        Me.btnsua.TabIndex = 11
        Me.btnsua.Text = "SỬA"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(630, 124)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(107, 67)
        Me.btnxoa.TabIndex = 12
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(519, 37)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(91, 57)
        Me.btnthem.TabIndex = 13
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Mã Loại Sản Phẩm:"
        '
        'cbbloaisp
        '
        Me.cbbloaisp.FormattingEnabled = True
        Me.cbbloaisp.Items.AddRange(New Object() {"dtdd", "lapt", "xeymh"})
        Me.cbbloaisp.Location = New System.Drawing.Point(127, 170)
        Me.cbbloaisp.Name = "cbbloaisp"
        Me.cbbloaisp.Size = New System.Drawing.Size(86, 21)
        Me.cbbloaisp.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(294, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "( lapt = Laptop, dtdd = Điện Thoại di động, xeymh = Xe máy )"
        '
        'frmquanlysanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 494)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbbloaisp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.dtgquanly)
        Me.Controls.Add(Me.txtchitietsp)
        Me.Controls.Add(Me.txtsoluongsp)
        Me.Controls.Add(Me.txtgiasp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmasanpham)
        Me.Name = "frmquanlysanpham"
        Me.Text = "Quản Lý Sản Phẩm"
        CType(Me.dtgquanly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmasanpham As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtgiasp As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluongsp As System.Windows.Forms.TextBox
    Friend WithEvents txtchitietsp As System.Windows.Forms.TextBox
    Friend WithEvents dtgquanly As System.Windows.Forms.DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbbloaisp As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
