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
        divCabecalho.Attributes.Add("style", "background:" & listaCor(0))
        divSobre.Attributes.Add("style", "background:" & listaCor(2))
        divDiferenciais.Attributes.Add("style", "background:" & listaCor(3))
        divCardapio.Attributes.Add("style", "background:" & listaCor(4))
        divContato.Attributes.Add("style", "background:" & listaCor(6))
        'divBanners.Attributes.Add("style", "background:" & listaCor(1))
        'divLocalizacao.Attributes.Add("style", "background:" & listaCor(5))
        'divFinal.Attributes.Add("style", "background:" & listaCor(7))

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

    Public Shared Sub AbreModal(Mensagem As String, ObjLocal As Object, Tipo As String, Optional customBotoes As String = "", Optional customJS As String = "",
                            Optional css As String = "", Optional nomeBotaoFechar As String = "Fechar", Optional ClasseExtraModalDialog As String = "")

        Dim codespecial As Long
        Dim numero As Long
        Dim GeradorDeNumerosAleatorios As Random = New Random()
        For i = 1 To 2
            numero = numero & GeradorDeNumerosAleatorios.Next(100000000, 999999999)
        Next
        codespecial = numero

        Dim numeroModal As String = codespecial
        Dim modalString As String = "<div id='modal" & numeroModal & "' class='modal fade' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' style='z-index: 999999999;background: #00000070;'>" &
                                        "<div class='modal-dialog " & ClasseExtraModalDialog & "" & css & "' role='document'>" &
                                            "<div class='modal-content'>" &
                                                "<div class='modal-body text-center'>" &
                                                    "<span " & IIf(Tipo.ToString.Trim <> "", "class='alert alert-" & Tipo.ToString & "'", "") & ">" & Mensagem.Replace(vbCrLf, "").Replace("\", "\\").Replace("'", "'") & "</span>" &
                                                "</div>" &
                                                "<div class='modal-footer'>" &
                                                    "<button type='button' class='btn btn-default bttFechaModal' id='bttFechaModal' data-dismiss='modal'>" & nomeBotaoFechar & "</button>" &
                                                    customBotoes &
                                                "</div>" &
                                            "</div>" &
                                        "</div>" &
                                    "</div>"

        modalString = modalString.Replace("'", "\'")

        Dim fechaModalNoEnter As String = "$('#bttFechaModal').focus();
                                           $('#bttFechaModal').on('click',function(){
                                                $('body').removeClass('modal-open').attr('style','');
                                                $('.modal-backdrop').remove();
                                           });
                                           $('.modal').keypress(function(event){ 
                                                if(event.keyCode == 13){ 
                                                  $('.modal').modal('hide'); 
                                                } 
                                           });"

        ScriptManager.RegisterStartupScript(ObjLocal, ObjLocal.GetType, numeroModal, "$('#form1').append('" & modalString & "'); setTimeout(function(){ $('#modal" & numeroModal & "').modal() },500); " & fechaModalNoEnter & customJS, True)

    End Sub

    Protected Sub saibaMaisBanner_Click(sender As Object, e As EventArgs)
        AbreModal("A escoola é top vale a pena de mais matricula seus filhoos aqui!!!", Page, "")
    End Sub
End Class