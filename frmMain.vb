Public Class frmMain

    Private Sub btnLapHD_Click(sender As Object, e As EventArgs) Handles btnLapHD.Click
        If lsvKH.SelectedItems.Count = 1 Then
            grThongTinHD.Enabled = True
            btnLapHD.Enabled = False
            lsvKH.Enabled = False
            add_getIDHD()
        Else
            MessageBox.Show("Bạn phải chọn một khách hàng để lập hóa đơn")
        End If
    End Sub

    Private Sub btnKetThucHD_Click(sender As Object, e As EventArgs) Handles btnKetThucHD.Click
        LsvCTHD.Items.Clear()
        btnLapHD.Enabled = True
        grThongTinHD.Enabled = False
        lsvKH.Enabled = True

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadKH()
        loadsanpham()
    End Sub
    Dim connectdata As New layer_data()

    Private Sub loadKH()
        connectdata.laydulieu("select * from KhachHang")
        Dim datatables As New DataTable()
        datatables = connectdata.datatable
        Dim i As Integer = 0
        lsvKH.Items.Clear()
        For Each rows As DataRow In datatables.Rows
            lsvKH.Items.Add(rows("TenKH"))
            If rows("GioiTinh") = "True" Then
                lsvKH.Items(i).SubItems.Add("Nam")
            ElseIf rows("GioiTinh") = "False" Then
                lsvKH.Items(i).SubItems.Add("Nữ")
            Else
                lsvKH.Items(i).SubItems.Add("Chưa biết")
            End If
            lsvKH.Items(i).SubItems.Add(rows("SDTKH"))
            lsvKH.Items(i).SubItems.Add(rows("DiaChiKH"))
            lsvKH.Items(i).SubItems.Add(rows("Email"))
            lsvKH.Items(i).SubItems.Add(rows("MaKH"))
            i += 1
        Next
    End Sub

    Private Sub loadsanpham()
        connectdata.laydulieu("select * from SanPham")
        Dim datatables As New DataTable()
        datatables = connectdata.datatable
        Dim i As Integer = 0
        LsvSP.Items.Clear()
        For Each rows As DataRow In datatables.Rows
            LsvSP.Items.Add(rows("MaSp"))
            LsvSP.Items(i).SubItems.Add(rows("TenSp"))
            LsvSP.Items(i).SubItems.Add(rows("DongiaSP"))
            i += 1
        Next
    End Sub

    'Lấy Mã hóa đơn
    Private Sub add_getIDHD()
        Dim makh As String = lblMaKH.Text
        connectdata.thucthi("Insert into HoaDon (MaKH_HD) values ('" + makh + "')")
        If connectdata.status = "ok" Then
            connectdata.laydulieu("select MAX(MaHD)MaHD from HoaDon")
            Dim datatables As New DataTable()
            datatables = connectdata.datatable
            lsvKH.Items.Clear()
            For Each rows As DataRow In datatables.Rows
                lblMaHD.Text = rows("MaHD").ToString()
            Next
        Else
            MessageBox.Show("Có lỗi xẩy ra khi lập hóa đơn")
        End If

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim name As String = txtTenKH.Text
        Dim gt As String
        Dim sdt As String = txtSDT.Text
        Dim diachi As String = txtDiachi.Text
        Dim email As String = txtEmail.Text

        If cbxGT.Text = "Nam" Then
            gt = "True"
        ElseIf cbxGT.Text = "Nữ" Then
            gt = "False"
        Else
            gt = "null"
        End If

        connectdata.thucthi("Insert into KhachHang (TenKH,GioiTinh,SDTKH,DiaChiKH,Email) values (N'" + name + "', '" + gt + "','" + sdt + "',N'" + diachi + "','" + email + "')")
        If connectdata.status = "ok" Then
            MessageBox.Show("Đã thêm khách hàng")
            loadKH()
        Else
            MessageBox.Show("Khách hàng chưa được thêm")
        End If

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim makh As String = lblMaKH.Text
        If lsvKH.SelectedItems.Count = 1 Then
            connectdata.thucthi("delete from KhachHang where MaKH = '" + makh + "'")
            If connectdata.status = "ok" Then
                MessageBox.Show("Đã Xóa khách hàng")
                loadKH()
            Else
                MessageBox.Show("Khách hàng chưa được xóa")
            End If
        End If

    End Sub

    Private Sub lsvKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvKH.SelectedIndexChanged
        For Each item As ListViewItem In lsvKH.SelectedItems
            lblMaKH.Text = item.SubItems(5).Text
            lblTenKH.Text = item.SubItems(0).Text
            txtTenKH.Text = item.SubItems(0).Text
            cbxGT.Text = item.SubItems(1).Text
            txtSDT.Text = item.SubItems(2).Text
            txtDiachi.Text = item.SubItems(3).Text
            txtEmail.Text = item.SubItems(4).Text
        Next
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim makh As String = lblMaKH.Text
        Dim name As String = txtTenKH.Text
        Dim gt As String
        Dim sdt As String = txtSDT.Text
        Dim diachi As String = txtDiachi.Text
        Dim email As String = txtEmail.Text

        If cbxGT.Text = "Nam" Then
            gt = "True"
        ElseIf cbxGT.Text = "Nữ" Then
            gt = "False"
        Else
            gt = "null"
        End If

        If lsvKH.SelectedItems.Count = 1 Then
            connectdata.thucthi("update KhachHang set TenKH =N'" + name + "',GioiTinh ='" + gt + "',SDTKH ='" + sdt + "',DiaChiKH =N'" + diachi + "',Email ='" + email + "' where MaKH = '" + makh + "'")
            If connectdata.status = "ok" Then
                MessageBox.Show("Đã sửa khách hàng")
                loadKH()
            Else
                MessageBox.Show("Khách hàng chưa được sửa")
            End If
        End If
    End Sub

    Private Sub loadcthd()
        Dim mahd As String = lblMaHD.Text
        connectdata.laydulieu("select * from ChiTietHD left join SanPham on SanPham.MaSp = ChiTietHD.MaSp_CTHD where ChiTietHD.MaHD_CTHD = '" + mahd + "'")
        Dim datatables As New DataTable()
        datatables = connectdata.datatable
        Dim i As Integer = 0
        LsvCTHD.Items.Clear()
        For Each rows As DataRow In datatables.Rows
            LsvCTHD.Items.Add(rows("TenSp").ToString())
            LsvCTHD.Items(i).SubItems.Add(rows("DonGia").ToString())
            LsvCTHD.Items(i).SubItems.Add(rows("Soluong").ToString())
            LsvCTHD.Items(i).SubItems.Add(rows("DonGia").ToString() * rows("Soluong").ToString())
            LsvCTHD.Items(i).SubItems.Add(rows("MaCTHD").ToString())
            i += 1
        Next
    End Sub


    Public idsp As String = ""
    Public idcthd As String = ""
    Private Sub LsvSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvSP.SelectedIndexChanged
        For Each item As ListViewItem In LsvSP.SelectedItems
            lblTenSP.Text = item.SubItems(1).Text
            lblGiaSP.Text = item.SubItems(2).Text
            idsp = item.SubItems(0).Text
        Next
    End Sub

    Private Sub NbrSoLuong_ValueChanged(sender As Object, e As EventArgs) Handles NbrSoLuong.ValueChanged
        If NbrSoLuong.Value > 0 And LsvSP.SelectedItems.Count > 0 Then
            Dim gia As Int32 = 0
            gia = Convert.ToInt32(lblGiaSP.Text)
            lblTongGia.Text = (gia * NbrSoLuong.Value).ToString()
        End If
    End Sub

    Private Sub btnThemCTHD_Click(sender As Object, e As EventArgs) Handles btnThemCTHD.Click
        Dim mahd As String = lblMaHD.Text
        Dim masp As String = idsp
        Dim soluong As String = NbrSoLuong.Value()
        Dim dongia As String = lblGiaSP.Text
        If LsvSP.SelectedItems.Count > 0 And NbrSoLuong.Value > 0 Then
            connectdata.thucthi("Insert into ChiTietHD (MaHD_CTHD,MaSp_CTHD,Soluong,DonGia) values ('" + mahd + "','" + masp + "','" + soluong + "','" + dongia + "')")
            If connectdata.status = "ok" Then
                loadcthd()
            Else
                MessageBox.Show("Sản phẩm chưa được thêm vui lòng kiểm tra")
            End If
        End If
    End Sub

    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles btnXoaSP.Click
        If LsvSP.SelectedItems.Count > 0 Then
            connectdata.thucthi("delete from ChiTietHD where MaCTHD= '" + idcthd + "'")
            If connectdata.status = "ok" Then
                loadcthd()
            Else
                MessageBox.Show("Sản phẩm chưa được xóa vui lòng kiểm tra")
            End If
        End If
    End Sub

    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        Dim mahd As String = lblMaHD.Text
        Dim masp As String = idsp
        Dim soluong As String = NbrSoLuong.Value()
        Dim dongia As String = lblGiaSP.Text
        If LsvSP.SelectedItems.Count > 0 And NbrSoLuong.Value > 0 Then
            connectdata.thucthi("Update ChiTietHD set MaHD_CTHD = '" + mahd + "',MaSp_CTHD = '" + masp + "',Soluong = '" + soluong + "',DonGia = '" + dongia + "' where  MaCTHD= '" + idcthd + "' ")
            If connectdata.status = "ok" Then
                loadcthd()
            Else
                MessageBox.Show("Sản phẩm chưa được sửa vui lòng kiểm tra")
            End If
        End If
    End Sub

    Private Sub LsvCTHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvCTHD.SelectedIndexChanged
        For Each item As ListViewItem In LsvCTHD.SelectedItems
            lblTenSP.Text = item.SubItems(0).Text
            lblGiaSP.Text = item.SubItems(1).Text
            'NbrSoLuong.t = Convert.ToInt32(item.SubItems(2).Text)
            lblTongGia.Text = item.SubItems(3).Text
            idcthd = item.SubItems(4).Text
        Next
    End Sub

    Private Sub lblGiaSP_TextChanged(sender As Object, e As EventArgs) Handles lblGiaSP.TextChanged
        If NbrSoLuong.Value > 0 And LsvSP.SelectedItems.Count > 0 Then
            Dim gia As Int32 = 0
            gia = Convert.ToInt32(lblGiaSP.Text)
            lblTongGia.Text = (gia * NbrSoLuong.Value).ToString()
        End If
    End Sub

    Private Sub ToolSanPham_Click(sender As Object, e As EventArgs) Handles ToolSanPham.Click
        frm_SanPham.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
