Public Class ConfigDB

    Public Sub New()
        AuthSecret = "r8JyZpt8G3TJvlIdCA0CGjgk8HqeWPWgp4wql4WL"
        BasePath = "https://vbnetrealtimedb-default-rtdb.asia-southeast1.firebasedatabase.app/"
        Users = "/users/"
        Rooms = "/rooms/"
    End Sub

    Public Property AuthSecret As String
    Public Property BasePath As String
    Public Property Users As String
    Public Property Rooms As String
End Class
