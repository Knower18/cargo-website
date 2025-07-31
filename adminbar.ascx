

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
.sidebar {
     width: 120px;
     background-color: #2a3d66;
     color: white;
     padding: 20px;
     height: 100vh;
     position: fixed;
     top: 0;
     left: 0;
 }

 .sidebar h2 {
     text-align: center;
     margin-bottom: 40px;
     font-size: 24px;
 }

 .sidebar ul {
     list-style: none;
 }

 .sidebar ul li {
     padding: 15px 0;
     text-align: center;
     border-bottom: 1px solid #ddd;
     transition: background-color 0.3s;
 }

 .sidebar ul li:hover {
     background-color: #374a6d;
     cursor: pointer;
 }

 .sidebar ul li a {
     text-decoration: none;
     color: white;
     display: block;
 }
 .sidebar img{
     max-height:20px;
     max-width:30px;
 }
    </style>
</head>
<body>
    <div class="sidebar">
     <h2> <img src="https://cdn-icons-png.flaticon.com/128/9512/9512709.png" "/>Admin Panel</h2>
     <ul>
         <li> <img src="https://cdn-icons-png.flaticon.com/128/16137/16137107.png" /><a href="Dshboard.aspx">Dashboard</a></li>
         <li> <img src="https://cdn-icons-png.flaticon.com/128/17701/17701286.png" /><a href="users.aspx">Users</a></li>
         <li> <img src="https://cdn-icons-png.flaticon.com/128/17883/17883527.png"/><a href="admin.aspx">Shipments</a></li>
         <li><img src="https://cdn-icons-png.flaticon.com/128/18303/18303173.png" /> <a href="cargo_mange.aspx">KARGOSs</a></li>
          <li><img src="https://cdn-icons-png.flaticon.com/128/18303/18303159.png"/> <a href="addcargo.aspx">KARGOS_SETTING</a></li>
            <li><img src="comm.png"/> <a href=" admin_delivery_issues.aspx">compliens</a></li>
        
      
     </ul>
        <br />
 </div>

</body>
</html>
