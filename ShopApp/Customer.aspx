<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ShopApp.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        var x = document.getElementById("TxtId");
        function IDAlert()
        {
           
           if (isNaN(x))
            {
                alert("please enter number");
            }
       
        }      

    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="LblError" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TxtFName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TxtLName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnSave" runat="server" OnClick="BtnSave_Click" Text="Save" OnClientClick="IDAlert()" />
&nbsp;
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
    
    </div>
    </form>
</body>
</html>
