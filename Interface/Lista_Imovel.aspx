<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista_Imovel.aspx.cs" Inherits="Interface.Lista_Imovel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.default.css" rel="stylesheet">
    <link href="css/jquery.datatables.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script>
        (function ($) {
            $(window).load(function () {
            });
        })(jQuery);
        function RemoveProduto(produto) {
            $('[id$=hdnProd]').val(produto);
            $('[id$=RemoveProdutoId]').click();
        }
    </script>
    <div id="preloader">
        <div id="status"><i class="fa fa-spinner fa-spin"></i></div>
    </div>
    <div class="pageheader">
        <h2><i class="fa fa-edit"></i>Lista de Usuários<span></span></h2>
    </div>
    <div class="panel panel-default">
        <div class="contentpanel">
            <div class="panel-body panel-body-nopadding">
                <%-- lista --%>
                <div class="panel panel-default">
                    <div class="panel-body">
                        <!-- table-responsive -->
                        <div style="display: none;">
                            <asp:HiddenField ID="hdnImov" runat="server" />
                            <asp:Button ID="RemoveImovelId" runat="server"  />
                        </div>
                        <asp:Literal ID="litLista" runat="server" />
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
            jQuery('#table2').dataTable({
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
