<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_delivery_issues.aspx.cs" Inherits="WebApplication27.admin_delivery_issues" %>

<%@ Register Src="adminbar.ascx" TagPrefix="uc" TagName="UserBar" %>

<!DOCTYPE html>
<html>
<head>
    <title>Delivery Issues - Admin Panel</title>
    <style>
        body {
            font-family: 'Segoe UI', sans-serif;
            background-color: #f4f6f8;
            margin: 0;
            padding: 0;
        }
        .container {
            margin: 50px auto;
            max-width: 800px;
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.1);
        }
        h2 {
            text-align: center;
            color: #1e293b;
            margin-bottom: 30px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            font-size: 14px;
        }
        th, td {
            padding: 12px;
            border-bottom: 1px solid #ddd;
            text-align: left;
        }
        th {
            background-color: #1e293b;
            color: white;
        }
        tr:hover {
            background-color: #f1f5f9;
        }
    </style>
</head>
<body>
    <uc:UserBar runat="server" />
    <form id="form1" runat="server">
        <div class="container">
            <h2>All Reported Delivery Issues</h2>
            <asp:GridView ID="gridIssues" runat="server" AutoGenerateColumns="False" CssClass="table">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="User" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="trackcode" HeaderText="TrackingCode" />
                    <asp:BoundField DataField="issue_type" HeaderText="IssueType" />
                    <asp:BoundField DataField="Decription" HeaderText="Description" />
                    <asp:BoundField DataField="date" HeaderText="Date" DataFormatString="{0:dd/MM/yyyy HH:mm}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>