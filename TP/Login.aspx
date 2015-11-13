<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CreditCardStyle.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            height: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
         <br />
         <h1>Login</h1>
        <div class="content" style="height: 298px; width: 538px">

            <div class="floating-box">
                <asp:Label ID="Label1" runat="server" Text="User Name: "></asp:Label> &nbsp; 
                <asp:TextBox ID="txtUserName" runat="server" Width="223px"></asp:TextBox>
            *</div> 


             <div class="floating-box">
                  &nbsp;&nbsp;&nbsp;
                 <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>&nbsp;
                 <asp:TextBox ID="txtPassword" runat="server" Width="218px" TextMode="Password"></asp:TextBox>
             *<br />
            </div>
             <asp:CheckBox ID="chkbxRemeberMe" runat="server" OnCheckedChanged="chkbxRemeberMe_CheckedChanged" Text="Remember Me" />
            <br />
            <br />
            <div class="box">
                <asp:Button ID="btnLogin" runat="server" Height="35px" Text="Login" Width="100px" Font-Names="Century Gothic" OnClick="btnLogin_Click" />
            </div>
              <div class="box">
                     <asp:Button ID="btnNewUser" runat="server" Height="33px" style="margin-top: 0px" Text="New User" Width="102px" Font-Names="Century Gothic" />
              </div>
               
          
           
               
          
        </div>




    </form>
</body>
</html>
