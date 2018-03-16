<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CADASTRO.aspx.cs" Inherits="Interface.Agencia_cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

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
        <h2><i class="fa fa-edit"></i>Cadastro de Agência<span>Subtitle goes here...</span></h2>
    </div>


    <!-- -->

    <div class="panel panel-default">


        <div class="panel-body panel-body-nopadding">

            <div class="form-group">
                <label class="col-sm-3 control-label">Código Agência</label>
                <div class="col-sm-1">
                    <asp:TextBox ID="CodAgencia" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Tipo Logradouro</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="TpLog" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Logradouro</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="Log" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Número</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="Num" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Complemento</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="Complemento" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>



            <div class="form-group">
                <label class="col-sm-3 control-label">Hora abertura</label>
                <div class="col-sm-3">


                    <div class="input-group mb15">
                        <span class="input-group-addon"><i class="glyphicon glyphicon-time"></i></span>
                        <div class="bootstrap-timepicker">
                            <asp:TextBox ID="HoraAbe" CssClass="form-control Hora" runat="server"></asp:TextBox>
                        </div>
                    </div>


                </div>
            </div>



            <div class="form-group">
                <label class="col-sm-3 control-label">Hora Fechamento</label>
                <div class="col-sm-3">

                    <div class="input-group mb15">
                        <span class="input-group-addon"><i class="glyphicon glyphicon-time"></i></span>
                        <div class="bootstrap-timepicker">
                            <asp:TextBox ID="HraFec" CssClass="form-control Hora" runat="server"></asp:TextBox>
                        </div>
                    </div>

                </div>
            </div>


        </div>

        <!-- panel-body -->

        <div class="panel-footer">
            <div class="row">
                <div class="col-sm-6 col-sm-offset-3">
                    <asp:Button ID="GravaAgencia" CssClass="btn btn-primary" runat="server" Text="Gravar" OnClick="GravaAgencia_Click" />
                </div>
            </div>
        </div>
        <!-- panel-footer -->

    </div>
    <!-- -->









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
