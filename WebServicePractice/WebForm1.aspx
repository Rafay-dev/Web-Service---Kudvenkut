<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServicePractice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <%-- LC: 6 -3 --%>
    <script>
        function GetStudentById() {
            // Get Id 
            // Add this function to onClick event of form button
            var id = document.getElementById('txtStudentId').value;

            // Calling WebMethod of WebService (Add 2nd parameter of callback{any name})
            WebServicePractice.StudentService.GetStudentById(id, GetStudentByIdSuccessCallBack, GetStudentByIdSuccessFailedBack);
        }

        // This function will be used to get output on success
        function GetStudentByIdSuccessCallBack(output) {
            document.getElementById('txtName').value = output["Name"];
            document.getElementById('txtGender').value = output["Gender"];
            document.getElementById('txtTotalMarks').value = output["TotalMarks"];
        }

        // onFail Callback
        function GetStudentByIdSuccessFailedBack(errors) {
            alert(errors.get_message());
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <%-- LC: 6 -2 --%>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/StudentService.asmx" />
            </Services>
        </asp:ScriptManager>

        <%-- LC: 6 -1 --%>
        <table style="font-family: Arial; border: 1px solid black">
            <tr>
                <td>
                    <b>ID</b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtStudentId"></asp:TextBox>
                    <input id="Button1" type="button" onclick="GetStudentById()" value="Get Student" />
                </td>
            </tr>
            <tr>
                <td>
                    <b>Name</b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                </td>
            </tr>
<tr>
                <td>
                    <b>Gender</b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtGender"></asp:TextBox>
                </td>
            </tr>
<tr>
                <td>
                    <b>Total Marks</b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtTotalMarks"></asp:TextBox>
                </td>
            </tr>

        </table>

        <h4>
            The Time Below doesn't change, when we click Get Student button as we doing it partial page and not a full page postback.
        </h4>
        <asp:Label ID="lblTime" runat="server"></asp:Label>
    </form>
</body>
</html>
