<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="admin_register" %>
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
                document.getElementById("uploadedImage").src = "/admin/images/uploadTemp/" + e.callbackData;
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
     <script type="text/javascript">
         function UpdateInfo() {
             var daysTotal = deEnd.GetRangeDayCount();
             tbInfo.SetText(daysTotal !== -1 ? daysTotal + ' days' : '');
         }
     </script>

       <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 pad-top-4" >
      <dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="Chi nhánh :"></dx:ASPxLabel>
     </div> 
    <div class="col-lg-9 no-padding" >
   <dx:ASPxComboBox ID="cb_comCode" runat="server" Theme="Material" AutoPostBack="true"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="comCode"
              TextFormatString="{0} {1} {2}"
                Width="200px" DropDownStyle="DropDown" OnSelectedIndexChanged="cb_comCode_SelectedIndexChanged">
    <%--   <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>--%>
       <%--   <ClientSideEvents Validation="onCodeValidation" />--%>
         <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox>
    </div> 
               </div>
          <asp:UpdatePanel ID="UpdatePanel1" runat="server"  UpdateMode="Conditional" ChildrenAsTriggers="false">
          <Triggers > 
              <%--<asp:PostBackTrigger ControlID="radio_gold_silver" />--%>
              <asp:AsyncPostBackTrigger ControlID="cb_comCode"  ></asp:AsyncPostBackTrigger> 
                  </Triggers>
             <ContentTemplate>
        
    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 pad-top-4" >
      <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Phòng ban :"></dx:ASPxLabel>
     </div> 
    <div class="col-lg-9 no-padding" >
   <dx:ASPxComboBox ID="cb_depCode" runat="server" Theme="Material"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="depCode"
              TextFormatString="{0} {1} {2}"
                Width="200px" DropDownStyle="DropDown" TabIndex="1">
     <%--  <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>--%>
       <%--   <ClientSideEvents Validation="onCodeValidation" />--%>
         <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox>
    </div> 

    </div>
         


      <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_empCode" runat="server" Text="Mã nhân viên :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" data-bind="txt_empCode: { editEnabled: false  }"> 
   
    <dx:ASPxTextBox ID="txt_empCode" runat="server" Width="120px" Theme="Material"   CssClass="black_14_b" ReadOnly="True" TabIndex="3">
           <%--<ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings> --%>
                    
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_empName" runat="server" Text="Tên nhân viên :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_empName" runat="server" Width="300px" Theme="Material" TabIndex="4">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Mật khẩu :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_password" runat="server" Width="120px" Theme="Material" TabIndex="5" Text="pfe@2022"> 
        <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Ngày sinh :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxDateEdit ID="txt_birthDay" runat="server" Width="120px" Theme="Material" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="6">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
               
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxDateEdit></div>
        </div>

     <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Nơi sinh :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxComboBox ID="cb_birthPlace" runat="server" Width="150PX" Theme="Material" TabIndex="7">
          
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxComboBox></div>
        </div>

     <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Giới tính :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:aspxcombobox ID="txt_sex" runat="server" Width="100px" Theme="Material" SelectedIndex="0" TabIndex="8">
           <Items>
               <dx:ListEditItem Selected="True" Text="Nam" Value="0" />
               <dx:ListEditItem Text="Nữ" Value="1" />
               <dx:ListEditItem Text="Khác" Value="2" />
           </Items>
  <%--         <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>--%>
                 
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox></div>
        </div>

     <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="CMCN/CCCD :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_identityCard" runat="server" Width="120px" Theme="Material" TabIndex="9">
        <%--   <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>--%>
                    <%--<ClientSideEvents Validation="onNameValidation" />--%>
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_mail" runat="server" Text="Mail :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_email" runat="server" Width="300px" Theme="Material" TabIndex="10" OnValueChanged="txt_email_ValueChanged">
            <ValidationSettings ErrorDisplayMode="ImageWithText" Display="Dynamic" SetFocusOnError="True">
                            <RequiredField IsRequired="True" ErrorText="E-mail không thể để trống." />
                            <RegularExpression ErrorText="Invalid e-mail." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        </ValidationSettings>
                   <%-- <ClientSideEvents Validation="onNameValidation" />--%>
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" /> 

    </dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Số điện thoại :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_phone" runat="server" Width="150px" Theme="Material" TabIndex="11">
               <MaskSettings Mask="0000000000" AllowMouseWheel="False" />
     <%--   <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập. " Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
       
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onAgeValidation" />--%>
             <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>
     

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Địa chỉ thường trú:"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_address" runat="server" Width="100%" Theme="Material" TabIndex="12">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
   </div>
 
    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Địa chỉ tạm trú:"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxTextBox ID="txt_address1" runat="server" Width="100%" Theme="Material" TabIndex="13">
    
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
   </div>
  

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Ngày bắt đầu làm việc"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <%--<dx:ASPxTextBox ID="txt_comTax" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox>--%>
   <dx:ASPxDateEdit ID="txt_beginDate" runat="server"  Width="120px"  Theme="Material"  CssClass="black_18_b" AutoPostBack="false" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="14" >
                 
                 <%--   <ClientSideEvents Validation="onNameValidation" />--%>
                     <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxDateEdit>
    </div> 
        </div>

        <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Ngày ký hợp đồng :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 

   <dx:ASPxDateEdit ID="txt_contractBegin" runat="server"  Width="120px"  Theme="Material"  CssClass="black_18_b"   DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="15" ClientInstanceName="txt_contractBegin">  
                 <ClientSideEvents DateChanged="UpdateInfo"></ClientSideEvents>
                                    <CalendarProperties>
                                        <FastNavProperties DisplayMode="Inline" />
                                    </CalendarProperties>
                                    <ValidationSettings Display="Dynamic" SetFocusOnError="True" CausesValidation="True">
                                        <RequiredField IsRequired="True" ErrorText="Start date is required"></RequiredField>
                                    </ValidationSettings>
                     <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxDateEdit>
    </div> 
        </div>

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Ngày hết hạn hợp đồng :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
        <dx:aspxcombobox ID="txt_contractEnd" runat="server" Width="120px" Theme="Material" SelectedIndex="0" TabIndex="8">
           <Items>
               <dx:ListEditItem Selected="True" Text="1 năm" Value="1" />
               <dx:ListEditItem Text="3 năm" Value="3" />
               <dx:ListEditItem Text="Không thời hạn" Value="40" />
           </Items>
  <%--         <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>--%>
                 
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>
  <%-- <dx:ASPxDateEdit ID="txt_contractEnd" runat="server"  Width="120px"  Theme="Material"  CssClass="black_18_b"   DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="16" ClientInstanceName="txt_contractEnd">
  <CalendarProperties>
                                        <FastNavProperties DisplayMode="Inline" />
                                    </CalendarProperties>
                                    <DateRangeSettings StartDateEditID="txt_contractBegin" MinDayCount="1"></DateRangeSettings>
                                    <ClientSideEvents DateChanged="UpdateInfo"></ClientSideEvents>
                                    <ValidationSettings Display="Dynamic" SetFocusOnError="True" CausesValidation="True" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="True" ErrorText="End date is required"></RequiredField>
                                    </ValidationSettings>
       <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxDateEdit>--%>

          

    </div> 
        </div>

      <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="BHXH :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 

   <dx:ASPxTextBox ID="txt_BHXH" runat="server"  Width="120px"  Theme="Material"  CssClass="black_18_b" AutoPostBack="false" TabIndex="17"  >
               
                        
                     <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxTextBox>
    </div> 
        </div>

    
      <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="BHYT :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
 
   <dx:ASPxTextBox ID="txt_BHYT" runat="server"  Width="120px"  Theme="Material"  CssClass="black_18_b" AutoPostBack="false" TabIndex="18"  >
           <%--      <MaskSettings Mask="00000000000" AllowMouseWheel="False" />--%>
              
                     <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxTextBox>
    </div> 
        </div>

       <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="Hình ảnh :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
  
    <div class="uploadContainer">
        <dx:ASPxUploadControl ID="UploadControl" ClientInstanceName="UploadControl" runat="server" UploadMode="Auto" AutoStartUpload="True" Width="100%" 
            ShowProgressPanel="True" DialogTriggerID="externalDropZone" OnFileUploadComplete="UploadControl_FileUploadComplete" Theme="Office2010Black" TabIndex="19" >
            <AdvancedModeSettings EnableDragAndDrop="True" EnableMultiSelect="True" ExternalDropZoneID="externalDropZone" DropZoneText="" />
            <ValidationSettings MaxFileSize="1194304" AllowedFileExtensions=".jpg, .jpeg, .gif, .png" ErrorStyle-CssClass="validationMessage" >
                <ErrorStyle CssClass="validationMessage" />
            </ValidationSettings>
            <BrowseButton Text="Select an image for upload..." />
            <DropZoneStyle CssClass="uploadControlDropZone" />
            <ClientSideEvents 
                DropZoneEnter="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', true); }" 
                DropZoneLeave="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', false); }" 
                FileUploadComplete="onUploadControlFileUploadComplete">
            </ClientSideEvents>
            <Border BorderStyle="None" />
            <BorderBottom BorderColor="#CBAB58" />
        </dx:ASPxUploadControl>
        
    </div>
          <asp:Label ID="lbl_alert_upload" runat="server" Text="Upload images is required" CssClass="reb_14" Visible="false"></asp:Label>
        
        <div id="externalDropZone" class="dropZoneExternal">
        <div id="dragZone">
            <span class="dragZoneText" >Drag an image here <img id="icon" src="/images/staff-icon-300x300.png" height="100px"></span> 
            <i class="fa-solid fa-image-portrait"></i>
        </div>
        <img id="uploadedImage" src="#" class="hidden" alt="" height="180px" onload="onImageLoad()"   />
        <div id="dropZone" class="hidden">
            <span class="dropZoneText">Drop an image here</span>
             
        </div>
    </div>
             </div>  
 
        </div>
                 
    
