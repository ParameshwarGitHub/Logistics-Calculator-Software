Imports System.IdentityModel.Tokens.Jwt
Imports Newtonsoft.Json.Linq
Public Class JSONFILE
    Function GetJwtPayloadAsJson(jwtToken As String) As String
        Dim handler As New JwtSecurityTokenHandler()
        Dim jsonToken As JwtSecurityToken = handler.ReadToken(jwtToken)

        If jsonToken IsNot Nothing AndAlso jsonToken.Payload IsNot Nothing Then
            Return Newtonsoft.Json.JsonConvert.SerializeObject(jsonToken.Payload, Newtonsoft.Json.Formatting.Indented)
        End If
        Return String.Empty
    End Function
End Class
