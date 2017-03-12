<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AgeRanger.SinglePage.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
        <div>
            <h5>Add Person</h5>
            <asp:Label runat="server" ID="IdLabel" Text="ID" />
            <asp:Label AssociatedControlID="FirstNameTextBox" runat="server" ID="FirstNameLabel" Text="First Name" />
            <asp:TextBox runat="server" ID="FirstNameTextBox" />
            <asp:Label AssociatedControlID="LastNameTextBox" runat="server" ID="LastNameLabel" Text="Last Name" />
            <asp:TextBox runat="server" ID="LastNameTextBox" />
            <asp:Label AssociatedControlID="AgeTextBox" runat="server" ID="AgeLabel" Text="Age" />
            <asp:TextBox runat="server" ID="AgeTextBox" />
            <asp:Button runat="server" ID="SaveButton" Text="Add" OnClick="SaveButton_Click" />
        </div>
        <div class="container">
            <h5>Person List</h5>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                    <asp:BoundField HeaderText="Last Name"  DataField="LastName" />
                    <asp:BoundField HeaderText="Age" DataField="Age" />
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="EditButton" runat="server" 
                                            onclick="EditButton_Click" 
                                            CommandArgument='<%#Eval("Id")+","+Eval("FirstName")+","+Eval("LastName")+","+Eval("Age") %>' 
                                            Text="Edit" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <a href="AgeGroupListPage.aspx"><h5>Person List By Age Group</h5></a>
        </div>
        <div>
            <h5>Search for a Person</h5>
            <asp:Label AssociatedControlID="SearchNameTextBox" runat="server" ID="SearchNameLabel" Text="Name" />
            <asp:TextBox runat="server" ID="SearchNameTextBox" />
            <asp:Button runat="server" ID="SearchButton" Text="Search" OnClick="SearchButton_Click" />
            <h5>Search Result</h5>
            <asp:Label runat="server" ID="rFirstNameLabel" />
            <asp:Label runat="server" ID="rLastNameLabel" />
            <asp:Label runat="server" ID="rAgeLabel" />
            <asp:Label runat="server" ID="rAgeGroupLabel" />
        </div>
    </form>
</body>
</html>
