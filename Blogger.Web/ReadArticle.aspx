<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ReadArticle.aspx.cs" Inherits="Blogger.Web.ReadArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="all-blog-posts">
        <div class="row">
            <div class="col-lg-12">
                <div class="blog-post">
                    <div class="blog-thumb">
                        <asp:Image ID="imgCoverImage" runat="server" />
                    </div>
                    <div class="down-content">
                        <span>
                            <asp:Label runat="server" ID="lblCategoryName"></asp:Label>
                        </span>
                        <h4>
                            <asp:Label runat="server" ID="lblTitle"></asp:Label>
                        </h4>
                        <ul class="post-info">
                            <li>
                                <asp:Label runat="server" ID="lblCreationTime"></asp:Label>
                            </li>
                        </ul>
                        <p>
                            <asp:Label runat="server" ID="lblContent"></asp:Label>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
