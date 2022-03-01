<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.ptbUtama = New System.Windows.Forms.PictureBox()
        Me.cbxShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblLupaPassword = New System.Windows.Forms.Label()
        Me.lblKlikDisini = New System.Windows.Forms.Label()
        CType(Me.ptbUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Palatino Linotype", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.SystemColors.Control
        Me.lblJudul.Location = New System.Drawing.Point(113, 48)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(178, 45)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "E-DONAT"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(49, 152)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(49, 186)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(147, 149)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 23)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(147, 183)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 23)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(55, 238)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOr.Location = New System.Drawing.Point(137, 242)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(18, 13)
        Me.lblOr.TabIndex = 7
        Me.lblOr.Text = "Or"
        '
        'btnRegister
        '
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Location = New System.Drawing.Point(161, 237)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'ptbUtama
        '
        Me.ptbUtama.BackColor = System.Drawing.Color.Gray
        Me.ptbUtama.BackgroundImage = CType(resources.GetObject("ptbUtama.BackgroundImage"), System.Drawing.Image)
        Me.ptbUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptbUtama.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptbUtama.InitialImage = Nothing
        Me.ptbUtama.Location = New System.Drawing.Point(39, 34)
        Me.ptbUtama.Name = "ptbUtama"
        Me.ptbUtama.Size = New System.Drawing.Size(68, 79)
        Me.ptbUtama.TabIndex = 0
        Me.ptbUtama.TabStop = False
        '
        'cbxShowPassword
        '
        Me.cbxShowPassword.AutoSize = True
        Me.cbxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxShowPassword.Location = New System.Drawing.Point(147, 214)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.cbxShowPassword.TabIndex = 9
        Me.cbxShowPassword.Text = "Show Password"
        Me.cbxShowPassword.UseVisualStyleBackColor = True
        '
        'lblLupaPassword
        '
        Me.lblLupaPassword.AutoSize = True
        Me.lblLupaPassword.Location = New System.Drawing.Point(69, 269)
        Me.lblLupaPassword.Name = "lblLupaPassword"
        Me.lblLupaPassword.Size = New System.Drawing.Size(86, 13)
        Me.lblLupaPassword.TabIndex = 10
        Me.lblLupaPassword.Text = "Lupa Password?"
        '
        'lblKlikDisini
        '
        Me.lblKlikDisini.AutoSize = True
        Me.lblKlikDisini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblKlikDisini.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKlikDisini.ForeColor = System.Drawing.Color.Maroon
        Me.lblKlikDisini.Location = New System.Drawing.Point(152, 269)
        Me.lblKlikDisini.Name = "lblKlikDisini"
        Me.lblKlikDisini.Size = New System.Drawing.Size(50, 13)
        Me.lblKlikDisini.TabIndex = 11
        Me.lblKlikDisini.Text = "Klik disini"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(562, 315)
        Me.Controls.Add(Me.lblKlikDisini)
        Me.Controls.Add(Me.lblLupaPassword)
        Me.Controls.Add(Me.cbxShowPassword)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.ptbUtama)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Donat"
        CType(Me.ptbUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbUtama As PictureBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblOr As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents cbxShowPassword As CheckBox
    Friend WithEvents lblLupaPassword As Label
    Friend WithEvents lblKlikDisini As Label
End Class
