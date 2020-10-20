<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pruebaAPI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formato Json</title>
    <style>
        html, body {
            width: 100%;
            height: 100%;
        }

        body {
            padding: 0;
            background: #eeeeee;
        }

        .container-json {
            width: 100%;
            height: 540px;
            overflow-x: hidden;
            overflow-y: scroll;
        }

            .container-json::-webkit-scrollbar {
                width: 8px;
            }

            .container-json::-webkit-scrollbar-track {
                border-radius: 13px;
                box-shadow: inset 0 0 1px #202020;
            }

            .container-json::-webkit-scrollbar-thumb {
                border-radius: 10px;
                background: #ff9966;
                background: -webkit-linear-gradient(to right, #ff5e62, #ff9966);
                background: linear-gradient(to right, #ff5e62, #ff9966);
            }
    </style>
</head>
<body>
    <div class="container-fluid h-100">
        <div class="row justify-content-center h-100">
            <%-- Form --%>
            <div class="col-8 align-self-center">
                <%--<form id="form1" runat="server">
                    <div class="form-group">
                        <label for="nameApi">Nombre de la API</label>
                        <input type="text" name="nameApi" id="txtnameApi" placeholder="Default: Countries Information" class="form-control" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Url</label>
                        <input type="url" name="urlApi" id="txturlApi" class="form-control"
                            placeholder="Default: https://restcountries.eu/rest/v2/alpha/cr" runat="server" />
                    </div>
                   
                </form>--%>
                <div class="d-flex justify-content-around">
                    <button runat="server" id="btnJson" onserverclick="ApiResponse" class="btn btn-primary" style="width: 50%">JSON</button>
                    <button class="btn btn-secondary" id="btnExample" onserverclick="JsonExample" style="width: 50%" runat="server">Ejemplo</button>
                </div>
            </div>
            <%-- Ouput Json --%>
            <div class="col-8 align-self-center">
                <div id="jsonOuput">
                    <p class="bg-light p-1 m-0 w-50 text-center rounded-top border-top border-right border-left">
                        <span class="h5">API</span><span id="apiName" runat="server" class="h5"></span>
                    </p>
                    <article class="container-json bg-light border-top">
                        <pre id="salida" runat="server" class="text-dark" style="font-size: 16px;"></pre>
                    </article>
                </div>
                <%-- Ouput Table --%>
                <div runat="server" id="printTable"></div>
            </div>
        </div>
    </div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script>
        // Buttons
        const json = $("#btnJson");
        const example = $("#btnExample");

    </script>
</body>
</html>
