﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="courseAddTime.aspx.cs" Inherits="admin_courseAddTime" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxHtmlEditor.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHtmlEditor" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
     
        <asp:UpdatePanel ID="UpdatePanel1" runat="server"  UpdateMode="Conditional" ChildrenAsTriggers="false">
          <Triggers >   
              
              <asp:AsyncPostBackTrigger ControlID="chk_alldayenvent"  ></asp:AsyncPostBackTrigger> 
                <asp:AsyncPostBackTrigger ControlID="chk_recurrence"></asp:AsyncPostBackTrigger> 
                <asp:AsyncPostBackTrigger ControlID="cb_recurrence"></asp:AsyncPostBackTrigger>  
              <%--  <asp:AsyncPostBackTrigger ControlID="cb_no_end_date"></asp:AsyncPostBackTrigger> --%>
                <asp:AsyncPostBackTrigger ControlID="chk_endAfter"></asp:AsyncPostBackTrigger> 
                <asp:AsyncPostBackTrigger ControlID="chk_endBy"></asp:AsyncPostBackTrigger> 
               <asp:AsyncPostBackTrigger ControlID="cb_subject"></asp:AsyncPostBackTrigger> 
                 <asp:PostBackTrigger ControlID="popup_Notification"/>  
               <asp:PostBackTrigger ControlID="btn_submit"  ></asp:PostBackTrigger> 
              
                  </Triggers>
             <ContentTemplate>
      <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_empCode" runat="server" Text="Mã khóa học :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" >  
        <div class="col-lg-8  no-padding">
    <dx:ASPxTextBox ID="txt_couCode" runat="server" Width="120px" Theme="Material"   CssClass="black_14_b" ReadOnly="True" TabIndex="3"> <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox> 
            </div>
         <div class="col-lg-4">
           <%--       <dx:ASPxButton ID="btn_add_day" runat="server" Text="Thêm giờ học" Theme="MaterialCompact" style="float: right; margin-right: -11px; "  CausesValidation="false" OnClick="btn_add_day_Click"  >
                    <Image IconID="iconbuilder_actions_add_svg_white_16x16">
                    </Image>
                </dx:ASPxButton>--%>
             </div>
    </div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_empName" runat="server" Text="Tên khóa học :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
      
    <dx:ASPxTextBox ID="txt_couName" runat="server" Width="100%" Theme="Material" TabIndex="4" ReadOnly="true">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip" >
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox>
        </div>

       </div> 
        
              <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Sự kiện cả ngày :"></dx:ASPxLabel></div> 
            <div class="col-lg-10 no-padding" > 
                 <div class="col-lg-5 no-padding" > 
                <dx:ASPxCheckBox ID="chk_alldayenvent" runat="server" Theme="Material" ToggleSwitchDisplayMode="Always" OnCheckedChanged="chk_alldayenvent_CheckedChanged" AutoPostBack="true" CausesValidation="false"></dx:ASPxCheckBox>
                 
            </div>

              <div class="col-lg-7 no-padding" > 
              <div class="col-lg-3 pad-top-4" > 
                   <dx:ASPxLabel ID="ASPxLabel25" runat="server" Text="Location :"></dx:ASPxLabel>
               </div>
               <div class="col-lg-9 no-padding" > 
                        <dx:aspxcombobox ID="cb_location" runat="server" Width="100%" Theme="Material" TabIndex="12">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>
               </div>
                  </div>

                        </div>
                </div>
        

              <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > 
        <dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Bắt đầu thời gian :"></dx:ASPxLabel>

    </div> 
            <div class="col-lg-10 no-padding" > 
           <div class="col-lg-5 no-padding" > 
           <dx:ASPxDateEdit ID="txt_startDate" runat="server" Width="130px" Theme="Material" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="6"  style="float: left; margin-right: 10px">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings> 
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxDateEdit> 
                 <dx:ASPxTimeEdit  ID="txt_startTime" runat="server" Width="130px" Theme="Material"   EditFormat="Time" AllowNull="false"  TabIndex="6"  style="float: left; margin-right: 10px" >
           
        <ValidationSettings ErrorDisplayMode="None" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTimeEdit> 
               </div>
              <div class="col-lg-7 no-padding" > 
              <div class="col-lg-3 pad-top-4" > 
                   <dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Label :"></dx:ASPxLabel>
               </div>
               <div class="col-lg-9 no-padding" > 
                     <dx:aspxcombobox ID="cb_lable" runat="server" Width="100%" Theme="Material" SelectedIndex="0" TabIndex="8"   AutoPostBack="true" CausesValidation="false">
           <Items>
               <dx:ListEditItem Selected="True" Text="Routine" Value="Routine" />
               <dx:ListEditItem Text="Follow-Up" Value="FollowUp" /> 
               <dx:ListEditItem Text="Urgent" Value="Urgent" /> 
               <dx:ListEditItem Text="Lab Testing" Value="LabTesting" />  
               <dx:ListEditItem Text="Service" Value="Service" />  

           </Items>  <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>
               </div>
                  </div>
                </div> 
            </div> 

          <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Kết thúc thời gian :"></dx:ASPxLabel></div> 
            <div class="col-lg-10 no-padding" > 
                <div class="col-lg-5 no-padding" > 
           <dx:ASPxDateEdit ID="txt_endDate" runat="server" Width="130px" Theme="Material" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="6"  style="float: left; margin-right: 10px" >
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings> 
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxDateEdit> 
                 <dx:ASPxTimeEdit  ID="txt_endTime" runat="server" Width="130px" Theme="Material"   EditFormat="Time" AllowNull="false"  TabIndex="6"  style="float: left; margin-right: 10px" >
           
        <ValidationSettings ErrorDisplayMode="None" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTimeEdit> 
                 </div>

              <div class="col-lg-7 no-padding" > 
              <div class="col-lg-3 pad-top-4" > 
                   <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Show As Time :"></dx:ASPxLabel>
               </div>
               <div class="col-lg-9 no-padding" > 
                     <dx:aspxcombobox ID="cb_showAsTime" runat="server" Width="100%" Theme="Material" SelectedIndex="0" TabIndex="8"  CausesValidation="false">
           <Items>
               <dx:ListEditItem Selected="True" Text="Confirmed" Value="Confirmed" />
               <dx:ListEditItem Text="Awaiting Confirmation" Value="waiting" /> 
               <dx:ListEditItem Text="Cancelled" Value="Cancelled" /> 
              

           </Items>  <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>
               </div>
                  </div>

                </div> 
            </div> 

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > </div> 
            <div class="col-lg-10 no-padding" > 
                <dx:ASPxCheckBox ID="chk_recurrence" runat="server" Theme="Material" ToggleSwitchDisplayMode="Always" OnCheckedChanged="chk_recurrence_CheckedChanged" AutoPostBack="true" Text="Hiển thị" CausesValidation="false"></dx:ASPxCheckBox>
                </div>
            </div> 
     
    <asp:Panel ID="panel_recurrence" runat="server" Width="100%">
        <div class="col-lg-12 margin-bottom" >  
    <div class="col-lg-2 pad-top-4" > 
        <%--<dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="xuất hiện :"></dx:ASPxLabel> --%>

    </div>
    <div class="col-lg-10 no-padding" > 
         <div class="col-lg-12 margin-bottom no-padding" >  
         <dx:aspxcombobox ID="cb_recurrence" runat="server" Width="150px" Theme="Material" SelectedIndex="0" TabIndex="8" OnSelectedIndexChanged="cb_recurrence_SelectedIndexChanged" AutoPostBack="true" CausesValidation="false">
           <Items>
               <dx:ListEditItem Selected="True" Text="Daily" Value="daily" />
               <dx:ListEditItem Text="Weekly" Value="weekly" /> 
               <dx:ListEditItem Text="Monthly" Value="monthly" /> 
               <dx:ListEditItem Text="Yearly" Value="yearly" />  

           </Items>  <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>
        </div>  
        
        <div class="col-lg-12 no-padding" > 
          <div class="col-lg-6 no-padding left" > 
              
    <asp:Panel ID="panel_Daily" runat="server" Width="100%"> 
          <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 no-padding" > 
        <dx:ASPxRadioButton ID="chk_dailyEvery" Text="Every" runat="server" Checked="true" GroupName="every" Theme="Material" >     </dx:ASPxRadioButton>
            </div>

              <div class="col-lg-4  no-padding" > 
                     <dx:ASPxSpinEdit ID="txt_dailyEveryData" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" Width="120px">
                           <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit>
                </div>
             </div>

        <div class="col-lg-12 no-padding" >  
         <div class="col-lg-6 no-padding" > 
          <dx:ASPxRadioButton ID="chk_dailyEveryWeekday" Text="Every Weekday"  runat="server" Checked="false" GroupName="every" Theme="Material" >   </dx:ASPxRadioButton>
             </div> 
         </div>  
        </asp:Panel>
        
        <asp:Panel ID="panel_Weekly" runat="server" Width="100%">
         <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 pad-top-4" > 
      <dx:ASPxLabel ID="ASPxLabel21"  runat="server" Text="Recur Every"></dx:ASPxLabel>
            </div>
              <div class="col-lg-7 no-padding  no-padding" > 
                  <dx:ASPxSpinEdit ID="txt_weeklyEveryData" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px"> 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit>
                   <dx:ASPxLabel ID="ASPxLabel22"  runat="server" Text="week(s) on:" Theme="Material"></dx:ASPxLabel>
                  </div>
             </div>
     <div class="col-lg-12 no-padding" >  
         <dx:ASPxCheckBoxList ID="chk_weekdays" runat="server" EnableTheming="True" RepeatDirection="Horizontal" Theme="Material" RepeatColumns="6" >
             <Items>
              <dx:ListEditItem Text="Mon" Value="mon" />
                 <dx:ListEditItem Text="Tue" Value="tue" />
                 <dx:ListEditItem Text="Wed" Value="wed" />
                 <dx:ListEditItem Text="Thu" Value="thu" />
                 <dx:ListEditItem Text="Fri" Value="fri" />
                 <dx:ListEditItem Text="Sat" Value="sat" />
                 <dx:ListEditItem Text="Sun" Value="sun" />
             </Items>
             <Border BorderStyle="None" />
         </dx:ASPxCheckBoxList>
         </div>  
        </asp:Panel>

         <asp:Panel ID="panel_month" runat="server" Width="100%">
         <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 no-padding" > 
                <dx:ASPxRadioButton ID="chk_monthlyDay" Text="Every" runat="server" Checked="true" GroupName="month" Theme="Material" >     </dx:ASPxRadioButton>
    
            </div>
              <div class="col-lg-9 no-padding" > 
                  <dx:ASPxSpinEdit ID="txt_monthlyDayData" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px"> 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit>
                   
                  </div>
             </div>

        <div class="col-lg-12 no-padding" >  
           <div class="col-lg-3 pad-top-4" > 
                 <dx:ASPxLabel ID="ASPxLabel23"  runat="server" Text="of every :" Theme="Material"></dx:ASPxLabel>
                  </div>
            
              <div class="col-lg-9 no-padding margin-bottom-5" > 
                  <dx:ASPxSpinEdit ID="txt_monthlyOfEveryDay" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px" > 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit> 
                  </div>
         </div>

              <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 no-padding" > 
                <dx:ASPxRadioButton ID="chk_monthlyThe" Text="The" runat="server" Checked="false" GroupName="month" Theme="Material" >     </dx:ASPxRadioButton>
    
            </div>
              <div class="col-lg-9 no-padding" > 
                   <dx:aspxcombobox ID="txt_monthlyTheData" runat="server" Width="120px" Theme="Material" SelectedIndex="0" TabIndex="8" style="float: left; margin-right: 10px;">
           <Items>
               <dx:ListEditItem Selected="True" Text="Firts" Value="Firts" />
               <dx:ListEditItem Text="Second" Value="Second" /> 
               <dx:ListEditItem Text="Third" Value="Third" /> 
               <dx:ListEditItem Text="Fourth" Value="Fourth" />  
                 <dx:ListEditItem Text="Last" Value="Last" />  

           </Items>  <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
                 </dx:aspxcombobox>

            <dx:aspxcombobox ID="txt_monthlyTheData1" runat="server" EnableTheming="True" RepeatDirection="Horizontal" Theme="Material"  style="float: left; margin-right: 0px;" Width="120px">
             <Items>
              <dx:ListEditItem Text="Monday" Value="Monday" Selected="True" />
                 <dx:ListEditItem Text="Tuesday" Value="Tuesday" />
                 <dx:ListEditItem Text="Wednesday" Value="Wednesday" />
                 <dx:ListEditItem Text="Thursday" Value="Thursday" />
                 <dx:ListEditItem Text="Friday" Value="Friday" />
                 <dx:ListEditItem Text="Saturday" Value="Saturday" />
                 <dx:ListEditItem Text="Sunday" Value="Sunday" />
             </Items>
              <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
         </dx:aspxcombobox>

                  </div>
             </div>

        <div class="col-lg-12 no-padding" >  
           <div class="col-lg-3 pad-top-4" > 
                 <dx:ASPxLabel ID="ASPxLabel24"  runat="server" Text="of every :" Theme="Material"></dx:ASPxLabel>
                  </div>
            
              <div class="col-lg-7 no-padding  no-padding" > 
                  <dx:ASPxSpinEdit ID="txt_monthlyofEveryThe" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px" SelectInputTextOnClick="True"> 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit> 
                  

                  </div>
         </div> 
        </asp:Panel>

                 <asp:Panel ID="panel_yearly" runat="server" Width="100%">
         <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 no-padding" > 
                <dx:ASPxRadioButton ID="chk_yearEvery" Text="Every" runat="server" Checked="true" GroupName="month" Theme="Material" >     </dx:ASPxRadioButton>
    
            </div>
              <div class="col-lg-9 no-padding" > 
                  <dx:aspxcombobox ID="txt_yearEveryData" runat="server" EnableTheming="True" RepeatDirection="Horizontal" Theme="Material"  style="float: left; margin-right: 10px;" Width="120px">
             <Items>
              <dx:ListEditItem Text="January" Value="January" Selected="True" />
                 <dx:ListEditItem Text="February" Value="February" />
                 <dx:ListEditItem Text="March" Value="March" />
                 <dx:ListEditItem Text="April" Value="April" />
                 <dx:ListEditItem Text="May" Value="May" />
                 <dx:ListEditItem Text="June" Value="June" />
                 <dx:ListEditItem Text="July" Value="July" />
                 <dx:ListEditItem Text="August" Value="August" />
                 <dx:ListEditItem Text="September" Value="September" />
                 <dx:ListEditItem Text="October" Value="October" />
                 <dx:ListEditItem Text="November" Value="November" />
                 <dx:ListEditItem Text="December" Value="December" />
             </Items>
              <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
         </dx:aspxcombobox>

                  <dx:ASPxSpinEdit ID="txt_yearEveryData1" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px"> 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit>
                   
                  </div>
             </div>

        

              <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 no-padding" > 
                <dx:ASPxRadioButton ID="chk_yearThe" Text="The" runat="server" Checked="false" GroupName="month" Theme="Material" >     </dx:ASPxRadioButton>
    
            </div>
              <div class="col-lg-9 no-padding" > 
                   <dx:aspxcombobox ID="txt_yearTheData" runat="server" Width="120px" Theme="Material" SelectedIndex="0" TabIndex="8" style="float: left; margin-right: 10px;">
           <Items>
               <dx:ListEditItem Selected="True" Text="Firts" Value="Firts" />
               <dx:ListEditItem Text="Second" Value="Second" /> 
               <dx:ListEditItem Text="Third" Value="Third" /> 
               <dx:ListEditItem Text="Fourth" Value="Fourth" />  
                 <dx:ListEditItem Text="Last" Value="Last" />  

           </Items>  <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
                 </dx:aspxcombobox>

           <dx:aspxcombobox ID="txt_yearTheData1" runat="server" EnableTheming="True" RepeatDirection="Horizontal" Theme="Material"  style="float: left; margin-right: 0px;" Width="120px">
             <Items>
              <dx:ListEditItem Text="Monday" Value="Monday" Selected="True" />
                 <dx:ListEditItem Text="Tuesday" Value="Tuesday" />
                 <dx:ListEditItem Text="Wednesday" Value="Wednesday" />
                 <dx:ListEditItem Text="Thursday" Value="Thursday" />
                 <dx:ListEditItem Text="Friday" Value="Friday" />
                 <dx:ListEditItem Text="Saturday" Value="Saturday" />
                 <dx:ListEditItem Text="Sunday" Value="Sunday" />
             </Items>
              <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
         </dx:aspxcombobox>

                  </div>
             </div>

        <div class="col-lg-12 no-padding" >  
           <div class="col-lg-3 pad-top-4 text-right" > 
                 <dx:ASPxLabel ID="ASPxLabel20"  runat="server" Text="of :" Theme="Material"></dx:ASPxLabel>
                  </div>
            
              <div class="col-lg-9 no-padding" > 
             
                  <dx:aspxcombobox ID="txt_yearOf" runat="server" EnableTheming="True" RepeatDirection="Horizontal" Theme="Material"  style="float: left; margin-right: 10px;" Width="250">
             <Items>
              <dx:ListEditItem Text="January" Value="January" Selected="True" />
                 <dx:ListEditItem Text="February" Value="February" />
                 <dx:ListEditItem Text="March" Value="March" />
                 <dx:ListEditItem Text="April" Value="April" />
                 <dx:ListEditItem Text="May" Value="May" />
                 <dx:ListEditItem Text="June" Value="June" />
                 <dx:ListEditItem Text="July" Value="July" />
                 <dx:ListEditItem Text="August" Value="August" />
                 <dx:ListEditItem Text="September" Value="September" />
                 <dx:ListEditItem Text="October" Value="October" />
                 <dx:ListEditItem Text="November" Value="November" />
                 <dx:ListEditItem Text="December" Value="December" />
             </Items>
              <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
         </dx:aspxcombobox>

                  </div>
         </div>

        </asp:Panel>


          </div>

         <div class="col-lg-6 no-padding right" >  
          <div class="col-lg-12 no-padding " >  
         <dx:ASPxRadioButton ID="chk_noEndDate" Text="No End Date"  runat="server" Checked="true" GroupName="enddate" Theme="Material" OnCheckedChanged="chk_noEndDate_CheckedChanged" AutoPostBack="true" >   </dx:ASPxRadioButton>
                  </div>

             <div class="col-lg-12 no-padding " >  
          <div class="col-lg-4 no-padding" >
         <dx:ASPxRadioButton ID="chk_endAfter" Text="End After"  runat="server" Checked="false" GroupName="enddate" Theme="Material" OnCheckedChanged="chk_endAfter_CheckedChanged" AutoPostBack="true">   </dx:ASPxRadioButton>
              </div>   

       <div class="col-lg-4 no-padding" >
          <dx:ASPxSpinEdit ID="txt_endAfterData" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material"   Width="100px"> 
                <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit>
              </div>    
             </div>

               <div class="col-lg-12 no-padding " >  
                     <div class="col-lg-4 no-padding" >
                      <dx:ASPxRadioButton ID="chk_endBy" Text="End By"  runat="server" Checked="false" GroupName="enddate" Theme="Material" OnCheckedChanged="chk_endBy_CheckedChanged" AutoPostBack="true">   </dx:ASPxRadioButton>
                         </div>
                     <div class="col-lg-8 no-padding" >
 <dx:ASPxDateEdit ID="txt_endByData" runat="server" Width="130px" Theme="Material" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="6"  style="float: left; margin-right: 10px" >
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings> 
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxDateEdit> 
                         </div>
                  </div>
            </div>  
         </div> 
                   </div>
             </div>
        </asp:Panel>

   <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Môn học :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
 <dx:aspxcombobox ID="cb_subject"  ValueField="empCode" runat="server" Width="250px" Theme="Material" SelectedIndex="0" TabIndex="8" AutoPostBack="true" OnSelectedIndexChanged="cb_subject_SelectedIndexChanged">
     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox> 
    </div>
        </div>

    <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Giáo viên :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
 <dx:aspxcombobox ID="cb_empCode"  ValueField="empCode" runat="server" Width="250px" Theme="Material" SelectedIndex="0" TabIndex="8"  > 
     <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>

                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>

    </div>
        </div>

     
 
