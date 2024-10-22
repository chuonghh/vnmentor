﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="companyUpdate.aspx.cs" Inherits="admin_companyUpdate" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="col-lg-12" > 
     <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Mã Công Ty"></dx:ASPxLabel></div> 
    <div class="col-lg-7" >
    <dx:ASPxTextBox ID="txt_comCode" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div> </div>

    <div class="col-lg-12" > 
      <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Tên Công Ty"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_comName" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12" > 
      <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Địa chỉ"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_comAddress" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
   </div>

    <div class="col-lg-12" > 
    <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Số điện thoại"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_comTel" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12" > 
     <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Mail công ty"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_comEmail" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12" > 
    <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Mã số thuế"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <%--<dx:ASPxTextBox ID="txt_comTax" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox>--%>
   <dx:ASPxTextBox ID="txt_comTax" runat="server"  Width="300px"  Theme="Material"  CssClass="black_18_b" AutoPostBack="false"  >
                 <MaskSettings Mask="0000000000" />
                          <ValidationSettings SetFocusOnError="True" ErrorText="Phone is required" Display="Dynamic" ErrorTextPosition="right" ErrorDisplayMode="ImageWithTooltip">
                        <RequiredField IsRequired="True" ErrorText="" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="onNameValidation" />
                     <InvalidStyle BackColor="#FFD2D9" />
                  <Border BorderColor="#CBAB58" BorderStyle="Solid" BorderWidth="1px" />
             </dx:ASPxTextBox>

    </div> 

        </div>

    <div class="col-lg-12" > 
    <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Mô tả"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_comDescription" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
        </div>

    <div class="col-lg-12" > 
     <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Active" ></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    
        <dx:ASPxCheckBox ID="chk_active" runat="server" Theme="Material"></dx:ASPxCheckBox>
    </div>
        </div>

        <div class="col-lg-12" > 
      <div class="col-lg-4" >  </div> 
    <div class="col-lg-7" > 
        <dx:ASPxButton ID="btn_save" runat="server" Text="Lưu"  Theme="Material" OnClick="btn_save_Click" ></dx:ASPxButton>
    </div>
         </div>
</asp:Content>

