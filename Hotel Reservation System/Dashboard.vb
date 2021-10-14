Imports Newtonsoft.Json '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.
Imports FireSharp.EventStreaming
Imports System.ServiceModel

Public Class Dashboard

#Region "Body Dragable"
    Dim mouseX, mouseY As Integer
    Dim dragable As Boolean
    Public AllowMove As Boolean = True

    Private Sub Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If AllowMove Then
            Me.Cursor = Cursors.NoMove2D
            dragable = True
            mouseX = Cursor.Position.X - Me.Location.X
            mouseY = Cursor.Position.Y - Me.Location.Y
        End If
    End Sub

    Private Sub Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If AllowMove Then
            If dragable Then
                Me.Top = Cursor.Position.Y - mouseY
                Me.Left = Cursor.Position.X - mouseX
            End If
        End If
    End Sub

    Private Sub Main_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If AllowMove Then
            dragable = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Main_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If AllowMove Then
            dragable = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region


    Dim firebase = My.Application.firebase

    Sub InitializeView()
        ' Start the Timer (Seconds)
        UpdateDateTime()
        TimerSec.Start()

        ' Visible Date and Time
        lbl_date.Visible = True
        lbl_time.Visible = True

        ' Set User Profile
        lbl_u_username.Text = My.Application.ActiveProfile.Name
        lbl_u_position.Text = My.Application.ActiveProfile.Position

        RefreshRooms()

        Me.Show()
    End Sub

    Sub UpdateDateTime()
        Dim dateTimeNow = DateAndTime.Now
        lbl_time.Text = dateTimeNow.ToString("HH:mm:ss tt")
        lbl_date.Text = dateTimeNow.ToString("dddd, dd MMMM yyyy")
        If dateTimeNow.Second Mod 2 = 0 Then
            ' perform every 2 sec
        End If
        If dateTimeNow.Second Mod 30 = 0 Then
            ' perform every 30 sec
            RefreshRooms()
        End If
    End Sub

    Async Sub RefreshRooms()
        Try
            Dim allRooms = Await firebase.GetAsync(My.Application.db.Rooms)
            My.Application.Rooms = JsonConvert.DeserializeObject(Of List(Of Rooms))(allRooms.Body)
            If My.Application.Rooms.Count > 0 Then
                updateRoom(1, Pic_Room1, Btn_Book_Room1)
                updateRoom(2, Pic_Room2, Btn_Book_Room2)
                updateRoom(3, Pic_Room3, Btn_Book_Room3)
                updateRoom(4, Pic_Room4, Btn_Book_Room4)
                updateRoom(5, Pic_Room5, Btn_Book_Room5)
                updateRoom(6, Pic_Room6, Btn_Book_Room6)
            Else
                MessageBox.Show(Me, "No rooms found!", "Database Error", vbOKOnly, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub updateRoom(num As Integer, pic As PictureBox, lbl As Label)
        If num > 0 AndAlso My.Application.Rooms.Count > 0 AndAlso My.Application.Rooms.Count >= num Then
            Dim vacant As String = My.Application.Status_Text_Vacant
            If My.Application.Rooms(num).Status = vacant AndAlso Not pic.Tag = vacant Then
                lbl.Text = My.Application.Rooms(num).Status
                pic.Tag = My.Application.Rooms(num).Status
                pic.Image = My.Resources.h_alarm
            ElseIf Not My.Application.Rooms(num).Status = vacant AndAlso (pic.Tag = vacant Or pic.Tag = Nothing) Then
                lbl.Text = My.Application.Rooms(num).Status
                pic.Tag = My.Application.Rooms(num).Status
                pic.Image = My.Resources.h_bed
            End If
        End If
    End Sub

    Private Sub TimerSec_Tick(sender As Object, e As EventArgs) Handles TimerSec.Tick
        UpdateDateTime()
    End Sub


    Private Sub Dashboard_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        TimerSec.Stop()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Application.ActiveProfile = New PersonalData()
        Me.Close()
        RoomDetails.Close()
        Profile.Close()
        Login.Show()
        Login.input_username.Focus()
    End Sub

    Sub OpenRoom(num)
        If num > 0 AndAlso My.Application.Rooms.Count > 0 AndAlso My.Application.Rooms.Count >= num Then
            RefreshRooms()
            RoomDetails.InitializeRoomDetailed(num)
        End If
    End Sub

    Private Sub Panel_Room1_Click(sender As Object, e As EventArgs) Handles Lbl_Room1.Click, Panel_Room1.Click, Btn_Book_Room1.Click, Pic_Room1.Click
        OpenRoom(1)
    End Sub

    Private Sub Panel_Room2_Click(sender As Object, e As EventArgs) Handles Lbl_Room2.Click, Panel_Room2.Click, Pic_Room2.Click, Btn_Book_Room2.Click
        OpenRoom(2)
    End Sub

    Private Sub Panel_Room3_Click(sender As Object, e As EventArgs) Handles Lbl_Room3.Click, Panel_Room3.Click, Pic_Room3.Click, Btn_Book_Room3.Click
        OpenRoom(3)
    End Sub

    Private Sub Panel_Room4_Click(sender As Object, e As EventArgs) Handles Lbl_Room4.Click, Panel_Room4.Click, Pic_Room4.Click, Btn_Book_Room4.Click
        OpenRoom(4)
    End Sub

    Private Sub Panel_Room5_Click(sender As Object, e As EventArgs) Handles Lbl_Room5.Click, Panel_Room5.Click, Pic_Room5.Click, Btn_Book_Room5.Click
        OpenRoom(5)
    End Sub

    Private Sub Panel_Room6_Click(sender As Object, e As EventArgs) Handles Lbl_Room6.Click, Panel_Room6.Click, Pic_Room6.Click, Btn_Book_Room6.Click
        OpenRoom(6)
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim user = My.Application.ActiveProfile
        With Profile
            .User_FullName.Text = user.Name
            .User_Position.Text = user.Position
            .User_Username.Text = "@" & user.Username
            .Show()
            If user.Position.ToLower().Contains("admin") Then .Button_AddAccount.Visible = True
        End With
    End Sub
End Class