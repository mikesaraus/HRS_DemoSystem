Public Class AddUser

#Region "Body Dragable"
    Dim mouseX, mouseY As Integer
    Dim dragable As Boolean
    Public AllowMove As Boolean = True

    Private Sub Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, TopDragPanel.MouseDown
        If AllowMove Then
            Me.Cursor = Cursors.NoMove2D
            dragable = True
            mouseX = Cursor.Position.X - Me.Location.X
            mouseY = Cursor.Position.Y - Me.Location.Y
        End If
    End Sub

    Private Sub Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, TopDragPanel.MouseMove
        If AllowMove Then
            If dragable Then
                Me.Top = Cursor.Position.Y - mouseY
                Me.Left = Cursor.Position.X - mouseX
            End If
        End If
    End Sub

    Private Sub Main_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, TopDragPanel.MouseUp
        If AllowMove Then
            dragable = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Main_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, TopDragPanel.MouseLeave
        If AllowMove Then
            dragable = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

    Dim firebase = My.Application.firebase

    Private Sub Close_RoomDetails_Click(sender As Object, e As EventArgs) Handles Close_RoomDetails.Click
        Me.Close()
    End Sub

    Private Sub Close_RoomDetails_MouseHover(sender As Object, e As EventArgs) Handles Close_RoomDetails.MouseHover
        Close_RoomDetails.ForeColor = Color.White
    End Sub

    Function ValidateInput() As Boolean
        If New_Username.Text.Length > 0 Then
            ' Username is valid
            If New_FullName.Text.Length > 0 Then
                ' FullName is valid
                If New_Position.Text.Length > 0 Then
                    ' Position is valid
                    If New_Password.Text.Length > 0 AndAlso New_PasswordConf.Text.Length > 0 Then
                        ' Has password
                        If New_Password.Text = New_PasswordConf.Text Then
                            ' password matches
                            Return True
                        Else
                            MessageBox.Show(Me, "Password do not match!", "Error", vbOKOnly, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show(Me, "Password is required!", "Error", vbOKOnly, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show(Me, "Position is required!", "Error", vbOKOnly, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show(Me, "Full Name is required!", "Error", vbOKOnly, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show(Me, "Username is required!", "Error", vbOKOnly, MessageBoxIcon.Warning)
        End If
        Return False
    End Function

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        If ValidateInput() Then
            Dim cmd As New CMD
            Dim PD As New PersonalData() With
            {
            .Name = New_FullName.Text,
            .Password = cmd.Base64_Encode(New_Password.Text),
            .Position = New_Position.Text
            }
            If New_Username.ReadOnly Then
                MessageBox.Show(Dashboard, "User has been updated!", "Done", vbOKOnly, MessageBoxIcon.Information)
                Dim Update = firebase.Update(My.Application.db.Users & New_Username.Text, PD)
                ' Dashboard Update User Profile
                My.Application.ActiveProfile = PD
                My.Application.ActiveProfile.Username = New_Username.Text
                Dashboard.lbl_u_username.Text = My.Application.ActiveProfile.Name
                Dashboard.lbl_u_position.Text = My.Application.ActiveProfile.Position
            Else
                MessageBox.Show(Dashboard, "User has been added!", "Done", vbOKOnly, MessageBoxIcon.Information)
                Dim Update = firebase.Set(My.Application.db.Users & New_Username.Text, PD)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub New_Username_TextChanged(sender As Object, e As EventArgs) Handles New_Username.TextChanged
        If New_Username.Text.Contains(" ") Then
            New_Username.Text = New_Username.Text.Replace(" ", "_")
        End If
    End Sub

    Private Sub Close_RoomDetails_MouseLeave(sender As Object, e As EventArgs) Handles Close_RoomDetails.MouseLeave
        Close_RoomDetails.ForeColor = Color.DarkSlateGray
    End Sub

    Sub EnterSubmit(e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button_Update_Click(Button_Update, Nothing)
        End If
    End Sub

    Private Sub New_Input_KeyDown(sender As Object, e As KeyEventArgs) Handles New_FullName.KeyDown, New_Password.KeyDown, New_PasswordConf.KeyDown, New_Position.KeyDown, New_Username.KeyDown
        EnterSubmit(e)
    End Sub
End Class