Public Class CadastroBLL


    Public Function GetCadastroByNmLogin(nmlogin As String) As DataTable
        Return Select_("select * from cadastro where email = '" & nmlogin & "'")
    End Function



End Class
