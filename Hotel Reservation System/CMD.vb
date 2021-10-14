Public Class CMD
    Public Function Base64_Encode(str As String) As String
        Try
            If IsNothing(str) Then
                Return Nothing
            Else
                Dim data As Byte()
                data = Text.Encoding.ASCII.GetBytes(str)
                Dim result = Convert.ToBase64String(data)
                Return result
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Base64_Decode(str As String) As String
        Try
            If IsNothing(str) Then
                Return Nothing
            Else
                Dim data As Byte()
                data = Convert.FromBase64String(str)
                Dim result = Text.Encoding.ASCII.GetString(data)
                Return result
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
