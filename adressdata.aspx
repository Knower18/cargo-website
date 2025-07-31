<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adressdata.aspx.cs" Inherits="WebApplication27.adressdata" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8" />
  <title>Insert Address - Istanbul Cargo</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <style>
    body {
      margin: 0;
      padding: 0;
      font-family: 'Segoe UI', sans-serif;
      background: linear-gradient(to right, #1e3c72, #2a5298);
      color: white;
      display: flex;
      align-items: center;
      justify-content: center;
      min-height: 100vh;
    }

    .container {
      background-color: rgba(255, 255, 255, 0.1);
      padding: 30px;
      border-radius: 16px;
      width: 100%;
      max-width: 500px;
      backdrop-filter: blur(10px);
      box-shadow: 0 6px 20px rgba(0, 0, 0, 0.3);
    }

    h2 {
      text-align: center;
      margin-bottom: 20px;
    }

    label {
      display: block;
      margin-top: 12px;
      font-weight: bold;
    }

    input, select {
      width: 100%;
      padding: 10px;
      margin-top: 6px;
      border: none;
      border-radius: 8px;
      font-size: 14px;
      outline: none;
    }

    .btn-submit {
      margin-top: 20px;
      width: 100%;
      background-color: #2a5298;
      color: white;
      padding: 12px;
      font-weight: bold;
      border: none;
      border-radius: 8px;
      cursor: pointer;
      transition: background 0.3s ease;
    }

    .btn-submit:hover {
      background-color: #1e3c72;
    }

    .success {
      margin-top: 10px;
      color: lightgreen;
      text-align: center;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
    <div class="container">
      <h2>Add your Address</h2>

     

      <asp:Label AssociatedControlID="txtStreet" runat="server" Text="Street Address:" />
      <asp:TextBox ID="txtStreet" runat="server" />

      <asp:Label AssociatedControlID="txtCity" runat="server" Text="City:" />
      <asp:TextBox ID="txtCity" runat="server" />

      <asp:Label AssociatedControlID="txtState" runat="server" Text="State:" />
      <asp:TextBox ID="txtState" runat="server" />

      <asp:Label AssociatedControlID="txtZip" runat="server" Text="ZIP Code:" />
      <asp:TextBox ID="txtZip" runat="server" />

      <asp:Label AssociatedControlID="txtCountry" runat="server" Text="Country:" />
      <asp:TextBox ID="txtCountry" runat="server" />

      <asp:Button ID="btnSubmit" runat="server" Text="Save Address" CssClass="btn-submit" OnClick="btnSubmit_Click" />

      <asp:Label ID="lblSuccess" runat="server" CssClass="success" Visible="false" />
    </div>
  </form>
</body>
</html>