<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Painel/MasterPainelPage.Master" CodeBehind="cadastro.aspx.vb" Inherits="Teste_Wave.cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div runat="server" id="fundoElementos" class="fundoElementos">
        <div class="col-xs-12">
            <h1 class="page-header" ><a href="#">Cadastros</a></h1>
        </div>
        <div runat="server" id="divMae" class="divMae">
            <table border="0" class="table table-hover">
                <tr>
                    <td style="color: White">Nome</td>
                    <td style="color: White">Email</td>
                    <td style="color: White">Senha</td>
                </tr>
                <asp:Repeater ID="rpt_cadastro" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="vertical-align: middle;">
                                <%#Eval("nome")%>
                            </td>
                            <td style="vertical-align: middle;">
                                <%# Eval("email")%>
                            </td>
                            <td style="vertical-align: middle;">
                                <%# Eval("senha")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>

            </table>

        </div>
    </div>





</asp:Content>

