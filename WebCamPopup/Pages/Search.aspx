<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebCamPopup.Pages.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.24/themes/start/jquery-ui.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.24/jquery-ui.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#dialog").dialog({
                autoOpen: false,
                modal: true,
                width: 430,
                height: 520
            });
            $("#Image1").click(function () {
                document.getElementById("Image1").style.width = "450px"
                document.getElementById("Image1").style.height = "450px"
                $('#dialog').html('');
                $('#dialog').append($(this).clone());
                $('#dialog').dialog('open');
                document.getElementById("Image1").style.width = "80mm"
                document.getElementById("Image1").style.height = "45mm"
            });
        });
    </script>
    <style>
        .open1 {
            display: flex;
            justify-content: center;
            overflow: hidden;
            width: 35mm;
            height: 45mm;
        }
        .makeitMRP {
            width:80mm;
            margin: 0px -15mm 0px -15mm;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblinput" runat="server">Id: </asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
            <asp:Button ID="myButton" runat="server" Text="Get" OnClick="btnsubmit_Click"/>
            You can add image from <a href="Base.aspx">here</a>
        </div>
        <div  class="open1">
        <asp:image ID="Image1" runat="server" class="makeitMRP" ImageUrl ="Search.aspx?ImageID=1"/>
            
        </div>
        <div id="dialog" style="display: none"></div>
    </form><br />
    
</body>
</html>
