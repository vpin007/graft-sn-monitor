Public Class IpsAndIds

    Public Property IPS As New List(Of IPsandports)

    Public Property IDS As New List(Of IDandValue)

End Class

Public Class IPsandports
    Public Property Name As String
    Public Property IPAddress As String
    Public Property Port As Integer

End Class

Public Class IDandValue
    Public Property Name As String
    Public Property ID As String
End Class
