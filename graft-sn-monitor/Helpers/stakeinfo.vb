Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports System.Runtime.CompilerServices

Namespace wallet
    Partial Public Class Stakeinfo
        <JsonProperty("testnet")>
        Public Property Testnet As Boolean
        <JsonProperty("wallet_public_address")>
        Public Property WalletPublicAddress As String
        <JsonProperty("id_key")>
        Public Property IdKey As String
        <JsonProperty("signature")>
        Public Property Signature As String

    End Class

    Partial Public Class Stakeinfo
        Public Shared Function FromJson(ByVal json As String) As Stakeinfo
            Return JsonConvert.DeserializeObject(Of Stakeinfo)(json, wallet.Converter.Settings)
        End Function
    End Class

    Module Serialize
        <Extension()>
        Function ToJson(ByVal self As Stakeinfo) As String
            Return JsonConvert.SerializeObject(self, wallet.Converter.Settings)
        End Function
    End Module


    Public Class Converter
        Public Shared ReadOnly settings As JsonSerializerSettings = New JsonSerializerSettings With {.MetadataPropertyHandling = MetadataPropertyHandling.Ignore, .DateParseHandling = DateParseHandling.None}

    End Class











End Namespace
