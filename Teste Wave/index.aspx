<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="index.aspx.vb" Inherits="Teste_Wave.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server" />

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="col-xs-12">
                <div class="row">
                    <div id="divCabecalho" runat="server" class="col-xs-12 divCabecalho container">
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
                        <div id="divElementos" class="col-xs-8  divElementos">
                            <nav id="menu-h">
                                <ul>
                                    <li><a href="#">Início</a> </li>
                                    <li><a href="#divSobre">Sobre</a></li>
                                    <li><a href="#divDiferenciais">Diferenciais</a></li>
                                    <li><a href="#divCardapio">Cardápio</a></li>
                                    <li><a href="#divLocalizacao">Localização</a></li>
                                    <li><a href="#">Contato</a></li>
                                </ul>
                            </nav>

                        </div>
                    </div>

                    <%--Banner--%>
                    <div id="divBanners" class="col-xs-12 container sessoes" runat="server">
                        <img src="/img/Matrículas-e-rematrículas-1024x580.jpg" class="placeBannerBlocoLeft" />
                        <asp:Button runat="server" CssClass="btn btn-primary btnSaibaMais" Text="Saiba mais" ID="btnSaibaMais" OnClick="saibaMaisBanner_Click" />
                    </div>
                    <div id="divSobre" runat="server" class="col-xs-12">
                        <div class=" col-xs-4">
                            <img src="/img/2020-11-ensino-infantil-img-001-19112020.png" class="" />
                        </div>
                        <div class="col-xs-8" style="color: white;">
                            <h3>Sobre</h3>
                            <hr />
                            <label>tefdiohifod dfh ud</label>
                        </div>
                    </div>

                    <%--Diferenciais--%>
                    <div id="divDiferenciais" runat="server" class="col-xs-12">
                        <div class=" col-xs-4">
                            <img src="/img/2020-11-ensino-infantil-img-001-19112020.png" class="" />
                        </div>
                        <div class="col-xs-8" style="color: white;">
                            <h3>Diferenciais</h3>
                            <hr />
                            <label>tefdiohifod dfh ud</label>
                        </div>
                    </div>

                    <%--Cardapio--%>
                    <div id="divCardapio" runat="server" class="col-xs-12">
                        <div class=" col-xs-4">
                            <img src="/img/2020-11-ensino-infantil-img-001-19112020.png" class="" />
                        </div>
                        <div class="col-xs-8" style="color: white;">
                            <h3>Cardapio</h3>
                            <hr />
                            <label>tefdiohifod dfh ud</label>
                        </div>
                    </div>

                    <%--Localizacao--%>
                    <div id="divLocalizacao" runat="server" class="col-xs-12">
                        <div class="row">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d30707.586015343557!2d-48.04322237935568!3d-15.833020956626257!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x935a326b07233ecd%3A0x77f692f28d1b9f0e!2s%C3%81guas%20Claras%2C%20Bras%C3%ADlia%20-%20DF%2C%2070297-400!5e0!3m2!1spt-BR!2sbr!4v1664920484345!5m2!1spt-BR!2sbr" width="1310" height="500" style="border: 0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                        </div>
                    </div>

                    <%--Contato--%>
                    <div id="divContato" class="col-xs-12 container" runat="server">
                        <div id="div1" runat="server" class="col-xs-4 divQuadradoContato">
                            <div class="col-xs-12 divLetras" runat="server">
                                <label runat="server" id="Label1">S</label>
                                <label runat="server" id="Label2">E</label>
                                <label runat="server" id="Label3">M</label>
                                <label runat="server" id="Label4">E</label>
                                <label runat="server" id="Label5">A</label>
                                <label runat="server" id="Label6">N</label>
                                <label runat="server" id="Label7">D</label>
                                <label runat="server" id="Label8">O</label>
                                &nbsp&nbsp
                        <label runat="server" id="Label9">V</label>
                                <label runat="server" id="Label10">I</label>
                                <label runat="server" id="Label11">D</label>
                                <label runat="server" id="Label12">A</label>
                                <label runat="server" id="Label13">S</label>
                            </div>
                            <hr />
                            <div class="col-xs-12 divInfo">
                                <label>CRECHE | ESCOLA | REFORÇO ESCOLAR</label>
                            </div>
                        </div>
                        <div runat="server" class="col-xs-4 divRedeSocial" id="divRedeSocial">
                            <div class="col-xs-12  text-center">
                                <h3><b>Rede Sociais</b></h3>
                            </div>
                            <ul class="col-xs-12" style="list-style: none;">
                                <li class="liContato">
                                    <a href="https://www.instagram.com/wavelojasvirtuais" target="_blank">
                                        <img class="img-responsive" src="/img/insta.png" alt="Instagram">
                                    </a>
                                </li>
                                <li class="liContato">
                                    <a href="https://api.whatsapp.com/send?phone=553193388100" target="_blank">
                                        <img class="img-responsive" src="/img/What.png" alt="WhatsApp">
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div runat="server" class="col-xs-4 divCont" id="divCont">
                            <div class="col-xs-12  text-center">
                                <h3><b>Contato</b></h3>
                            </div>
                            <div class="col-xs-12">
                                <label>(61) 9 99999-9999</label>
                            </div>
                            <div class="col-xs-12">
                                <label>comercial@semeando.com.br</label>
                            </div>
                            <div class="col-xs-12">
                                <label>Endereço</label>
                            </div>
                            <div class="col-xs-12">
                                <label>Horario</label>
                            </div>
                            <div class="col-xs-12">
                                <label>CNPJ</label>
                            </div>
                        </div>
                    </div>

                    <div id="divFinal" runat="server" class=" col-xs-12 text-center container colorCopyright">
                        © Copyright 2022 | Semeando - Todos os direitos reservados
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
