﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Base.aspx.cs" Inherits="Interface.Base" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="css/style.default.css" rel="stylesheet">
    <link href="css/jquery.datatables.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
  <script src="js/html5shiv.js"></script>
  <script src="js/respond.min.js"></script>
  <![endif]-->


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="preloader">
        <div id="status"><i class="fa fa-spinner fa-spin"></i></div>
    </div>


    <div class="pageheader">
        <h2><i class="fa fa-edit"></i>Cadastro de Produto<span>Preencher os campos abaixo...</span></h2>
    </div>


    <div class="panel panel-default">

        <div class="contentpanel">
            <div class="panel-body panel-body-nopadding">


                <%-- lista --%>

                Conteudo

                <%-- fim lista --%>
            </div>
        </div>

        <!-- panel-body -->
<%--        <div class="panel-footer">
            <div class="row">
                Rodapé
            </div>
        </div>--%>
        <!-- panel-footer -->

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
