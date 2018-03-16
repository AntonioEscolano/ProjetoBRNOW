<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro_Produto.aspx.cs" Inherits="Interface.Cadastro_Produto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="shortcut icon" href="images/favicon.png" type="image/png">
    <link href="css/style.default.css" rel="stylesheet">
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

    <div id="preloader">
        <div id="status"><i class="fa fa-spinner fa-spin"></i></div>
    </div>

    <div class="pageheader">
        <h2><i class="fa fa-edit"></i>Cadastro de Produto<span>Preencher os campos abaixo...</span></h2>
    </div>
    <!-- -->
    <div class="panel panel-default">

        <div class="panel-body panel-body-nopadding">

            <div class="form-group">
                <label class="col-sm-3 control-label">Código Produto</label>
                <div class="col-sm-1">
                    <asp:TextBox ID="CodProd" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Nome Produto</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="NomeProd" runat="server" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Descrição</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="Descricao" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10" ></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Especificações</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="Especificacoes" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10" ></asp:TextBox>
                </div>
            </div>


            <div class="form-group">
                <label class="col-sm-3 control-label">Categoria</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control chosen-select" required></asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">File Upload</label>
                <div class="col-sm-6">
                    <div class="fileupload fileupload-new" data-provides="fileupload">
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
                        <asp:FileUpload ID="IMG" runat="server" CssClass=""  required />
                    </div>
                    <%--<asp:FileUpload ID="FileUpload1" required runat="server" />--%>
                </div>
            </div>
        </div>
        <!-- panel-body -->
        <div class="panel-footer">
            <div class="row">
                <div class="col-sm-6 col-sm-offset-3">
                    <asp:Button ID="Gravar" CssClass="btn btn-primary" runat="server" Text="Gravar" OnClick="Gravar_Click" />
                </div>
            </div>
        </div>
        <!-- panel-footer -->
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

            // Time Picker
            //jQuery('.HoraAbe').timepicker({ defaultTIme: false });
            //jQuery('.HoraAbe').timepicker({ showMeridian: false });
            //jQuery('#timepicker3').timepicker({ minuteStep: 15 });

            jQuery('.Hora').timepicker({ minuteStep: 1, showMeridian: false });
        });
    </script>
</asp:Content>
