<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Interface.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <title>BUFFALO</title>

    <link rel="shortcut icon" href="images/favicon.png" type="image/png">
    <link href="css/style.default.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
  <script src="js/html5shiv.js"></script>
  <script src="js/respond.min.js"></script>
  <![endif]-->

</head>
<body class="signin" style="background:#000;">

    <!-- Preloader -->
    <div id="preloader">
        <div id="status"><i class="fa fa-spinner fa-spin"></i></div>
    </div>

    <section>

        <div class="signinpanel">

            <div class="row">


                <div class="col-md-12">

                    <form method="post"  runat="server" style="background:#e4e7ea;">
                        <h4 class="nomargin" style="font-size:26px!important;">BUFFALO</h4>
                        <p class="mt5 mb20">Sistema de produtos.</p>

                        <asp:TextBox ID="LoginUsu" runat="server" CssClass="form-control uname" placeholder="Username"></asp:TextBox>
                        <label for="login-username">Login</label>


                        <asp:TextBox ID="SenhaClie" TextMode="Password" CssClass="form-control pword" runat="server" placeholder="Password"></asp:TextBox>
                        <label for="login-password">Senha</label>

                        <asp:Button ID="Logar" runat="server" Text="Logar" CssClass="btn btn-block btn-primary" OnClick="Logar_Click" />

                       
                            <label visible="false" style="color: red;" id="lblmsg" runat="server"></label>
                       
                    </form>
                </div>
                <!-- col-sm-5 -->

            </div>
            <!-- row -->

            <div class="signup-footer">
                <div class="pull-left" style="color:#ffffff;">
                    &copy; 2017. All Rights Reserved. 
                </div>
                <div class="pull-right" style="color:#ffffff;">
                    Created By: <a href="http://www.google.com.br/"style="color:#ffffff;"  target="_blank">EN</a>
                </div>
            </div>

        </div>
        <!-- signin -->

    </section>



    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/jquery-migrate-1.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/modernizr.min.js"></script>
    <script src="js/retina.min.js"></script>

    <script src="js/custom.js"></script>


</body>
</html>
