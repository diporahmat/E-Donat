Imports System.Data.OleDb
Public Class frmPembayaran
    Dim hasil As Integer
    Sub tampiljenisdonat()
        Try
            Dim str As String
            hasil = 0
            str = "SELECT namadonat, jumlah, harga FROM pemesanan WHERE nopesanan='" & frmHome.lblid.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    ltvDetailPemesanan.Items.Add(New ListViewItem({sdr.Item("namadonat"), sdr.Item("jumlah"), sdr.Item("harga")}))
                    hasil = CInt(sdr.Item("harga")) + hasil
                End While
                ltvDetailPemesanan.Items.Add(New ListViewItem({"Total Pembelian", "", hasil}))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampiljenisdonat()
        lblTotalKembalian.Visible = False
        txtUangDiterima.Text = "0"
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        frmHome.Show()
        frmHome.cbxPilihan.Focus()
        frmHome.belilagi()
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (CInt(txtUangDiterima.Text) < hasil) Then
            MessageBox.Show("Duitnya Kurang!", "E-Donat")
        Else
            Call updatedata()
            Call pembelianSelesai()
        End If
    End Sub
    Sub pembelianSelesai()
        Dim x As MsgBoxResult
        MessageBox.Show("Terima Kasih Sudah Membeli Donat", "E-Donat")
        x = MessageBox.Show("Mau Beli Donat Lagi?", "E-Donat", MessageBoxButtons.YesNo)
        If x = MsgBoxResult.Yes Then
            frmHome.Show()
            frmHome.lblid.Text = Format(Now, "HHmmss")
            Me.Close()
            frmHome.belilagi()
        Else
            frmLogin.Show()
            frmLogin.txtUsername.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub TxtUangDiterima_TextChanged(sender As Object, e As EventArgs) Handles txtUangDiterima.TextChanged
        lblTotalKembalian.Text = CInt(txtUangDiterima.Text) - hasil
        lblTotalKembalian.Visible = True
    End Sub

    Private Sub txtUangDiterima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUangDiterima.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Sub updatedata()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE pemesanan SET totalharga='" & hasil & "' WHERE nopesanan='" & frmHome.lblid.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ErrorToString)
        End Try
    End Sub
End Class