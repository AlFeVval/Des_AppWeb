using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encryption{
	public partial class Caesar: System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			lblMessage.Text = "";
		}
		protected void btnDecn_Click(object sender, EventArgs e)
		{
			string encrypt_Msg = enc_Msg.Text; 
			for(int key=1; key <= 26; key++){
				string deencrypt_Msg = decMsg(encrypt_Msg, key);

				Label lblMessage = new Label();
				lblMessage.ID = "lblMsg"+key;
				lblMessage.Text = "El mensaje procesado: "+deencrypt_Msg+", con la key ->"+key;		

				form1.Controls.Add(lblMessage);
				LiteralControl lineBreak = new LiteralControl("<br>");
				form1.Controls.Add(lineBreak);
			}
		}
		public static string decMsg(string encrypt_Msg, int key)
		{
			string deencrypt_Msg = "";
			foreach(char character in encrypt_Msg){
				if(char.IsLetter(character)){
					char decryptedChar = (char)(character-key);
					if(char.IsLower(character) && decryptedChar < 'a'){
						decryptedChar = (char)(decryptedChar +26);
					}
					else if(char.IsUpper(character) && decryptedChar < 'A'){
						decryptedChar = (char)(decryptedChar+26);
					}
					deencrypt_Msg +=decryptedChar;
				}
				else{
					deencrypt_Msg += character;
				}
			}
			return deencrypt_Msg;
		}

	}
}
