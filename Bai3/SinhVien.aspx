<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SinhVien.aspx.cs" Inherits="SinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Xml ID="Xml1" runat="server" DocumentSource="~/xml/SinhVien.xml" TransformSource="~/xslt/Cau2.xslt"></asp:Xml>
        </div>
        <asp:Xml ID="Xml2" runat="server" DocumentSource="~/xml/SinhVien.xml" TransformSource="~/xslt/Cau3.xslt"></asp:Xml>
        <asp:Xml ID="Xml3" runat="server" DocumentSource="~/xml/SinhVien.xml" TransformSource="~/xslt/Cau4.xslt"></asp:Xml>
    </form>
</body>
</html>
