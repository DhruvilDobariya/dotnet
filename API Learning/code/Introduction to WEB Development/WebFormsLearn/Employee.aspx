<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebFormsLearn.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table class="table">
                <tr>
                    <td>Name</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Region</td>
                    <td>:</td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddRegion">
                            <asp:ListItem Value="-1" Text="Select Institute"></asp:ListItem>
                            <asp:ListItem Value="India" Text="India"></asp:ListItem>
                            <asp:ListItem Value="Other" Text="Other"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>Gender</td>
                    <td>:</td>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server">
                            <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                            <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Hobies</td>
                    <td>:</td>
                    <td>
                        <asp:CheckBoxList ID="cblHobbies" runat="server">
                            <asp:ListItem Value="Cricket" Text="Cricket"></asp:ListItem>
                            <asp:ListItem Value="Football" Text="Footbool"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>File</td>
                    <td>:</td>
                    <td>
                        <asp:FileUpload ID="fuFile" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="tbAdrress" runat="server" TextMode="MultiLine" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="d-flex justify-content-center">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit"/>
                    </td>
                </tr>
            </table>
    </div>
</asp:Content>
