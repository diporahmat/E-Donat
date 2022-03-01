Imports System.Data.OleDb
Public Class frmlupaPassword

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPassword.TextLength < 6 Then
            MessageBox.Show("Password Masih Kurang Panjang", "E-Donat")
        ElseIf txtPassword.Text = txtCOnfirmpass.Text Then
            Call updatePassword()
            frmLogin.Show()
            Me.Hide()
            Call reset()
            frmLogin.txtUsername.Focus()
        Else
            MessageBox.Show("Konfirmasi Password Baru Gagal", "E-Donat")
        End If
    End Sub

    Sub reset()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Sub updatePassword()
        If txtPassword.Text = "" Then
            MessageBox.Show("Isi Password barunya dulu dong", "E-Donat")
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Isi Username dulu dong", "E-Donat")
        Else
            Try
                Call koneksi()
                Dim str As String
                str = "UPDATE register SET [password]='" & txtPassword.Text & "' WHERE [username]='" & txtUsername.Text & "'"
                cmd = New OleDb.OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password Berhasil Dirubah", "E-Donat")
                frmLogin.Show()
                Me.Hide()
                frmLogin.txtUsername.Focus()
            Catch ex As Exception
                MessageBox.Show("Salah Username", "E-Donat")
            End Try
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        frmLogin.Show()
        frmLogin.txtUsername.Focus()
        Me.Close()
        Call reset()
    End Sub

End Class