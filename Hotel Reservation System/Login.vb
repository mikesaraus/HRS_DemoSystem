Imports Newtonsoft.Json '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.

Public Class Login

    Dim show_password = False
    Dim firebase = My.Application.firebase

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Close_MouseHover(sender As Object, e As EventArgs) Handles Btn_Close.MouseHover
        Btn_Close.ForeColor = Color.White
    End Sub

    Private Sub Btn_Close_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Close.MouseLeave
        Btn_Close.ForeColor = Color.Gainsboro
    End Sub

    Private Sub button_passview_Click(sender As Object, e As EventArgs) Handles button_passview.Click
        If show_password Then
            button_passview.BackgroundImage = My.Resources.i_eye_show
            input_accnt_password.PasswordChar = "*"
            show_password = False
        Else
            button_passview.BackgroundImage = My.Resources.i_eye_hidden
            input_accnt_password.PasswordChar = vbNullChar
            show_password = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        input_username.Focus()
    End Sub

    Private Sub button_login_Click(sender As Object, e As EventArgs) Handles button_login.Click
        ' Disable Input Boxes
        input_username.ReadOnly = True
        input_accnt_password.ReadOnly = True

        Try
            ' Perform Login Action
            Dim users = firebase.Get(My.Application.db.Users & input_username.Text)
            If users.StatusCode = 200 Then
                Dim myDeserializeData As PersonalData = JsonConvert.DeserializeObject(Of PersonalData)(users.Body)
                If Not IsNothing(myDeserializeData) Then
                    Dim cmd As New CMD
                    If Not IsNothing(myDeserializeData.Password) AndAlso myDeserializeData.Password = cmd.Base64_Encode(input_accnt_password.Text) Then
                        My.Application.ActiveProfile = myDeserializeData
                        My.Application.ActiveProfile.Username = input_username.Text
                        input_username.Text = "Username"
                        input_accnt_password.Text = "Password"
                        Dashboard.InitializeView()
                        Me.Hide()
                        ' MessageBox.Show(Me, "Howaday, " & input_accnt_id.Text & "!", "Login Success", vbOKOnly, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show(Me, "Incorrect username or password!", "Login Failed", vbOKOnly, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show(Me, "Account not found!", "Login Failed", vbOKOnly, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show(Me, "Error " & users.StatusCode & " has occured!" & vbNewLine & users.Body, users.StatusCode & " Error", vbOKOnly, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", vbOKOnly, MessageBoxIcon.Error)
        End Try

        ' Reset The Input Boxes
        input_username.ReadOnly = False
        input_accnt_password.ReadOnly = False
    End Sub

    Private Sub input_username_KeyDown(sender As Object, e As KeyEventArgs) Handles input_username.KeyDown, input_accnt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            button_login_Click(button_login, Nothing)
        End If
    End Sub
End Class
