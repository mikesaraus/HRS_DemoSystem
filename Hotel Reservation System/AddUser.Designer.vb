<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TopDragPanel = New System.Windows.Forms.Panel()
        Me.Lbl_Top_Title = New System.Windows.Forms.Label()
        Me.Close_RoomDetails = New System.Windows.Forms.Label()
        Me.New_Position = New System.Windows.Forms.TextBox()
        Me.New_FullName = New System.Windows.Forms.TextBox()
        Me.New_Username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.New_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.New_PasswordConf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PlusIco = New System.Windows.Forms.Label()
        Me.TopDragPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Update
        '
        Me.Button_Update.BackColor = System.Drawing.Color.Teal
        Me.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Update.FlatAppearance.BorderSize = 0
        Me.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Update.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button_Update.Location = New System.Drawing.Point(228, 318)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(126, 33)
        Me.Button_Update.TabIndex = 6
        Me.Button_Update.Text = "Submit"
        Me.Button_Update.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(370, 32)
        Me.Panel2.TabIndex = 31
        '
        'TopDragPanel
        '
        Me.TopDragPanel.BackColor = System.Drawing.Color.Teal
        Me.TopDragPanel.Controls.Add(Me.Lbl_Top_Title)
        Me.TopDragPanel.Controls.Add(Me.Close_RoomDetails)
        Me.TopDragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopDragPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopDragPanel.Name = "TopDragPanel"
        Me.TopDragPanel.Size = New System.Drawing.Size(370, 42)
        Me.TopDragPanel.TabIndex = 30
        '
        'Lbl_Top_Title
        '
        Me.Lbl_Top_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Top_Title.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Top_Title.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Lbl_Top_Title.Location = New System.Drawing.Point(15, 7)
        Me.Lbl_Top_Title.Name = "Lbl_Top_Title"
        Me.Lbl_Top_Title.Size = New System.Drawing.Size(103, 26)
        Me.Lbl_Top_Title.TabIndex = 23
        Me.Lbl_Top_Title.Text = "User Details"
        Me.Lbl_Top_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Close_RoomDetails
        '
        Me.Close_RoomDetails.AutoSize = True
        Me.Close_RoomDetails.BackColor = System.Drawing.Color.Transparent
        Me.Close_RoomDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_RoomDetails.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_RoomDetails.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Close_RoomDetails.Location = New System.Drawing.Point(339, 6)
        Me.Close_RoomDetails.Name = "Close_RoomDetails"
        Me.Close_RoomDetails.Size = New System.Drawing.Size(20, 28)
        Me.Close_RoomDetails.TabIndex = 1
        Me.Close_RoomDetails.Text = "x"
        Me.Close_RoomDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'New_Position
        '
        Me.New_Position.BackColor = System.Drawing.Color.Gainsboro
        Me.New_Position.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.New_Position.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Position.Location = New System.Drawing.Point(134, 214)
        Me.New_Position.Name = "New_Position"
        Me.New_Position.Size = New System.Drawing.Size(220, 18)
        Me.New_Position.TabIndex = 3
        '
        'New_FullName
        '
        Me.New_FullName.BackColor = System.Drawing.Color.Gainsboro
        Me.New_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.New_FullName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_FullName.Location = New System.Drawing.Point(134, 181)
        Me.New_FullName.Name = "New_FullName"
        Me.New_FullName.Size = New System.Drawing.Size(220, 18)
        Me.New_FullName.TabIndex = 2
        '
        'New_Username
        '
        Me.New_Username.BackColor = System.Drawing.Color.Gainsboro
        Me.New_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.New_Username.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Username.Location = New System.Drawing.Point(134, 148)
        Me.New_Username.Name = "New_Username"
        Me.New_Username.Size = New System.Drawing.Size(220, 18)
        Me.New_Username.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(8, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Position:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(8, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Full Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(8, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hotel_Reservation_System.My.Resources.Resources.app_icon
        Me.PictureBox1.Location = New System.Drawing.Point(74, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'New_Password
        '
        Me.New_Password.BackColor = System.Drawing.Color.Gainsboro
        Me.New_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.New_Password.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Password.Location = New System.Drawing.Point(134, 247)
        Me.New_Password.Name = "New_Password"
        Me.New_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.New_Password.Size = New System.Drawing.Size(220, 18)
        Me.New_Password.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(8, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Password:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'New_PasswordConf
        '
        Me.New_PasswordConf.BackColor = System.Drawing.Color.Gainsboro
        Me.New_PasswordConf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.New_PasswordConf.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_PasswordConf.Location = New System.Drawing.Point(134, 280)
        Me.New_PasswordConf.Name = "New_PasswordConf"
        Me.New_PasswordConf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.New_PasswordConf.Size = New System.Drawing.Size(220, 18)
        Me.New_PasswordConf.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(8, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Confirm Password:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Hotel_Reservation_System.My.Resources.Resources.h_human_care
        Me.PictureBox2.Location = New System.Drawing.Point(228, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'PlusIco
        '
        Me.PlusIco.AutoSize = True
        Me.PlusIco.BackColor = System.Drawing.Color.Transparent
        Me.PlusIco.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusIco.ForeColor = System.Drawing.Color.Teal
        Me.PlusIco.Location = New System.Drawing.Point(175, 79)
        Me.PlusIco.Name = "PlusIco"
        Me.PlusIco.Size = New System.Drawing.Size(27, 30)
        Me.PlusIco.TabIndex = 45
        Me.PlusIco.Text = "+"
        Me.PlusIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(370, 366)
        Me.Controls.Add(Me.PlusIco)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.New_PasswordConf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.New_Password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.New_Position)
        Me.Controls.Add(Me.New_FullName)
        Me.Controls.Add(Me.New_Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Update)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TopDragPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.TopDragPanel.ResumeLayout(False)
        Me.TopDragPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Update As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TopDragPanel As Panel
    Friend WithEvents Lbl_Top_Title As Label
    Friend WithEvents Close_RoomDetails As Label
    Friend WithEvents New_Position As TextBox
    Friend WithEvents New_FullName As TextBox
    Friend WithEvents New_Username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents New_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents New_PasswordConf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PlusIco As Label
End Class
