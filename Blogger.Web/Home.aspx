<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Blogger.Web.Home1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="all-blog-posts">
        <div class="row">
            <asp:Repeater ID="rptArticles" runat="server">
                <ItemTemplate>
                    <div class="col-lg-12">
                        <div class="blog-post">
                            <div class="blog-thumb">
                                <img src='Uploads/<%#Eval("CoverImage") %>' alt="">
                            </div>
                            <div class="down-content">
                                <span><%#Eval("CategoryName") %></span>
                                <a href='/ReadArticle.aspx?id=<%#Eval("Id")%>'>
                                    <h4><%#Eval("Title") %></h4>
                                </a>
                                <ul class="post-info">
                                    <li><%#Eval("CreationTime") %></li>
                                </ul>
                                <p><%#Eval("Summary") %></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
