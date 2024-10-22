﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="courseList.aspx.cs" Inherits="admin_courseList" %>

<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Src="~/admin/UserControls/scheduling.ascx" TagPrefix="uc1" TagName="scheduling" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
               <asp:UpdatePanel ID="UpdatePanel1" runat="server"  UpdateMode="Conditional" ChildrenAsTriggers="true">
          <Triggers > 
           <asp:AsyncPostBackTrigger ControlID="cb_comCode"  ></asp:AsyncPostBackTrigger> 
                  <asp:AsyncPostBackTrigger ControlID="cb_depCode"></asp:AsyncPostBackTrigger> 
                 <asp:PostBackTrigger ControlID="gv_list"/>  
              <asp:PostBackTrigger ControlID="popup_Notification"  /> 
                  <%--<asp:AsyncPostBackTrigger ControlID="popup_scheduling"/> --%>
                  </Triggers>
             <ContentTemplate>
     <div class ="col-lg-12 margin-bottom"> 
         <div class="col-lg-8">
         <div class="col-lg-2 text-right pad-4">
               <dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="Chi nhánh :"></dx:ASPxLabel>
         </div>
           <div class="col-lg-3">
 <dx:ASPxComboBox ID="cb_comCode" runat="server" Theme="Material" AutoPostBack="true"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="comCode"
              TextFormatString="{0} {1} {2}"
                Width="150px" DropDownStyle="DropDown" OnSelectedIndexChanged="cb_comCode_SelectedIndexChanged"> 
         <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox>
         </div>

         <div class="col-lg-2 text-right pad-4">
             <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Phòng ban :"></dx:ASPxLabel>
         </div>
         

         <div class="col-lg-3">
             <dx:ASPxComboBox ID="cb_depCode" runat="server" Theme="Material"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="depCode"  AutoPostBack="true"
              TextFormatString="{0} {1} {2}"
                Width="150px" DropDownStyle="DropDown" TabIndex="1" OnSelectedIndexChanged="cb_depCode_SelectedIndexChanged"> 
         <Border BorderColor="#006600" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox>
         </div>
                </div>
            <div class="col-lg-4">
       
                <dx:ASPxButton ID="btn_add" runat="server" Text="Tạo mới" Theme="Material" style="float: right; margin-right: -11px;Width:140px"  CausesValidation="false" OnClick="btn_add_Click" BackColor="#3c8dbc" >
                    <Image IconID="iconbuilder_actions_add_svg_white_16x16">
                    </Image>
                </dx:ASPxButton>
                 
            </div>
         </div>


          
    <div class ="col-lg-12"> 
   
          <dx:ASPxGridView ID="gv_list" KeyFieldName="couCode" runat="server" Theme="Material" AutoGenerateColumns="False" Width="100%" EnableTheming="True" OnDataBinding="gv_list_DataBinding"> 
            <SettingsPager PageSize="15" AlwaysShowPager="True" Position="TopAndBottom">
                <PageSizeItemSettings ShowAllItem="True" Items="5, 15, 50, 100, 500" Visible="True">
                </PageSizeItemSettings>
            </SettingsPager>
            <Settings HorizontalScrollBarMode="Hidden"  />
            <SettingsSearchPanel Visible="True" />
            <SettingsText EmptyDataRow="Hiện tại chưa có data" />
            <Columns>
                  <dx:GridViewCommandColumn ShowSelectCheckbox="True" ShowClearFilterButton="true"  SelectAllCheckboxMode="Page"  VisibleIndex="0" Width="25px" >
                      <HeaderStyle BackColor="White" VerticalAlign="Middle" />
                   
                  </dx:GridViewCommandColumn>
                   <dx:GridViewDataButtonEditColumn Caption="" VisibleIndex="1"  Width="90px">
                    <DataItemTemplate> 
                                   
                                       <dx:ASPxButton ID="btn_popup_delete" runat="server" AutoPostBack="true" CssClass="fa fa-times"  style="font-size:20px; color: #ff0000; float: left; margin-right: 5px" CssPostfix="Aqua"   OnClick="btn_popup_delete_Click" ClientEnabled="true"  ToolTip="Delete Data" >
                                         <%--  <Image IconID="snap_snapdeletelist_svg_16x16">
                                           </Image>--%>
                                       </dx:ASPxButton>

                            <dx:ASPxButton ID="btn_update" runat="server" AutoPostBack="true" CssClass="fa fa-edit" style="font-size:20px; color: #0094ff; float: left" CssPostfix="Aqua" OnClick="btn_update_Click" ToolTip="Update">
                                       </dx:ASPxButton> 
                                 

                           <dx:ASPxButton ID="btn_new_time" runat="server" AutoPostBack="true" CssClass="fa fa-plus"  style="font-size:20px; color:#009688 ;float: right; " CssPostfix="Aqua"  ClientEnabled="true" ToolTip="Add New" OnClick="btn_new_time_Click"  >
                                       </dx:ASPxButton>
                                   </div>
                                    
                    </DataItemTemplate>
                </dx:GridViewDataButtonEditColumn> 
              <dx:GridViewDataTextColumn Caption="Mã khóa học" FieldName="couCode" VisibleIndex="2"  Width="60px" Settings-AllowCellMerge="True" >
                  <Settings AllowCellMerge="True" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Tên khóa học" FieldName="couName" VisibleIndex="3"  Width="200px" >
                </dx:GridViewDataTextColumn>  
                    <dx:GridViewDataDateColumn Caption="TG đào tạo" FieldName="timeEducation" VisibleIndex="4" Width="70px">
                </dx:GridViewDataDateColumn>
                  <%-- <dx:GridViewDataTextColumn Caption="Nơi sinh" FieldName="birthPlace" VisibleIndex="5"  Width="100px">
                </dx:GridViewDataTextColumn>--%>
                  <%-- <dx:GridViewDataTextColumn Caption="Giới tính" FieldName="sex" VisibleIndex="6"  Width="100px">
                </dx:GridViewDataTextColumn>--%>
                 <dx:GridViewDataTextColumn Caption="Thời gian học" FieldName="startEndTime" VisibleIndex="5"  Width="70px">
                </dx:GridViewDataTextColumn> 
                  <dx:GridViewDataTextColumn Caption="Ngày học" FieldName="dayTech" VisibleIndex="6"  Width="70px">
                </dx:GridViewDataTextColumn> 
                    <dx:GridViewDataTextColumn Caption="Địa chỉ" FieldName="prvCityName" VisibleIndex="8"  Width="150px">
                </dx:GridViewDataTextColumn>
                   <dx:GridViewDataTextColumn Caption="Hình thức" FieldName="style"  VisibleIndex="9"   Width="50px">
                </dx:GridViewDataTextColumn> 
                  <dx:GridViewDataTextColumn Caption="recID" FieldName="recID"  VisibleIndex="10" Visible="false"   Width="80px">
                </dx:GridViewDataTextColumn>  
            <dx:GridViewDataTextColumn Caption="schCodec" FieldName="schCode"  VisibleIndex="10" Visible="false"   Width="80px">
                </dx:GridViewDataTextColumn>  
             
            </Columns>
            <SettingsBehavior AllowSelectByRowClick="true" />
          <Styles>
            <AlternatingRow Enabled="true" />
          
                          <Header BackColor="#009688" ForeColor="White"  Font-Bold="True" Font-Size="14px"> 
                       
                          </Header>
                          <FocusedRow BackColor="#DCC78F">
                          </FocusedRow>
                          <HeaderPanel BackColor="#CBAB58">
                          </HeaderPanel>
                          <FilterBar BackColor="#CBAB58">
                          </FilterBar> 
          
        </Styles>
        </dx:ASPxGridView>
        <dx:ASPxGridViewExporter ID="Exporter" GridViewID="gv_list" runat="server"></dx:ASPxGridViewExporter>      

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
                                    
                                            <dx:ASPxButton ID="btn_close" runat="server" Text="HỦY BỎ"  AutoPostBack="false" style="float: left; margin-right: 0px;Width:140px" Theme="Office365" OnClick="btn_close_Click"  >
                                                <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />
                                            </dx:ASPxButton>
                 
            <dx:ASPxButton ID="btn_delete" runat="server" Text="Xóa"  AutoPostBack="true" style="float: right; margin-right: -11px;Width:140px"  Theme="Material"     CausesValidation="false" OnClick="btn_delete_Click" >
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

           </ContentTemplate>
                 </asp:UpdatePanel>
               
    
</asp:Content>
 
