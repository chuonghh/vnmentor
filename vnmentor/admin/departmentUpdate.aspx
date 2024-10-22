﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="departmentUpdate.aspx.cs" Inherits="admin_departmentUpdate" %>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 
    <div class="col-lg-12" > 
      <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Tên Công Ty"></dx:ASPxLabel></div> 
    <div class="col-lg-7" >  
    
        <dx:ASPxComboBox ID="cb_comCode" runat="server" ValueType="System.String" Width="300px"  Theme="Material"></dx:ASPxComboBox>

    </div>
        </div>

    <div class="col-lg-12" > 
      <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Mã bộ phận" ></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_depCode" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
   </div>

    <div class="col-lg-12" > 
    <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Tên bộ phận"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_depName" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
        </div>
 

    <div class="col-lg-12" > 
    <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Thuộc bộ phận" ></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
     
      <dx:ASPxComboBox ID="cb_depentsID" runat="server" ValueType="System.String" Width="300px"  Theme="Material"></dx:ASPxComboBox>
    </div> 

        </div>

    <div class="col-lg-12" > 
    <div class="col-lg-4" > <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Mô tả"></dx:ASPxLabel></div> 
    <div class="col-lg-7" > 
    <dx:ASPxTextBox ID="txt_depDescription" runat="server" Width="300px" Theme="Material"></dx:ASPxTextBox></div>
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

