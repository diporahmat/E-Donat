Imports System.Data.OleDb
Public Class frmHome
    Sub tampildata()
        lblJenisDonat.Text = cbxPilihan.Text
        lblHarga.Text = "Harga : Rp." & infoDonat()
        lblJumlah.Text = "Jumlah :"
        txtJumlah.Visible = True
        txtJumlah.Text = "0"
        lblTotalHarga.Text = "Total Harga :"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPilihan.SelectedIndexChanged
        If (cbxPilihan.Text = "Alcapone") Then
            ptb1.Image = My.Resources.Alcapone
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Caviar Chocolate") Then
            ptb1.Image = My.Resources.Caviar_Chocolate
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Cheese Cakelicious") Then
            ptb1.Image = My.Resources.Cheese_Cakelicious
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Crunchy Crunchy") Then
            ptb1.Image = My.Resources.Crunchy_Crunchy
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Heaven Berry") Then
            ptb1.Image = My.Resources.Heaven_Berry
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Marble Hazel") Then
            ptb1.Image = My.Resources.Marble_Hazel
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Mr. Green Tea") Then
            ptb1.Image = My.Resources.Mr__Green_Tea
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Why Nut?") Then
            ptb1.Image = My.Resources.Why_Nut_
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Oreology") Then
            ptb1.Image = My.Resources.Oreology
            Call tampildata()
        ElseIf (cbxPilihan.Text = "Tira Miss U") Then
            ptb1.Image = My.Resources.Tira_Miss_U
            Call tampildata()
        End If
    End Sub
    Function infoDonat()
        Dim harga As Integer
        Dim str As String
        Try
            Call koneksi()
            str = "SELECT hargadonat from harga WHERE namadonat='" & cbxPilihan.Text & "'"
            cmd = New OleDb.OleDbCommand(str, conn)
            Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read()) Then
                harga = sdr.Item("hargadonat")
            End If
            lblPilihDonat.Visible = False
        Catch ex As Exception

        End Try

        Return harga
    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnLanjutPembayaran.Click
        If (txtJumlah.Text = "0") Then
            MessageBox.Show("Mau beli berapa?", "E-Donat")
        Else
            Call simpan()
            frmPembayaran.Show()
            Me.Hide()
            txtJumlah.Text = ""
            cbxPilihan.Focus()
            frmPembayaran.txtUangDiterima.Focus()
        End If

    End Sub

    Private Sub LblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim x As MsgBoxResult
        x = MessageBox.Show("Anda Yakin?", "E-Donat", MessageBoxButtons.YesNo)
        If x = MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Close()
        Else

        End If
    End Sub
    Sub simpan()
        Try
            Call koneksi()
            Dim str As String
            str = "INSERT into pemesanan (nopesanan,namadonat,jumlah,harga,tglpemesanan,username,totalharga)values('" & lblid.Text & "','" & lblJenisDonat.Text & "','" & CInt(txtJumlah.Text) & "','" & lblHargaTotal.Text & "','" & Format(Date.Now(), "ddMMMyyyy") & "','" & lblnamapelanggan.Text & "','" & lblHargaTotal.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnAdaLagi_Click(sender As Object, e As EventArgs) Handles btnAdaLagi.Click
        If (txtJumlah.Text = "0") Then
            MessageBox.Show("Mau beli berapa?", "E-Donat")
        Else
            Call simpan()
            MessageBox.Show("Silahkan Pilih Lagi", "E-Donat")
            Call belilagi()
        End If

    End Sub

    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        Dim harga As Integer
        harga = CInt(infoDonat())

        If (txtJumlah.Text = vbBack) Then
            reset()
        ElseIf (txtJumlah.Text = "0") Then
            lblHargaTotal.Text = 0
        ElseIf (txtJumlah.Text = "") Then
            lblHargaTotal.Text = 0
        Else
            lblHargaTotal.Text = (harga * CInt(txtJumlah.Text))
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call koneksi()
            Dim str As String
            str = "SELECT * FROM register WHERE username='" & frmLogin.txtUsername.Text & "' AND password='" & frmLogin.txtPassword.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            RD = cmd.ExecuteReader
            If (RD.Read()) Then
                lblnamapelanggan.Text = RD.Item("namalengkap")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub belilagi()
        lblHarga.Text = Nothing
        lblJumlah.Text = Nothing
        txtJumlah.Text = Nothing
        txtJumlah.Text = Nothing
        lblTotalHarga.Text = Nothing
        lblHargaTotal.Text = Nothing
        lblJenisDonat.Text = Nothing
        txtJumlah.Visible = False
        cbxPilihan.ResetText()
        ptb1.Image = Nothing
        lblPilihDonat.Visible = True
    End Sub

    Private Sub BtnOpenData_Click(sender As Object, e As EventArgs) Handles btnOpenData.Click
        frmData.Show()
        Call belilagi()
        Me.Hide()
    End Sub

End Class