</ContentTemplate>
                 </asp:UpdatePanel>

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Mô tả :"></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    <dx:ASPxMemo ID="txt_description" runat="server" Width="100%" Theme="Material" Height="60px" TabIndex="20">
          <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxMemo></div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="" ></dx:ASPxLabel></div> 
    <div class="col-lg-9 no-padding" > 
    
        <dx:ASPxCheckBox ID="chk_active" runat="server" Theme="Material" Text="Active" TabIndex="21"></dx:ASPxCheckBox>
    </div>
        </div>

        <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" >  </div> 
    <div class="col-lg-9 no-padding" > 
      
        <dx:ASPxButton ID="btn_submit" runat="server" Text="Lưu"  Width="140px" Theme="Material" OnClick="btn_submit_Click" TabIndex="22"  ></dx:ASPxButton>
      &nbsp; &nbsp;
        <dx:ASPxButton ID="btn_reset" runat="server" Text="Làm lại"  style="float: left; margin-right: 10px"  Theme="Office365" OnClick="btn_reset_Click" AutoPostBack="false" CausesValidation="false" Width="140px"  > 
               <%--     <ClientSideEvents Click="clearEditors" />--%>
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
                            <div class="col-lg-12 margin-bottom">
                               <div class="col-lg-12 margin-bottom-5">
 <asp:Label ID="lbl_popup_title" runat="server" CssClass="black_16_b"></asp:Label>
                               </div>
                                 <div class="col-lg-12 margin-bottom-5">
                                         <asp:Label ID="lbl_popup_content" runat="server" CssClass="black_14_b"> </asp:Label>
                               </div>
                                   <div class="col-lg-12 margin-bottom margin-bottom">
                                          <asp:Label ID="lbl_active_clear" runat="server" Visible="false"></asp:Label>
                               </div>

                                   <div class="col-lg-12">
                                    
                                            <dx:ASPxButton ID="btn_close" runat="server" Text="HỦY BỎ" AutoPostBack="false" style="float: left; margin-right: 0px; Width:140px" OnClick="btn_close_Click" Theme="Office365"  >
                                                <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />
                                            </dx:ASPxButton>
                 
            <dx:ASPxButton ID="btn_save" runat="server" Text="LƯU"  AutoPostBack="true" style="float: right; margin-right: -11px; Width:140px"   Theme="Material"  CssClass="button_gold" OnClick="btn_save_Click" CausesValidation="false" >
                                               <%-- <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />--%>
                                            </dx:ASPxButton>
                                       </div>  
                               
                            </div>
                          
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
