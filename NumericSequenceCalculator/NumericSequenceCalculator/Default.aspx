<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumericSequenceCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Numeric Sequence Calculator</title>

    <link href="css/style.css" rel='stylesheet' type='text/css' media="all" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css' />
</head>
<body>
    <div class="content">
        <h1>Numeric Sequence Calculator</h1>
        <form id="form1" runat="server">
            <p>This calculate generates numeric sequences based on the number entered. To start, simply enter a whole, positive number in the field below, select the numeric sequence you would like calculate and then click 'Calculate Sequence'!</p>
            <asp:TextBox CssClass="text" ID="txtEnteredNumber" runat="server" placeholder="ENTER A NUMBER" ClientIDMode="Static"></asp:TextBox>
            <div class="options" id="options" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td style="width:100%;">
                            <asp:RadioButton ID="rbOption1" GroupName="options" runat="server" Text="Show all numbers up to and including the entered number" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rbOption2" GroupName="options" runat="server" Text="Show all odd numbers up to and including the entered number" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rbOption3" GroupName="options" runat="server" Text="Show all even numbers up to and including the entered number" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rbOption4" GroupName="options" runat="server" Text="Show all numbers up to and including the entered number *" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rbOption5" GroupName="options" runat="server" Text="Show all fibonacci numbers up to and including the entered number" />
                        </td>
                    </tr>
                </table>
                <p>* this option will: Output C if the entered number is a multiple of 3; Output E if the entered number is a multiple 5; and Output Z if the entered number is a multiple of both 3 and 5.</p>
            </div>
            <asp:Button CssClass="submit" ID="btnSubmit" runat="server" Text="CALCULATE SEQUENCE" OnClick="ReturnResult" />
            <div id="divSequence" class="results" runat="server"><p><b>Numeric Sequence: Results</b></p></div>
		</form>
    </div>
</body>
</html>
