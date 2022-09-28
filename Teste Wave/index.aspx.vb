Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sotearCor()
        If Not Page.IsPostBack Then
        End If
    End Sub


    Sub sotearCor()
        Dim listaCor As List(Of String) = New List(Of String)
        listaCor.Add("#940533")
        listaCor.Add("#f5061d")
        listaCor.Add("#ff8800")
        listaCor.Add("#ffb300")
        listaCor.Add("#018790")
        listaCor.Add("#ff00aa")
        listaCor.Add("#e2ddd9")
        listaCor.Add("#8fbe00")

        listaCor.Sort()

        'divs
        divCabecalho.Attributes.Add("style", " height: 130px;  width: 100%;  position: absolute;  background:" & listaCor(0))
        divBanners.Attributes.Add("style", "background:" & listaCor(1))
        divSobre.Attributes.Add("style", "background:" & listaCor(2))
        divDiferenciais.Attributes.Add("style", "background:" & listaCor(3))
        divCardapio.Attributes.Add("style", "background:" & listaCor(4))
        divLocalizacao.Attributes.Add("style", "background:" & listaCor(5))
        divContato.Attributes.Add("style", "background:" & listaCor(6))
        divFinal.Attributes.Add("style", "background:" & listaCor(7))

        'letras
        divS1.Attributes.Add("style", "color:" & listaCor(0))
        divE1.Attributes.Add("style", "color:" & listaCor(1))
        divM.Attributes.Add("style", "color:" & listaCor(2))
        divE2.Attributes.Add("style", "color:" & listaCor(3))
        divA1.Attributes.Add("style", "color:" & listaCor(4))
        divN.Attributes.Add("style", "color:" & listaCor(5))
        divD1.Attributes.Add("style", "color:" & listaCor(6))
        divO.Attributes.Add("style", "color:" & listaCor(7))
        divV.Attributes.Add("style", "color:" & listaCor(0))
        divI.Attributes.Add("style", "color:" & listaCor(1))
        divD2.Attributes.Add("style", "color:" & listaCor(2))
        divA2.Attributes.Add("style", "color:" & listaCor(3))
        divS2.Attributes.Add("style", "color:" & listaCor(4))

    End Sub

End Class