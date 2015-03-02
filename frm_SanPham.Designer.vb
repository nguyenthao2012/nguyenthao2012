<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SanPham
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
        Me.lsv_SP = New System.Windows.Forms.ListView()
        Me.lsv_Loai = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.btnThemSP = New System.Windows.Forms.Button()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLoaiSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnXoaSP = New System.Windows.Forms.Button()
        Me.btnSuaSP = New System.Windows.Forms.Button()
        Me.txtMotaLoai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSuaLoai = New System.Windows.Forms.Button()
        Me.btnXoaLoai = New System.Windows.Forms.Button()
        Me.btnThemLoai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsv_SP
        '
        Me.lsv_SP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsv_SP.FullRowSelect = True
        Me.lsv_SP.GridLines = True
        Me.lsv_SP.Location = New System.Drawing.Point(2, 194)
        Me.lsv_SP.MultiSelect = False
        Me.lsv_SP.Name = "lsv_SP"
        Me.lsv_SP.Size = New System.Drawing.Size(473, 295)
        Me.lsv_SP.TabIndex = 0
        Me.lsv_SP.UseCompatibleStateImageBehavior = False
        Me.lsv_SP.View = System.Windows.Forms.View.Details
        '
        'lsv_Loai
        '
        Me.lsv_Loai.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lsv_Loai.FullRowSelect = True
        Me.lsv_Loai.GridLines = True
        Me.lsv_Loai.Location = New System.Drawing.Point(481, 194)
        Me.lsv_Loai.MultiSelect = False
        Me.lsv_Loai.Name = "lsv_Loai"
        Me.lsv_Loai.Size = New System.Drawing.Size(315, 295)
        Me.lsv_Loai.TabIndex = 1
        Me.lsv_Loai.UseCompatibleStateImageBehavior = False
        Me.lsv_Loai.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã sản phẩm"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên "
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Loại "
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 119
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Đơn giá"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mô tả"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mã loại"
        Me.ColumnHeader6.Width = 78
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tên"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 128
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Mô tả"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã sản phẩm"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(89, 6)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.ReadOnly = True
        Me.txtMaSP.Size = New System.Drawing.Size(210, 20)
        Me.txtMaSP.TabIndex = 3
        '
        'btnThemSP
        '
        Me.btnThemSP.Location = New System.Drawing.Point(89, 165)
        Me.btnThemSP.Name = "btnThemSP"
        Me.btnThemSP.Size = New System.Drawing.Size(95, 23)
        Me.btnThemSP.TabIndex = 4
        Me.btnThemSP.Text = "Thêm sản phẩm"
        Me.btnThemSP.UseVisualStyleBackColor = True
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(89, 32)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(210, 20)
        Me.txtTenSP.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên sản phẩm"
        '
        'txtLoaiSP
        '
        Me.txtLoaiSP.Location = New System.Drawing.Point(89, 58)
        Me.txtLoaiSP.Name = "txtLoaiSP"
        Me.txtLoaiSP.ReadOnly = True
        Me.txtLoaiSP.Size = New System.Drawing.Size(210, 20)
        Me.txtLoaiSP.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Loại sản phẩm"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(89, 84)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(210, 20)
        Me.txtDonGia.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Đơn giá"
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(89, 110)
        Me.txtMoTa.Multiline = True
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(210, 49)
        Me.txtMoTa.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mô tả"
        '
        'btnXoaSP
        '
        Me.btnXoaSP.Location = New System.Drawing.Point(190, 165)
        Me.btnXoaSP.Name = "btnXoaSP"
        Me.btnXoaSP.Size = New System.Drawing.Size(95, 23)
        Me.btnXoaSP.TabIndex = 13
        Me.btnXoaSP.Text = "Xóa sản phẩm"
        Me.btnXoaSP.UseVisualStyleBackColor = True
        '
        'btnSuaSP
        '
        Me.btnSuaSP.Location = New System.Drawing.Point(291, 165)
        Me.btnSuaSP.Name = "btnSuaSP"
        Me.btnSuaSP.Size = New System.Drawing.Size(95, 23)
        Me.btnSuaSP.TabIndex = 14
        Me.btnSuaSP.Text = "Sửa sản phẩm"
        Me.btnSuaSP.UseVisualStyleBackColor = True
        '
        'txtMotaLoai
        '
        Me.txtMotaLoai.Location = New System.Drawing.Point(554, 58)
        Me.txtMotaLoai.Multiline = True
        Me.txtMotaLoai.Name = "txtMotaLoai"
        Me.txtMotaLoai.Size = New System.Drawing.Size(210, 101)
        Me.txtMotaLoai.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Mô tả"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(554, 32)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(210, 20)
        Me.txtTenLoai.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(477, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tên loại"
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(554, 6)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(210, 20)
        Me.txtMaLoai.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Mã loại"
        '
        'btnSuaLoai
        '
        Me.btnSuaLoai.Location = New System.Drawing.Point(693, 165)
        Me.btnSuaLoai.Name = "btnSuaLoai"
        Me.btnSuaLoai.Size = New System.Drawing.Size(95, 23)
        Me.btnSuaLoai.TabIndex = 23
        Me.btnSuaLoai.Text = "Sửa loại"
        Me.btnSuaLoai.UseVisualStyleBackColor = True
        '
        'btnXoaLoai
        '
        Me.btnXoaLoai.Location = New System.Drawing.Point(592, 165)
        Me.btnXoaLoai.Name = "btnXoaLoai"
        Me.btnXoaLoai.Size = New System.Drawing.Size(95, 23)
        Me.btnXoaLoai.TabIndex = 22
        Me.btnXoaLoai.Text = "Xóa loại"
        Me.btnXoaLoai.UseVisualStyleBackColor = True
        '
        'btnThemLoai
        '
        Me.btnThemLoai.Location = New System.Drawing.Point(491, 165)
        Me.btnThemLoai.Name = "btnThemLoai"
        Me.btnThemLoai.Size = New System.Drawing.Size(95, 23)
        Me.btnThemLoai.TabIndex = 21
        Me.btnThemLoai.Text = "Thêm loại"
        Me.btnThemLoai.UseVisualStyleBackColor = True
        '
        'frm_SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 501)
        Me.Controls.Add(Me.btnSuaLoai)
        Me.Controls.Add(Me.btnXoaLoai)
        Me.Controls.Add(Me.btnThemLoai)
        Me.Controls.Add(Me.txtMotaLoai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSuaSP)
        Me.Controls.Add(Me.btnXoaSP)
        Me.Controls.Add(Me.txtMoTa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLoaiSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThemSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsv_Loai)
        Me.Controls.Add(Me.lsv_SP)
        Me.Name = "frm_SanPham"
        Me.Text = "Sản phẩm - Loại sản phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_SP As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_Loai As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents btnThemSP As System.Windows.Forms.Button
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMoTa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnXoaSP As System.Windows.Forms.Button
    Friend WithEvents btnSuaSP As System.Windows.Forms.Button
    Friend WithEvents txtMotaLoai As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTenLoai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaLoai As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSuaLoai As System.Windows.Forms.Button
    Friend WithEvents btnXoaLoai As System.Windows.Forms.Button
    Friend WithEvents btnThemLoai As System.Windows.Forms.Button
End Class
