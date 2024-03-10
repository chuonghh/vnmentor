<%@ Control Language="C#" AutoEventWireup="true" CodeFile="scheduling.ascx.cs" Inherits="admin_control_scheduling" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
  <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <Triggers>
           <%--     <asp:PostBackTrigger ControlID="chk_alldayenvent" />  
                         <asp:PostBackTrigger ControlID="chk_recurrence" />  --%>
                    </Triggers>
                    <ContentTemplate>
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
                <dx:ASPxCheckBox ID="chk_recurrence" runat="server" Theme="Material" ToggleSwitchDisplayMode="Always" OnCheckedChanged="chk_recurrence_CheckedChanged" AutoPostBack="true" Text="Hiển thị" CausesValidation="false" ></dx:ASPxCheckBox>
                </div>
            </div> 
     
    <asp:Panel ID="panel_recurrence" runat="server" Width="100%">
        <div class="col-lg-12 margin-bottom" >  
    <div class="col-lg-2 pad-top-4" > 
 

    </div>
    <div class="col-lg-10 no-padding" > 
         <div class="col-lg-12 margin-bottom no-padding" >  
         <dx:aspxcombobox ID="cb_recurrence" runat="server" Width="150px" Theme="Material" SelectedIndex="0" TabIndex="8" OnSelectedIndexChanged="cb_recurrence_SelectedIndexChanged" AutoPostBack="true" CausesValidation="false">
           <Items>
               <dx:ListEditItem Selected="True" Text="Daily" Value="Daily" />
               <dx:ListEditItem Text="Weekly" Value="Weekly" /> 
               <dx:ListEditItem Text="Monthly" Value="Monthly" /> 
               <dx:ListEditItem Text="Yearly" Value="Yearly" />  

           </Items>  <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:aspxcombobox>
        </div>  
        
        <div class="col-lg-12 margin-bottom no-padding" > 
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
         <dx:ASPxCheckBoxList ID="chk_weekdays" runat="server" EnableTheming="True" RepeatDirection="Horizontal" Theme="Material" RepeatColumns="5" >
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
              <div class="col-lg-9 no-padding  no-padding" > 
                  <dx:ASPxSpinEdit ID="txt_monthlyDayData" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px"> 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit>
                   
                  </div>
             </div>

        <div class="col-lg-12 no-padding" >  
           <div class="col-lg-3 pad-top-4" > 
                 <dx:ASPxLabel ID="ASPxLabel23"  runat="server" Text="of every :" Theme="Material"></dx:ASPxLabel>
                  </div>
            
              <div class="col-lg-9 no-padding no-padding margin-bottom-5" > 
                  <dx:ASPxSpinEdit ID="txt_monthlyOfEveryDay" runat="server" Number="1" style="float: left; margin-right: 10px" NumberType="Integer" Theme="Material" MaxValue="99" MinValue="1" Width="120px" > 
                        <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxSpinEdit> 
                  </div>
         </div>

              <div class="col-lg-12 no-padding" >  
         <div class="col-lg-3 no-padding" > 
                <dx:ASPxRadioButton ID="chk_monthlyThe" Text="The" runat="server" Checked="false" GroupName="month" Theme="Material" >     </dx:ASPxRadioButton>
    
            </div>
              <div class="col-lg-9 no-padding no-padding" > 
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
              <div class="col-lg-9 no-padding no-padding" > 
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
              <div class="col-lg-9 no-padding no-padding" > 
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
                 <dx:ASPxLabel ID="ASPxLabel2"  runat="server" Text="of :" Theme="Material"></dx:ASPxLabel>
                  </div>
            
              <div class="col-lg-9 no-padding no-padding" > 
             
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
        
                    </ContentTemplate>
                </asp:UpdatePanel>
