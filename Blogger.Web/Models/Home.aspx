<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Blogger.Web.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 400px; margin: auto; background-color:aquamarine; float:left">
            <div>
                <asp:Label Text="Adınız:" runat="server" />
                <asp:TextBox runat="server" ID="txtAd" />
            </div>
            <div>
                <asp:Label Text="Soyadınız:" runat="server" />
                <asp:TextBox runat="server" ID="txtSoyad" />
            </div>
            <div>
                <%--<asp:Label Text="Doğum Tarihiniz:" runat="server" />--%>
                <label>Doğum Tarihiniz:</label>
                <%--<asp:Calendar runat="server" ID="calDogumTarihi"></asp:Calendar>--%>
                <asp:TextBox runat="server" ID="txtDogumTarihi" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <label>Cinsiyet</label>
                <asp:RadioButtonList ID="rdCinsiyet" runat="server">
                    <asp:ListItem Text="Kadın" Value="K" />
                    <asp:ListItem Text="Erkek" Value="E" />
                </asp:RadioButtonList>
            </div>
            <div>
                <asp:Label Text="Adres:" runat="server" />
                <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine" Rows="8"></asp:TextBox>
            </div>
            <div>
                <asp:CheckBox runat="server" ID="chkOkudum" />
                <asp:Label Text="Okudum,Onaylıyorum" runat="server" />
            </div>
            <div>
                <asp:Button runat="server" ID="btnKaydet" Text="Kaydet" OnClick="btnKaydet_Click" />
            </div>
        </div>
        <div style="width: 300px; background-color: antiquewhite; float:left">
            <asp:Panel runat="server" ID="pnlResult" Visible="false">
                <div>
                    <asp:Label runat="server" ID="lblAdSoyad" Text="Ad bilgisi"></asp:Label>
                </div>
                <div>
                    <asp:Label runat="server" ID="lblDogumTarihi" />
                </div>
                <div>
                    <asp:Label runat="server" ID="lblCinsiyet" />
                </div>
                <div>
                    <asp:Label runat="server" ID="lblAdres" />
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
