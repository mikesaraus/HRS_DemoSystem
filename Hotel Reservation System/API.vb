Public Class PersonalData
    Public Sub New()
        Name = Nothing
        Username = Nothing
        Password = Nothing
        Position = Nothing
    End Sub

    Public Property Name() As String
    Public Property Username() As String
    Public Property Password() As String
    Public Property Position() As String
End Class

Public Class Rooms
    Public Sub New()
        Status = Nothing
        Guest = New GuestDetails
    End Sub

    Public Property Status() As String
    Public Property Guest() As GuestDetails
End Class

Public Class GuestDetails
    Public Sub New()
        FirstName = Nothing
        MiddleName = Nothing
        LastName = Nothing
        Gender = Nothing
        Address = Nothing
    End Sub

    Public Property FirstName() As String
    Public Property MiddleName() As String
    Public Property LastName() As String
    Public Property Gender() As String
    Public Property Address() As String
End Class