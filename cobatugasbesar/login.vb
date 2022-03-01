Imports System.Data.OleDb

Public Class frmLogin
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database_Mahasiswa.mdb")
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Hide()
        frmRegister.txtNama.Focus()
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    Sub login()
        Try
            Call koneksi()
            Dim str As String
            str = "SELECT * FROM register WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()

            If txtUsername.Text = "" And txtPassword.Text = "" Then
                MessageBox.Show("Username dan Password wajib diisi !!!", "Peringatan!")
                txtUsername.Focus()
                Exit Sub
            ElseIf txtUsername.Text = "" Then
                MessageBox.Show("Username wajib diisi !!!", "Peringatan!")
                txtUsername.Focus()
                Exit Sub
            ElseIf txtPassword.Text = "" Then
                MessageBox.Show("Password wajib diisi !!!", "Peringatan!")
                txtPassword.Focus()
                Exit Sub
            End If
            If (sdr.Read()) Then
                If (txtUsername.Text = "admin" And txtPassword.Text = "admin") Then
                    frmHome.Show()
                    Me.Hide()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtUsername.Focus()
                Else
                    frmHome.Show()
                    Me.Hide()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtUsername.Focus()
                    frmHome.btnOpenData.Visible = False
                End If
                frmHome.lblNamaWelcome.Text = "Welcome, " + sdr.Item("namalengkap")
            Else
                MsgBox("Username atau Password Anda Salah!", MsgBoxStyle.OkOnly, "Login Gagal")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
        frmHome.lblid.Text = Format(Now, "HHmmss")
    End Sub

    Private Sub CbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.CheckState = cbxShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblKlikDisini.Click
        Me.Hide()
        frmlupaPassword.Show()
        frmlupaPassword.txtUsername.Focus()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.CapsLock) Then

        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            login()
            frmHome.lblid.Text = Format(Now, "HHmmss")
        End If
    End Sub
End Class