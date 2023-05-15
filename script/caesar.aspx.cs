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
			string customAlphabet = "abcdefghijklmnopqrstuvwxyz ";
			string deencrypt_Msg = "";

			foreach(char character in encrypt_Msg)
			{
				if (char.IsLetter(character))
				{
					int index = customAlphabet.IndexOf(character);
					if(index >= 0)
					{
						int dencryptIndex = (index - key + customAlphabet.Length) % customAlphabet.Length;

						char decChar = char.IsLower(character)
						? char.ToLower(customAlphabet[dencryptIndex])
						: customAlphabet[dencryptIndex];

						deencrypt_Msg += decChar;
					}
				}
				else
				{
					deencrypt_Msg += character;
				}
			}
			return deencrypt_Msg;
		}

	}
}
