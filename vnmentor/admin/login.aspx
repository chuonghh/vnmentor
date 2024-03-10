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
    <link href="bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../Content/login.css" rel="stylesheet" />
	 
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
						<div class="img" style="background-image: url(../images/icon/logo-education.jpg); background-size: 250px"></div>
						<div class="login-wrap p-4 p-md-4">
			      	<div class="d-flex">
			      		<div class="w-100">
			      			<h3 class="mb-2">Quản Trị Viên Đăng nhập</h3>
			      		</div>
								<div class="w-100">
									<p class="social-media d-flex justify-content-end">
										<a href="#" class="social-icon d-flex align-items-center justify-content-center" CausesValidation="false"><span class="fa fa-facebook"></span></a>
								<%--	 <dx:ASPxButton ID="btn_google" CssClass="social-icon d-flex align-items-center justify-content-center"  class="fa fa-google"  runat="server" Text="" OnClick="btn_google_Click"> </dx:ASPxButton> --%>
									 
										<asp:LinkButton ID="btn_google"  CssClass="social-icon d-flex align-items-center justify-content-center"   runat="server" OnClick="btn_google_Click" CausesValidation="false"><span class="fa fa-google"></span></asp:LinkButton>

									<%--	<a href="#" class="social-icon d-flex align-items-center justify-content-center"><span class="fa fa-google"></span></a>--%>
									</p>
								</div>
			      	</div>
							<form action="#" class="signin-form">
			      		<div class="form-group mt-3">
			      			<%--<input type="text" class="form-control" id="userName" runat="server" required>--%>
							  <asp:TextBox ID="txt_username" runat="server" CssClass="form-control" required/>
			      			<label class="form-control-placeholder" for="username">Vui lòng nhập email của bạn</label>
			      		</div>
		            <div class="form-group">
		              <%--<input id="password-field" type="password" class="form-control" required>--%>
						 <asp:TextBox ID="txt_password" TextMode="Password" runat="server" CssClass="form-control" required/>
					<%--	<dx:ASPxTextBox ID="passworfield" Password="true" runat="server" CssClass="form-control" required></dx:ASPxTextBox>--%>
		              <label class="form-control-placeholder" for="password">Vui lòng nhập mật khẩu của bạn</label>
		              <span toggle="#txt_password" class="fa fa-fw fa-eye field-icon toggle-password"></span>
		            </div>
		            <div class="form-group">
						<dx:ASPxButton ID="btn_login" runat="server" Text="Đăng nhập" CssClass="form-control btn btn-primary rounded submit px-3" OnClick="btn_login_Click" CausesValidation="false" AutoPostBack="false"></dx:ASPxButton>
		            <%--	<button type="submit" class="form-control btn btn-primary rounded submit px-3">Đăng nhập</button>--%>
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
		          <p class="text-center">Thành viên mới?&nbsp;&nbsp; <a data-toggle="tab" href="#signup">Đăng Ký </a>tại đây</p>
		        </div>
		      </div>
				</div>
			</div>
		</div>
	</section>
		  <dx:ASPxPopupControl ID="popup_Notification" runat="server" CloseAction="CloseButton" CloseOnEscape="true" Modal="True"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="popup_Notification"
        HeaderText="LỖI" AllowDragging="True" PopupAnimationType="None" EnableViewState="False" Theme="SoftOrange" Width="400px" style="z-index:99999; margin-top: 0px;" CssClass="bg_popup">
   <%--     <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); txt_phone.Focus(); }" />--%>
                 <HeaderStyle Font-Bold="True" Font-Size="16px">
                 <Paddings PaddingBottom="10px" PaddingTop="10px" />
                 </HeaderStyle>
        <ContentCollection>  
            <dx:PopupControlContentControl runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK" Width="100%"  >
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <table width="100%" >
                         <tr style="height:40px">
                                    <td class="pcmCellText">
                                        <asp:Label ID="lbl_popup_title" runat="server" CssClass="black_16_b"></asp:Label>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="pcmCellText"><asp:Label ID="lbl_popup_content" runat="server" CssClass="black_14"> </asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="pcmCheckBox">
                                      <asp:Label ID="lbl_active_clear" runat="server" Visible="false"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="pcmButton">
                                           <%--   <dx:ASPxButton ID="btCancel" runat="server" Text="Cancel" Width="80px" AutoPostBack="False" Style="float: left; margin-right: 8px">
                                                    <ClientSideEvents Click="function(s, e) { pcLogin.Hide(); }" />
                                                </dx:ASPxButton>--%>

                                            <dx:ASPxButton ID="btn_close" runat="server" Text="Đóng lại" Width="40%" AutoPostBack="false" style="float: right; margin-right: 0px; height: 29px;" OnClick="btn_close_Click" Theme="Office365"  >
                                                <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />
                                            </dx:ASPxButton> 
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
              
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ContentStyle>
            <Paddings PaddingBottom="5px" />
        </ContentStyle>
    </dx:ASPxPopupControl>

        <script src="../js/jquery.min.js"></script>
  <script src="../js/popper.js"></script>
  <script src="../js/bootstrap.min.js"></script>
  <script src="../js/main.js"></script>
 
    </form>
</body>
</html>
