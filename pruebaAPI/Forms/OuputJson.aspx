<%@ Page Title="" Language="C#" MasterPageFile="~/JsonFormat.Master" AutoEventWireup="true" CodeBehind="OuputJson.aspx.cs" Inherits="pruebaAPI.Forms.OuputJson" %>

<%@ MasterType VirtualPath="~/JsonFormat.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <%-- Ouput Json --%>
    <div id="jsonOuput">
        <p class="bg-light p-1 m-0 w-50 text-center rounded-top border-top border-right border-left">
            <span class="h5">API [Countries information]</span></p>
        <article class="container-json bg-light border-top">
            <pre id="salida" runat="server" class="text-dark" style="font-size: 16px;"></pre>
        </article>
    </div>
</asp:Content>
