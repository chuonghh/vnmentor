<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="templateWebsiteAdd.aspx.cs" Inherits="admin_templateWebsiteAdd" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxHtmlEditor.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHtmlEditor" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<%@ Register Src="~/admin/UserControls/UploadedFilesContainer.ascx" TagPrefix="uc1" TagName="UploadedFilesContainer" %>

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

<%--      <script type="text/javascript">
          function onFileUploadComplete(s, e) {
              if (e.callbackData) {
                  var fileData = e.callbackData.split('|');
                  var fileName = fileData[0],
                      fileUrl = fileData[1],
                      fileSize = fileData[2];
                  DXUploadedFilesContainer.AddFile(fileName, fileUrl, fileSize);
              
              }
          }
      </script>--%>

      <script type="text/javascript">
          function load_dataView(s, e) { 
              dataView.PerformCallback();
          }
      </script>

  <script type="text/javascript">
      function ColorChangedHandler(s, e) {
          CallbackPanel.PerformCallback();
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


             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <Triggers > 
              <asp:AsyncPostBackTrigger ControlID="cb_menCode" />
               <%--<asp:AsyncPostBackTrigger ControlID="cb_menCode1" />
                    <asp:AsyncPostBackTrigger ControlID="txt_title" />--%>
          <%--     <asp:PostBackTrigger ControlID="UploadControl" />
                     <asp:PostBackTrigger ControlID="cardView" />--%>
            <asp:PostBackTrigger ControlID="popup_Notification"/>  
               <asp:PostBackTrigger ControlID="btn_submit"  ></asp:PostBackTrigger>
                  </Triggers>
             <ContentTemplate> 
                 
                 </ContentTemplate>
            </asp:UpdatePanel>

       <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_empCode" runat="server" Text="Mã giao diện :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding"  > 
   
    <dx:ASPxTextBox ID="txt_newCode" runat="server" Width="120px" Theme="Material" ReadOnly="true"   CssClass="black_14_b" TabIndex="3">
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox></div>
        </div>

                 <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Nhóm sản phẩm :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
   
    <dx:ASPxComboBox ID="cb_menCode" runat="server" Theme="Material"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="menCode"
              TextFormatString="{0} {1} {2}"
                Width="250px" DropDownStyle="DropDown" TabIndex="1" OnSelectedIndexChanged="cb_menuCode_SelectedIndexChanged" AutoPostBack="true"> 
         <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox> 

    </div>
        </div>
             <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Danh mục sản phẩm :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" >  
         <dx:ASPxComboBox ID="cb_menCode1" runat="server" Theme="Material"  EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="menCode"
              TextFormatString="{0} {1} {2}"
                Width="250px" DropDownStyle="DropDown" TabIndex="2" AutoPostBack="true"> 
         <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
        </dx:ASPxComboBox>
    </div>
        </div>
     

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="lbl_empName" runat="server" Text="Tiêu đề :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
      
    <dx:ASPxTextBox ID="txt_title" runat="server" Width="100%" Theme="Material" TabIndex="4" AutoPostBack="true">
           <ValidationSettings SetFocusOnError="True" ErrorText="Bắt buộc nhập" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
          <RequiredField IsRequired="True" ErrorText="Bắt buộc nhập" />
                   </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                 <Border BorderColor="#009688" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxTextBox>
   
        </div>

       </div> 

     <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Hình ảnh :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" >  
          <div class="col-lg-5 no-padding">
   <%--        <div class="uploadContainer">--%>
            <%--   FileUploadMode="OnPageLoad" để chạy get dữ liệu từ các textbox--%>
    <%--       <dx:ASPxUploadControl ID="UploadControl" runat="server" ClientInstanceName="UploadControl" Width="100%"
            NullText="Select multiple files..." UploadMode="Advanced" ShowUploadButton="True" ShowProgressPanel="True"
             Theme="Material"  ClientEnabled="true" OnFileUploadComplete="UploadControl_FileUploadComplete"    >
            <AdvancedModeSettings EnableMultiSelect="True" EnableFileList="True" EnableDragAndDrop="True"  />
            <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg,.jpeg,.gif,.png">
            </ValidationSettings>  
        <ClientSideEvents FileUploadComplete="load_dataView"  />
        </dx:ASPxUploadControl>--%>

       <%--    </div>--%>
<%--     <p class="note">
            <dx:ASPxLabel ID="AllowedFileExtensionsLabel" runat="server" Text="Allowed file extensions: .jpg, .jpeg, .gif, .png." Font-Size="8pt">
            </dx:ASPxLabel>
            <br />
            <dx:ASPxLabel ID="MaxFileSizeLabel" runat="server" Text="Maximum file size: 4 MB." Font-Size="8pt">
            </dx:ASPxLabel>
        </p>
           --%>

               <div class="uploadContainer">
        <dx:ASPxUploadControl ID="UploadControl" runat="server" ClientInstanceName="UploadControl" Width="100%"
            NullText="Select multiple files..." UploadMode="Advanced" ShowUploadButton="True" ShowProgressPanel="True"
            OnFileUploadComplete="UploadControl_FileUploadComplete">
            <AdvancedModeSettings EnableMultiSelect="True" EnableFileList="True" EnableDragAndDrop="True" />
            <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg,.jpeg,.gif,.png">
            </ValidationSettings>
            <ClientSideEvents FilesUploadStart="function(s, e) { DXUploadedFilesContainer.Clear(); }"
                              FileUploadComplete="onFileUploadComplete" />
        </dx:ASPxUploadControl>
        <br /><br />
        <p class="note">
            <dx:ASPxLabel ID="AllowedFileExtensionsLabel" runat="server" Text="Allowed file extensions: .jpg, .jpeg, .gif, .png." Font-Size="8pt">
            </dx:ASPxLabel>
            <br />
            <dx:ASPxLabel ID="MaxFileSizeLabel" runat="server" Text="Maximum file size: 4 MB." Font-Size="8pt">
            </dx:ASPxLabel>
        </p>
    </div>
    <div class="filesContainer">
        <dx:UploadedFilesContainer ID="FileContainer" runat="server" Width="100%" Height="180"
            NameColumnWidth="240" SizeColumnWidth="70" HeaderText="Uploaded files" />
    </div>
    <div class="contentFooter">
        <p class="Note">
            <b>Note</b>: All files uploaded to this demo will be automatically deleted in 5 minutes.
        </p>
    </div>


          </div>

             <div class="col-lg-7">  
                     <dx:ASPxDataView ID="dataView" EnableCallBacks="true" runat="server"   EnableTheming="True" Theme="Material" OnInit="dataView_Init"  > 
            
             
               <ItemTemplate>
            <table style="margin: 0 auto;">  
                <tr>
                   
                    <td>     <dx:ASPxButton ID="btn_delete" runat="server" AutoPostBack="true" CssClass="fa fa-times"  style="font-size:20px; color: #ff0000; float: left; margin-right: 5px" CssPostfix="Aqua"   OnClick="btn_delete_Click" ClientEnabled="true"  ToolTip="Remove" >
                                       </dx:ASPxButton></td>
                </tr>
                <tr>
                    <td colspan="2">

                        <dx:ASPxImage ID="ASPxImage1" runat="server" ShowLoadingImage="true"  ImageUrl='<%#Eval("photo")%>' Width="90px"  ></dx:ASPxImage>
        
                    </td>
                </tr>
               
               
            </table>
        </ItemTemplate>
        <PagerSettings ShowNumericButtons="true">
            <AllButton Visible="False" />
            <Summary Visible="false" />
            <PageSizeItemSettings Visible="true" ShowAllItem="true" />
        </PagerSettings>


           </dx:ASPxDataView>
               <%--    <dx:ASPxCardView ID="cardView" runat="server" Theme="Material" KeyFieldName ="newCode"  EnableCallbackMode="true" OnDataBinding="cardView_DataBinding">
                      <ClientSideEvents EndCallback="onEndCallback" />  
                     <SettingsExport ExportSelectedCardsOnly="False">
                     </SettingsExport>
                     <Templates>
                         <Header>
                          <dx:ASPxButton ID="btn_delete" runat="server" AutoPostBack="true" CssClass="fa fa-times"  style="font-size:20px; color: #ff0000; float: left; margin-right: 5px" CssPostfix="Aqua"   OnClick="btn_delete_Click" ClientEnabled="true"  ToolTip="Remove" >
                                       </dx:ASPxButton>
                         </Header>
                 <Card>
                  <img alt="" src='<%# Eval("photo") %>'  Width="120px"  />
              <dx:ASPxBinaryImage ID="Photo" runat="server" Value='<%# Eval("photo") %>' Width="100px" LoadingImageUrl='<%# Eval("photo") %>' Theme="Material" />
                    
                <div class="info">
                    <p><dx:ASPxLabel runat="server" Text='<%# Eval("description") %>' Width="60px" /></p> 
                    <div class="address"> 
                        <dx:ASPxLabel runat="server" Text='<%# Eval("size") %>' />
                         <dx:ASPxLabel runat="server" Text='<%# Eval("photo") %>' />
                    </div>
                </div>
            </Card>
                     </Templates>
                         
                    <Styles>
            <Card CssClass="card" />
        </Styles>
                     <StylesExport>
                         <Card BorderSides="All" BorderSize="1">
                         </Card>
                         <Group BorderSides="All" BorderSize="1">
                         </Group>
                         <TabbedGroup BorderSides="All" BorderSize="1">
                         </TabbedGroup>
                         <Tab BorderSize="1">
                         </Tab>
                     </StylesExport>
                 </dx:ASPxCardView>--%>
        
                 </div>

    </div>
        </div>

        
             <div class="col-lg-12 margin-bottom" > 
    <div class="col-lg-2 pad-top-4" > 
        <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Mô tả :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
  <dx:ASPxHtmlEditor ID="txt_description" runat="server" Theme="Material"  Width="100%" Height="600px" TabIndex="5">
      
      <SettingsDialogs>
            <InsertImageDialog ShowStyleSettingsSection="true">
                <SettingsImageSelector Enabled="True">
                    <CommonSettings RootFolder="~/admin/images/upload/" ThumbnailFolder="~/admin/images/upload"
                        InitialFolder="templateWebsite" />
                    <PermissionSettings>
                        <AccessRules>
                            <dx:FileManagerFolderAccessRule Role="" Upload="Deny" />
                            <dx:FileManagerFolderAccessRule Role="" Path="Upload" Upload="Allow" />
                        </AccessRules>
                    </PermissionSettings>
                </SettingsImageSelector>
                <SettingsImageUpload UploadFolder="~/admin/images/upload/templateWebsite/" AdvancedUploadModeTemporaryFolder="~\admin\images\upload\uploadTemp\">
                    <ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="200000">
                       <%-- 200000 byte = 200kb--%>
                    </ValidationSettings>
                </SettingsImageUpload>
                <CssClassItems>
                    <dx:InsertImageCssClassItem Text="With border" CssClass="WithBorder" />
                    <dx:InsertImageCssClassItem Text="With paddings" CssClass="WithPaddings" />
                    <dx:InsertImageCssClassItem Text="Semi-transparent" CssClass="SemiTransparent" />
                </CssClassItems>
            </InsertImageDialog>
          
        </SettingsDialogs>

         <SettingsHtmlEditing AllowIFrames="True" AllowYouTubeVideoIFrames="True">
             <PasteFiltering Attributes="class" />
      </SettingsHtmlEditing>

         <SettingsSpellChecker Culture="English (United States)">
            <Dictionaries>
                <dx:ASPxSpellCheckerISpellDictionary CacheKey="hunspellDic" Culture="English (United States)"
                    DictionaryPath="~/App_Data/Dictionaries/american.xlg" GrammarPath="~/App_Data/Dictionaries/english.aff" />
            </Dictionaries>
        </SettingsSpellChecker>

        <Toolbars>
            <dx:HtmlEditorToolbar Name="StandardToolbar1">
                <Items>
                    <dx:ToolbarCutButton AdaptivePriority="2">
                    </dx:ToolbarCutButton>
                    <dx:ToolbarCopyButton AdaptivePriority="2">
                    </dx:ToolbarCopyButton>
                    <dx:ToolbarPasteButton AdaptivePriority="2">
                    </dx:ToolbarPasteButton>
                    <dx:ToolbarPasteFromWordButton AdaptivePriority="2">
                    </dx:ToolbarPasteFromWordButton>
                    <dx:ToolbarUndoButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton AdaptivePriority="1">
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarRemoveFormatButton AdaptivePriority="2" BeginGroup="True">
                    </dx:ToolbarRemoveFormatButton>
                    <dx:ToolbarSuperscriptButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarSuperscriptButton>
                    <dx:ToolbarSubscriptButton AdaptivePriority="1">
                    </dx:ToolbarSubscriptButton>
                    <dx:ToolbarInsertOrderedListButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarInsertOrderedListButton>
                    <dx:ToolbarInsertUnorderedListButton AdaptivePriority="1">
                    </dx:ToolbarInsertUnorderedListButton>
                    <dx:ToolbarIndentButton AdaptivePriority="2" BeginGroup="True">
                    </dx:ToolbarIndentButton>
                    <dx:ToolbarOutdentButton AdaptivePriority="2">
                    </dx:ToolbarOutdentButton>
                    <dx:ToolbarInsertLinkDialogButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarInsertLinkDialogButton>
                    <dx:ToolbarUnlinkButton AdaptivePriority="1">
                    </dx:ToolbarUnlinkButton>
                    <dx:ToolbarInsertImageDialogButton AdaptivePriority="1">
                    </dx:ToolbarInsertImageDialogButton>
                    <dx:ToolbarInsertYouTubeVideoDialogButton>
                    </dx:ToolbarInsertYouTubeVideoDialogButton>
                    <dx:ToolbarTableOperationsDropDownButton AdaptivePriority="2" BeginGroup="True">
                        <Items>
                            <dx:ToolbarInsertTableDialogButton BeginGroup="True" Text="Insert Table..." ToolTip="Insert Table...">
                            </dx:ToolbarInsertTableDialogButton>
                            <dx:ToolbarTablePropertiesDialogButton BeginGroup="True">
                            </dx:ToolbarTablePropertiesDialogButton>
                            <dx:ToolbarTableRowPropertiesDialogButton>
                            </dx:ToolbarTableRowPropertiesDialogButton>
                            <dx:ToolbarTableColumnPropertiesDialogButton>
                            </dx:ToolbarTableColumnPropertiesDialogButton>
                            <dx:ToolbarTableCellPropertiesDialogButton>
                            </dx:ToolbarTableCellPropertiesDialogButton>
                            <dx:ToolbarInsertTableRowAboveButton BeginGroup="True">
                            </dx:ToolbarInsertTableRowAboveButton>
                            <dx:ToolbarInsertTableRowBelowButton>
                            </dx:ToolbarInsertTableRowBelowButton>
                            <dx:ToolbarInsertTableColumnToLeftButton>
                            </dx:ToolbarInsertTableColumnToLeftButton>
                            <dx:ToolbarInsertTableColumnToRightButton>
                            </dx:ToolbarInsertTableColumnToRightButton>
                            <dx:ToolbarSplitTableCellHorizontallyButton BeginGroup="True">
                            </dx:ToolbarSplitTableCellHorizontallyButton>
                            <dx:ToolbarSplitTableCellVerticallyButton>
                            </dx:ToolbarSplitTableCellVerticallyButton>
                            <dx:ToolbarMergeTableCellRightButton>
                            </dx:ToolbarMergeTableCellRightButton>
                            <dx:ToolbarMergeTableCellDownButton>
                            </dx:ToolbarMergeTableCellDownButton>
                            <dx:ToolbarDeleteTableButton BeginGroup="True">
                            </dx:ToolbarDeleteTableButton>
                            <dx:ToolbarDeleteTableRowButton>
                            </dx:ToolbarDeleteTableRowButton>
                            <dx:ToolbarDeleteTableColumnButton>
                            </dx:ToolbarDeleteTableColumnButton>
                        </Items>
                    </dx:ToolbarTableOperationsDropDownButton>
                    <dx:ToolbarFindAndReplaceDialogButton AdaptivePriority="2" BeginGroup="True">
                    </dx:ToolbarFindAndReplaceDialogButton>
                    <dx:ToolbarFullscreenButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarFullscreenButton>
                    
                </Items>
            </dx:HtmlEditorToolbar>
            <dx:HtmlEditorToolbar Name="StandardToolbar2">
                <Items>
                    <dx:ToolbarParagraphFormattingEdit AdaptivePriority="2" Width="120px">
                        <Items>
                            <dx:ToolbarListEditItem Text="Normal" Value="p" />
                            <dx:ToolbarListEditItem Text="Heading  1" Value="h1" />
                            <dx:ToolbarListEditItem Text="Heading  2" Value="h2" />
                            <dx:ToolbarListEditItem Text="Heading  3" Value="h3" />
                            <dx:ToolbarListEditItem Text="Heading  4" Value="h4" />
                            <dx:ToolbarListEditItem Text="Heading  5" Value="h5" />
                            <dx:ToolbarListEditItem Text="Heading  6" Value="h6" />
                            <dx:ToolbarListEditItem Text="Address" Value="address" />
                            <dx:ToolbarListEditItem Text="Normal (DIV)" Value="div" />
                        </Items>
                    </dx:ToolbarParagraphFormattingEdit>
                    <dx:ToolbarFontNameEdit AdaptivePriority="2">
                        <Items>
                            <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                            <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                            <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                            <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                            <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                            <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                            <dx:ToolbarListEditItem Text="Segoe UI" Value="Segoe UI" />
                        </Items>
                    </dx:ToolbarFontNameEdit>
                    <dx:ToolbarFontSizeEdit AdaptivePriority="2">
                        <Items>
                            <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                            <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                            <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                            <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                            <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                            <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                            <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                        </Items>
                    </dx:ToolbarFontSizeEdit>
                    <dx:ToolbarBoldButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarBoldButton>
                    <dx:ToolbarItalicButton AdaptivePriority="1">
                    </dx:ToolbarItalicButton>
                    <dx:ToolbarUnderlineButton AdaptivePriority="1">
                    </dx:ToolbarUnderlineButton>
                    <dx:ToolbarStrikethroughButton AdaptivePriority="1">
                    </dx:ToolbarStrikethroughButton>
                    <dx:ToolbarJustifyLeftButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarJustifyLeftButton>
                    <dx:ToolbarJustifyCenterButton AdaptivePriority="1">
                    </dx:ToolbarJustifyCenterButton>
                    <dx:ToolbarJustifyRightButton AdaptivePriority="1">
                    </dx:ToolbarJustifyRightButton>
                    <dx:ToolbarBackColorButton AdaptivePriority="1" BeginGroup="True">
                    </dx:ToolbarBackColorButton>
                    <dx:ToolbarFontColorButton AdaptivePriority="1">
                    </dx:ToolbarFontColorButton>
                </Items>
            </dx:HtmlEditorToolbar>
      </Toolbars>

        <CssFiles>
            <dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/CustomCss.css"></dx:HtmlEditorCssFile>
        </CssFiles>  

  </dx:ASPxHtmlEditor>
           </div>
        </div>    
                  

      <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Tags :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
        <dx:BootstrapTagBox runat="server" ID="txt_tags" AllowCustomTags="true" Width="100%" TabIndex="9">
        </dx:BootstrapTagBox>

    </div>
   </div>

    <div class="col-lg-12 margin-bottom" > 
      <div class="col-lg-2 pad-top-4" > <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="SEO description (100 -165 ký tự) :"></dx:ASPxLabel></div> 
    <div class="col-lg-10 no-padding" > 
        <dx:BootstrapTagBox runat="server" ID="BootstrapTagBox1" AllowCustomTags="true" Width="100%" TabIndex="9">
        </dx:BootstrapTagBox>

    </div>
   </div>

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
          </dx:ASPxButton>                
                               
    </div>
         </div>

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

    
     
</asp:Content>
