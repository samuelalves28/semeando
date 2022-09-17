Public Class pedidos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            carregaPedidos()
        End If

    End Sub


    Sub carregaPedidos()
        Dim Listagem As DataTable = Select_("select * from produto")
        rpt_pedidos.DataSource = Listagem
        rpt_pedidos.DataBind()
    End Sub

End Class