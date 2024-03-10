<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="companyList.aspx.cs" Inherits="admin_companyList" %>

<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server"> 

    <div class ="col-lg-12"> 
   
          <dx:ASPxGridView ID="gv_list" KeyFieldName="comCode" runat="server" Theme="Material" AutoGenerateColumns="False" Width="100%" EnableTheming="True"  >
               
            <SettingsPager PageSize="15" AlwaysShowPager="True" Position="TopAndBottom">
                <PageSizeItemSettings ShowAllItem="True">
                </PageSizeItemSettings>
            </SettingsPager>
            <Settings HorizontalScrollBarMode="Hidden"  />
            <SettingsSearchPanel Visible="True" />
            <SettingsText EmptyDataRow="Hiện tại chưa có data" />
            <Columns>
              <dx:GridViewDataTextColumn Caption="Mã công ty" FieldName="comCode" VisibleIndex="1"  Width="80px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Tên công ty" FieldName="comName" VisibleIndex="2"  Width="500px">
                </dx:GridViewDataTextColumn> 
                  <dx:GridViewDataTextColumn Caption="Địa chỉ" FieldName="comAddress" VisibleIndex="3"  Width="100px">
                </dx:GridViewDataTextColumn>

                   <dx:GridViewDataTextColumn Caption="Điện thoại" FieldName="comTel" VisibleIndex="4"  Width="100px">
                </dx:GridViewDataTextColumn>
                   <dx:GridViewDataTextColumn Caption="Mail" FieldName="comEmail" VisibleIndex="5"  Width="100px">
                </dx:GridViewDataTextColumn>
                   
                <dx:GridViewDataButtonEditColumn Caption="Edit" VisibleIndex="0"  Width="50px">
                    <DataItemTemplate>
                        <dx:ASPxButton ID="btn_update" runat="server" Text="Cập nhật" OnClick="btn_update_Click">
                        </dx:ASPxButton>
                    </DataItemTemplate>
                </dx:GridViewDataButtonEditColumn>
                   
            </Columns>
          <Styles>
            <AlternatingRow Enabled="true" />
        </Styles>
        </dx:ASPxGridView>
        <dx:ASPxGridViewExporter ID="Exporter" GridViewID="gv_forecast" runat="server"></dx:ASPxGridViewExporter>      

    </div>
</asp:Content>

