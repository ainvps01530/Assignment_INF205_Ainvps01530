Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmquanlysanpham
    Dim tb As New DataTable
    Dim ketnoistr As String = "workstation id=ainvps01530.mssql.somee.com;packet size=4096;user id=ainvps01530fpt;pwd=LEKIMA123;data source=ainvps01530.mssql.somee.com;persist security info=False;initial catalog=ainvps01530"
    Public Sub Loaddata()
        Dim ketnoi As New SqlConnection(ketnoistr)
        Dim sqladapter As New SqlDataAdapter("Select * From SanPham", ketnoi)
        Try
            sqladapter.Fill(tb)

        Catch ex As Exception

        End Try
        dtgquanly.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub dtgquanly_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgquanly.CellClick
        Dim Index As Integer = dtgquanly.CurrentCell.RowIndex
        txtmasp.Text = dtgquanly.Item(0, Index).Value
        txttensp.Text = dtgquanly.Item(1, Index).Value
        txtgiasp.Text = dtgquanly.Item(2, Index).Value
        txtsoluongsp.Text = dtgquanly.Item(3, Index).Value
        txtchitietsp.Text = dtgquanly.Item(4, Index).Value

    End Sub


    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(ketnoistr)
        ketnoi.Open()
        Dim sua As String = "UPDATE SanPham SET TenSP = @TenSP, GiaSP = @GiaSP, SoLuong = @SoLuong , ChiTietSP = @ChiTietSP WHERE MaSP = @MaSP"
        Dim com As New SqlCommand(sua, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            com.Parameters.AddWithValue("@TenSP", txttensp.Text)
            com.Parameters.AddWithValue("@GiaSP", txtgiasp.Text)
            com.Parameters.AddWithValue("@SoLuong", txtsoluongsp.Text)
            com.Parameters.AddWithValue("@ChiTietSP", txtchitietsp.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Sửa thành công ")

        End Try
        tb.Clear()
        dtgquanly.DataSource = tb
        dtgquanly.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Ketnoi As New SqlConnection(ketnoistr)
        Ketnoi.Open()
        Dim sua As String = "DELETE SanPham WHERE MaSP = @MaSP"
        Dim com As New SqlCommand(sua, Ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            com.Parameters.AddWithValue("@TenSP", txttensp.Text)
            com.Parameters.AddWithValue("@GiaSP", txtgiasp.Text)
            com.Parameters.AddWithValue("@SoLuong", txtsoluongsp.Text)
            com.Parameters.AddWithValue("@ChiTietSP", txtchitietsp.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Đã xóa thành công")

        End Try
        tb.Clear()
        dtgquanly.DataSource = tb
        dtgquanly.DataSource = Nothing
        Loaddata()
    End Sub

    
    Private Sub frmquanlysanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb.Clear()
        dtgquanly.DataSource = tb
        dtgquanly.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim ketnoi As New SqlConnection(ketnoistr)
        ketnoi.Open()
        Dim sua As String = "INSERT INTO SanPham VALUES (@MASP, @TenSP, @GiaSP, @SoLuong, @ChiTietSP,@LoaiSP)"
        Dim com As New SqlCommand(sua, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            com.Parameters.AddWithValue("@TenSP", txttensp.Text)
            com.Parameters.AddWithValue("@GiaSP", txtgiasp.Text)
            com.Parameters.AddWithValue("@SoLuong", txtsoluongsp.Text)
            com.Parameters.AddWithValue("@ChiTietSP", txtchitietsp.Text)
            com.Parameters.AddWithValue("@LoaiSP", cbbloaisp.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Thêm thành công ")

        End Try
        tb.Clear()
        dtgquanly.DataSource = tb
        dtgquanly.DataSource = Nothing
        Loaddata()
    End Sub


End Class