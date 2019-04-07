Public Class settings


    Public Property Address As String
    Public Property ID_key As String





End Class

Public Class settings2
    Public Property Address As String
    Public Property IDS As New List(Of String)


    'Public Property ID As String


End Class

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

Public Class settings3

    Public Property Address As String
    Public Property IDS As New List(Of IDandValue)


End Class
