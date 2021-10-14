'-------------------------------------------Importing FireSharp. Make sure you have FireSharp installed on this project.
'-------------------------------------------For more information see here : https://github.com/ziyasal/FireSharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
'-------------------------------------------

Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Public db As New ConfigDB()
        '-------------------------------------------Configure FireSharp
        Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = db.AuthSecret,
        .BasePath = db.BasePath
        }

        ' Firebase - Client
        Public firebase As IFirebaseClient
        ' Global Variables
        Public ActiveProfile As New PersonalData()
        Public Rooms As New List(Of Rooms)
        Public Status_Text_Vacant As String = "Vacant"

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                firebase = New FireSharp.FirebaseClient(fcon)
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Connection Error", vbOKOnly, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
