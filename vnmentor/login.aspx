<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<meta charset="utf-8">
	 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"> 
	<%--<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet"> --%>
<%--	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">--%>
    <link href="admin/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="Content/login.css" rel="stylesheet" />
	 
</head>
<body>
    <form id="form1" runat="server">
      <section class="ftco-section">
		<div class="container">
			<div class="row justify-content-center">
				<div class="col-md-6 text-center mb-4">
					<%--<h2 class="heading-section">Chào mừng đến với PFY Education.</h2>--%>
				</div>
			</div>
			<div class="row justify-content-center">
				<div class="col-md-7 col-lg-5">
					<div class="wrap">
						<div class="img" style="background-image: url(images/icon/logo-education.jpg); background-size: 250px"></div>
						<div class="login-wrap p-4 p-md-4">
			      	<div class="d-flex">
			      		<div class="w-100">
			      			<h3 class="mb-2">Sinh Viên &nbsp;&nbsp;&nbsp;&nbsp; Đăng nhập</h3>
			      		</div>
								<div class="w-100">
									<p class="social-media d-flex justify-content-end">
										<a href="#" class="social-icon d-flex align-items-center justify-content-center"><span class="fa fa-facebook"></span></a>
										
										<span class="fa fa-google"><dx:ASPxButton ID="btn_google" CssClass="social-icon d-flex align-items-center justify-content-center" runat="server" Text="" OnClick="btn_google_Click"></dx:ASPxButton></span>
										<%--<a href="#" class="social-icon d-flex align-items-center justify-content-center"><span class="fa fa-google"></span></a>--%>
									</p>
								</div>
			      	</div>
							<form action="#" class="signin-form">
			      		<div class="form-group mt-3">
			      			<input type="text" class="form-control" required>
			      			<label class="form-control-placeholder" for="username">Vui lòng nhập email của bạn</label>
			      		</div>
		            <div class="form-group">
		              <input id="password-field" type="password" class="form-control" required>
		              <label class="form-control-placeholder" for="password">Vui lòng nhập mật khẩu của bạn</label>
		              <span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password"></span>
		            </div>
		            <div class="form-group">
		            	<button type="submit" class="form-control btn btn-primary rounded submit px-3">Đăng nhập</button>
		            </div>
		            <div class="form-group d-md-flex">
		            	<div class="w-50 text-left">
			            	<label class="checkbox-wrap checkbox-primary mb-0">Remember Me
									  <input type="checkbox" checked>
									  <span class="checkmark"></span>
										</label>
									</div>
									<div class="w-50 text-md-right">
										<a href="#">Quên mật khẩu</a>
									</div>
		            </div>
		          </form>
		          <p class="text-center">Thành viên mới?&nbsp;&nbsp; <a data-toggle="tab" href="#signup">Đăng Ký </a>&nbsp;tại đây</p>
		        </div>
		      </div>
				</div>
			</div>
		</div>
	</section>
        <script src="js/jquery.min.js"></script>
  <script src="js/popper.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/main.js"></script>
 
    </form>
</body>
</html>
