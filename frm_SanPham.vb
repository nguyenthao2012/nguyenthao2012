Public Class frm_SanPham

    Dim class_data As New layer_data

    Private Sub frm_SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatasanpham()
        loaddataloai()
    End Sub

    Private Sub loaddatasanpham()
        class_data.moketnoi()
        class_data.laydulieu("select * from SanPham left join LoaiSanPham on SanPham.MaLsp_SP = LoaiSanPham.MaLsp")
        Dim dt As New DataTable
        class_data.dongketnoi()
        dt = class_data.datatable
        Dim i As Integer = 0
        lsv_SP.Items.Clear()
        For Each row As DataRow In dt.Rows
            lsv_SP.Items.Add(row("MaSp").ToString())
            lsv_SP.Items(i).SubItems.Add(row("TenSp").ToString())
            lsv_SP.Items(i).SubItems.Add(row("TenLsp").ToString())
            lsv_SP.Items(i).SubItems.Add(row("DongiaSP").ToString())
            lsv_SP.Items(i).SubItems.Add(row("MotaSP").ToString())
            i += 1
        Next
    End Sub

    Private Sub loaddataloai()
        class_data.moketnoi()
        class_data.laydulieu("select * from LoaiSanPham")
        Dim dt As New DataTable
        class_data.dongketnoi()
        dt = class_data.datatable
        Dim i As Integer = 0
        lsv_Loai.Items.Clear()
        For Each row As DataRow In dt.Rows
            lsv_Loai.Items.Add(row("MaLsp").ToString())
            lsv_Loai.Items(i).SubItems.Add(row("TenLsp").ToString())
            lsv_Loai.Items(i).SubItems.Add(row("MotaLsp").ToString())
            i += 1
        Next
    End Sub

    Private Sub lsv_SP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_SP.SelectedIndexChanged
        For Each item As ListViewItem In lsv_SP.SelectedItems
            masp = item.SubItems(0).Text
            txtMaSP.Text = item.SubItems(0).Text
            txtTenSP.Text = item.SubItems(1).Text
            txtLoaiSP.Text = item.SubItems(2).Text
            txtDonGia.Text = item.SubItems(3).Text
            txtMoTa.Text = item.SubItems(4).Text
        Next
    End Sub

    Private Sub lsv_Loai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_Loai.SelectedIndexChanged
        For Each item As ListViewItem In lsv_Loai.SelectedItems
            maloai = item.SubItems(0).Text
            txtMaLoai.Text = item.SubItems(0).Text
            txtTenLoai.Text = item.SubItems(1).Text
            txtMotaLoai.Text = item.SubItems(2).Text
        Next
    End Sub

    Public maloai As String = ""
    Public masp As String = ""

    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        If lsv_Loai.SelectedItems.Count > 0 Then
            Dim tensp As String = txtTenSP.Text
            Dim dongia As String = txtDonGia.Text
            Dim motasp As String = txtMoTa.Text
            class_data.moketnoi()
            class_data.thucthi("Insert into SanPham (TenSp,MaLsp_SP,DongiaSP,MotaSP) values (N'" + tensp + "','" + maloai + "','" + dongia + "','" + motasp + "')")

            If class_data.status = "no" Then
                MessageBox.Show("Chưa thêm được sản phẩm, vui lòng kiểm tra lại!")
            End If
            class_data.dongketnoi()
        Else
            MessageBox.Show("Vui lòng chọn một loại sản phẩm")
        End If
        loaddatasanpham()
    End Sub

    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles btnXoaSP.Click
        If lsv_SP.SelectedItems.Count > 0 Then
            class_data.moketnoi()
            class_data.thucthi("delete from SanPham where MaSp = '" + masp + "'")

            If class_data.status = "no" Then
                MessageBox.Show("Chưa xóa được sản phẩm, vui lòng kiểm tra lại!")
            End If
            class_data.dongketnoi()
        End If
        loaddatasanpham()
    End Sub

    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        If lsv_SP.SelectedItems.Count > 0 And lsv_Loai.SelectedItems.Count > 0 Then
            Dim tensp As String = txtTenSP.Text
            Dim dongia As String = txtDonGia.Text
            Dim motasp As String = txtMoTa.Text
            class_data.moketnoi()

            class_data.thucthi("update SanPham set TenSp = N'" + tensp + "',MaLsp_SP = '" + maloai + "',DongiaSP = '" + dongia + "',MotaSP = '" + motasp + "' where MaSp = '" + masp + "'")
            If class_data.status = "no" Then
                MessageBox.Show("Chưa sửa được sản phẩm, vui lòng kiểm tra lại!")
            End If

            class_data.dongketnoi()
        Else
            MessageBox.Show("Vui lòng chọn một sản phẩm và một loại sản phẩm")
        End If
        loaddatasanpham()
    End Sub

    Private Sub btnThemLoai_Click(sender As Object, e As EventArgs) Handles btnThemLoai.Click
        Dim tenloai As String = txtTenLoai.Text
        Dim motaloai As String = txtMotaLoai.Text
        class_data.moketnoi()
        class_data.thucthi("Insert into LoaiSanPham (TenLsp,MotaLsp) values (N'" + tenloai + "','" + motaloai + "')")

        If class_data.status = "no" Then
            MessageBox.Show("Chưa thêm được loại sản phẩm, vui lòng kiểm tra lại!")
        End If

        class_data.dongketnoi()
        loaddataloai()
    End Sub

    Private Sub btnXoaLoai_Click(sender As Object, e As EventArgs) Handles btnXoaLoai.Click
        If lsv_Loai.SelectedItems.Count > 0 Then
            class_data.moketnoi()
            class_data.thucthi("delete from LoaiSanPham where MaLsp = '" + maloai + "'")

            If class_data.status = "no" Then
                MessageBox.Show("Chưa xóa được loại sản phẩm, vui lòng kiểm tra lại!")
            End If

            class_data.dongketnoi()
            loaddataloai()
        End If
    End Sub

    Private Sub btnSuaLoai_Click(sender As Object, e As EventArgs) Handles btnSuaLoai.Click
        If lsv_Loai.SelectedItems.Count > 0 Then
            Dim tenloai As String = txtTenLoai.Text
            Dim motaloai As String = txtMotaLoai.Text
            class_data.moketnoi()
            class_data.thucthi("update LoaiSanPham set TenLsp = '" + tenloai + "',MotaLsp = '" + motaloai + "'  where MaLsp = '" + maloai + "'  ")

            If class_data.status = "no" Then
                MessageBox.Show("Chưa sửa được loại sản phẩm, vui lòng kiểm tra lại!")
            End If

            class_data.dongketnoi()
            loaddataloai()
        End If
    End Sub
End Class