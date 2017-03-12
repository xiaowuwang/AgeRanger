<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgeGroupListPage.aspx.cs" Inherits="AgeRanger.SinglePage.AgeGroupListPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h5>Person List By Age Group</h5>
            <asp:GridView ID="grdViewGroupAge" runat="server" AutoGenerateColumns="False"
                OnRowDataBound="grdViewGroupAge_RowDataBound" OnRowCreated="grdViewGroupAge_RowCreated" >
                <Columns>
                    <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                    <asp:BoundField HeaderText="Last Name"  DataField="LastName" />
                    <asp:BoundField HeaderText="Age" DataField="Age" />
                </Columns>
            </asp:GridView>    
        </div>
        <div>
            <a href="Default.aspx"><h5>Back to default page</h5></a>
        </div>
    </form>
</body>
</html>
