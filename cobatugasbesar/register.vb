Imports System.Data.OleDb

Public Class frmRegister

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        cekdata()
    End Sub
    Private Sub hapus()
        txtNama.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        rtbAlamat.Text = ""
        txtNoHP.Text = ""
        txtNama.Focus()
    End Sub
    Sub simpan()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into register values('" & txtNama.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & rtbAlamat.Text & "','" & txtNoHP.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Register", "E-Donat")
            frmLogin.Show()
            frmLogin.txtUsername.Focus()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Gagal Register", "E-Donat")
            hapus()
        End Try

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub rtbAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbAlamat.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            cekdata()
        End If
    End Sub
    Sub cekdata()
        If txtNama.Text = "" Then
            MessageBox.Show("Nama Lengkap wajib diisi !!!", "E-Donat")
            txtNama.Focus()
            Exit Sub
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Username wajib diisi !!!", "E-Donat")
            txtUsername.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Password wajib diisi !!!", "E-Donat")
            txtPassword.Focus()
            Exit Sub
        ElseIf txtPassword.TextLength < 6 Then
            MessageBox.Show("Password Kurang Panjang", "E-Donat")
        ElseIf txtNoHP.Text = "" Then
            MessageBox.Show("No. Handphone wajib diisi !!!", "E-Donat")
            txtNoHP.Focus()
            Exit Sub
        ElseIf rtbAlamat.Text = "" Then
            MessageBox.Show("Alamat wajib diisi !!!", "E-Donat")
            rtbAlamat.Focus()
            Exit Sub
        ElseIf txtNoHP.TextLength < 10 Then
            MessageBox.Show("No. HP Salah", "E-Donat")
            txtNoHP.Focus()
        Else
            simpan()
        End If
    End Sub

    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

End Class