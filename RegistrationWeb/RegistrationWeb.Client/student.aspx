<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="RegistrationWeb.Client.student" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
       <asp:ListBox runat="server" ID="studentlist" ClientIDMode="Static"></asp:ListBox>
       <asp:ListBox runat="server" ID="courselist" ClientIDMode="Static"></asp:ListBox>
       <asp:ListBox runat="server" ID="studentcourselist" ClientIDMode="Static"></asp:ListBox>
   </div>
</asp:Content>
