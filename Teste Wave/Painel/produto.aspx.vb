Public Class produto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            carregaProduto()
        End If

    End Sub


    Sub carregaProduto()
        Dim Listagem As DataTable = Select_("select * from produto")
        rpt_produto.DataSource = Listagem
        rpt_produto.DataBind()
    End Sub
End Class