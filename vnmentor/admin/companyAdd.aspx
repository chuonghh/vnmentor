﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="companyAdd.aspx.cs" Inherits="admin_companyAdd" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <script type="text/javascript">
        function onCodeValidation(s, e) {
            var code = e.value;
            if (code == null)
                return;
            if (code.length < 10)
                e.isValid = false;
            if (code.length > 10)
                e.isValid = false;
        }

        function onNameValidation(s, e) {
            var name = e.value;
            if (name == null)
                return;
            if (name.length < 3)
                e.isValid = false;
        }

        function onAgeValidation(s, e) {
            var age = e.value;
            if (age == null || age == "")
                return;
            var digits = "0123456789";
            for (var i = 0; i < age.length; i++) {
                if (digits.indexOf(age.charAt(i)) == -1) {
                    e.isValid = false;
                    break;
                }
            }
            if (e.isValid && age.charAt(0) == '0') {
                age = age.replace(/^0+/, "");
                if (age.length == 0)
                    age = "0";
                e.value = age;
            }
            if (age < 18)
                e.isValid = false;
        }
        function onArrivalDateValidation(s, e) {
            var selectedDate = s.date;
            if (selectedDate == null || selectedDate == false)
                return;
            var currentDate = new Date();
            if (currentDate.getFullYear() != selectedDate.getFullYear() || currentDate.getMonth() != selectedDate.getMonth())
                e.isValid = false;
        }
        function clearEditors(s, e) {
            var container = document.getElementsByClassName("clientContainer")[0];
            ASPxClientEdit.ClearEditorsInContainer(container);
        }
    </script>
 
    <script type="text/javascript">
        function onUploadControlFileUploadComplete(s, e) {
            if(e.isValid)
                document.getElementById("uploadedImage").src = "/Upload/UploadTemp/" + e.callbackData;
            setElementVisible("uploadedImage", e.isValid);
        }
        function onImageLoad() {
            var externalDropZone = document.getElementById("externalDropZone");
            var uploadedImage = document.getElementById("uploadedImage");
            uploadedImage.style.left = (externalDropZone.clientWidth - uploadedImage.width) / 2 + "px";
            uploadedImage.style.top = (externalDropZone.clientHeight - uploadedImage.height) / 2 + "px";
            setElementVisible("dragZone", false);
        }
        function setElementVisible(elementId, visible) {
            document.getElementById(elementId).className = visible ? "" : "hidden";
        }
    </script>

    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 text-right" >
      <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Mã công ty :"></dx:ASPxLabel>

     </div> 
    <div class="col-lg-9" >
   <dx:ASPxComboBox ID="cb_comCode" runat="server" Theme="Material"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="comCode"
              TextFormatString="{0} {1} {2}"
                Width="150px" DropDownStyle="DropDown">
       <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
       <%--   <ClientSideEvents Validation="onCodeValidation" />--%>
         <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox>
    </div> 
    </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="lbl_comName" runat="server" Text="Tên công ty :"></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    <dx:ASPxTextBox ID="txt_comName" runat="server" Width="300px" Theme="Material">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Địa chỉ :"></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    <dx:ASPxTextBox ID="txt_comAddress" runat="server" Width="100%" Theme="Material">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
   </div>
 
    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Số điện thoại :"></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    <dx:ASPxTextBox ID="txt_comTel" runat="server" Width="150px" Theme="Material">
               <MaskSettings Mask="0000000000" AllowMouseWheel="False" />
        <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập. " Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
       
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onAgeValidation" />
             <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Mail công ty :"></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    <dx:ASPxTextBox ID="txt_comEmail" runat="server" Width="300px" Theme="Material">
            <ValidationSettings ErrorDisplayMode="ImageWithText" Display="Dynamic" SetFocusOnError="True">
                            <RequiredField IsRequired="True" ErrorText="E-mail không thể để trống." />
                            <RegularExpression ErrorText="Invalid e-mail." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" /> 

    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Mã số thuế :"></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    <%--<dx:ASPxTextBox ID="txt_comTax" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox>--%>
   <dx:ASPxTextBox ID="txt_comTax" runat="server"  Width="150px"  Theme="Material"  CssClass="black_18_b" AutoPostBack="false"  >
                 <MaskSettings Mask="00000000000" AllowMouseWheel="False" />
                          <ValidationSettings SetFocusOnError="True" ErrorText="Mã số thuế công ty" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
                        <RequiredField IsRequired="True" ErrorText="" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxTextBox>

    </div> 

        </div>

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Mô tả :"></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    <dx:ASPxMemo ID="txt_comDescription" runat="server" Width="100%" Theme="Material" Height="60px">
          <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxMemo></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 text-right" > <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Active" ></dx:ASPxLabel></div> 
    <div class="col-lg-9" > 
    
        <dx:ASPxCheckBox ID="chk_active" runat="server" Theme="Material" Text="Active"></dx:ASPxCheckBox>
    </div>
        </div>

        <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 text-right" >  </div> 
    <div class="col-lg-9" > 
      
        <dx:ASPxButton ID="btn_submit" runat="server" Text="Lưu"  Theme="Material" OnClick="btn_submit_Click"  ></dx:ASPxButton>
      &nbsp; &nbsp;
        <dx:ASPxButton ID="btn_reset" runat="server" Text="Làm lại"  style="float: left; margin-right: 10px"  Theme="Office365" OnClick="btn_reset_Click" AutoPostBack="false" CausesValidation="false"  > 
                    <ClientSideEvents Click="clearEditors" />
        </dx:ASPxButton>
  
                                              
                               
    </div>
         </div>

    
           <dx:ASPxPopupControl ID="popup_Notification" runat="server" CloseAction="CloseButton" CloseOnEscape="true" Modal="True"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="popup_Notification"
        HeaderText="THÔNG BÁO" AllowDragging="True" PopupAnimationType="None" EnableViewState="False" Theme="SoftOrange" Width="400px" style="z-index:99999; margin-top: 0px;" CssClass="bg_popup">
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
                         <tr>
                                    <td class="auto-style1">
                                        <asp:Label ID="lbl_popup_title" runat="server" CssClass="black_16_b"></asp:Label>
                                        &nbsp;</td> 
                                </tr>
                                <tr>
                                    <td class="pcmCellText">
                                        <asp:Label ID="lbl_popup_content" runat="server" CssClass="black_14"> </asp:Label>
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

                                            <dx:ASPxButton ID="btn_close" runat="server" Text="HỦY BỎ" Width="40%" AutoPostBack="false" style="float: left; margin-right: 0px" OnClick="btn_close_Click" Theme="Office365"  >
                                                <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />
                                            </dx:ASPxButton>

                                             <dx:ASPxButton ID="btn_save" runat="server" Text="LƯU" Width="40%" AutoPostBack="false" style="float: right; margin-right: 0px"  Theme="Material"  CssClass="button_gold" OnClick="btn_save_Click" >
                                           <%--     <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />--%>
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


</asp:Content>

