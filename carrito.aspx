<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="carrito.aspx.cs" Inherits="CarritoCompra.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carrito</title>
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
        #div1{
            display: flex;
            flex-direction: row;
            justify-content: space-around;
            margin-top: 90px;
            width: auto;
            height:auto;
        }
        #butt1{
            display: flex;
            justify-content: center;
            height: 100px;
            margin-top: 30px;
        }
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
            <div class="claseDiv" id="Diva1">
                <asp:Image ID="Image1" runat="server" Height="150px" Width="250px"/>
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:DropDownList ID="DropList1" runat="server">
                    <asp:ListItem Value="0"></asp:ListItem>
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                    <asp:ListItem Value="5"></asp:ListItem>
                    <asp:ListItem Value="6"></asp:ListItem>
                    <asp:ListItem Value="7"></asp:ListItem>
                    <asp:ListItem Value="8"></asp:ListItem>
                    <asp:ListItem Value="9"></asp:ListItem>
                    <asp:ListItem Value="10"></asp:ListItem>
                    <asp:ListItem Value="Eliminar"></asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>

            <div class="claseDiv" id="Diva2">
                <asp:Image ID="Image2" runat="server" Height="150px" Width="250px"/>
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:DropDownList ID="DropList2" runat="server">
                    <asp:ListItem Value="0"></asp:ListItem>
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                    <asp:ListItem Value="5"></asp:ListItem>
                    <asp:ListItem Value="6"></asp:ListItem>
                    <asp:ListItem Value="7"></asp:ListItem>
                    <asp:ListItem Value="8"></asp:ListItem>
                    <asp:ListItem Value="9"></asp:ListItem>
                    <asp:ListItem Value="10"></asp:ListItem>
                    <asp:ListItem Value="Eliminar"></asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>

            <div class="claseDiv" id="Diva3">
                <asp:Image ID="Image3" runat="server" Height="150px" Width="250px"/>
                <br />
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:DropDownList ID="DropList3" runat="server">
                    <asp:ListItem Value="0"></asp:ListItem>
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                    <asp:ListItem Value="5"></asp:ListItem>
                    <asp:ListItem Value="6"></asp:ListItem>
                    <asp:ListItem Value="7"></asp:ListItem>
                    <asp:ListItem Value="8"></asp:ListItem>
                    <asp:ListItem Value="9"></asp:ListItem>
                    <asp:ListItem Value="10"></asp:ListItem>
                    <asp:ListItem Value="Eliminar"></asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>
            <div class="claseDiv" id="Diva4">
                <asp:Image ID="Image4" runat="server" Height="150px" Width="250px"/>
                <br />
                <asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <asp:DropDownList ID="DropList4" runat="server">
                    <asp:ListItem Value="0"></asp:ListItem>
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                    <asp:ListItem Value="5"></asp:ListItem>
                    <asp:ListItem Value="6"></asp:ListItem>
                    <asp:ListItem Value="7"></asp:ListItem>
                    <asp:ListItem Value="8"></asp:ListItem>
                    <asp:ListItem Value="9"></asp:ListItem>
                    <asp:ListItem Value="10"></asp:ListItem>
                    <asp:ListItem>Eliminar</asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>
        </div>
            <div style="margin-top: 62px">

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

            </div>
    </form>
</body>
</html>
