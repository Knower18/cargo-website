<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication27.admin" %>
<%@ Register Src="adminbar.ascx" TagPrefix="uc" TagName="UserBar" %>

<%--<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin Panel - Cargo Management</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f6f8;
            display: flex;
        }
        .main-content {
            margin-left: 250px;
            padding: 20px;
            width: 100%;
        }
        .header {
            background-color: #374a6d;
            color: white;
            padding: 15px 20px;
            margin-bottom: 20px;
        }
        .table-container {
            background-color: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        table th, table td {
            padding: 10px;
            text-align: center;
            border: 1px solid #ddd;
        }
        .status-select {
            padding: 6px;
        }
        .progress-bar {
            width: 100%;
            height: 10px;
            background-color: #ddd;
            border-radius: 5px;
            overflow: hidden;
        }
        .progress-fill {
            height: 100%;
            width: 0%;
            background-color: #ff9800;
            transition: width 0.3s ease, background-color 0.3s ease;
        }
        img {
            max-width: 80px;
            max-height: 60px;
        }
    </style>
    <script>
        function updateShipmentStatus(selectElement, progressId) {
            const status = selectElement.value;
            const fill = document.getElementById("fill_" + progressId.split("_")[1]);
            if (!fill) return;
            switch (status) {
                case "In Office":
                    fill.style.width = "25%";
                    fill.style.backgroundColor = "#ff9800";
                    break;
                case "in-transit":
                    fill.style.width = "50%";
                    fill.style.backgroundColor = "#2196F3";
                    break;
                case "out-for-delivery":
                    fill.style.width = "75%";
                    fill.style.backgroundColor = "#FFC107";
                    break;
                case "delivered":
                    fill.style.width = "100%";
                    fill.style.backgroundColor = "#4CAF50";
                    break;
                default:
                    fill.style.width = "0%";
                    fill.style.backgroundColor = "#ddd";
            }
        }
        window.addEventListener('load', function () {
            const allSelects = document.querySelectorAll('.status-select');
            allSelects.forEach(select => {
                const id = select.name.replace('ddlStatus_', '');
                const fill = document.getElementById("fill_" + id);
                updateShipmentStatus(select, "progress_" + id);
            });
        });
    </script>
</head>
<body>
    <uc:UserBar runat="server" />
    <form id="form1" runat="server">
        <div class="main-content">
            <div class="header">
                <h1>Admin Dashboard - Shipment Management</h1>
            </div>
            <div class="table-container">
                <asp:Repeater ID="rptShipments" runat="server" OnItemCommand="rptShipments_ItemCommand">
                    <HeaderTemplate>
                        <table>
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>User ID</th>
                                    <th>booked date</th>
                                    <th>Sender</th>
                                    <th>Sender State</th>
                                    <th>Receiver</th>
                                    <th>Rechiver State</th>
                                    <th>Company</th>
                                    <th>Logo</th>
                                    <th>Price</th>
                                  
                                    <th>order image</th>
                                      <th>Category</th>
                                    <th>Status</th>
                                    <th>Progress</th>
                                    <th>Update</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ShipmentID") %></td>
                             <td><%# Eval("UserID") %></td>
                          <td><%# Eval("CreatedAt", "{0:yyyy-MM-dd HH:mm}") %></td>


                            <td><%# Eval("Sender.FullName") %></td>
                             <td><%# Eval("Sender.state") %></td>
                            <td><%# Eval("Receiver.FullName") %></td>
                             <td><%# Eval("Receiver.state") %></td>

                            <td><%# Eval("cargocompany.company_name") %></td>
                            <td>
                                <%# Eval("logo_company") != DBNull.Value ? "<img src='data:image/png;base64," + Convert.ToBase64String((byte[])Eval("logo_company")) + "' />" : "" %>
                            </td>
                             <td><%# Eval("price") %></td>
                            <td>
                                  <%# Eval("lcatigory_image") != DBNull.Value ? "<img src='data:image/png;base64," + Convert.ToBase64String((byte[])Eval("lcatigory_image")) + "' />" : "" %>
                            </td>

                            <td><%# Eval("Category") %></td>
                            <td>
                                <select id="ddlStatus_<%# Eval("ShipmentID") %>" name="ddlStatus_<%# Eval("ShipmentID") %>" class="status-select"
                                        onchange="updateShipmentStatus(this, 'progress_<%# Eval("ShipmentID") %>')">
                                    <option value="in-office" <%# Eval("Status").ToString() == "In Office" ? "selected" : "" %>>In Office</option>
                                    <option value="in-transit" <%# Eval("Status").ToString() == "in-transit" ? "selected" : "" %>>In Transit</option>
                                    <option value="out-for-delivery" <%# Eval("Status").ToString() == "out-for-delivery" ? "selected" : "" %>>Out for Delivery</option>
                                    <option value="delivered" <%# Eval("Status").ToString() == "delivered" ? "selected" : "" %>>Delivered</option>
                                </select>
                            </td>
                            <td>
                                <div id='progress_<%# Eval("ShipmentID") %>' class='progress-bar'>
                                    <div class='progress-fill' id='fill_<%# Eval("ShipmentID") %>'></div>
                                </div>
                            </td>
                            <td>
                                <asp:Button ID="btnUpdateStatus" runat="server"
                                    Text="Update"
                                    CommandName="UpdateStatus"
                                    CommandArgument='<%# Eval("ShipmentID ") %>' />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                            </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>--%>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin Panel - Cargo Management</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f6f8;
            display: flex;
        }
        .main-content {
            margin-left: 250px;
            padding: 20px;
            width: 100%;
        }
        .header {
            background-color: #374a6d;
            color: white;
            padding: 15px 20px;
            margin-bottom: 20px;
        }
        .table-container {
            background-color: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        table th, table td {
            padding: 10px;
            text-align: center;
            border: 1px solid #ddd;
        }
        .edit-btn {
            background-color: #1976d2;
            color: white;
            padding: 6px 12px;
            border: none;
            border-radius: 4px;
            margin-right: 5px;
            cursor: pointer;
        }
        .delete-btn {
            background-color: #e53935;
            color: white;
            padding: 6px 12px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .logo-img {
            max-width: 60px;
            max-height: 50px;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <uc:UserBar runat="server" />
    <form id="form1" runat="server">
        <div class="main-content">
            <div class="header">
                <h1>Admin Dashboard - Shipment Management</h1>
            </div>
            <div class="table-container">
                <asp:Repeater ID="rptShipments" runat="server" OnItemCommand="rptShipments_ItemCommand">
                    <HeaderTemplate>
                        <table>
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>User ID</th>
                                    <th>Booked Date</th>
                                    <th>Sender</th>
                                    <th>Sender State</th>
                                    <th>Receiver</th>
                                    <th>Receiver State</th>
                                    <th>Company</th>
                                    <th>Logo</th>
                                    <th>Price</th>
                                    <th>Order Image</th>
                                    <th>Category</th>
                                    <th>Status</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ShipmentID") %></td>
                            <td><%# Eval("UserID") %></td>
                            <td><%# Eval("CreatedAt", "{0:yyyy-MM-dd HH:mm}") %></td>
                            <td><%# Eval("Sender.FullName") %></td>
                            <td><%# Eval("Sender.state") %></td>
                            <td><%# Eval("Receiver.FullName") %></td>
                            <td><%# Eval("Receiver.state") %></td>
                            <td><%# Eval("cargocompany.company_name") %></td>
                            <td>
                                <%# Eval("logo_company") != DBNull.Value ? "<img src='data:image/png;base64," + Convert.ToBase64String((byte[])Eval("logo_company")) + "' class='logo-img' />" : "" %>
                            </td>
                            <td><%# Eval("price") %></td>
                            <td>
                                <%# Eval("lcatigory_image") != DBNull.Value ? "<img src='data:image/png;base64," + Convert.ToBase64String((byte[])Eval("lcatigory_image")) + "' class='logo-img' />" : "" %>
                            </td>
                            <td><%# Eval("Category") %></td>
                            <td><%# Eval("Status") %></td>
                            <td>
                                <asp:Button runat="server" Text="Edit" CssClass="edit-btn"
                                            CommandName="EditShipment" CommandArgument='<%# Eval("ShipmentID") %>' />
                                <asp:Button runat="server" Text="Delete" CssClass="delete-btn"
                                            CommandName="DeleteShipment" CommandArgument='<%# Eval("ShipmentID") %>'
                                            OnClientClick="return confirm('Are you sure you want to delete this shipment?');" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                            </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
