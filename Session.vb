Public Class Session
    Private Shared _userID As Integer
    Private Shared _username As String
    Private Shared _userRole As String
    Private Shared _loginTime As DateTime

    Public Shared Property UserID As Integer
        Get
            Return _userID
        End Get
        Set(ByVal value As Integer)
            _userID = value
        End Set
    End Property

    Public Shared Property Username As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Public Shared Property UserRole As String
        Get
            Return _userRole
        End Get
        Set(ByVal value As String)
            _userRole = value
        End Set
    End Property

    Public Shared Property LoginTime As DateTime
        Get
            Return _loginTime
        End Get
        Set(ByVal value As DateTime)
            _loginTime = value
        End Set
    End Property

    Public Shared Function IsLoggedIn() As Boolean
        Return Not String.IsNullOrEmpty(_username)
    End Function

    Public Shared Sub Clear()
        _userID = 0
        _username = ""
        _userRole = ""
        _loginTime = Nothing
    End Sub
End Class