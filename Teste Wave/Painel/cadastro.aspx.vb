Public Class cadastro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            carregaCadastro()
        End If

    End Sub


    Sub carregaCadastro()
        Dim Listagem As DataTable = Select_("select * from cadastro")
        rpt_cadastro.DataSource = Listagem
        rpt_cadastro.DataBind()
    End Sub

End Class