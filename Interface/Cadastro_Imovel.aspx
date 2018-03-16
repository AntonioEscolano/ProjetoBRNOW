<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro_Imovel.aspx.cs" Inherits="Interface.Cadastro_Imovel" %>
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
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <div id="preloader">
        <div id="status"><i class="fa fa-spinner fa-spin"></i></div>
    </div>

    <div class="pageheader">
        <h2><i class="fa fa-edit"></i>Cadastro de Imóveis<span>Preencher os campos abaixo...</span></h2>
    </div>
    <!-- -->
    <div class="panel panel-default">

        <div class="panel-body panel-body-nopadding">

            <!--<div class="form-group">
                <label class="col-sm-3 control-label">Código Produto</label>
                <div class="col-sm-1">
                    <asp:TextBox ID="CodProd" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>-->

            <div class="form-group">
                <label class="col-sm-3 control-label">Nome Imóvel</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="Nome_Imovel" runat="server" CssClass="form-control" ></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqNome" ControlToValidate="Nome_Imovel" ErrorMessage="Por favor escreva o nome do imóvel!" />
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Número</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="Numero" runat="server" CssClass="form-control" TextMode="Number" ></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqNumer" ControlToValidate="Numero" ErrorMessage="Por favor escreva o número do imóvel!" />
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Preço</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="Preco" runat="server" CssClass="form-control" ></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqPrec" ControlToValidate="Preco" ErrorMessage="Por favor escreva o preço do imóvel no padrão R$ 0.000,00!" />
                </div>
            </div>
            <%--<div class="form-group">
                <label class="col-sm-3 control-label">Ativo</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="Ativo" runat="server" CssClass="form-control"  required="required"></asp:TextBox>
                </div>
            </div>--%>
            <div class="form-group">
                <label class="col-sm-3 control-label">Categoria</label>
                <div class="col-sm-3">
                    <%--<asp:TextBox ID="Categoria" runat="server" CssClass="form-control" ></asp:TextBox>--%>
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control chosen-select"></asp:DropDownList> 
                    <asp:RequiredFieldValidator runat="server" ID="reqCat" ControlToValidate="ddlCategoria" ErrorMessage="Por favor escreva a Categoria do imóvel (1-Residência, 2-Comercial)!" />
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">SubCategoria</label>
                <div class="col-sm-3">
                    <%--<asp:TextBox ID="SubCategoria" runat="server" CssClass="form-control" ></asp:TextBox>--%>
                    <asp:DropDownList ID="SubCategoria" runat="server" CssClass="form-control chosen-select"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="reqSubCat" ControlToValidate="SubCategoria" ErrorMessage="Por favor escreva a SubCategoria do imóvel (1-Casa Térrea, 2-Prédio)!" />
                </div>
            </div>
            <%--<div class="form-group">
                <label class="col-sm-3 control-label">Ativo</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="Ativo" runat="server" CssClass="form-control chosen-select" required></asp:DropDownList>
                </div>
            </div>--%>
            <%--<div class="form-group">
                <label class="col-sm-3 control-label">Tipo</label>
                <div class="col-sm-6">--%>
                    <%--<div class="fileupload fileupload-new" data-provides="fileupload">--%>
                        <%--<div class="input-append">
                            <div class="uneditable-input">
                                <i class="glyphicon glyphicon-file fileupload-exists"></i>
                                <span class="fileupload-preview"></span>
                            </div>
                            <span class="btn btn-default btn-file">
                                <span class="fileupload-new">Selecionar Imagem</span>
                                <span class="fileupload-exists">Change</span>
                                <input type="file" runat="server" id="Imagem" />
                            </span>
                            <a href="#" class="btn btn-default fileupload-exists" data-dismiss="fileupload">Remove</a>
                        </div>--%>
                        <%--<asp:FileUpload ID="IMG" runat="server" CssClass=""  required />
                    </div>--%>
                    <%--<asp:FileUpload ID="FileUpload1" required runat="server" />--%>
                <%--</div>
            </div>--%>
        </div>
         <%--panel-body--%> 
        <div class="panel-footer">
            <div class="row">
                <div class="col-sm-6 col-sm-offset-3">
                    <asp:Button ID="Gravar" CssClass="btn btn-primary" runat="server" Text="Gravar" OnClick="Gravar_Click"/>
                </div>
            </div>
        </div>
         <%--panel-footer--%> 
    </div>
    <!-- -->
    <script src="js/jqueryrotate.min.js"></script>
    <script src="js/main.js"></script>
    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/jquery-migrate-1.2.1.min.js"></script>
    <script src="js/jquery-ui-1.10.3.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/modernizr.min.js"></script>
    <script src="js/jquery.sparkline.min.js"></script>
    <script src="js/toggles.min.js"></script>
    <script src="js/retina.min.js"></script>
    <script src="js/jquery.cookies.js"></script>
    <script src="js/jquery.autogrow-textarea.js"></script>
    <script src="js/bootstrap-fileupload.min.js"></script>
    <script src="js/bootstrap-timepicker.min.js"></script>
    <script src="js/jquery.maskedinput.min.js"></script>
    <script src="js/jquery.tagsinput.min.js"></script>
    <script src="js/jquery.mousewheel.js"></script>
    <script src="js/chosen.jquery.min.js"></script>
    <script src="js/dropzone.min.js"></script>
    <script src="js/colorpicker.js"></script>
    <script src="js/custom.js"></script>
    <script src="js/maskMonkey.js"></script>
    <script>
        jQuery(document).ready(function () {

            // Chosen Select
            jQuery(".chosen-select").chosen({ 'width': '100%', 'white-space': 'nowrap' });

            // Tags Input
            jQuery('#tags').tagsInput({ width: 'auto' });

            // Textarea Autogrow
            jQuery('#autoResizeTA').autogrow();

            // Color Picker
            if (jQuery('#colorpicker').length > 0) {
                jQuery('#colorSelector').ColorPicker({
                    onShow: function (colpkr) {
                        jQuery(colpkr).fadeIn(500);
                        return false;
                    },
                    onHide: function (colpkr) {
                        jQuery(colpkr).fadeOut(500);
                        return false;
                    },
                    onChange: function (hsb, hex, rgb) {
                        jQuery('#colorSelector span').css('backgroundColor', '#' + hex);
                        jQuery('#colorpicker').val('#' + hex);
                    }
                });
            }

            // Color Picker Flat Mode
            jQuery('#colorpickerholder').ColorPicker({
                flat: true,
                onChange: function (hsb, hex, rgb) {
                    jQuery('#colorpicker3').val('#' + hex);
                }
            });

            // Date Picker
            jQuery('#datepicker').datepicker();

            jQuery('#datepicker-inline').datepicker();

            jQuery('#datepicker-multiple').datepicker({
                numberOfMonths: 3,
                showButtonPanel: true
            });

            // Spinner
            var spinner = jQuery('#spinner').spinner();
            spinner.spinner('value', 0);

            // Input Masks
            jQuery("#date").mask("99/99/9999");
            jQuery("#phone").mask("(999) 999-9999");
            jQuery("#ssn").mask("999-99-9999");
            jQuery("#Preco").mask("99.999.999,99");

            // Time Picker
            //jQuery('.HoraAbe').timepicker({ defaultTIme: false });
            //jQuery('.HoraAbe').timepicker({ showMeridian: false });
            //jQuery('#timepicker3').timepicker({ minuteStep: 15 });

            jQuery('.Hora').timepicker({ minuteStep: 1, showMeridian: false });
        });

        //jQuery(document).ready(function () {
        //    jQuery("input.Preco").maskMoney({ showSymbol: true, symbol: "R$", decimal: ",", thousands: "." });
        //});
    </script>

</asp:Content>
