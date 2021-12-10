<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalitzarComp.aspx.cs" Inherits="CarritoCompra.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>infoPersonal</title>
    <style>
        body{
            background-color: #E1E1E1;
        }
        header{
            background-color: #A4A4A4;
            align-items: center;
        }
        #carr{
            float: right;
            height: 43px;
            width: 41px;
        }
        h1{
            text-align: center;
        }
        /*#div1{
            display: flex;
            flex-direction: row;
            justify-content: space-around;
            margin-top: 90px;
            width: auto;
            height:auto;
        }
        #butt1{
            margin-top: 65px;
        }*/
    </style>
</head>
<body style="height: 694px">
    <form id="form1" runat="server">
        <header style="height: 61px">
            <h1>TuConsola</h1>
        </header>
        <div style="height: 46px">
            <a href="MenuPrincipal.aspx"> <img src="imagenes/inici.png" id="carr"/></a>
        </div>
        <div id= "div1">
            Introdueix informació personal.<br />
            <br />
            Nom:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Dni:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Num Teléfon:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Finalitzar compra" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
