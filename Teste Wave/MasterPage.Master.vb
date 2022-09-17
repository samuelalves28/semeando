Imports System.IO
Imports System.Web
Imports System.Web.HttpContext

Public Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        linkCSS.Text = New utils().GetVersaoMaisRecente("/css/StyleSheet.css")
        linkBootsrap.Text = New utils().GetVersaoMaisRecente("/css/bootstrap.min.css")

    End Sub





End Class