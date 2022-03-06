<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/_Admin.Master" AutoEventWireup="true" CodeBehind="CreateCategory.aspx.cs" Inherits="Blogger.Web.Admin.CreateCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card has-table">
        <header class="card-header">
            <p class="card-header-title">
                <span class="icon"><i class="mdi mdi-account-multiple"></i></span>
                Kategori Oluştur
            </p>
        </header>
        <div class="card-content">
            <div class="field" style="width: 250px; padding: 30px">
                <div class="field-body">
                    <asp:HiddenField ID="hdnId" runat="server" />
                    <div class="field">
                        <label>Kategori Adı:</label>
                        <asp:TextBox runat="server" ID="txtName" CssClass="input" />
                    </div>
                    <div class="field">
                        <asp:CheckBox Text=" Aktif" runat="server"
                            ID="chkIsActive" Checked="true" AutoPostBack="true" OnCheckedChanged="chkIsActive_CheckedChanged" />
                    </div>
                    <div class="field">
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" OnClick="btnSave_Click" CssClass="button green" />
                    </div>
                    <asp:Panel runat="server" ID="pnlSuccess" Visible="false">
                        <div class="field" style="background-color: rgba(16,185,129,var(--tw-bg-opacity)); padding: 5px; font-size: large; color: white; text-align: center">
                            İşlem başarılı.  
                        </div>
                    </asp:Panel>
                    <asp:Panel runat="server" ID="pnlError" Visible="false">
                        <div class="field" style="background-color: #DC2626; padding: 5px; font-size: large; color: white; text-align: center">
                            <asp:Label Text="text" ID="lblError" runat="server" />
                        </div>
                    </asp:Panel>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
