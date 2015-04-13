Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Login


    Private Sub btnketnoi_Click(sender As Object, e As EventArgs) Handles btnketnoi.Click
        Dim chuoikn As String = "workstation id=ainvps01530.mssql.somee.com;packet size=4096;user id=ainvps01530fpt;pwd=LEKIMA123;data source=ainvps01530.mssql.somee.com;persist security info=False;initial catalog=ainvps01530"
        Dim Ketnoi As SqlConnection = New SqlConnection(chuoikn)
        Dim sqlAdapter As New SqlDataAdapter("SELECT * From NhanVien Where MaNhanVien='" & txtid.Text & "' and MatKhau='" & txtpass.Text & "' ", Ketnoi)
        Dim tb As New DataTable

        Try
            Ketnoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công")
                frmquanlysanpham.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại")
            End If
        Catch ex As Exception

        End Try
    End Sub

  

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        
        Me.Close()
    End Sub
End Class
