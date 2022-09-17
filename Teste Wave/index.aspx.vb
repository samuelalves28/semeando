Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'GetClientes()
        End If
    End Sub

#Region "Clientes"

    'Protected Sub rptClientes_ItemDataBound(sender As Object, e As RepeaterItemEventArgs)
    '    Dim rptPedidos As Repeater = e.Item.FindControl("rptPedidos")
    '    Dim hddCdcliente As HiddenField = e.Item.FindControl("hddCdcliente")

    '    GetPedidos(hddCdcliente.Value, rptPedidos)
    'End Sub

    'Sub GetClientes()
    '    ' Dim clientes As DataTable = Select_("select * from clientes order by nmcliente")
    '    'rptClientes.DataSource = clientes
    '    rptClientes.DataBind()

    '    '  lblTotalClientes.Text = clientes.Rows.Count
    '    divClienteEdit.Visible = False
    'End Sub

    'Protected Sub bttClienteInserir_Click(sender As Object, e As EventArgs)
    '    '   Insert("insert into clientes set nmcliente = '" & txtClienteNome.Text & "', idade = " & txtClienteIdade.Text)
    '    GetClientes()
    'End Sub

    'Protected Sub bttClienteAtualizar_Click(sender As Object, e As EventArgs)
    '    '  Update("update clientes set nmcliente = '" & txtClienteNomeEdit.Text & "', idade = " & txtClienteIdadeEdit.Text & " where cdcliente = " & lblClienteCod.Text)
    '    txtClienteNomeEdit.Text = ""
    '    txtClienteIdadeEdit.Text = ""
    '    GetClientes()
    'End Sub

    'Protected Sub bttClienteExcluir_Command(sender As Object, e As CommandEventArgs)
    '    '   Delete("delete from clientes where cdcliente = " & e.CommandArgument)
    '    '  Delete("delete from pedidos where cdcliente = " & e.CommandArgument)
    '    '  GetClientes()
    'End Sub

    'Protected Sub bttClienteEditar_Command(sender As Object, e As CommandEventArgs)
    '    ' Dim cliente As DataTable = Select_("select * from clientes where cdcliente = " & e.CommandArgument)
    '    txtClienteNomeEdit.Text = cliente.Rows(0).Item("nmcliente")
    '    txtClienteIdadeEdit.Text = cliente.Rows(0).Item("idade")
    '    lblClienteCod.Text = cliente.Rows(0).Item("cdcliente")
    '    divClienteEdit.Visible = True
    'End Sub

#End Region

#Region "Pedidos"

    'Sub GetPedidos(cdcliente As Integer, ByRef repeater As Repeater)
    '    Dim pedidos As DataTable = Select_("select * from pedidos p inner join clientes c on c.cdcliente = p.cdcliente and c.cdcliente = " & cdcliente & " order by nmcliente")
    '    repeater.DataSource = pedidos
    '    repeater.DataBind()
    '    repeater.Visible = pedidos.Rows.Count > 0
    'End Sub

    'Protected Sub bttPedidoExcluir_Command(sender As Object, e As CommandEventArgs)
    '    Delete("delete from pedidos where cdpedido = " & e.CommandArgument)
    '    GetClientes()
    'End Sub

    'Protected Sub bttPedidoEditar_Command(sender As Object, e As CommandEventArgs)
    '    Dim pedido As DataTable = Select_("select * from pedidos where cdpedido = " & e.CommandArgument)
    '    txtPedidoValor.Text = pedido.Rows(0).Item("valorpedido")
    '    lblPedidoCod.Text = pedido.Rows(0).Item("cdpedido")
    '    divClienteEdit.Visible = True
    'End Sub

    'Protected Sub bttPedidoInserir_Click(sender As Object, e As EventArgs)
    '    Insert("insert into pedidos set cdcliente = " & lblClienteCod.Text & ", valorpedido = " & txtPedidoValor.Text.Replace(",", ".") & ", datapedido = now()")
    '    GetClientes()
    'End Sub

    'Protected Sub bttPedidoAtualizar_Click(sender As Object, e As EventArgs)
    '    Update("update pedidos set valorpedido = " & txtPedidoValor.Text.Replace(",", ".") & " where cdpedido = " & lblPedidoCod.Text)
    '    txtClienteNomeEdit.Text = ""
    '    txtClienteIdadeEdit.Text = ""
    '    GetClientes()
    'End Sub


#End Region

End Class