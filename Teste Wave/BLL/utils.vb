Imports System.IO
Imports System.Web
Imports System.Web.HttpContext

Public Class utils


    Public Function LinkPainel(stringUrl As String) As String
        Return "/painel/" & stringUrl
    End Function

    Public Function GetVersaoMaisRecente(filename As String, Optional SoFileName As Boolean = False) As String
        Dim QtdPontos As Integer = filename.Split(".").Count - 1
        Dim tipo As String = filename.Split(".")(QtdPontos)

        Dim DataDoAqruivo As String = File.GetLastWriteTime(HttpContext.Current.Server.MapPath(filename))
        DataDoAqruivo = DataDoAqruivo.ToString().Replace("#", "").Replace("/", "").Replace(":", "").Replace(" ", "")

        filename = filename & "?" & DataDoAqruivo

        If tipo = "css" Then
            If SoFileName Then
                Return filename
            Else
                Return "<link href='" & filename & "' rel='stylesheet' />"
            End If

        ElseIf tipo = "js" Then
            If SoFileName Then
                Return filename
            Else
                Return "<script async src='" & filename & "'></script>"
            End If

        Else 'imagens e links puros
            Return filename

        End If

    End Function

End Class
