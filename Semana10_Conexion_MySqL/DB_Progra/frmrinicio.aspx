<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmrinicio.aspx.cs" Inherits="DB_Progra.frmrinicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonCargardatos" runat="server" Height="29px" OnClick="ButtonCargardatos_Click" Text="Cargar Datos" Width="140px" />
        <p>
            <asp:TextBox ID="TextBoxIDE" runat="server" Height="17px" Width="253px"></asp:TextBox>
            <asp:Button ID="ButtonID" runat="server" OnClick="ButtonID_Click" Text="Buscar por ID" Width="96px" />
        </p>
        <asp:TextBox ID="TextBoxNombre" runat="server" Width="671px"></asp:TextBox>
        <asp:Button ID="ButtonBuscarName" runat="server" OnClick="ButtonBuscarName_Click" Text="Buscar por nombre" />
    </form>
</body>
</html>
