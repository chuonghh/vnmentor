<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="employeesImport.aspx.cs" Inherits="admin_employeesImport" %>

<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
 

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <script type="text/javascript">
         function load_grid(s, e) {
             gridView.PerformCallback();
         }
     </script> 
     
       <div class ="col-lg-12 margin-bottom"> 
         <div class="col-lg-6 no-padding">
             <dx:ASPxUploadControl ID="Upload" runat="server" ShowUploadButton="True" OnFileUploadComplete="Upload_FileUploadComplete" Theme="Material" Width="100%">
                <ValidationSettings AllowedFileExtensions=".xls,.xlsx">
                </ValidationSettings>
                <ClientSideEvents FileUploadComplete="load_grid" />
            </dx:ASPxUploadControl>
       <p class="note">
            <dx:ASPxLabel ID="AllowedFileExtensionsLabel" runat="server" Text="Allowed file extensions: .xlsx, .xls" Font-Size="8pt">
            </dx:ASPxLabel>
           <br /> 
            <dx:ASPxLabel ID="MaxFileSizeLabel" runat="server" Text="Nếu bạn chưa có mẫu thì click vào đây để tải về " Font-Size="8pt">
            </dx:ASPxLabel>
          <a href="dataFile\templateImport\employeesImport.xlsx" style="Font-Size:8pt">Template Import Employees</a>

         </p>
                </div>
             <div class="col-lg-2 no-padding">
                     <dx:ASPxButton ID="btn_submit"  runat="server" Text=" &nbsp; &nbsp;Lưu &nbsp; &nbsp;"  Width="140px" Theme="Material" OnClick="btn_submit_Click" TabIndex="1"  style="float: right; margin-right: -11px;Width:140px" >
                                <Image IconID="save_save_svg_white_16x16">
                    </Image>
                          </dx:ASPxButton>
                 </div>

            <div class="col-lg-4">
            
                <dx:ASPxButton ID="btn_add" runat="server" Text="Tạo mới" Theme="Material" style="float: right; margin-right: -11px;Width:140px"  CausesValidation="false" OnClick="btn_add_Click" BackColor="#3c8dbc" >
                    <Image IconID="iconbuilder_actions_add_svg_white_16x16">
                    </Image>
                </dx:ASPxButton>
                 
            </div>
         </div> 
           

       <div class ="col-lg-12"> 

               <dx:ASPxGridView ID="gridView" ClientInstanceName="gridView" runat="server" OnInit="gridView_Init" Theme="Material" Width="100%" >
                        <Settings HorizontalScrollBarMode="Auto"  />
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
                                    
                                            <dx:ASPxButton ID="btn_close" runat="server" Text="ĐÓNG" AutoPostBack="false" style="float: right; margin-right: -11px; Width:140px" OnClick="btn_close_Click" Theme="Office365"  >
                                                <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" />
                                            </dx:ASPxButton>
                 
          <%--  <dx:ASPxButton ID="btn_save" runat="server" Text="LƯU"  AutoPostBack="true" style="float: right; margin-right: -11px; Width:140px"   Theme="Material"  CssClass="button_gold" OnClick="btn_save_Click" CausesValidation="false" >
                                        <ClientSideEvents Click="function(s, e) { popup_Notification.Hide(); }" /> 
                                            </dx:ASPxButton>--%>
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

