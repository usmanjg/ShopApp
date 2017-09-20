<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellProducts.aspx.cs" Inherits="ShopApp.SellProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ForeName" DataValueField="ForeName" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopAppConnectionString %>" SelectCommand="SELECT [ForeName] FROM [Customer]"></asp:SqlDataSource>
        <br />
        <br />
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Pro_Id" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Pro_Id" HeaderText="Pro_Id" ReadOnly="True" SortExpression="Pro_Id" />
                <asp:BoundField DataField="Pro_Name" HeaderText="Pro_Name" SortExpression="Pro_Name" />
                <asp:BoundField DataField="Value" HeaderText="Value" SortExpression="Value" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                <asp:TemplateField HeaderText="Selection">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ShopAppConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="AddToBasket" runat="server" OnClick="AddToBasket_Click" Text="AddToBasket" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Pro_Id" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="Pro_Id" HeaderText="Pro_Id" ReadOnly="True" SortExpression="Pro_Id" />
                <asp:BoundField DataField="Pro_Name" HeaderText="Pro_Name" SortExpression="Pro_Name" />
                <asp:BoundField DataField="Value" HeaderText="Value" SortExpression="Value" />
                <asp:TemplateField HeaderText="Qty">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ShopAppConnectionString %>" SelectCommand="SELECT [Pro_Id], [Pro_Name], [Value] FROM [Product]"></asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
