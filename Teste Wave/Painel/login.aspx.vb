Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub bttLogin_Click(sender As Object, e As EventArgs)
        Dim cadastro = New CadastroBLL().GetCadastroByNmLogin(txtLogin.Text)

        If cadastro.Rows.Count > 0 Then
            Dim consulta As DataTable = Select_("select * from cadastro where
                                             email = '" & txtLogin.Text & "' and senha = '" & txtSenha.Text & "'")
            If consulta.Rows.Count() > 0 Then
                Response.Redirect(New utils().LinkPainel("home.aspx"))
            End If
        End If



    End Sub

    Protected Sub lnkEsqueciSenha_Click(sender As Object, e As EventArgs)

    End Sub

End Class