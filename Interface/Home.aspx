<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Interface.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="shortcut icon" href="images/favicon.png" type="image/png" />
    <link href="css/style.default.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="js/html5shiv.js"></script>
      <script src="js/respond.min.js"></script>
      <![endif]-->
    <link rel="stylesheet" href="css/bootstrap-fileupload.min.css" />
    <link rel="stylesheet" href="css/bootstrap-timepicker.min.css" />
    <link rel="stylesheet" href="css/jquery.tagsinput.css" />
    <link rel="stylesheet" href="css/colorpicker.css" />
    <link rel="stylesheet" href="css/dropzone.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="contentpanel">
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="panel-btns">
                        <a href="#" class="panel-close">&times;</a>
                    </div>
                    <!-- panel-btns -->
                    <h4 class="panel-title">Sistema de inserção de imóveis</h4>    
                    <p>Escolha a ação que irá ser feita</p>
                </div>
                <!-- panel-heading -->
                <div class="panel-body">
                    <!-- Button trigger modal -->
                    <!--<a href="Usuario_Cadastro.aspx" class="btn btn-primary btn-lg">Cadastrar Usuários</a>-->
                    <a href="Cadastro_Imovel.aspx" class="btn btn-primary btn-lg">Cadastrar Imóveis</a>
                    <!--Button trigger modal-->
                    <!--<a href="Usuario_Lista.aspx" class="btn btn-primary btn-lg">Lista de Usuários</a>-->
                    <a href="Lista_Imovel.aspx" class="btn btn-primary btn-lg">Listar Imóveis</a>
                    <a href="Produto_Lista.aspx" class="btn btn-primary btn-lg">Listar Produtos</a>
                    <%--<a href="Upload_Foto.aspx" class="btn btn-primary btn-lg">Enviar Fotos</a>--%>
                    <a href="Editar_Produto.aspx" class="btn btn-primary btn-lg">Editar Produtos</a>
                </div>
            </div>
        </div>
    </div>
    <script src="js/jqueryrotate.min.js"></script>
    <script src="js/main.js"></script>
</asp:Content>
