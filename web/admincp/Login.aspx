<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admincp_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" href="css/login.css" rel="stylesheet" />	
	<link type="text/css" href="css/smoothness/jquery-ui-1.7.2.custom.html" rel="stylesheet" />	
	<script type="text/javascript" src="js/jquery-1.3.2.min.js"></script>
	<script type="text/javascript" src="js/easyTooltip.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.7.2.custom.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
	<div id="container">
		<div class="logo">
			<a href="#"><img src="assets/logo.png" alt="" /></a>
		</div>
		<div id="box">
			<p class="main">
				<label>用户名: </label>
                <asp:TextBox ID="tb_userName" runat="server"></asp:TextBox>
				<label>密&nbsp;&nbsp;码: </label>
                <asp:TextBox ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
			</p>

			<p class="space">
                <asp:Button ID="btn_Login" runat="server" CssClass="login" Text="登录" 
                    onclick="btn_Login_Click" />
			</p>
		</div>
	</div>
    </form>
</body>
</html>
