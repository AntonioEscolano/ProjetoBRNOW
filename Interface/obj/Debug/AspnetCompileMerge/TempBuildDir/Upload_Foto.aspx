<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload_Foto.aspx.cs" Inherits="Interface.Upload_Foto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.default.css" rel="stylesheet">
    <link href="css/jquery.datatables.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="preloader">
        <div id="status"><i class="fa fa-spinner fa-spin"></i></div>
    </div>


    <div class="pageheader">
        <h2><i class="fa fa-edit"></i>Upload de Fotos</h2>


    </div>


    <div class="contentpanel">
        <div class="panel panel-default">
            <div class="form-group">
                <label class="col-sm-3 control-label">CPF:</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtCpf" runat="server" placeholder="CPF" required CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Agência:</label>
                <div class="col-sm-6">
                    <asp:DropDownList name="ddlAgencia" ID="ddlAgencia" runat="server" required class="form-control chosen-select">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">File Upload</label>
                <div class="col-sm-6">
                    <div class="fileupload fileupload-new" data-provides="fileupload">
                        <div class="input-append">

                            <span class="btn btn-default btn-file">

                                <asp:FileUpload ID="fluFoto" required runat="server" />
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel-footer">
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3">
                        <asp:Button ID="GravaAgencia" CssClass="btn btn-primary" runat="server" Text="Gravar" OnClick="GravaAgencia_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>


    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/jquery-migrate-1.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/modernizr.min.js"></script>
    <script src="js/jquery.sparkline.min.js"></script>
    <script src="js/toggles.min.js"></script>
    <script src="js/retina.min.js"></script>
    <script src="js/jquery.cookies.js"></script>

    <script src="js/jquery.datatables.min.js"></script>
    <script src="js/chosen.jquery.min.js"></script>

    <script src="js/custom.js"></script>
    <script>
        jQuery(document).ready(function () {

            jQuery('#table1').dataTable();

            jQuery('.Grid1').dataTable();

            jQuery('#table2').dataTable({
                "sPaginationType": "full_numbers"
            });

            jQuery('.Grid').dataTable({
                "sPaginationType": "full_numbers"
            });

            // Chosen Select
            jQuery("select").chosen({
                'min-width': '100px',
                'white-space': 'nowrap',
                disable_search_threshold: 10
            });

            // Delete row in a table
            jQuery('.delete-row').click(function () {
                var c = confirm("Continue delete?");
                if (c)
                    jQuery(this).closest('tr').fadeOut(function () {
                        jQuery(this).remove();
                    });

                return false;
            });

            // Show aciton upon row hover
            jQuery('.table-hidaction tbody tr').hover(function () {
                jQuery(this).find('.table-action-hide a').animate({ opacity: 1 });
            }, function () {
                jQuery(this).find('.table-action-hide a').animate({ opacity: 0 });
            });


        });
    </script>

</asp:Content>
