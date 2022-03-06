<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/_Admin.Master" AutoEventWireup="true"
    CodeBehind="CreateArticle.aspx.cs" Inherits="Blogger.Web.Admin.CreateArticle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card has-table">
        <header class="card-header">
            <p class="card-header-title">
                <span class="icon"><i class="mdi mdi-account-multiple"></i></span>
                Makale Oluştur
            </p>
        </header>
        <div class="card-content">
            <div class="field" style="width: 100%; padding: 30px">
                <div class="field-body">
                    <asp:HiddenField ID="hdnId" runat="server" />
                    <div class="field">
                        <label class="label">Kategori</label>
                        <div class="control">
                            <div class="select">
                                <asp:DropDownList ID="drpCategories" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="field">
                        <label class="label">Başlık</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="input"></asp:TextBox>
                    </div>
                    <div class="field">
                        <label class="label">İçerik</label>
                        <asp:TextBox ID="txtContent" runat="server" CssClass="textarea" TextMode="MultiLine" Rows="20"></asp:TextBox>
                    </div>
                    <div class="field">
                        <label class="label">Özet</label>
                        <asp:TextBox ID="txtSummary" runat="server" CssClass="textarea" TextMode="MultiLine" Rows="20"></asp:TextBox>
                    </div>
                    <div class="field">
                        <label class="label">Kapak Resmi</label>
                        <asp:Image ID="imgCoverImage" runat="server" Visible="false" />
                        <asp:FileUpload ID="flCoverImage" runat="server" />
                    </div>
                    <div class="field">
                        <label class="label">Aktif Durumu</label>
                        <asp:CheckBox ID="chkIsActive" runat="server" />
                    </div>
                    <div class="field">
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="button green" OnClick="btnSave_Click" />
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
    <script src="Content/ckeditor/ckeditor.js"></script>
    <script>
        CKEDITOR.replace('ContentPlaceHolder1_txtContent')
        CKEDITOR.replace('ContentPlaceHolder1_txtSummary')
    </script>
</asp:Content>

