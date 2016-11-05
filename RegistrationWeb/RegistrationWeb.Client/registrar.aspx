<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="RegistrationWeb.Client.registrar" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
      <div>
       <asp:ListBox runat="server" ID="studentlist" ClientIDMode="Static" Width="15%"></asp:ListBox>
       <asp:ListBox runat="server" ID="courselist" ClientIDMode="Static" Width="50%"></asp:ListBox>
       <asp:ListBox runat="server" ID="studentcourselist" ClientIDMode="Static" Width="25%"></asp:ListBox>
      </div>
      <div>
       <asp:Button  ID="deleteStudentButton" Text="Delete Student" OnClick="deleteStudentButton_Click" runat="server" Width="15%"/>
       <asp:Button  ID="deleteCourseButton" Text="Delete Course" OnClick="deleteCourseButton_Click" runat="server" Width="15%"/>
       <asp:Button  ID="unregisterCourse" Text="Unregister Course" OnClick="unregisterCourse_Click" runat="server" Width="15%"/>
       <asp:Button  ID="viewStudentSchedule" Text="View Student Schedule" OnClick="viewStudentSchedule_Click" runat="server" Width="15%"/>
       <asp:Button  ID="viewCourseEnrollment" Text="View Course Enrollment" OnClick="viewCourseEnrollment_Click" runat="server" Width="15%"/>
      </div>
   </div>
</asp:Content>
