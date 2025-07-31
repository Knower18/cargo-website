<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcargo.aspx.cs" Inherits="WebApplication27.addcargo" %>
<%@ Register Src="adminbar.ascx" TagPrefix="uc" TagName="UserBar" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Admin Panel - Add Cargo</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f6f8;
            margin: 0;
            padding: 0;
        }

        .container {
            margin: 50px auto;
            max-width: 600px;
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.1);
        }

        h2 {
            text-align: center;
            color: #2a3d66;
            margin-bottom: 30px;
        }

        label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
            margin-top: 15px;
        }

        input[type="text"],
        input[type="number"],
        textarea {
            width: 100%;
            padding: 10px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        input[type="file"] {
            margin-top: 10px;
        }

        .submit-btn {
            background-color: #2a3d66;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 5px;
            margin-top: 20px;
            cursor: pointer;
            width: 100%;
        }

        .submit-btn:hover {
            background-color: #1f2f4d;
        }
        #previewContainer {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 10px;
}

#previewImage {
    display: none;
    width: 100px;
    height: 100px;
    border-radius: 50%;
    margin-top: 10px;
}
    </style>
     <script>
     function previewFile() {
         const preview = document.getElementById('previewImage');
         const file = document.getElementById('cargoImage').files[0];
         const reader = new FileReader();

         reader.onloadend = function () {
             preview.src = reader.result;
             preview.style.display = 'block';
         }

         if (file) {
             reader.readAsDataURL(file);
         } else {
             preview.src = "";
             preview.style.display = 'none';
         }
     }
 </script>
</head>
<body>
      <uc:userbar runat="server" />

    <form id="form1" runat="server">
        <div class="container">
            <h2>Add New Cargo</h2>
             <div id="previewContainer">
            <label for="cargoImage">Cargo Image:</label>
             <asp:FileUpload ID="cargoImage" runat="server" CssClass="form-control" onchange="previewFile()" />
               <img id="previewImage" alt="Profile Preview" />
                </div>
            <label for="cargoName">Cargo Name:</label>
            <asp:TextBox ID="cargoName" runat="server" />

            <label for="cargoWeight">PRICE:</label>
            <asp:TextBox ID="price" runat="server" TextMode="Number" />

           

            <label for="cargoDescription">DELIVERY_TIME:</label>
            <asp:TextBox ID="cargoDescription" runat="server" TextMode="MultiLine" Rows="4" />
           
            <asp:Button ID="submitCargo" runat="server" Text="Add Cargo" CssClass="submit-btn" OnClick="submitCargo_Click" />
        </div>
    </form>
</body>
</html>
