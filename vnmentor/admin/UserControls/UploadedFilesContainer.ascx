﻿<%@ Control Language="C#" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<script runat="server">
    
    public Unit Width { get; set; }
    public Unit Height { get; set; }
    public Unit NameColumnWidth { get; set; }
    public Unit SizeColumnWidth { get; set; }
    public Unit ThumbColumnWidth { get; set; }
    public string HeaderText { get; set; }
    public bool UseExtendedPopup { get; set; }
    protected void Page_Load(object sender, EventArgs e) {
        FilesRoundPanel.Width = Width;
        FilesRoundPanel.Height = Height;
        FilesRoundPanel.HeaderText = HeaderText;
    }
    protected string GetOptionsString() {
        return "'" + GetStyleAttributeValue(NameColumnWidth) + "', '" 
            + GetStyleAttributeValue(SizeColumnWidth) + "', '"
            + GetStyleAttributeValue(ThumbColumnWidth) +"', "
            + UseExtendedPopup.ToString().ToLower();
    }
    protected string GetStyleAttributeValue(Unit width) {
        return !width.IsEmpty ? string.Format("width: {0}; max-width: {0}", width.ToString()) : string.Empty;
    }
 </script>
<script type="text/javascript">
    DXUploadedFilesContainer.ApplySettings(<%= GetOptionsString() %>);
</script>
<dx:ASPxRoundPanel ID="FilesRoundPanel" ClientInstanceName="FilesRoundPanel" runat="server" CssClass="uploadFilesContainerPanel">
    <PanelCollection>
        <dx:PanelContent runat="server">
            <table id="uploadedFilesContainer" class="uploadedFilesContainer">
                <tbody></tbody>
            </table>
        </dx:PanelContent>
       
    </PanelCollection>
</dx:ASPxRoundPanel>
