Imports System.Data
Imports System.Data.SqlClient
Public Class layer_data
    'Khai báo chuỗi kết nối đến CSDL
    Dim con As New SqlConnection("Data Source=TUANDC-PC\SQLEXPRESS;Initial Catalog=datacloud;Integrated Security=True")

    'Hàm mở kết nối
    Public Sub moketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    'Hàm đóng kết nối
    Public Sub dongketnoi()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    'Khai báo datatable dữ liệu
    Public datatable As New DataTable()

    'Hàm lấy dữ liệu (Truyền các câu truy vấn vào)
    Public Sub laydulieu(cmd As String)
        moketnoi()
        Try
            datatable.Rows.Clear()
            Dim com As New SqlCommand(cmd, con)
            Dim da As New SqlDataAdapter(com)
            da.Fill(datatable)
        Catch ex As Exception
            MessageBox.Show("Có lỗi xẩy ra khi tải dữ liệu")
        End Try
        dongketnoi()
    End Sub

    'Khai báo trạng thái sau khi thực thi
    Public status As String = ""

    'Hàm thực thi dữ liệu (Insert, Update, Delete)
    Public Sub thucthi(cmd As String)
        moketnoi()
        Try
            Dim com As New SqlCommand(cmd, con)
            com.ExecuteNonQuery()
            status = "ok"
        Catch ex As Exception
            status = "no"
        End Try
        dongketnoi()
    End Sub


    'Hướng dẫn sử dụng: Khi truy vấn dữ liệu hoặt thực thi dữ liệu thì luôn gọi hàm moketnoi(),
    ' Sau đó sử dụng thủ tục cần thiết (có 2 thủ tục và truy vấn và thực thi), sau đó gọi hàm dongketnoi().
    'Sử dụng thủ tục
    ' Trong Form bạn khởi tạo một biến cho Class. Ví dụ  Dim connectdata As New Tên class() (Không để trong thủ tục nào)
    'sau đó dùng bằng cách connectdata.Tên thủ tục trong Class ("Các câu lệnh SQL")
    'Nếu dùng thủ tục Truy vấn, kết quả trả về là data table có dạng connectdata.datatable,
    'Ngược lại nếu dùng thực thi thì có một chuỗi trả về dạng connectdata.status có 2 trạng thái là "ok" và "no"
    '"ok" tức đã làm xong, "No" tức có lỗi
    'TUANDC
End Class
