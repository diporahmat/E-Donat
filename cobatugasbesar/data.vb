Imports System.Data.OleDb
Public Class frmData
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\donat.mdb")
    Sub tampilDataDiri()
        Dim cmd As New OleDbCommand
        Dim adapt As New OleDbDataAdapter
        Dim dt As New DataTable

        Try
            'Call koneksi()
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM register"

            adapt.SelectCommand = cmd
            adapt.Fill(dt)

            dgvDataDiri.DataSource = dt

            con.Close()
        Catch myerror As OleDbException
            MessageBox.Show("Error: " & myerror.Message)
        End Try
    End Sub
    Sub tampilDataPesanan()
        Dim cmd As New OleDbCommand
        Dim adapt As New OleDbDataAdapter
        Dim dt As New DataTable

        Try
            'Call koneksi()
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM pemesanan"

            adapt.SelectCommand = cmd
            adapt.Fill(dt)

            dgvDataPesanan.DataSource = dt

            con.Close()
        Catch myerror As OleDbException
            MessageBox.Show("Error: " & myerror.Message)
        End Try
    End Sub
    Private Sub FrmData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilDataDiri()
        dgvDataPesanan.Visible = False
        dgvDataDiri.Visible = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deleteData()
        Call tampilDataDiri()
    End Sub
    Sub deleteData()
        Try
            Call koneksi()
            Dim str As String
            Dim x As MsgBoxResult
            str = "DELETE * FROM register WHERE username='" & txtUsername.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Yakin?", "E-Donat", MessageBoxButtons.YesNo)
            If x = MsgBoxResult.Yes Then
                MessageBox.Show("Delete Data Berhasil", "E-Donat")
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Delete Data Gagal Dilakukan", "E-Donat")
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btnDataDiri_Click(sender As Object, e As EventArgs) Handles btnDataDiri.Click
        Call tampilDataDiri()
        btnDataPesanan.Visible = True
        dgvDataDiri.Visible = True
        dgvDataPesanan.Visible = False
    End Sub

    Private Sub btnDataPesanan_Click(sender As Object, e As EventArgs) Handles btnDataPesanan.Click
        Call tampilDataPesanan()
        btnDataDiri.Visible = True
        dgvDataPesanan.Visible = True
        dgvDataDiri.Visible = False
    End Sub
End Class