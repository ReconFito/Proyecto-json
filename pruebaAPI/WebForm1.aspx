<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pruebaAPI.WebForm1" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <button type="submit" runat="server" onserverclick="Respuesta">Enviar</button>
    </form>
    <div>
        <h3>Salida</h3>
        <pre runat="server" id="salida"></pre>
    </div>
</body>
</html>
