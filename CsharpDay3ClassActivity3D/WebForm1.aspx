<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CsharpDay3ClassActivity3D.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="height" placeholder="inches" runat="server"></asp:TextBox>
            <asp:TextBox ID="weight" placeholder="pounds" runat="server"></asp:TextBox>
            <asp:Button 
                ID ="Button"
                runat ="server"
                OnClick ="Calculate_bmi"
                Text ="Calculate BMI "
                />
        </div>
        <div role="alert" id="bmi">
            <asp:Label ID="result" Text="Body Mass Index" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
