<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Btn_Close = New System.Windows.Forms.Label()
        Me.input_username = New System.Windows.Forms.TextBox()
        Me.input_accnt_password = New System.Windows.Forms.TextBox()
        Me.button_login = New System.Windows.Forms.Label()
        Me.button_passview = New System.Windows.Forms.PictureBox()
        CType(Me.button_passview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Close
        '
        Me.Btn_Close.AutoSize = True
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Close.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Close.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btn_Close.Location = New System.Drawing.Point(234, 470)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(21, 22)
        Me.Btn_Close.TabIndex = 1
        Me.Btn_Close.Text = "x"
        '
        'input_username
        '
        Me.input_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input_username.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_username.ForeColor = System.Drawing.Color.DimGray
        Me.input_username.Location = New System.Drawing.Point(127, 211)
        Me.input_username.Name = "input_username"
        Me.input_username.Size = New System.Drawing.Size(278, 26)
        Me.input_username.TabIndex = 1
        Me.input_username.Text = "Username"
        '
        'input_accnt_password
        '
        Me.input_accnt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input_accnt_password.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_accnt_password.ForeColor = System.Drawing.Color.DimGray
        Me.input_accnt_password.Location = New System.Drawing.Point(127, 288)
        Me.input_accnt_password.Name = "input_accnt_password"
        Me.input_accnt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.input_accnt_password.Size = New System.Drawing.Size(278, 26)
        Me.input_accnt_password.TabIndex = 2
        Me.input_accnt_password.Text = "Password"
        '
        'button_login
        '
        Me.button_login.BackColor = System.Drawing.Color.Transparent
        Me.button_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_login.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_login.ForeColor = System.Drawing.Color.White
        Me.button_login.Location = New System.Drawing.Point(250, 351)
        Me.button_login.Name = "button_login"
        Me.button_login.Size = New System.Drawing.Size(154, 50)
        Me.button_login.TabIndex = 3
        Me.button_login.Text = "LOGIN"
        Me.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_passview
        '
        Me.button_passview.BackColor = System.Drawing.Color.Transparent
        Me.button_passview.BackgroundImage = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_show
        Me.button_passview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_passview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_passview.Location = New System.Drawing.Point(373, 289)
        Me.button_passview.Name = "button_passview"
        Me.button_passview.Size = New System.Drawing.Size(34, 24)
        Me.button_passview.TabIndex = 5
        Me.button_passview.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(486, 512)
        Me.Controls.Add(Me.button_passview)
        Me.Controls.Add(Me.button_login)
        Me.Controls.Add(Me.input_accnt_password)
        Me.Controls.Add(Me.input_username)
        Me.Controls.Add(Me.Btn_Close)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.button_passview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Close As Label
    Friend WithEvents input_username As TextBox
    Friend WithEvents input_accnt_password As TextBox
    Friend WithEvents button_login As Label
    Friend WithEvents button_passview As PictureBox
End Class
