<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Painel/MasterPainelPage.Master" CodeBehind="login.aspx.vb" Inherits="Teste_Wave.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="loginmodal-container" runat="server" id="divLogin">
                <asp:Image runat="server" ID="imgLogo" CssClass="logoLogin" />
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:TextBox runat="server" ID="txtLogin" CssClass="form-control" placeholder="Login" required="" />
                        <div class="form-group has-feedback">
                            <asp:TextBox runat="server" ID="txtSenha" CssClass="form-control camposenha" placeholder="Senha" required="" type="password" />
                        </div>
                        <asp:Button runat="server" ID="bttLogin" OnClick="bttLogin_Click" Text="Entrar" CssClass="login loginmodal-submit" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
