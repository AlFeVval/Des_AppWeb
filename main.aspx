<%@Page Language="C#" AutoEventWireup="true" CodeFile="script/caesar.aspx.cs" Inherits="Encryption.Caesar" %>

  <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head>
    <title>Pruebas</title>
  </head>
  <body>
    <form ID="form1" runat="server">
      <div>
        <asp:Label Font-Bold="true" Text="Encrypted Message: " runat="server"/>
        <asp:TextBox ID="enc_Msg" runat="server" />
        <asp:Button ID="btnDenc" OnClick="btnDecn_Click" Text="De-encrypt" runat="server"/>
        <asp:Label ID="lblMessage" runat="server" />
      </div>
    </form>
  </body>
</html>
