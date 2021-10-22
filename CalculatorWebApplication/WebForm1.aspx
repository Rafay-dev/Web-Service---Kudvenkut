<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <b>First Number: </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtFirstNum"/>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Second Number: </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSecondNum"/>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Third Number: </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtThirdNum"/>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Result: </b>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblResult"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button runat="server" ID="btnAdd" Text="Add" OnClick="btnAdd_Click"/>
                </td>
            </tr>
            <%--Add Grid View--%>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvCalculations" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
