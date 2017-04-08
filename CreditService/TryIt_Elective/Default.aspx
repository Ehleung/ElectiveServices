<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt_Elective._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Credit Card Service</h1>
        <p class="lead">Ellery Leung</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Service #1 - Verify Credit Card Number</h2>
            <p>
                Enter your credit card number here:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </p>
            <p>
                For grading purposes, first four digits must be &#39;3490&#39;. The string MUST be 8 or 12 digits long. The last two digits in any CCN must be a prime number (ie. 29).</p>
            <p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Service #2 - Process Payment</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
