<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 230px;
    }
    .style8
    {
        width: 230px;
        height: 23px;
    }
    .style9
    {
        height: 23px;
    }
    .style10
    {
        width: 230px;
        height: 26px;
    }
    .style11
    {
        height: 26px;
    }
    .style12
    {
        width: 230px;
        height: 45px;
    }
    .style13
    {
        height: 45px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="style1" style="margin-bottom: 187px">
    <tr>
        <td class="style8">
            Name</td>
        <td class="style9">
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style10">
            Address</td>
        <td class="style11">
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="209px"></asp:TextBox>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style12">
            E-Mail</td>
        <td class="style13">
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style10">
            Mobile No
        </td>
        <td class="style11">
            <br />
            <asp:TextBox ID="TextBox4" runat="server" ontextchanged="TextBox4_TextChanged" 
                Width="211px"></asp:TextBox>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style7">
            Course</td>
        <td>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="213px"></asp:TextBox>
            <br />
            <br />
        </td>
    </tr>
</table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="Submit" 
    Width="121px" />
<br />

</asp:Content>

