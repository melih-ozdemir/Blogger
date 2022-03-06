<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/_Admin.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Blogger.Web.Admin.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card has-table">
        <header class="card-header">
            <p class="card-header-title">
                <span class="icon"><i class="mdi mdi-account-multiple"></i></span>
                Kategori Listesi
            </p>
        </header>
        <div class="card-content">
            <table>
                <thead>
                    <tr>
                        <th>Kategori Adı</th>
                        <th>Aktif</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptCategories" runat="server" OnItemCommand="rptCategories_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("Name")%></td>
                                <td><%#Eval("IsActive")%></td>
                                <td class="actions-cell">
                                    <div class="buttons right nowrap">
                                        <a class="button small green" href='/Admin/CreateCategory.aspx?id=<%#Eval("Id")%>'>
                                            <span class="icon"><i class="mdi mdi-eye"></i></span>
                                        </a>
                                        <asp:LinkButton CommandName="Delete" CommandArgument='<%#Eval("Id")%>' ID="lnkDelete" runat="server" CssClass="button small red">
                                            <span class="icon"><i class="mdi mdi-trash-can"></i></span>
                                        </asp:LinkButton>
                                    </div>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
