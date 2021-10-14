<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.lbl_u_username = New System.Windows.Forms.Label()
        Me.lbl_u_position = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.TimerSec = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.MenuStrip_Users = New System.Windows.Forms.MenuStrip()
        Me.EyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Room1 = New System.Windows.Forms.Panel()
        Me.Btn_Book_Room1 = New System.Windows.Forms.Label()
        Me.Pic_Room1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Room1 = New System.Windows.Forms.Label()
        Me.Panel_Room2 = New System.Windows.Forms.Panel()
        Me.Btn_Book_Room2 = New System.Windows.Forms.Label()
        Me.Lbl_Room2 = New System.Windows.Forms.Label()
        Me.Pic_Room2 = New System.Windows.Forms.PictureBox()
        Me.Panel_Room3 = New System.Windows.Forms.Panel()
        Me.Btn_Book_Room3 = New System.Windows.Forms.Label()
        Me.Lbl_Room3 = New System.Windows.Forms.Label()
        Me.Pic_Room3 = New System.Windows.Forms.PictureBox()
        Me.Panel_Room6 = New System.Windows.Forms.Panel()
        Me.Btn_Book_Room6 = New System.Windows.Forms.Label()
        Me.Lbl_Room6 = New System.Windows.Forms.Label()
        Me.Pic_Room6 = New System.Windows.Forms.PictureBox()
        Me.Panel_Room5 = New System.Windows.Forms.Panel()
        Me.Btn_Book_Room5 = New System.Windows.Forms.Label()
        Me.Lbl_Room5 = New System.Windows.Forms.Label()
        Me.Pic_Room5 = New System.Windows.Forms.PictureBox()
        Me.Panel_Room4 = New System.Windows.Forms.Panel()
        Me.Btn_Book_Room4 = New System.Windows.Forms.Label()
        Me.Lbl_Room4 = New System.Windows.Forms.Label()
        Me.Pic_Room4 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip_Users.SuspendLayout()
        Me.Panel_Room1.SuspendLayout()
        CType(Me.Pic_Room1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Room2.SuspendLayout()
        CType(Me.Pic_Room2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Room3.SuspendLayout()
        CType(Me.Pic_Room3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Room6.SuspendLayout()
        CType(Me.Pic_Room6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Room5.SuspendLayout()
        CType(Me.Pic_Room5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Room4.SuspendLayout()
        CType(Me.Pic_Room4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_u_username
        '
        Me.lbl_u_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_u_username.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_u_username.Location = New System.Drawing.Point(89, 12)
        Me.lbl_u_username.Name = "lbl_u_username"
        Me.lbl_u_username.Size = New System.Drawing.Size(340, 33)
        Me.lbl_u_username.TabIndex = 8
        Me.lbl_u_username.Text = "Username"
        Me.lbl_u_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_u_position
        '
        Me.lbl_u_position.BackColor = System.Drawing.Color.Transparent
        Me.lbl_u_position.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_u_position.Location = New System.Drawing.Point(89, 45)
        Me.lbl_u_position.Name = "lbl_u_position"
        Me.lbl_u_position.Size = New System.Drawing.Size(340, 21)
        Me.lbl_u_position.TabIndex = 5
        Me.lbl_u_position.Text = "position"
        Me.lbl_u_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_date
        '
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_date.Location = New System.Drawing.Point(433, 41)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(234, 25)
        Me.lbl_date.TabIndex = 6
        Me.lbl_date.Text = "dddd, dd MMMM yyyyy"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_date.Visible = False
        '
        'TimerSec
        '
        Me.TimerSec.Interval = 1000
        '
        'lbl_time
        '
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Franklin Gothic Medium", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.Teal
        Me.lbl_time.Location = New System.Drawing.Point(433, 12)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(234, 37)
        Me.lbl_time.TabIndex = 7
        Me.lbl_time.Text = "HH:mm:ss"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_time.Visible = False
        '
        'MenuStrip_Users
        '
        Me.MenuStrip_Users.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip_Users.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip_Users.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EyToolStripMenuItem})
        Me.MenuStrip_Users.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_Users.Name = "MenuStrip_Users"
        Me.MenuStrip_Users.Size = New System.Drawing.Size(683, 79)
        Me.MenuStrip_Users.TabIndex = 13
        Me.MenuStrip_Users.Text = "Options"
        '
        'EyToolStripMenuItem
        '
        Me.EyToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.EyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EyToolStripMenuItem.Image = Global.Hotel_Reservation_System.My.Resources.Resources.h_human_care
        Me.EyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EyToolStripMenuItem.Name = "EyToolStripMenuItem"
        Me.EyToolStripMenuItem.Size = New System.Drawing.Size(83, 75)
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Panel_Room1
        '
        Me.Panel_Room1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Room1.Controls.Add(Me.Btn_Book_Room1)
        Me.Panel_Room1.Controls.Add(Me.Pic_Room1)
        Me.Panel_Room1.Controls.Add(Me.Lbl_Room1)
        Me.Panel_Room1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Room1.Location = New System.Drawing.Point(45, 149)
        Me.Panel_Room1.Name = "Panel_Room1"
        Me.Panel_Room1.Size = New System.Drawing.Size(175, 220)
        Me.Panel_Room1.TabIndex = 14
        '
        'Btn_Book_Room1
        '
        Me.Btn_Book_Room1.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Book_Room1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Book_Room1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Book_Room1.ForeColor = System.Drawing.Color.Gray
        Me.Btn_Book_Room1.Location = New System.Drawing.Point(50, 195)
        Me.Btn_Book_Room1.Name = "Btn_Book_Room1"
        Me.Btn_Book_Room1.Size = New System.Drawing.Size(75, 21)
        Me.Btn_Book_Room1.TabIndex = 12
        Me.Btn_Book_Room1.Text = "Book"
        Me.Btn_Book_Room1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Room1
        '
        Me.Pic_Room1.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Room1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Room1.Image = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_hidden
        Me.Pic_Room1.Location = New System.Drawing.Point(12, 43)
        Me.Pic_Room1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Room1.Name = "Pic_Room1"
        Me.Pic_Room1.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Room1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Room1.TabIndex = 12
        Me.Pic_Room1.TabStop = False
        '
        'Lbl_Room1
        '
        Me.Lbl_Room1.BackColor = System.Drawing.Color.Teal
        Me.Lbl_Room1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Room1.ForeColor = System.Drawing.Color.White
        Me.Lbl_Room1.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Room1.Name = "Lbl_Room1"
        Me.Lbl_Room1.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Room1.TabIndex = 12
        Me.Lbl_Room1.Text = "Room 1"
        Me.Lbl_Room1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Room2
        '
        Me.Panel_Room2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Room2.Controls.Add(Me.Btn_Book_Room2)
        Me.Panel_Room2.Controls.Add(Me.Lbl_Room2)
        Me.Panel_Room2.Controls.Add(Me.Pic_Room2)
        Me.Panel_Room2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Room2.Location = New System.Drawing.Point(254, 149)
        Me.Panel_Room2.Name = "Panel_Room2"
        Me.Panel_Room2.Size = New System.Drawing.Size(175, 220)
        Me.Panel_Room2.TabIndex = 15
        '
        'Btn_Book_Room2
        '
        Me.Btn_Book_Room2.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Book_Room2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Book_Room2.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Book_Room2.ForeColor = System.Drawing.Color.Gray
        Me.Btn_Book_Room2.Location = New System.Drawing.Point(52, 195)
        Me.Btn_Book_Room2.Name = "Btn_Book_Room2"
        Me.Btn_Book_Room2.Size = New System.Drawing.Size(72, 21)
        Me.Btn_Book_Room2.TabIndex = 13
        Me.Btn_Book_Room2.Text = "Book"
        Me.Btn_Book_Room2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Room2
        '
        Me.Lbl_Room2.BackColor = System.Drawing.Color.Teal
        Me.Lbl_Room2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Room2.ForeColor = System.Drawing.Color.White
        Me.Lbl_Room2.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Room2.Name = "Lbl_Room2"
        Me.Lbl_Room2.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Room2.TabIndex = 13
        Me.Lbl_Room2.Text = "Room 2"
        Me.Lbl_Room2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Room2
        '
        Me.Pic_Room2.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Room2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Room2.Image = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_hidden
        Me.Pic_Room2.Location = New System.Drawing.Point(13, 43)
        Me.Pic_Room2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Room2.Name = "Pic_Room2"
        Me.Pic_Room2.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Room2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Room2.TabIndex = 14
        Me.Pic_Room2.TabStop = False
        '
        'Panel_Room3
        '
        Me.Panel_Room3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Room3.Controls.Add(Me.Btn_Book_Room3)
        Me.Panel_Room3.Controls.Add(Me.Lbl_Room3)
        Me.Panel_Room3.Controls.Add(Me.Pic_Room3)
        Me.Panel_Room3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Room3.Location = New System.Drawing.Point(463, 149)
        Me.Panel_Room3.Name = "Panel_Room3"
        Me.Panel_Room3.Size = New System.Drawing.Size(175, 220)
        Me.Panel_Room3.TabIndex = 16
        '
        'Btn_Book_Room3
        '
        Me.Btn_Book_Room3.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Book_Room3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Book_Room3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Book_Room3.ForeColor = System.Drawing.Color.Gray
        Me.Btn_Book_Room3.Location = New System.Drawing.Point(52, 195)
        Me.Btn_Book_Room3.Name = "Btn_Book_Room3"
        Me.Btn_Book_Room3.Size = New System.Drawing.Size(72, 21)
        Me.Btn_Book_Room3.TabIndex = 15
        Me.Btn_Book_Room3.Text = "Book"
        Me.Btn_Book_Room3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Room3
        '
        Me.Lbl_Room3.BackColor = System.Drawing.Color.Teal
        Me.Lbl_Room3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Room3.ForeColor = System.Drawing.Color.White
        Me.Lbl_Room3.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Room3.Name = "Lbl_Room3"
        Me.Lbl_Room3.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Room3.TabIndex = 14
        Me.Lbl_Room3.Text = "Room 3"
        Me.Lbl_Room3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Room3
        '
        Me.Pic_Room3.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Room3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Room3.Image = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_hidden
        Me.Pic_Room3.Location = New System.Drawing.Point(13, 43)
        Me.Pic_Room3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Room3.Name = "Pic_Room3"
        Me.Pic_Room3.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Room3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Room3.TabIndex = 16
        Me.Pic_Room3.TabStop = False
        '
        'Panel_Room6
        '
        Me.Panel_Room6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Room6.Controls.Add(Me.Btn_Book_Room6)
        Me.Panel_Room6.Controls.Add(Me.Lbl_Room6)
        Me.Panel_Room6.Controls.Add(Me.Pic_Room6)
        Me.Panel_Room6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Room6.Location = New System.Drawing.Point(463, 379)
        Me.Panel_Room6.Name = "Panel_Room6"
        Me.Panel_Room6.Size = New System.Drawing.Size(175, 220)
        Me.Panel_Room6.TabIndex = 19
        '
        'Btn_Book_Room6
        '
        Me.Btn_Book_Room6.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Book_Room6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Book_Room6.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Book_Room6.ForeColor = System.Drawing.Color.Gray
        Me.Btn_Book_Room6.Location = New System.Drawing.Point(52, 195)
        Me.Btn_Book_Room6.Name = "Btn_Book_Room6"
        Me.Btn_Book_Room6.Size = New System.Drawing.Size(72, 21)
        Me.Btn_Book_Room6.TabIndex = 17
        Me.Btn_Book_Room6.Text = "Book"
        Me.Btn_Book_Room6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Room6
        '
        Me.Lbl_Room6.BackColor = System.Drawing.Color.Teal
        Me.Lbl_Room6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Room6.ForeColor = System.Drawing.Color.White
        Me.Lbl_Room6.Location = New System.Drawing.Point(13, 9)
        Me.Lbl_Room6.Name = "Lbl_Room6"
        Me.Lbl_Room6.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Room6.TabIndex = 17
        Me.Lbl_Room6.Text = "Room 6"
        Me.Lbl_Room6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Room6
        '
        Me.Pic_Room6.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Room6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Room6.Image = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_hidden
        Me.Pic_Room6.Location = New System.Drawing.Point(13, 44)
        Me.Pic_Room6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Room6.Name = "Pic_Room6"
        Me.Pic_Room6.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Room6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Room6.TabIndex = 18
        Me.Pic_Room6.TabStop = False
        '
        'Panel_Room5
        '
        Me.Panel_Room5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Room5.Controls.Add(Me.Btn_Book_Room5)
        Me.Panel_Room5.Controls.Add(Me.Lbl_Room5)
        Me.Panel_Room5.Controls.Add(Me.Pic_Room5)
        Me.Panel_Room5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Room5.Location = New System.Drawing.Point(254, 379)
        Me.Panel_Room5.Name = "Panel_Room5"
        Me.Panel_Room5.Size = New System.Drawing.Size(175, 220)
        Me.Panel_Room5.TabIndex = 18
        '
        'Btn_Book_Room5
        '
        Me.Btn_Book_Room5.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Book_Room5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Book_Room5.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Book_Room5.ForeColor = System.Drawing.Color.Gray
        Me.Btn_Book_Room5.Location = New System.Drawing.Point(52, 195)
        Me.Btn_Book_Room5.Name = "Btn_Book_Room5"
        Me.Btn_Book_Room5.Size = New System.Drawing.Size(72, 21)
        Me.Btn_Book_Room5.TabIndex = 15
        Me.Btn_Book_Room5.Text = "Book"
        Me.Btn_Book_Room5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Room5
        '
        Me.Lbl_Room5.BackColor = System.Drawing.Color.Teal
        Me.Lbl_Room5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Room5.ForeColor = System.Drawing.Color.White
        Me.Lbl_Room5.Location = New System.Drawing.Point(13, 9)
        Me.Lbl_Room5.Name = "Lbl_Room5"
        Me.Lbl_Room5.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Room5.TabIndex = 16
        Me.Lbl_Room5.Text = "Room 5"
        Me.Lbl_Room5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Room5
        '
        Me.Pic_Room5.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Room5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Room5.Image = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_hidden
        Me.Pic_Room5.Location = New System.Drawing.Point(13, 44)
        Me.Pic_Room5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Room5.Name = "Pic_Room5"
        Me.Pic_Room5.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Room5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Room5.TabIndex = 16
        Me.Pic_Room5.TabStop = False
        '
        'Panel_Room4
        '
        Me.Panel_Room4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Room4.Controls.Add(Me.Btn_Book_Room4)
        Me.Panel_Room4.Controls.Add(Me.Lbl_Room4)
        Me.Panel_Room4.Controls.Add(Me.Pic_Room4)
        Me.Panel_Room4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Room4.Location = New System.Drawing.Point(45, 379)
        Me.Panel_Room4.Name = "Panel_Room4"
        Me.Panel_Room4.Size = New System.Drawing.Size(175, 220)
        Me.Panel_Room4.TabIndex = 17
        '
        'Btn_Book_Room4
        '
        Me.Btn_Book_Room4.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Book_Room4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Book_Room4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Book_Room4.ForeColor = System.Drawing.Color.Gray
        Me.Btn_Book_Room4.Location = New System.Drawing.Point(51, 195)
        Me.Btn_Book_Room4.Name = "Btn_Book_Room4"
        Me.Btn_Book_Room4.Size = New System.Drawing.Size(72, 21)
        Me.Btn_Book_Room4.TabIndex = 13
        Me.Btn_Book_Room4.Text = "Book"
        Me.Btn_Book_Room4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Room4
        '
        Me.Lbl_Room4.BackColor = System.Drawing.Color.Teal
        Me.Lbl_Room4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Room4.ForeColor = System.Drawing.Color.White
        Me.Lbl_Room4.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Room4.Name = "Lbl_Room4"
        Me.Lbl_Room4.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Room4.TabIndex = 15
        Me.Lbl_Room4.Text = "Room 4"
        Me.Lbl_Room4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_Room4
        '
        Me.Pic_Room4.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Room4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Room4.Image = Global.Hotel_Reservation_System.My.Resources.Resources.i_eye_hidden
        Me.Pic_Room4.Location = New System.Drawing.Point(12, 44)
        Me.Pic_Room4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Room4.Name = "Pic_Room4"
        Me.Pic_Room4.Size = New System.Drawing.Size(150, 150)
        Me.Pic_Room4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Room4.TabIndex = 14
        Me.Pic_Room4.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Teal
        Me.Panel8.Location = New System.Drawing.Point(-3, 82)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(690, 10)
        Me.Panel8.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(220, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Available Rooms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 623)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel_Room6)
        Me.Controls.Add(Me.Panel_Room3)
        Me.Controls.Add(Me.Panel_Room4)
        Me.Controls.Add(Me.Panel_Room5)
        Me.Controls.Add(Me.Panel_Room2)
        Me.Controls.Add(Me.Panel_Room1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_u_username)
        Me.Controls.Add(Me.lbl_u_position)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.MenuStrip_Users)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip_Users
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip_Users.ResumeLayout(False)
        Me.MenuStrip_Users.PerformLayout()
        Me.Panel_Room1.ResumeLayout(False)
        CType(Me.Pic_Room1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Room2.ResumeLayout(False)
        CType(Me.Pic_Room2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Room3.ResumeLayout(False)
        CType(Me.Pic_Room3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Room6.ResumeLayout(False)
        CType(Me.Pic_Room6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Room5.ResumeLayout(False)
        CType(Me.Pic_Room5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Room4.ResumeLayout(False)
        CType(Me.Pic_Room4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_u_position As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_u_username As Label
    Friend WithEvents TimerSec As Timer
    Friend WithEvents lbl_time As Label
    Friend WithEvents MenuStrip_Users As MenuStrip
    Friend WithEvents EyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Room1 As Panel
    Friend WithEvents Btn_Book_Room1 As Label
    Friend WithEvents Pic_Room1 As PictureBox
    Friend WithEvents Lbl_Room1 As Label
    Friend WithEvents Panel_Room2 As Panel
    Friend WithEvents Btn_Book_Room2 As Label
    Friend WithEvents Lbl_Room2 As Label
    Friend WithEvents Pic_Room2 As PictureBox
    Friend WithEvents Panel_Room3 As Panel
    Friend WithEvents Btn_Book_Room3 As Label
    Friend WithEvents Lbl_Room3 As Label
    Friend WithEvents Pic_Room3 As PictureBox
    Friend WithEvents Panel_Room6 As Panel
    Friend WithEvents Btn_Book_Room6 As Label
    Friend WithEvents Lbl_Room6 As Label
    Friend WithEvents Pic_Room6 As PictureBox
    Friend WithEvents Panel_Room5 As Panel
    Friend WithEvents Btn_Book_Room5 As Label
    Friend WithEvents Lbl_Room5 As Label
    Friend WithEvents Pic_Room5 As PictureBox
    Friend WithEvents Panel_Room4 As Panel
    Friend WithEvents Btn_Book_Room4 As Label
    Friend WithEvents Lbl_Room4 As Label
    Friend WithEvents Pic_Room4 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
End Class
