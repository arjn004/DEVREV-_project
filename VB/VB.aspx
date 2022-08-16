<%@ Page Language="VB" AutoEventWireup="false" CodeFile="VB.aspx.vb" Inherits="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .Grid td
        {
            background-color: #A1DCF2;
            color: black;
            font-size: 10pt;
            line-height: 200%;
            font-family: Arial;
            font-size: 10pt;
        }
        .Grid th
        {
            background-color: #3AC0F2;
            color: White;
            font-size: 10pt;
            line-height: 200%;
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="gvCustomers" CssClass="Grid" runat="server" AutoGenerateColumns="false"
        PageSize="10" AllowPaging="true" DataSourceID="dsCustomers">
        <Columns>
            <asp:BoundField DataField="CustomerId" HeaderText="Customer Id" />
            <asp:BoundField DataField="ContactName" HeaderText="Contact Name" />
            <asp:BoundField DataField="City" HeaderText="City" />
            <asp:BoundField DataField="Country" HeaderText="Country" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="dsCustomers" runat="server" EnablePaging="true" SelectMethod="GetCustomers"
        SelectCountMethod="GetCustomersCount" TypeName="CustomerDS" MaximumRowsParameterName="maxRows"
        StartRowIndexParameterName="startIndex"></asp:ObjectDataSource>
    </form>
</body>
</html>
