<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="index.aspx.vb" Inherits="Teste_Wave.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server" />

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div id="divCabecalho" runat="server" class="col-xs-12">
                <div id="divQuadrado" runat="server" class="col-xs-4 divQuadrado">
                    <div class="col-xs-12 divLetras" runat="server">
                        <label runat="server" id="divS1">S</label>
                        <label runat="server" id="divE1">E</label>
                        <label runat="server" id="divM">M</label>
                        <label runat="server" id="divE2">E</label>
                        <label runat="server" id="divA1">A</label>
                        <label runat="server" id="divN">N</label>
                        <label runat="server" id="divD1">D</label>
                        <label runat="server" id="divO">O</label>
                        &nbsp&nbsp
                        <label runat="server" id="divV">V</label>
                        <label runat="server" id="divI">I</label>
                        <label runat="server" id="divD2">D</label>
                        <label runat="server" id="divA2">A</label>
                        <label runat="server" id="divS2">S</label>
                    </div>
                    <hr />
                    <div class="col-xs-12 divInfo">
                        <label>CRECHE | ESCOLA | REFORÇO ESCOLAR</label>
                    </div>
                </div>
                <div id="divElementos" class="col-xs-8 divElementos">
                    <nav id="menu-h">
                        <ul>
                            <li><a href="#">Início</a> </li>
                            <li><a href="#">Sobre</a></li>
                            <li><a href="#">Diferenciais</a></li>
                            <li><a href="#">Localização</a></li>
                            <li><a href="#">Cardápio</a></li>
                            <li><a href="#">Contato</a></li>
                        </ul>
                    </nav>

                </div>
            </div>
            <div id="divBanners" runat="server"></div>
            <div id="divSobre" runat="server"></div>
            <div id="divDiferenciais" runat="server"></div>
            <div id="divCardapio" runat="server"></div>
            <div id="divLocalizacao" runat="server"></div>
            <div id="divContato" runat="server"></div>
            <div id="divFinal" runat="server"></div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
