static string EncryptText(string text, string cipher)
{
	int CipherCount;
	int textLen = text.Length;
	ushort textChar = 0;
	ushort cipherChar =0;
	int result = 0;
	StringBuilder encriptText = new StringBuilder();
	for(int count = 0; count < text.Length; count++)
	{
		CipherCount = textLen%cipher.Length;
		textChar = (ushort) text[count];
		cipherChar = (ushort) cipher[CipherCount];
		result = (int) textChar ^ cipherChar;
		encriptText.Append(String.Format("\\u{0:x4}", (ushort)result));
		textLen--;
	}
	return encriptText.ToString();
}
