static string ConvertCharToUnicode(string text)
{
	ushort charconverted = 0;
	StringBuilder unicodeConverted = new StringBuilder();
	for(int count = 0; count < text.Length; count++)
	{
		charconverted = (ushort)text[count];
		unicodeConverted.Append(String.Format("\\u{0:x4}",charconverted));
	}
	return unicodeConverted.ToString();
}
