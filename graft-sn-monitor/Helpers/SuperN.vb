Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports System.Runtime.CompilerServices

Namespace Sup
    Partial Public Class SuperN
        <JsonProperty("jsonrpc")>
        Public Property Jsonrpc As String
        <JsonProperty("id")>
        Public Property Id As Long
        <JsonProperty("result")>
        Public Property Result As Result
    End Class

    Partial Public Class Result
        <JsonProperty("items")>
        Public Property Items As List(Of Item)
        <JsonProperty("has_blockchain_based_list")>
        Public Property HasBlockchainBasedList As Boolean
        <JsonProperty("height")>
        Public Property Height As Long

    End Class

    Partial Public Class Item
        <JsonProperty("Address")>
        Public Property Address As String
        <JsonProperty("PublicId")>
        Public Property PublicId As String
        <JsonProperty("StakeAmount")>
        Public Property StakeAmount As Decimal

        <JsonProperty("StakeFirstValidBlock")>
        Public Property StakeFirstValidBlock As Long
        <JsonProperty("StakeExpiringBlock")>
        Public Property StakeExpiringBlock As Long
        <JsonProperty("IsStakeValid")>
        Public Property IsStakeValid As Boolean
        <JsonProperty("BlockchainBasedListTier")>
        Public Property BlockchainBasedListTier As Long
        <JsonProperty("AuthSampleBlockchainBasedListTier")>
        Public Property AuthSampleBlockchainBasedListTier As Long
        <JsonProperty("IsAvailableForAuthSample")>
        Public Property IsAvailableForAuthSample As Boolean
        <JsonProperty("ExpiringBlock")>
        Public Property ExpiringBlock As Long

        <JsonProperty("LastUpdateAge")>
        Public Property LastUpdateAge As Long
    End Class

    Partial Public Class SuperN
        Public Shared Function FromJson(ByVal json As String) As SuperN
            Return JsonConvert.DeserializeObject(Of SuperN)(json, Sup.Converter.Settings)
        End Function
    End Class

    Module Serialize
        <Extension()>
        Function ToJson(ByVal self As SuperN) As String
            Return JsonConvert.SerializeObject(self, Sup.Converter.Settings)
        End Function
    End Module

    Public Class Converter

        Public Shared ReadOnly Settings As JsonSerializerSettings = New JsonSerializerSettings With {.MetadataPropertyHandling = MetadataPropertyHandling.Ignore, .DateParseHandling = DateParseHandling.None}
    End Class




End Namespace