<%--
    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Ngày dự kiến khai giảng :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
    <dx:ASPxDateEdit ID="txt_startDay" runat="server" Width="120px" Theme="Material" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" TabIndex="6">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithText">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
               
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxDateEdit></div>
        </div>--%>

    
    
 

 
  
    <div class="col-lg-12 margin-bottom" > 
     <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="" ></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
    
        <dx:ASPxCheckBox ID="chk_active" runat="server" Theme="Material" Checked="true" Text="Active" TabIndex="21"></dx:ASPxCheckBox>
    </div>
        </div>

        <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" >  </div> 
    <div class="col-lg-10 no-padding" > 
      
        <dx:ASPxButton ID="btn_submit" runat="server" Text="Lưu"  Width="140px" Theme="Material" OnClick="btn_submit_Click" TabIndex="22"  ></dx:ASPxButton>
      &nbsp; &nbsp;
        <dx:ASPxButton ID="btn_reset" runat="server" Text="Làm lại"  style="float: left; margin-right: 10px"  Theme="Office365" OnClick="btn_reset_Click" AutoPostBack="false" CausesValidation="false" Width="140px"  > 
              <ClientSideEvents Click="clearEditors" />
        </dx:ASPxButton>                
                               
    </div>
         </div>
</ContentTemplate>
            </asp:UpdatePanel>
    
           <dx:ASPxPopupControl ID="popup_Notification" runat="server" CloseAction="CloseButton" CloseOnEscape="true" Modal="True"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="popup_Notification"
        HeaderText="THÔNG BÁO" AllowDragging="True" PopupAnimationType="None" EnableViewState="False" Theme="SoftOrange" Width="400px" style="z-index:99999; margin-top: 0px;" CssClass="bg_popup">
 
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
                                    
                                            <dx:ASPxButton ID="btn_close" runat="server" Text="HỦY BỎ" AutoPostBack="false" style="float: left; margin-right: 0px; Width:140px" OnClick="btn_close_Click" Theme="Office365" CausesValidation="false"  >
                                            <%--    <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />--%>
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

    <div >
    </div>

</asp:Content>
